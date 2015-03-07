using System;
using V8.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace TypeScriptLanguageServiceTranspiler
{
    public class Transpiler
    {
        V8Engine v8Engine = null;
        TypeScriptServiceHostEnvironment host = null;
        char dS = Path.DirectorySeparatorChar;
        string assemblyFolder = null;
        string servicesTsPath = null;
        string typesTsPath = null;


        public Transpiler()
        {
            v8Engine = new  V8Engine();
            host = new TypeScriptServiceHostEnvironment();
            v8Engine.RegisterType<TypeScriptServiceHostEnvironment>(null, recursive: true);
            v8Engine.GlobalObject.SetProperty("host", host);

            assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            servicesTsPath = Path.Combine(
                assemblyFolder, 
                ".." + dS + ".." + dS + ".." + dS + "/TypeScript/src/services/services.ts"
            );
            servicesTsPath = Path.GetFullPath(servicesTsPath);

            typesTsPath = Path.Combine(
                assemblyFolder,
                ".." + dS + ".." + dS + ".." + dS + "/TypeScript/src/compiler/types.ts"
            );
            typesTsPath = Path.GetFullPath(typesTsPath);
        }

        public void addRequiredScriptsToHost()
        {
            //add all files
            List<string> filesPaths = Utilities.DirSearch(".." + dS + ".." + dS + ".." + dS + "/TypeScript/src/services");
            filesPaths.ForEach(x =>
                {
                    var fileScript = new Script(x, File.ReadAllText(x));                   
                    host.scripts.Add(fileScript.Id, fileScript);
                });

            List<string> fileNames = new List<string>
            {
                "binder.ts",
                "checker.ts",
                "commandLineParser.ts",
                "core.ts",
                "diagnosticInformationMap.generated.ts",
                "diagnosticMessages.json",
                "emitter.ts",
                "parser.ts",
                "program.ts",
                "scanner.ts",
                "sys.ts",
                "types.ts",
                "utilities.ts"
            };
            filesPaths = Utilities.SearchFile(".." + dS + ".." + dS + ".." + dS + "/TypeScript/src/compiler", fileNames);
            filesPaths.ForEach(x =>
                {
                    var fileScript = new Script(x, File.ReadAllText(x));                   
                    host.scripts.Add(fileScript.Id, fileScript);
                });
//
//            //create typedef script
            Script libdef = new Script(
                Path.Combine(assemblyFolder, "lib.d.ts"), 
                File.ReadAllText( Path.Combine(assemblyFolder, "lib.d.ts"))
            );
            host.scripts.Add(libdef.Id, libdef);
        }

        public void initTypescriptLanguageService(){
            var servicesScript = File.ReadAllText(Path.Combine(assemblyFolder, "typescriptServices.js"));
            var result = v8Engine.Execute(servicesScript);
            Console.WriteLine(result.ToString());
            //create languageservice
            var mainScript = @"﻿var ls = ts.createLanguageService(host, ts.createDocumentRegistry())";
            result = v8Engine.Execute(mainScript);
            Console.WriteLine(result.ToString());
        }

        public List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getInterfaces(string interfaceString){
            JObject jobjectServiceInterfaces = JObject.Parse(interfaceString);
            List<KeyValuePair<string,List<KeyValuePair<string,string>>>> interfaceList = 
                new List<KeyValuePair<string,List<KeyValuePair<string,string>>>>();
            foreach (JToken content in jobjectServiceInterfaces["interfaces"].Children())
            {
                var interfaceName = content.Value<JProperty>().Name;
                List<KeyValuePair<string,string>> interfaceMemberList = new List<KeyValuePair<string, string>>();
                foreach (JToken member in content.Value<JProperty>().Value.Children())
                {   
                    var cleanMember = member.Value<string>().Replace("\"","").Replace(" ","").Replace(";","");
                    var keyValue = cleanMember.Split(':');
                    KeyValuePair<string,string> temp = new KeyValuePair<string,string>(keyValue[1], keyValue[0]);
                    interfaceMemberList.Add(temp);
                }
                KeyValuePair<string,List<KeyValuePair<string,string>>> tsInterface = 
                    new KeyValuePair<string,List<KeyValuePair<string,string>>>(interfaceName,interfaceMemberList);
                interfaceList.Add(tsInterface);
            }
            return interfaceList;
        }

        public List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getServiceInterfaces(){
            host.position = 1;
            host.isMemberCompletion = false;
            host.fileName = servicesTsPath; 
            var script = File.ReadAllText(assemblyFolder + Path.DirectorySeparatorChar + "getInterfaces.js");
            var tsServiceInterfaces = v8Engine.Execute(script);
            return getInterfaces(tsServiceInterfaces);
        }

        public List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getCompilerInterfaces(){
            host.position = 1;
            host.isMemberCompletion = false;
            host.fileName = typesTsPath;
            var script = File.ReadAllText(assemblyFolder + Path.DirectorySeparatorChar + "getInterfaces.js");
            var compilerInterfaces = v8Engine.Execute(script);
            return getInterfaces(compilerInterfaces);
        }


    }
}

