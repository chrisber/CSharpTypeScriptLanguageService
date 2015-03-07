using System;
using V8.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace TypeScriptLanguageServiceTranspiler
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            Transpiler transpiler = new Transpiler();
            transpiler.addRequiredScriptsToHost();
            transpiler.initTypescriptLanguageService();
            List<KeyValuePair<string,List<KeyValuePair<string,string>>>> interfaces = transpiler.getServiceInterfaces();

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

            Console.WriteLine("TypeScriptLanguageServiceTranspiler");
        }
    }
}
