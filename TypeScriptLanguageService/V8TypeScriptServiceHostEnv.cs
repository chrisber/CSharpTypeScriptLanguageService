using System;
using V8.Net;
using System.Collections.Generic;
using System.Linq;

namespace TypeScriptLanguageService
{
    //
    // Public interface of the host of a language service instance.
    //
    [ScriptObject("V8TypeScriptServiceHostEnv", ScriptMemberSecurity.Permanent)]
    public class V8TypeScriptServiceHostEnv : IV8NativeObject
    {
        V8Engine v8engine = null;
        ILanguageServiceHost host = null;

        public V8TypeScriptServiceHostEnv(V8Engine v8engine, ILanguageServiceHost host)
        {
            this.v8engine = v8engine;
            this.host = host;
        }

        #region language service host implementation

   
        public InternalHandle getCompilationSettings(){

            var CopOptions = host.getCompilationSettings();

            V8NativeObject cOpt = v8engine.CreateObject<V8NativeObject>();

            cOpt.SetProperty("allowNonTsExtensions", v8engine.CreateValue(CopOptions.allowNonTsExtensions));
            cOpt.SetProperty("charset", v8engine.CreateValue(CopOptions.charset));
            cOpt.SetProperty("codepage", v8engine.CreateValue(CopOptions.codepage));
            cOpt.SetProperty("declaration", v8engine.CreateValue(CopOptions.declaration));
            cOpt.SetProperty("diagnostics", v8engine.CreateValue(CopOptions.diagnostics));
            cOpt.SetProperty("emitBOM", v8engine.CreateValue(CopOptions.emitBOM));
            cOpt.SetProperty("help", v8engine.CreateValue(CopOptions.help));
            cOpt.SetProperty("listFiles", v8engine.CreateValue(CopOptions.listFiles));
            cOpt.SetProperty("locale", v8engine.CreateValue(CopOptions.locale));
            cOpt.SetProperty("mapRoot", v8engine.CreateValue(CopOptions.mapRoot));
            cOpt.SetProperty("module", v8engine.CreateValue(CopOptions.module));
            cOpt.SetProperty("noEmit", v8engine.CreateValue(CopOptions.noEmit));
            cOpt.SetProperty("noEmitOnError", v8engine.CreateValue(CopOptions.noEmitOnError));
            cOpt.SetProperty("noErrorTruncation", v8engine.CreateValue(CopOptions.noErrorTruncation));
            cOpt.SetProperty("noImplicitAny", v8engine.CreateValue(CopOptions.noImplicitAny));
            cOpt.SetProperty("noLib", v8engine.CreateValue(CopOptions.noLib));
            cOpt.SetProperty("noLibCheck", v8engine.CreateValue(CopOptions.noLibCheck));
            cOpt.SetProperty("noResolve", v8engine.CreateValue(CopOptions.noResolve));
            cOpt.SetProperty("tsOut", v8engine.CreateValue(CopOptions.tsOut));
            cOpt.SetProperty("outDir", v8engine.CreateValue(CopOptions.outDir));
            cOpt.SetProperty("preserveConstEnums", v8engine.CreateValue(CopOptions.preserveConstEnums));
            cOpt.SetProperty("project", v8engine.CreateValue(CopOptions.project));
            cOpt.SetProperty("removeComments", v8engine.CreateValue(CopOptions.removeComments));
            cOpt.SetProperty("sourceMap", v8engine.CreateValue(CopOptions.sourceMap));
            cOpt.SetProperty("sourceRoot", v8engine.CreateValue(CopOptions.sourceRoot));
            cOpt.SetProperty("suppressImplicitAnyIndexErrors", v8engine.CreateValue(CopOptions.suppressImplicitAnyIndexErrors));
            cOpt.SetProperty("target", v8engine.CreateValue(CopOptions.target));
            cOpt.SetProperty("version", v8engine.CreateValue(CopOptions.version));
            cOpt.SetProperty("watch", v8engine.CreateValue(CopOptions.watch));
            cOpt.SetProperty("stripInternal", v8engine.CreateValue(CopOptions.stripInternal));

            return cOpt;

        }


        public InternalHandle getNewLine(){
            return v8engine.CreateValue(host.getNewLine());
        }


        public InternalHandle[] getScriptFileNames(){


            var scriptArray = host.getScriptFileNames();

            InternalHandle[] handleArray = new InternalHandle[scriptArray.Length];
            for (int i = 0; i < scriptArray.Length; i++)
            {
                handleArray[i] = v8engine.CreateValue(scriptArray[i]);
            }
            return handleArray;
        }


