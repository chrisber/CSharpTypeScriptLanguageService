using System;
using System.IO;
using V8.Net;
using System.Collections.Generic;
using System.Linq;

namespace TypeScriptLanguageServiceGenerator
{
    public class TypeScriptCompilerEnvironment
    {
        public Dictionary<string, Script> scripts = new Dictionary<string, Script>();

        public TypeScriptCompilerEnvironment()
        {

        }

        [ScriptMember (inScriptName: "updateSemanticDiagnosticsResult", security: ScriptMemberSecurity.Permanent)]
        public void updateSemanticDiagnosticsResult(string json)
        {

            log(json);
            try{
//                var result = JsonConvert.DeserializeObject<DiagnosticsResult>(json);
//                var semantic = result.semantic.Where(x => x != null).ToArray();
//                var syntactic = result.syntactic.Where(x => x != null).ToArray();
//                var finalresult = new Diagnostic[semantic.Length + syntactic.Length]; 
//                Array.Copy(semantic,SemanticDiagnosticsResult.result,semantic.Length);
//                Array.Copy(syntactic, 0, SemanticDiagnosticsResult.result, semantic.Length, syntactic.Length);

            }catch(Exception ex){
//                MonoLog (ex.ToString());
            }
            //            SemanticDiagnosticsResult.result = res;
            //            SemanticDiagnosticsResult = JsonConvert.DeserializeObject<SemanticDiagnosticsResult>(result);
        }


        [ScriptMember (inScriptName: "updateLexicalStructure", security: ScriptMemberSecurity.Permanent)]
        public void updateLexicalStructure(string res){

        }

        [ScriptMember (inScriptName: "position", security: ScriptMemberSecurity.Permanent)]
        public int position { get; set; }
        [ScriptMember (inScriptName: "fileName", security: ScriptMemberSecurity.Permanent)]
        public string fileName { get; set; }
        [ScriptMember (inScriptName: "isMemberCompletion", security: ScriptMemberSecurity.Permanent)]
        public bool isMemberCompletion { get; set; }
        [ScriptMember (inScriptName: "completionEntry", security: ScriptMemberSecurity.Permanent)]
        public string completionEntry { get; set; }


        [ScriptMember(inScriptName: "getCompilationSettings", security: ScriptMemberSecurity.Permanent)]
        public CompilerOptions getCompilationSettings(){
            CompilerOptions c = new CompilerOptions();
            return c;
        }
        [ScriptMember(inScriptName: "getScriptFileNames", security: ScriptMemberSecurity.Permanent)]
        public string[] getScriptFileNames(){
           
            return  scripts.Keys.ToArray ();
        }
        [ScriptMember(inScriptName: "getScriptVersion", security: ScriptMemberSecurity.Permanent)]
        public string getScriptVersion(string fileName){
            return scripts[fileName].Version.ToString();
        }
        [ScriptMember(inScriptName: "getScriptIsOpen", security: ScriptMemberSecurity.Permanent)]
        public  bool getScriptIsOpen(string fileName){
            return false;
        }
        [ScriptMember(inScriptName: "getScriptSnapshot", security: ScriptMemberSecurity.Permanent)]
        public object getScriptSnapshot(string fileName) {
            Script script = scripts[fileName];
            return new ScriptSnapshotShim(script);
        }
        [ScriptMember(inScriptName: "getLocalizedDiagnosticMessages", security: ScriptMemberSecurity.Permanent)]
        public object getLocalizedDiagnosticMessages(){
            return null;
        }
        [ScriptMember(inScriptName: "getCancellationToken", security: ScriptMemberSecurity.Permanent)]
        public bool getCancellationToken() {
            return false;
        }
        [ScriptMember(inScriptName: "getCurrentDirectory", security: ScriptMemberSecurity.Permanent)]
        public string getCurrentDirectory(){
            return "";
        }
        [ScriptMember(inScriptName: "getDefaultLibFilename", security: ScriptMemberSecurity.Permanent)]
        public string getDefaultLibFilename(CompilerOptions options){
            return Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "lib.d.ts";
        }


       [ScriptMember(inScriptName: "log", security: ScriptMemberSecurity.Permanent)]
        public void log(string message)
        {       
            Console.WriteLine(String.Format("{0} : {1} : {2}:", DateTime.Now, "Log", message));
        }
    }


}

