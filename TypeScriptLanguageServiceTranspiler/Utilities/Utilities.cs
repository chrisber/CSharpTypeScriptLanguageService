using System;
using System.Collections.Generic;
using System.IO;

namespace TypeScriptLanguageServiceTranspiler
{
 
    public class Utilities
    {

        public static List<string>  DirSearch(string sDir)
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

        public static List<string>  SearchFile(string sDir, List<string> fileNames)
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
    }
}

