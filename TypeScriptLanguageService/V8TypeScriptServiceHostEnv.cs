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

            var cOpt = host.getCompilationSettings();

			if (cOpt == null) {
				return null;
			}

			var cOptHandle = v8engine.CreateObject<V8NativeObject>();

		    cOptHandle.SetProperty("allowNonTsExtensions", v8engine.CreateValue(cOpt.allowNonTsExtensions));
            cOptHandle.SetProperty("charset", v8engine.CreateValue(cOpt.charset));
            cOptHandle.SetProperty("codepage", v8engine.CreateValue(cOpt.codepage));
            cOptHandle.SetProperty("declaration", v8engine.CreateValue(cOpt.declaration));
            cOptHandle.SetProperty("diagnostics", v8engine.CreateValue(cOpt.diagnostics));
            cOptHandle.SetProperty("emitBOM", v8engine.CreateValue(cOpt.emitBOM));
            cOptHandle.SetProperty("help", v8engine.CreateValue(cOpt.help));
            cOptHandle.SetProperty("listFiles", v8engine.CreateValue(cOpt.listFiles));
            cOptHandle.SetProperty("locale", v8engine.CreateValue(cOpt.locale));
            cOptHandle.SetProperty("mapRoot", v8engine.CreateValue(cOpt.mapRoot));
            cOptHandle.SetProperty("module", v8engine.CreateValue(cOpt.module));
            cOptHandle.SetProperty("noEmit", v8engine.CreateValue(cOpt.noEmit));
            cOptHandle.SetProperty("noEmitOnError", v8engine.CreateValue(cOpt.noEmitOnError));
            cOptHandle.SetProperty("noErrorTruncation", v8engine.CreateValue(cOpt.noErrorTruncation));
            cOptHandle.SetProperty("noImplicitAny", v8engine.CreateValue(cOpt.noImplicitAny));
            cOptHandle.SetProperty("noLib", v8engine.CreateValue(cOpt.noLib));
            cOptHandle.SetProperty("noLibCheck", v8engine.CreateValue(cOpt.noLibCheck));
            cOptHandle.SetProperty("noResolve", v8engine.CreateValue(cOpt.noResolve));
            cOptHandle.SetProperty("tsOut", v8engine.CreateValue(cOpt.tsOut));
            cOptHandle.SetProperty("outDir", v8engine.CreateValue(cOpt.outDir));
            cOptHandle.SetProperty("preserveConstEnums", v8engine.CreateValue(cOpt.preserveConstEnums));
            cOptHandle.SetProperty("project", v8engine.CreateValue(cOpt.project));
            cOptHandle.SetProperty("removeComments", v8engine.CreateValue(cOpt.removeComments));
            cOptHandle.SetProperty("sourceMap", v8engine.CreateValue(cOpt.sourceMap));
            cOptHandle.SetProperty("sourceRoot", v8engine.CreateValue(cOpt.sourceRoot));
            cOptHandle.SetProperty("suppressImplicitAnyIndexErrors", v8engine.CreateValue(cOpt.suppressImplicitAnyIndexErrors));
            cOptHandle.SetProperty("target", v8engine.CreateValue(cOpt.target));
            cOptHandle.SetProperty("version", v8engine.CreateValue(cOpt.version));
            cOptHandle.SetProperty("watch", v8engine.CreateValue(cOpt.watch));
            cOptHandle.SetProperty("stripInternal", v8engine.CreateValue(cOpt.stripInternal));

            return cOptHandle;

        }


        public InternalHandle getNewLine(){

			var lineEnd = host.getNewLine();

			if (lineEnd == null) {
				return null;
			}

			return v8engine.CreateValue(lineEnd);
        }


        public InternalHandle[] getScriptFileNames(){


            var scriptArray = host.getScriptFileNames();

			if (scriptArray == null) {
				return null;
			}

            InternalHandle[] handleArray = new InternalHandle[scriptArray.Length];
            for (int i = 0; i < scriptArray.Length; i++)
            {
                handleArray[i] = v8engine.CreateValue(scriptArray[i]);
            }

            return handleArray;
        }


        public InternalHandle getScriptVersion(InternalHandle fileName){

			var version = host.getScriptVersion(fileName);

			if (version == null) {
				return null;
			}

			return v8engine.CreateValue(version); 
        }

       
        public InternalHandle getScriptSnapshot(InternalHandle fileName){
            // return IScriptSnapshot
            
            var snapshot = host.getScriptSnapshot(fileName);

			if (snapshot == null) {
				return null;
			}

			var v8Snapshot = new V8ScriptSnapshotAdapter(v8engine, snapshot);

			var guid = Guid.NewGuid().ToString();
			v8engine.GlobalObject.SetProperty(guid, v8Snapshot);
			var handle = v8engine.GlobalObject.GetProperty(guid);
			return handle;

        }

        public InternalHandle getLocalizedDiagnosticMessages(){
            return null;
        }


        //@TODO This callback needs meaning
        public InternalHandle getCancellationToken(){
            var cToken = new V8CancellationToken(v8engine);
			var cTokenHandle = v8engine.GetTypeBinder(typeof(V8CancellationToken)).CreateObject(cToken);
            return  cTokenHandle;
        }


        //@TODO What they need the dir for???
        public InternalHandle getCurrentDirectory() {

			var cDir = host.getCurrentDirectory();

			if (cDir == null) {
				return null;
			}

			return v8engine.CreateValue(cDir);
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

        public void log(InternalHandle s){
            host.log(s);
        }
        public void trace(InternalHandle s){
            host.trace(s);
        }
        public void error(InternalHandle s){
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
