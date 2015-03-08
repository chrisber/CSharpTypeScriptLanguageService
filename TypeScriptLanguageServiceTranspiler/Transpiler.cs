using System;
using V8.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace TypeScriptLanguageServiceTranspiler
{
    public class Transpiler
    {
        V8Engine v8Engine = null;
        TypeScriptServiceHostEnvironment host = null;
        Utilities utilities = null;


        public Transpiler()
        {
            utilities = new Utilities();
            v8Engine = new  V8Engine();
            host = new TypeScriptServiceHostEnvironment();
            v8Engine.RegisterType<TypeScriptServiceHostEnvironment>(null, recursive: true);
            v8Engine.GlobalObject.SetProperty("host", host);

        }

        public List<string> testme()
        {
            List<string> list = new List<string>();
            list.Add(utilities.ExecDir);
            list.Add(utilities.CompilerDirPath);
            list.Add(utilities.CompilerTypesScriptPath);
            list.Add(utilities.LibdtsScriptPath);
            list.Add(utilities.ServiceDirPath);
            list.Add(utilities.ServiceScriptPath);
            list.Add(utilities.TypeScriptServicesScriptPath);
            return list;
        }

        public void addRequiredScriptsToHost()
        {
            //add all files
            List<string> filesPaths = utilities.DirSearch(utilities.ServiceDirPath);
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
            filesPaths = utilities.SearchFile(utilities.CompilerDirPath, fileNames);
            filesPaths.ForEach(x =>
                {
                    var fileScript = new Script(x, File.ReadAllText(x));                   
                    host.scripts.Add(fileScript.Id, fileScript);
                });
//
//            //create typedef script
            Script libdef = new Script(
                                utilities.LibdtsScriptPath, 
                                File.ReadAllText(utilities.LibdtsScriptPath)
                            );
            host.scripts.Add(libdef.Id, libdef);
        }

        public void initTypescriptLanguageService()
        {
            var languageServicesScript = File.ReadAllText(utilities.TypeScriptServicesScriptPath);
            var result = v8Engine.Execute(languageServicesScript);
            Console.WriteLine(result.ToString());
            //create languageservice
            var mainScript = @"﻿var ls = ts.createLanguageService(host, ts.createDocumentRegistry())";
            result = v8Engine.Execute(mainScript);
            Console.WriteLine(result.ToString());
        }

        private List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getInterfaces(string interfaceString)
        {
            JObject jobjectServiceInterfaces = JObject.Parse(interfaceString);
            List<KeyValuePair<string,List<KeyValuePair<string,string>>>> interfaceList = 
                new List<KeyValuePair<string,List<KeyValuePair<string,string>>>>();
            foreach (JToken content in jobjectServiceInterfaces["interfaces"].Children())
            {
                var interfaceName = content.Value<JProperty>().Name;
                List<KeyValuePair<string,string>> interfaceMemberList = new List<KeyValuePair<string, string>>();
                foreach (JToken member in content.Value<JProperty>().Value.Children())
                {   
                    var cleanMember = member.Value<string>().Replace("\"", "").Replace(" ", "").Replace(";", "");
                    var keyValue = cleanMember.Split(':');
                    KeyValuePair<string,string> temp = new KeyValuePair<string,string>(keyValue[1], keyValue[0]);
                    interfaceMemberList.Add(temp);
                }
                KeyValuePair<string,List<KeyValuePair<string,string>>> tsInterface = 
                    new KeyValuePair<string,List<KeyValuePair<string,string>>>(interfaceName, interfaceMemberList);
                interfaceList.Add(tsInterface);
            }
            return interfaceList;
        }

        private List<KeyValuePair<string,List<string>>> getEnums(string enumString)
        {
            JObject jobjectServiceEnums = JObject.Parse(enumString);
            List<KeyValuePair<string,List<string>>> enumList = 
                new List<KeyValuePair<string,List<string>>>();
            foreach (JToken content in jobjectServiceEnums["enums"].Children())
            {
                var enumName = content.Value<JProperty>().Name;
                List<string> enumMemberList = new List<string>();
                foreach (JToken member in content.Value<JProperty>().Value.Children())
                {   
                    var cleanMember = member.Value<string>().Replace("\"", "").Replace(" ", "").Replace(";", "");
                    enumMemberList.Add(cleanMember);
                }
                KeyValuePair<string,List<string>> tsInterface = 
                    new KeyValuePair<string,List<string>>(enumName, enumMemberList);
                enumList.Add(tsInterface);
            }
            return enumList;
        }

        private List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getFunctions(string functionString)
        {



            JObject jobjectServiceFunctions = JObject.Parse(functionString);

            List<KeyValuePair<string,List<KeyValuePair<string,string>>>> functionList = 
                new List<KeyValuePair<string,List<KeyValuePair<string,string>>>>();
                
            foreach (JToken content in jobjectServiceFunctions["methods"].Children())
            {
                var functionName = content.Value<JProperty>().Name.Split('(')[0];
                functionName = functionName.Replace("\"", "").Replace(" ", "").Replace(";", "");
                functionName = functionName.Replace("number", "int").Replace("boolean", "bool").Replace("?", "");


                if (content.Value<JProperty>().Value.Children().Count() > 0)
                {

                    List<KeyValuePair<string,string>> parameterList = new List<KeyValuePair<string,string>>();
                    foreach (JToken parameter in content.Value<JProperty>().Value.Children())
                    {   
                        if (parameter.Value<string>() != functionName)
                        {
                            var keyValue = parameter.Value<string>().Split(':');
                            if (keyValue.Length > 1)
                            {
                                var parameterType = keyValue[1].Replace("number", "int").Replace("boolean", "bool").Replace("?", "");
                                var parameterName = keyValue[0].Replace("number", "int").Replace("boolean", "bool").Replace("?", "");
                                var value = new KeyValuePair<string,string>(parameterType, parameterName);
                                parameterList.Add(value);
                            }
                            else
                            {
                                var value = new KeyValuePair<string,string>(keyValue[0], "");
                                parameterList.Add(value);
                            }
                        }
                    }
                    KeyValuePair<string,List<KeyValuePair<string,string>>> function = 
                        new KeyValuePair<string,List<KeyValuePair<string,string>>>(functionName, parameterList);
                    functionList.Add(function);
                }
            }
            return functionList;
        }

        public List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getServiceInterfaces()
        {
            host.position = 1;
            host.isMemberCompletion = false;
            host.fileName = utilities.ServiceScriptPath; 
            var script = File.ReadAllText(utilities.InterfacesScript);
            var tsServiceInterfaces = v8Engine.Execute(script);
            return getInterfaces(tsServiceInterfaces);
        }

        public List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getCompilerInterfaces()
        {
            host.position = 1;
            host.isMemberCompletion = false;
            host.fileName = utilities.CompilerTypesScriptPath;
            var script = File.ReadAllText(utilities.InterfacesScript);
            var compilerInterfaces = v8Engine.Execute(script);
            return getInterfaces(compilerInterfaces);
        }

        public List<KeyValuePair<string,List<string>>> getServiceEnums()
        {
            host.position = 1;
            host.isMemberCompletion = false;
            host.fileName = utilities.ServiceScriptPath; 
            var script = File.ReadAllText(utilities.EnumsScript);
            var tsServiceEnums = v8Engine.Execute(script);
            return getEnums(tsServiceEnums);
        }

        public List<KeyValuePair<string,List<string>>> getCompilerEnums()
        {
            host.position = 1;
            host.isMemberCompletion = false;
            host.fileName = utilities.CompilerTypesScriptPath; 
            var script = File.ReadAllText(utilities.EnumsScript);
            var tsServiceEnums = v8Engine.Execute(script);
            return getEnums(tsServiceEnums);
        }

        public List<KeyValuePair<string,List<KeyValuePair<string,string>>>> getServiceMethods()
        {
            host.position = 1;
            host.isMemberCompletion = false;
            host.fileName = utilities.ServiceScriptPath; 
            var script = File.ReadAllText(utilities.MethodScript);
            var tsServiceEnums = v8Engine.Execute(script);
            return getFunctions(tsServiceEnums);
        }



    }
}

