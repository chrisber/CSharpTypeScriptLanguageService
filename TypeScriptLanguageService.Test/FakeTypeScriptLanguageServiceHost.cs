using System;
using System.IO;
using System.Reflection;

namespace TypeScriptLanguageService.Test
{
	public class FakeTypeScriptLanguageServiceHost : ILanguageServiceHost
    {
        public FakeTypeScriptLanguageServiceHost()
        {
        }

		#region ILanguageServiceHost implementation

		public ICompilerOptions getCompilationSettings()
		{
			var cOpt = new CompilerOptions();
			cOpt.allowNonTsExtensions=false;
			cOpt.charset="UTF-8";
			cOpt.codepage=0;
			cOpt.declaration=false;
			cOpt.diagnostics=false;
			cOpt.emitBOM=false;
			cOpt.help=false;
			cOpt.listFiles=false;
			cOpt.locale="";
			cOpt.mapRoot="";
			cOpt.module=0;
			cOpt.noEmit=false;
			cOpt.noEmitOnError=false;
			cOpt.noErrorTruncation=false;
			cOpt.noImplicitAny=false;
			cOpt.noLib=false;
			cOpt.noLibCheck=false;
			cOpt.noResolve=false;
			cOpt.tsOut="";
			cOpt.outDir="";
			cOpt.preserveConstEnums=false;
			cOpt.project="";
			cOpt.removeComments=false;
			cOpt.sourceMap=false;
			cOpt.sourceRoot="";
			cOpt.suppressImplicitAnyIndexErrors=false;
			cOpt.target=ScriptTarget.ES6;
			cOpt.version=false;
			cOpt.watch=false;
			cOpt.stripInternal=false;
			return cOpt;
		}

		public string getNewLine()
		{
			return Environment.NewLine;
		}

		public string[] getScriptFileNames()
		{
			return new string[]{"dummy.ts"};
		}

		public string getScriptVersion(string fileName)
		{
			return "0";
		}

		public IScriptSnapshot getScriptSnapshot(string fileName)
		{
			return null;
		}

		public string getLocalizedDiagnosticMessages()
		{
			return null;
		}

		public ICancellationToken getCancellationToken()
		{
			return null;
		}

		public string getCurrentDirectory()
		{
			return String.Empty;
		}

		public string getDefaultLibFileName(ICompilerOptions options)
		{
			return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + Path.DirectorySeparatorChar + "lib.d.ts";
		}

		public void log(string s)
		{
			Console.WriteLine(s);
		}

		public void trace(string s)
		{
			Console.WriteLine(s);
		}

		public void error(string s)
		{
			Console.WriteLine(s);
		}

		#endregion
    }
}

