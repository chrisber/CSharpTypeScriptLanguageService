﻿
         

﻿using System;
using V8.Net;
using System.Diagnostics;
namespace TypeScriptLanguageService { 


	public class TypeScriptLanguageServices {

	V8Engine v8Engine = null;

	Utilities utilities = null;
	InternalHandle languageService = null;

	public TypeScriptLanguageServices(ILanguageServiceHost host)
	{
		try
		{   //init V8Engine
			v8Engine = new V8Engine();
			v8Engine.GlobalObject.SetProperty(typeof(V8TypeScriptServiceHostEnv), V8PropertyAttributes.Locked, null, true);
            v8Engine.GlobalObject.SetProperty(typeof(V8ScriptSnapshot), V8PropertyAttributes.Locked, null, true);
            v8Engine.GlobalObject.SetProperty(typeof(V8CancellationToken), V8PropertyAttributes.Locked, null, true);
            this.Host = host;
            this.V8Host = new V8TypeScriptServiceHostEnv(v8Engine,host);
			v8Engine.GlobalObject.SetProperty("host", V8Host, null, true, ScriptMemberSecurity.Locked);
			//Execute typescript.ts
			string serviceScriptHandle = v8Engine.Compile("");
			v8Engine.Execute(serviceScriptHandle);
			languageService = v8Engine.GlobalObject.GetProperty("languageService");
			utilities = new Utilities();
		}
		catch (Exception ex)
		{
			log(ex.ToString());
			throw new Exception(ex.ToString());
		}

	}

    public ILanguageServiceHost Host { get; set; }
    public V8TypeScriptServiceHostEnv V8Host { get; set; }



		public void  cleanupSemanticCache ( ) {
				var resultHandle = languageService.Call("cleanupSemanticCache", null );
}
	
