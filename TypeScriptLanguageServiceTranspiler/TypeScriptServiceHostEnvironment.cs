using System;
using System.IO;
using V8.Net;
using System.Collections.Generic;
using System.Linq;

namespace TypeScriptLanguageServiceTranspiler
{
    public class TypeScriptServiceHostEnvironment
    {
        public Dictionary<string, Script> scripts = new Dictionary<string, Script>();

        public TypeScriptServiceHostEnvironment()
        {

        }

        [ScriptMember(inScriptName: "typeScriptLanguageTypes", security: ScriptMemberSecurity.Permanent)]
        public void typeScriptLanguageTypes(string json)
        {
            log(json);
            File.WriteAllText("test.json", json);
        }


        [ScriptMember(inScriptName: "position", security: ScriptMemberSecurity.Permanent)]
        public int position { get; set; }

        [ScriptMember(inScriptName: "fileName", security: ScriptMemberSecurity.Permanent)]
        public string fileName { get; set; }

        [ScriptMember(inScriptName: "isMemberCompletion", security: ScriptMemberSecurity.Permanent)]
        public bool isMemberCompletion { get; set; }

        [ScriptMember(inScriptName: "completionEntry", security: ScriptMemberSecurity.Permanent)]
        public string completionEntry { get; set; }


        [ScriptMember(inScriptName: "getCompilationSettings", security: ScriptMemberSecurity.Permanent)]
        public CompilerOptions getCompilationSettings()
        {
            CompilerOptions c = new CompilerOptions();
            return c;
        }

        [ScriptMember(inScriptName: "getScriptFileNames", security: ScriptMemberSecurity.Permanent)]
        public string[] getScriptFileNames()
        {
           
            return  scripts.Keys.ToArray();
        }

        [ScriptMember(inScriptName: "getScriptVersion", security: ScriptMemberSecurity.Permanent)]
        public string getScriptVersion(string fileName)
        {
            return scripts[fileName].Version.ToString();
        }


        [ScriptMember(inScriptName: "getScriptIsOpen", security: ScriptMemberSecurity.Permanent)]
        public  bool getScriptIsOpen(string fileName)
        {
            return false;
        }

        [ScriptMember(inScriptName: "getScriptSnapshot", security: ScriptMemberSecurity.Permanent)]
        public object getScriptSnapshot(string fileName)
        {  if ( fileName.Contains("generate.ts") || fileName.Contains("diff.ts") || fileName.Contains("events.ts")
            || fileName.Contains("events.d.ts") || fileName.Contains("net.ts") || fileName.Contains("net.d.ts")
            || fileName.Contains("stream.ts") || fileName.Contains("stream.d.ts") || fileName.Contains("child_process.ts")
            || fileName.Contains("child_process.d.ts") || fileName.Contains("tls.ts") || fileName.Contains("tls.d.ts") 
            || fileName.Contains("http.ts"))
            {
                return null;
            }
            Script script = null;
            try{
            script = scripts[fileName];
            }catch(Exception e){
                log("not-found!!!");
                log(e.ToString());
            }
            var snap = new ScriptSnapshotShim(script);
            return snap;

        }

        [ScriptMember(inScriptName: "getLocalizedDiagnosticMessages", security: ScriptMemberSecurity.Permanent)]
        public object getLocalizedDiagnosticMessages()
        {
            return null;
        }

        [ScriptMember(inScriptName: "getCancellationToken", security: ScriptMemberSecurity.Permanent)]
        public bool getCancellationToken()
        {
            return false;
        }

        [ScriptMember(inScriptName: "getCurrentDirectory", security: ScriptMemberSecurity.Permanent)]
        public string getCurrentDirectory()
        {   
            return Directory.GetCurrentDirectory();
        }

        [ScriptMember(inScriptName: "getDefaultLibFileName", security: ScriptMemberSecurity.Permanent)]
        public string getDefaultLibFileName(CompilerOptions options)
        {
            string result = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "lib.d.ts";
            return result;
        }



 
        #region CompilerHost
        [ScriptMember(inScriptName: "getSourceFile", security: ScriptMemberSecurity.Permanent)]
        public object getSourceFile(string filename, string languageVersion) {
            Script script = scripts[fileName];
            return new ScriptSnapshotShim(script); 
        }

        [ScriptMember(inScriptName: "writeFile", security: ScriptMemberSecurity.Permanent)]
        public void writeFile (string name, string text, string writeByteOrderMark) {

        }



        [ScriptMember(inScriptName: "getDefaultLibFilename", security: ScriptMemberSecurity.Permanent)]
        public string getDefaultLibFilename(CompilerOptions options)
        {
            return Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar  + "lib.d.ts";
        }




        [ScriptMember(inScriptName: "useCaseSensitiveFileNames", security: ScriptMemberSecurity.Permanent)]
        public string useCaseSensitiveFileNames()
        {
            return "true";
        }

        [ScriptMember(inScriptName: "getCanonicalFileName", security: ScriptMemberSecurity.Permanent)]
        public string getCanonicalFileName(string filename)
        {
            var result = scripts[fileName];
            return result.Id;
        }

//        [ScriptMember(inScriptName: "getCurrentDirectory", security: ScriptMemberSecurity.Permanent)]
//        public string getCurrentDirectory()
//        {
//            return Directory.GetCurrentDirectory();
//        }

        [ScriptMember(inScriptName: "getNewLine", security: ScriptMemberSecurity.Permanent)]
        public string getNewLine()
        {
            return Environment.NewLine;
        }
            
        #endregion


        [ScriptMember(inScriptName: "log", security: ScriptMemberSecurity.Permanent)]
        public void log(string message)
        {       
            Console.WriteLine(String.Format("log: {0}", message));
        }
        [ScriptMember(inScriptName: "error", security: ScriptMemberSecurity.Permanent)]
        public void error(string message)
        {       
            Console.WriteLine(String.Format("error: {0}", message));
        }
        [ScriptMember(inScriptName: "trace", security: ScriptMemberSecurity.Permanent)]
        public void trace(string message)
        {       
            Console.WriteLine(String.Format("trace:{0}", message));
        }
            
    }


}

