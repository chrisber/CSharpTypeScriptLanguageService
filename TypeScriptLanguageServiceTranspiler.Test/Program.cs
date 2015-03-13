using System;
using V8.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TypeScriptLanguageServiceTranspiler;


namespace TypeScriptLanguageServiceTranspiler.Test
{
    class MainClass
    {


        public static void Main(string[] args)
        { 
            Console.WriteLine("TypeScriptLanguageServiceTranspiler");
            try
            {
                Transpiler transpiler = new Transpiler();
                transpiler.addRequiredScriptsToHost();
                transpiler.initTypescriptLanguageService();
                List<KeyValuePair<string,List<KeyValuePair<string,string>>>> serviceInterfaces = transpiler.getServiceInterfaces();
                List<KeyValuePair<string,List<KeyValuePair<string,string>>>> compilerInterfaces = transpiler.getCompilerInterfaces();
                List<KeyValuePair<string,List<string>>> enums = transpiler.getServiceEnums();
                List<KeyValuePair<string,List<KeyValuePair<string,string>>>> methods = transpiler.getServiceMethods();

                foreach ( var method in methods) 
                {
                    var signature = "";
                    int lastItem = method.Value.Count -1;
                    var returnParameterType = method.Value[lastItem].Key;
                    var methodName = method.Key;
                    returnParameterType = returnParameterType.Replace("number","int").Replace("boolean","bool").Replace("?","");
                    method.Value.RemoveAt(lastItem);

                    foreach ( var parameter in method.Value) 
                    {   
                        signature = signature + " " + parameter.Key + " " + parameter.Value + ",";
                    }
                    signature = signature.TrimEnd(',');
                }

                foreach (var tsInterface in serviceInterfaces)
                {
                    if (tsInterface.Value.Count > 0)
                    {
                        Console.WriteLine(tsInterface.Key);
                        foreach (var interfaceMember in tsInterface.Value)
                        {
                            Console.WriteLine("public " + interfaceMember.Key + " " + interfaceMember.Value + "{get;set;}");
                        }
                    }
                }

                foreach (var tsInterface in compilerInterfaces)
                {
                    if (tsInterface.Value.Count > 0)
                    {
                        Console.WriteLine(tsInterface.Key);
                        foreach (var interfaceMember in tsInterface.Value)
                        {
                            Console.WriteLine("public " + interfaceMember.Key + " " + interfaceMember.Value + "{get;set;}");
                        }
                    }
                }

                foreach (var tsEnum in enums)
                {
                    Console.WriteLine("enum " + tsEnum.Key);
                    foreach (var member in tsEnum.Value)
                        {
                            Console.WriteLine("   " + member + ",");
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

    }
}