        public InternalHandle getScriptVersion(InternalHandle fileName){
            return v8engine.CreateValue(host.getScriptVersion(fileName)); 
        }

       
        public InternalHandle getScriptSnapshot(InternalHandle fileName){
            // return IScriptSnapshot
            
            var snapshot = host.getScriptSnapshot(fileName);
            var v8Snapshot = new V8ScriptSnapshot(v8engine, snapshot);
            v8engine.GlobalObject.SetProperty("snapshot", v8Snapshot, null, true, ScriptMemberSecurity.Locked);
            var snapshotHandle = v8engine.GlobalObject.GetProperty("snapshot");
            return  snapshotHandle;

        }

        public InternalHandle getLocalizedDiagnosticMessages(){
            return v8engine.CreateValue("null");
        }


        //@TODO This callback needs meaning
        public InternalHandle getCancellationToken(){
            var cToken = new V8CancellationToken(v8engine);
            v8engine.GlobalObject.SetProperty("cToken", cToken, null, true, ScriptMemberSecurity.Locked);
            var cTokenHandle = v8engine.GlobalObject.GetProperty("cToken");
            return  cTokenHandle;
        }


        //@TODO What they need the dir for???
        public InternalHandle getCurrentDirectory() {
            return v8engine.CreateValue("");
        }

        //@TODO Why do I need the options parameter?, should I mahrsahl  them???
        public InternalHandle getDefaultLibFileName(InternalHandle options ){
            var cOptions = new CompilerOptions();
            cOptions.allowNonTsExtensions = options.GetProperty("allowNonTsExtensions");
            cOptions.charset = options.GetProperty("charset");
            cOptions.codepage = options.GetProperty("codepage");
            cOptions.declaration = options.GetProperty("declaration");
            cOptions.diagnostics = options.GetProperty("diagnostics");
            cOptions.emitBOM = options.GetProperty("emitBOM");
            cOptions.help = options.GetProperty("help");
            cOptions.listFiles = options.GetProperty("listFiles");
            cOptions.locale = options.GetProperty("locale");
            cOptions.mapRoot = options.GetProperty("mapRoot");
            ModuleKind moduleKind;
            Enum.TryParse(options.GetProperty("module"), out moduleKind);
            cOptions.module = moduleKind;
            cOptions.noEmit = options.GetProperty("noEmit");
            cOptions.noEmitOnError = options.GetProperty("noEmitOnError");
            cOptions.noErrorTruncation = options.GetProperty("noErrorTruncation");
            cOptions.noImplicitAny = options.GetProperty("noImplicitAny");
            cOptions.noLib = options.GetProperty("noLib");
            cOptions.noLibCheck = options.GetProperty("noLibCheck");
            cOptions.noResolve = options.GetProperty("noResolve");
            cOptions.tsOut = options.GetProperty("tsOut");
            cOptions.outDir = options.GetProperty("outDir");
            cOptions.preserveConstEnums = options.GetProperty("preserveConstEnums");
            cOptions.project = options.GetProperty("project");
            cOptions.removeComments = options.GetProperty("removeComments");
            cOptions.sourceMap = options.GetProperty("sourceMap");
            cOptions.sourceRoot = options.GetProperty("sourceRoot");
            cOptions.suppressImplicitAnyIndexErrors = options.GetProperty("suppressImplicitAnyIndexErrors");
            ScriptTarget scriptTarget;
            Enum.TryParse(options.GetProperty("target"), out scriptTarget);
            cOptions.target = scriptTarget;
            cOptions.version = options.GetProperty("version");
            cOptions.watch = options.GetProperty("watch");
            cOptions.stripInternal = options.GetProperty("stripInternal");

            return v8engine.CreateValue(host.getDefaultLibFileName(cOptions));

        }

        void log(InternalHandle s){
            host.log(s);
        }
        void trace(InternalHandle s){
            host.trace(s);
        }
        void error(InternalHandle s){
            host.error(s);
        }

        #endregion

        #region IV8NativeObject implementation

        public void Initialize(V8NativeObject owner, bool isConstructCall, params InternalHandle[] args)
        {
        }

        public void Dispose()
        {
        }

        #endregion
       
    }
}

//
// Public interface of the host of a language service instance.
//
//export interface LanguageServiceHost {






//    log? (s: string): void;
//    trace? (s: string): void;
//    error? (s: string): void;
//}

