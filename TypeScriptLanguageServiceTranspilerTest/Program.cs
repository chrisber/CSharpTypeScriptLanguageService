using System;
using V8.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TypeScriptLanguageServiceTranspiler;


namespace TypeScriptLanguageServiceTranspilerTest
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
                List<KeyValuePair<string,List<KeyValuePair<string,string>>>> interfaces = transpiler.getServiceInterfaces();
                List<KeyValuePair<string,List<KeyValuePair<string,string>>>> compiler = transpiler.getCompilerInterfaces();
                List<KeyValuePair<string,List<string>>> enums = transpiler.getServiceEnums();



                foreach (var tsInterface in interfaces)
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


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

    }
}
