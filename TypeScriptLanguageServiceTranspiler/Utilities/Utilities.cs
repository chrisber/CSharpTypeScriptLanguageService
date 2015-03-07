using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TypeScriptLanguageServiceTranspiler
{
 
    public class Utilities
    {
        string execDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
         char dS = Path.DirectorySeparatorChar;

        public Utilities()
        {
            execDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            checkPathsExist();
        }


        public  List<string>  DirSearch(string sDir)
        {
            List<string> files = new List<string>();
            try
            {
                foreach (string file in Directory.EnumerateFiles(
                    sDir, "*.ts", SearchOption.AllDirectories))
                {
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), file);
                    filepath = Path.GetFullPath(filepath);
                    files.Add(filepath);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return files;
        }

        public  List<string>  SearchFile(string sDir, List<string> fileNames)
        {
            List<string> files = new List<string>();
            try
            {
                foreach (string fName in fileNames)
                {
                    foreach (string file in Directory.EnumerateFiles(
                        sDir, fName, SearchOption.AllDirectories))
                    {
                        var filepath = Path.Combine(Directory.GetCurrentDirectory(), file);
                        filepath = Path.GetFullPath(filepath);
                        files.Add(filepath);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return files;
        }


        public  string ExecDir { get { return execDir; } }

        public  string ServiceDirPath { get { return Path.GetFullPath(Path.Combine(
                    ExecDir,
            ".." + dS + ".." + dS + ".." + dS + "TypeScript"+ dS + "src"+ dS + "services"
                )); } }

        public  string CompilerDirPath { get { return Path.GetFullPath(Path.Combine(
                    ExecDir,
            ".." + dS + ".." + dS + ".." + dS + "TypeScript"+ dS + "src"+ dS + "compiler"
                )); } }

        public  string ServiceScriptPath { get { return Path.GetFullPath(Path.Combine(
                    ExecDir, 
            ".." + dS + ".." + dS + ".." + dS + "TypeScript" + dS + "src"  + dS + "services" + dS + "services.ts"
                )); } }

        public  string CompilerTypesScriptPath { get { return Path.GetFullPath(Path.Combine(
                    ExecDir,
            ".." + dS + ".." + dS + ".." + dS + "TypeScript" + dS + "src" + dS + "compiler" + dS +"types.ts"
                )); } }

        public  string TypeScriptServicesScriptPath { get { return Path.GetFullPath(Path.Combine(
                    ExecDir,
                    "typescriptServices.js"
                )); } }


        public  string LibdtsScriptPath { get { return Path.GetFullPath(Path.Combine(
                    ExecDir,
                    "lib.d.ts"
                )); } }


        public  string InterfacesScript { get {  return Path.GetFullPath(Path.Combine(
            ExecDir,
            "getInterfaces.js"
        )); }}

        public  string EnumsScript { get { return Path.GetFullPath(Path.Combine(
            ExecDir,
            "getEnums.js"
        )); }}


        private  void checkPathsExist()
        {

            if (!Directory.Exists(ExecDir))
            {
                throw new DirectoryNotFoundException(ExecDir);
            }
            if (!Directory.Exists(ServiceDirPath))
            {
                throw new DirectoryNotFoundException(ServiceDirPath);
            }
            if (!Directory.Exists(CompilerDirPath))
            {
                throw new DirectoryNotFoundException(CompilerDirPath);
            }


            if (!File.Exists(ServiceScriptPath))
            {
                throw new FileNotFoundException(ServiceScriptPath);
            }
            if (!File.Exists(CompilerTypesScriptPath))
            {
                throw new FileNotFoundException(CompilerTypesScriptPath);
            }
            if (!File.Exists(TypeScriptServicesScriptPath))
            {
                throw new FileNotFoundException(TypeScriptServicesScriptPath);
            }
            if (!File.Exists(LibdtsScriptPath))
            {
                throw new FileNotFoundException(LibdtsScriptPath);
            }
            if (!File.Exists(InterfacesScript))
            {
                throw new FileNotFoundException(InterfacesScript);
            }
            if (!File.Exists(EnumsScript))
            {
                throw new FileNotFoundException(EnumsScript);
            }
        
        }
    }
}