		public Diagnostic[]  getSyntacticDiagnostics (   string fileName) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);
				var resultHandle = languageService.Call("getSyntacticDiagnostics", null ,fileNameHandle);
				var result = utilities.TypeMapper<Diagnostic[]>(resultHandle);
				return result;
		}
	
		public Diagnostic[]  getSemanticDiagnostics (   string fileName) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);
				var resultHandle = languageService.Call("getSemanticDiagnostics", null ,fileNameHandle);
				var result = utilities.TypeMapper<Diagnostic[]>(resultHandle);
				return result;
		}
	
		public Diagnostic[]  getCompilerOptionsDiagnostics ( ) {
				var resultHandle = languageService.Call("getCompilerOptionsDiagnostics", null );
				var result = utilities.TypeMapper<Diagnostic[]>(resultHandle);
				return result;
		}
	
		public ClassifiedSpan[]  getSyntacticClassifications (   string fileName,  TextSpan span) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				V8NativeObject spanHandle = v8Engine.CreateObject<V8NativeObject>();
				spanHandle.SetProperty("start", v8Engine.CreateValue(span.start));
				spanHandle.SetProperty("length", v8Engine.CreateValue(span.length));
				v8Engine.GlobalObject.SetProperty("textspan", spanHandle);

				var resultHandle = languageService.Call("getSyntacticClassifications", null ,fileNameHandle,spanHandle);
				var result = utilities.TypeMapper<ClassifiedSpan[]>(resultHandle);
				return result;
		}
	
		public ClassifiedSpan[]  getSemanticClassifications (   string fileName,  TextSpan span) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				V8NativeObject spanHandle = v8Engine.CreateObject<V8NativeObject>();
				spanHandle.SetProperty("start", v8Engine.CreateValue(span.start));
				spanHandle.SetProperty("length", v8Engine.CreateValue(span.length));
				v8Engine.GlobalObject.SetProperty("textspan", spanHandle);

				var resultHandle = languageService.Call("getSemanticClassifications", null ,fileNameHandle,spanHandle);
				var result = utilities.TypeMapper<ClassifiedSpan[]>(resultHandle);
				return result;
		}
	
		public CompletionInfo  getCompletionsAtPosition (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getCompletionsAtPosition", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<CompletionInfo>(resultHandle);
				return result;
		}
	
		public CompletionEntryDetails  getCompletionEntryDetails (   string fileName,  int position,  string entryName) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);

				Handle entryNameHandle = v8Engine.CreateValue(entryName);
				var resultHandle = languageService.Call("getCompletionEntryDetails", null ,fileNameHandle,positionHandle,entryNameHandle);
				var result = utilities.TypeMapper<CompletionEntryDetails>(resultHandle);
				return result;
		}
	
		public QuickInfo  getQuickInfoAtPosition (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getQuickInfoAtPosition", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<QuickInfo>(resultHandle);
				return result;
		}
	
		public TextSpan  getNameOrDottedNameSpan (   string fileName,  int startPos,  int endPos) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle startPosHandle = v8Engine.CreateValue(startPos);

				Handle endPosHandle = v8Engine.CreateValue(endPos);
				var resultHandle = languageService.Call("getNameOrDottedNameSpan", null ,fileNameHandle,startPosHandle,endPosHandle);
				var result = utilities.TypeMapper<TextSpan>(resultHandle);
				return result;
		}
	
		public TextSpan  getBreakpointStatementAtPosition (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getBreakpointStatementAtPosition", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<TextSpan>(resultHandle);
				return result;
		}
	
		public SignatureHelpItems  getSignatureHelpItems (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getSignatureHelpItems", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<SignatureHelpItems>(resultHandle);
				return result;
		}
	
		public RenameInfo  getRenameInfo (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getRenameInfo", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<RenameInfo>(resultHandle);
				return result;
		}
	
		public RenameLocation[]  findRenameLocations (   string fileName,  int position,  bool findInStrings,  bool findInComments) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);

				Handle findInStringsHandle = v8Engine.CreateValue(findInStrings);

				Handle findInCommentsHandle = v8Engine.CreateValue(findInComments);
				var resultHandle = languageService.Call("findRenameLocations", null ,fileNameHandle,positionHandle,findInStringsHandle,findInCommentsHandle);
				var result = utilities.TypeMapper<RenameLocation[]>(resultHandle);
				return result;
		}
	
		public DefinitionInfo[]  getDefinitionAtPosition (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getDefinitionAtPosition", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<DefinitionInfo[]>(resultHandle);
				return result;
		}
	
		public ReferenceEntry[]  getReferencesAtPosition (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getReferencesAtPosition", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<ReferenceEntry[]>(resultHandle);
				return result;
		}
	
		public ReferenceEntry[]  getOccurrencesAtPosition (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getOccurrencesAtPosition", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<ReferenceEntry[]>(resultHandle);
				return result;
		}
	
		public NavigateToItem[]  getNavigateToItems (   string searchValue,  int maxResultCount) {

				Handle searchValueHandle = v8Engine.CreateValue(searchValue);

				Handle maxResultCountHandle = v8Engine.CreateValue(maxResultCount);
				var resultHandle = languageService.Call("getNavigateToItems", null ,searchValueHandle,maxResultCountHandle);
				var result = utilities.TypeMapper<NavigateToItem[]>(resultHandle);
				return result;
		}
	
		public NavigationBarItem[]  getNavigationBarItems (   string fileName) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);
				var resultHandle = languageService.Call("getNavigationBarItems", null ,fileNameHandle);
				var result = utilities.TypeMapper<NavigationBarItem[]>(resultHandle);
				return result;
		}
	
		public OutliningSpan[]  getOutliningSpans (   string fileName) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);
				var resultHandle = languageService.Call("getOutliningSpans", null ,fileNameHandle);
				var result = utilities.TypeMapper<OutliningSpan[]>(resultHandle);
				return result;
		}
	
		public TodoComment[]  getTodoComments (   string fileName,  TodoCommentDescriptor[] descriptors) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				InternalHandle[] array = new InternalHandle[descriptors.Length];
				for ( int i =0; i < descriptors.Length; i++ ) {
				V8NativeObject item = v8Engine.CreateObject<V8NativeObject>();
				item.SetProperty("text", v8Engine.CreateValue(descriptors[i].text));
				item.SetProperty("priority", v8Engine.CreateValue(descriptors[i].priority));
				array[i] = item;
				}
				var descriptorsHandle = v8Engine.CreateArray(array);
		                v8Engine.GlobalObject.SetProperty("descriptor", descriptorsHandle );
				var resultHandle = languageService.Call("getTodoComments", null ,fileNameHandle,descriptorsHandle);
				var result = utilities.TypeMapper<TodoComment[]>(resultHandle);
				return result;
		}
	
		public TextSpan[]  getBraceMatchingAtPosition (   string fileName,  int position) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);
				var resultHandle = languageService.Call("getBraceMatchingAtPosition", null ,fileNameHandle,positionHandle);
				var result = utilities.TypeMapper<TextSpan[]>(resultHandle);
				return result;
		}
	
		public int  getIndentationAtPosition (   string fileName,  int position,  EditorOptions options) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);

				V8NativeObject optionsHandle = v8Engine.CreateObject<V8NativeObject>();
				optionsHandle.SetProperty("IndentSize", v8Engine.CreateValue(options.IndentSize));
				optionsHandle.SetProperty("TabSize", v8Engine.CreateValue(options.TabSize));
				optionsHandle.SetProperty("NewLineCharacter", v8Engine.CreateValue(options.NewLineCharacter));
				optionsHandle.SetProperty("ConvertTabsToSpaces", v8Engine.CreateValue(options.ConvertTabsToSpaces));
				v8Engine.GlobalObject.SetProperty("textspan", optionsHandle);
				var resultHandle = languageService.Call("getIndentationAtPosition", null ,fileNameHandle,positionHandle,optionsHandle);
				return resultHandle;
		}
	
		public TextChange[]  getFormattingEditsForRange (   string fileName,  int start,  int end,  FormatCodeOptions options) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle startHandle = v8Engine.CreateValue(start);

				Handle endHandle = v8Engine.CreateValue(end);

				V8NativeObject optionsHandle = v8Engine.CreateObject<V8NativeObject>();
				optionsHandle.SetProperty("InsertSpaceAfterCommaDelimiter", v8Engine.CreateValue(options.InsertSpaceAfterCommaDelimiter));
				optionsHandle.SetProperty("InsertSpaceAfterSemicolonInForStatements", v8Engine.CreateValue(options.InsertSpaceAfterSemicolonInForStatements));
				optionsHandle.SetProperty("InsertSpaceBeforeAndAfterBinaryOperators", v8Engine.CreateValue(options.InsertSpaceBeforeAndAfterBinaryOperators));
				optionsHandle.SetProperty("InsertSpaceAfterKeywordsInControlFlowStatements", v8Engine.CreateValue(options.InsertSpaceAfterKeywordsInControlFlowStatements));
				optionsHandle.SetProperty("InsertSpaceAfterFunctionKeywordForAnonymousFunctions", v8Engine.CreateValue(options.InsertSpaceAfterFunctionKeywordForAnonymousFunctions));
				optionsHandle.SetProperty("InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis", v8Engine.CreateValue(options.InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis));
				optionsHandle.SetProperty("PlaceOpenBraceOnNewLineForFunctions", v8Engine.CreateValue(options.PlaceOpenBraceOnNewLineForFunctions));
				optionsHandle.SetProperty("PlaceOpenBraceOnNewLineForControlBlocks", v8Engine.CreateValue(options.PlaceOpenBraceOnNewLineForControlBlocks));
				v8Engine.GlobalObject.SetProperty("textspan", optionsHandle);
				var resultHandle = languageService.Call("getFormattingEditsForRange", null ,fileNameHandle,startHandle,endHandle,optionsHandle);
				var result = utilities.TypeMapper<TextChange[]>(resultHandle);
				return result;
		}
	
		public TextChange[]  getFormattingEditsForDocument (   string fileName,  FormatCodeOptions options) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				V8NativeObject optionsHandle = v8Engine.CreateObject<V8NativeObject>();
				optionsHandle.SetProperty("InsertSpaceAfterCommaDelimiter", v8Engine.CreateValue(options.InsertSpaceAfterCommaDelimiter));
				optionsHandle.SetProperty("InsertSpaceAfterSemicolonInForStatements", v8Engine.CreateValue(options.InsertSpaceAfterSemicolonInForStatements));
				optionsHandle.SetProperty("InsertSpaceBeforeAndAfterBinaryOperators", v8Engine.CreateValue(options.InsertSpaceBeforeAndAfterBinaryOperators));
				optionsHandle.SetProperty("InsertSpaceAfterKeywordsInControlFlowStatements", v8Engine.CreateValue(options.InsertSpaceAfterKeywordsInControlFlowStatements));
				optionsHandle.SetProperty("InsertSpaceAfterFunctionKeywordForAnonymousFunctions", v8Engine.CreateValue(options.InsertSpaceAfterFunctionKeywordForAnonymousFunctions));
				optionsHandle.SetProperty("InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis", v8Engine.CreateValue(options.InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis));
				optionsHandle.SetProperty("PlaceOpenBraceOnNewLineForFunctions", v8Engine.CreateValue(options.PlaceOpenBraceOnNewLineForFunctions));
				optionsHandle.SetProperty("PlaceOpenBraceOnNewLineForControlBlocks", v8Engine.CreateValue(options.PlaceOpenBraceOnNewLineForControlBlocks));
				v8Engine.GlobalObject.SetProperty("textspan", optionsHandle);
				var resultHandle = languageService.Call("getFormattingEditsForDocument", null ,fileNameHandle,optionsHandle);
				var result = utilities.TypeMapper<TextChange[]>(resultHandle);
				return result;
		}
	
		public TextChange[]  getFormattingEditsAfterKeystroke (   string fileName,  int position,  string key,  FormatCodeOptions options) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);

				Handle positionHandle = v8Engine.CreateValue(position);

				Handle keyHandle = v8Engine.CreateValue(key);

				V8NativeObject optionsHandle = v8Engine.CreateObject<V8NativeObject>();
				optionsHandle.SetProperty("InsertSpaceAfterCommaDelimiter", v8Engine.CreateValue(options.InsertSpaceAfterCommaDelimiter));
				optionsHandle.SetProperty("InsertSpaceAfterSemicolonInForStatements", v8Engine.CreateValue(options.InsertSpaceAfterSemicolonInForStatements));
				optionsHandle.SetProperty("InsertSpaceBeforeAndAfterBinaryOperators", v8Engine.CreateValue(options.InsertSpaceBeforeAndAfterBinaryOperators));
				optionsHandle.SetProperty("InsertSpaceAfterKeywordsInControlFlowStatements", v8Engine.CreateValue(options.InsertSpaceAfterKeywordsInControlFlowStatements));
				optionsHandle.SetProperty("InsertSpaceAfterFunctionKeywordForAnonymousFunctions", v8Engine.CreateValue(options.InsertSpaceAfterFunctionKeywordForAnonymousFunctions));
				optionsHandle.SetProperty("InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis", v8Engine.CreateValue(options.InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis));
				optionsHandle.SetProperty("PlaceOpenBraceOnNewLineForFunctions", v8Engine.CreateValue(options.PlaceOpenBraceOnNewLineForFunctions));
				optionsHandle.SetProperty("PlaceOpenBraceOnNewLineForControlBlocks", v8Engine.CreateValue(options.PlaceOpenBraceOnNewLineForControlBlocks));
				v8Engine.GlobalObject.SetProperty("textspan", optionsHandle);
				var resultHandle = languageService.Call("getFormattingEditsAfterKeystroke", null ,fileNameHandle,positionHandle,keyHandle,optionsHandle);
				var result = utilities.TypeMapper<TextChange[]>(resultHandle);
				return result;
		}
	
		public EmitOutput  getEmitOutput (   string fileName) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);
				var resultHandle = languageService.Call("getEmitOutput", null ,fileNameHandle);
				var result = utilities.TypeMapper<EmitOutput>(resultHandle);
				return result;
		}
	
		public Program  getProgram ( ) {
				var resultHandle = languageService.Call("getProgram", null );
				return null;
		}
	
		public SourceFile  getSourceFile (   string fileName) {

				Handle fileNameHandle = v8Engine.CreateValue(fileName);
				var resultHandle = languageService.Call("getSourceFile", null ,fileNameHandle);
				var result = utilities.TypeMapper<SourceFile>(resultHandle);
				return result;
		}
	
		public void  dispose ( ) {
				var resultHandle = languageService.Call("dispose", null );
}
	

		/*Helper Functions*/

		public static  void log(string result)
		{
		    var mth = new StackTrace().GetFrame(1).GetMethod();
		    System.Diagnostics.Debugger.Log(0, null, mth.ReflectedType.Name + "." + mth.Name + "()-->" + result + "\n");
		}
	}
}

