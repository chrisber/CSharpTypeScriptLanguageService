
	//interfaces
using System;
using System.Collections.Generic;

namespace CSharpTypeScriptLanguageServices { 
	
			[Flags]
			public enum SyntaxKind {
					Unknown,	
					EndOfFileToken,	
					SingleLineCommentTrivia,	
					MultiLineCommentTrivia,	
					NewLineTrivia,	
					WhitespaceTrivia,	
					ConflictMarkerTrivia,	
					NumericLiteral,	
					StringLiteral,	
					RegularExpressionLiteral,	
					NoSubstitutionTemplateLiteral,	
					TemplateHead,	
					TemplateMiddle,	
					TemplateTail,	
					OpenBraceToken,	
					CloseBraceToken,	
					OpenParenToken,	
					CloseParenToken,	
					OpenBracketToken,	
					CloseBracketToken,	
					DotToken,	
					DotDotDotToken,	
					SemicolonToken,	
					CommaToken,	
					LessThanToken,	
					GreaterThanToken,	
					LessThanEqualsToken,	
					GreaterThanEqualsToken,	
					EqualsEqualsToken,	
					ExclamationEqualsToken,	
					EqualsEqualsEqualsToken,	
					ExclamationEqualsEqualsToken,	
					EqualsGreaterThanToken,	
					PlusToken,	
					MinusToken,	
					AsteriskToken,	
					SlashToken,	
					PercentToken,	
					PlusPlusToken,	
					MinusMinusToken,	
					LessThanLessThanToken,	
					GreaterThanGreaterThanToken,	
					GreaterThanGreaterThanGreaterThanToken,	
					AmpersandToken,	
					BarToken,	
					CaretToken,	
					ExclamationToken,	
					TildeToken,	
					AmpersandAmpersandToken,	
					BarBarToken,	
					QuestionToken,	
					ColonToken,	
					EqualsToken,	
					PlusEqualsToken,	
					MinusEqualsToken,	
					AsteriskEqualsToken,	
					SlashEqualsToken,	
					PercentEqualsToken,	
					LessThanLessThanEqualsToken,	
					GreaterThanGreaterThanEqualsToken,	
					GreaterThanGreaterThanGreaterThanEqualsToken,	
					AmpersandEqualsToken,	
					BarEqualsToken,	
					CaretEqualsToken,	
					Identifier,	
					BreakKeyword,	
					CaseKeyword,	
					CatchKeyword,	
					ClassKeyword,	
					ConstKeyword,	
					ContinueKeyword,	
					DebuggerKeyword,	
					DefaultKeyword,	
					DeleteKeyword,	
					DoKeyword,	
					ElseKeyword,	
					EnumKeyword,	
					ExportKeyword,	
					ExtendsKeyword,	
					FalseKeyword,	
					FinallyKeyword,	
					ForKeyword,	
					FunctionKeyword,	
					IfKeyword,	
					ImportKeyword,	
					InKeyword,	
					InstanceOfKeyword,	
					NewKeyword,	
					NullKeyword,	
					ReturnKeyword,	
					SuperKeyword,	
					SwitchKeyword,	
					ThisKeyword,	
					ThrowKeyword,	
					TrueKeyword,	
					TryKeyword,	
					TypeOfKeyword,	
					VarKeyword,	
					VoidKeyword,	
					WhileKeyword,	
					WithKeyword,	
					AsKeyword,	
					ImplementsKeyword,	
					InterfaceKeyword,	
					LetKeyword,	
					PackageKeyword,	
					PrivateKeyword,	
					ProtectedKeyword,	
					PublicKeyword,	
					StaticKeyword,	
					YieldKeyword,	
					AnyKeyword,	
					BooleanKeyword,	
					ConstructorKeyword,	
					DeclareKeyword,	
					GetKeyword,	
					ModuleKeyword,	
					RequireKeyword,	
					NumberKeyword,	
					SetKeyword,	
					StringKeyword,	
					SymbolKeyword,	
					TypeKeyword,	
					FromKeyword,	
					OfKeyword,	
					QualifiedName,	
					ComputedPropertyName,	
					TypeParameter,	
					Parameter,	
					PropertySignature,	
					PropertyDeclaration,	
					MethodSignature,	
					MethodDeclaration,	
					Constructor,	
					GetAccessor,	
					SetAccessor,	
					CallSignature,	
					ConstructSignature,	
					IndexSignature,	
					TypeReference,	
					FunctionType,	
					ConstructorType,	
					TypeQuery,	
					TypeLiteral,	
					ArrayType,	
					TupleType,	
					UnionType,	
					ParenthesizedType,	
					ObjectBindingPattern,	
					ArrayBindingPattern,	
					BindingElement,	
					ArrayLiteralExpression,	
					ObjectLiteralExpression,	
					PropertyAccessExpression,	
					ElementAccessExpression,	
					CallExpression,	
					NewExpression,	
					TaggedTemplateExpression,	
					TypeAssertionExpression,	
					ParenthesizedExpression,	
					FunctionExpression,	
					ArrowFunction,	
					DeleteExpression,	
					TypeOfExpression,	
					VoidExpression,	
					PrefixUnaryExpression,	
					PostfixUnaryExpression,	
					BinaryExpression,	
					ConditionalExpression,	
					TemplateExpression,	
					YieldExpression,	
					SpreadElementExpression,	
					OmittedExpression,	
					TemplateSpan,	
					Block,	
					VariableStatement,	
					EmptyStatement,	
					ExpressionStatement,	
					IfStatement,	
					DoStatement,	
					WhileStatement,	
					ForStatement,	
					ForInStatement,	
					ForOfStatement,	
					ContinueStatement,	
					BreakStatement,	
					ReturnStatement,	
					WithStatement,	
					SwitchStatement,	
					LabeledStatement,	
					ThrowStatement,	
					TryStatement,	
					DebuggerStatement,	
					VariableDeclaration,	
					VariableDeclarationList,	
					FunctionDeclaration,	
					ClassDeclaration,	
					InterfaceDeclaration,	
					TypeAliasDeclaration,	
					EnumDeclaration,	
					ModuleDeclaration,	
					ModuleBlock,	
					ImportEqualsDeclaration,	
					ImportDeclaration,	
					ImportClause,	
					NamespaceImport,	
					NamedImports,	
					ImportSpecifier,	
					ExportAssignment,	
					ExportDeclaration,	
					NamedExports,	
					ExportSpecifier,	
					ExternalModuleReference,	
					CaseClause,	
					DefaultClause,	
					HeritageClause,	
					CatchClause,	
					PropertyAssignment,	
					ShorthandPropertyAssignment,	
					EnumMember,	
					SourceFile,	
					SyntaxList,	
					Count,	
					FirstAssignment=EqualsToken,	
					LastAssignment=CaretEqualsToken,	
					FirstReservedWord=BreakKeyword,	
					LastReservedWord=WithKeyword,	
					FirstKeyword=BreakKeyword,	
					LastKeyword=OfKeyword,	
					FirstFutureReservedWord=ImplementsKeyword,	
					LastFutureReservedWord=YieldKeyword,	
					FirstTypeNode=TypeReference,	
					LastTypeNode=ParenthesizedType,	
					FirstPunctuation=OpenBraceToken,	
					LastPunctuation=CaretEqualsToken,	
					FirstToken=Unknown,	
					LastToken=LastKeyword,	
					FirstTriviaToken=SingleLineCommentTrivia,	
					LastTriviaToken=ConflictMarkerTrivia,	
					FirstLiteralToken=NumericLiteral,	
					LastLiteralToken=NoSubstitutionTemplateLiteral,	
					FirstTemplateToken=NoSubstitutionTemplateLiteral,	
					LastTemplateToken=TemplateTail,	
					FirstBinaryOperator=LessThanToken,	
					LastBinaryOperator=CaretEqualsToken,	
					FirstNode=QualifiedName,	
				}
	
			[Flags]
			public enum NodeFlags {
					Export=0x00000001,	
					Ambient=0x00000002,	
					Public=0x00000010,	
					Private=0x00000020,	
					Protected=0x00000040,	
					Static=0x00000080,	
					MultiLine=0x00000100,	
					Synthetic=0x00000200,	
					DeclarationFile=0x00000400,	
					Let=0x00000800,	
					Const=0x00001000,	
					OctalLiteral=0x00002000,	
					Modifier=Export|Ambient|Public|Private|Protected|Static,	
					AccessibilityModifier=Public|Private|Protected,	
					BlockScoped=Let|Const,	
				}
	
			[Flags]
			public enum ParserContextFlags {
					StrictMode=1<<0,	
					DisallowIn=1<<1,	
					Yield=1<<2,	
					GeneratorParameter=1<<3,	
					ThisNodeHasError=1<<4,	
					ParserGeneratedFlags=StrictMode|DisallowIn|Yield|GeneratorParameter|ThisNodeHasError,	
					ThisNodeOrAnySubNodesHasError=1<<5,	
					HasAggregatedChildData=1<<6,	
				}
	
			[Flags]
			public enum RelationComparisonResult {
					Succeeded=1,	
					Failed=2,	
					FailedAndReported=3,	
				}
	
			[Flags]
			public enum ExitStatus {
					Success=0,	
					DiagnosticsPresent_OutputsSkipped=1,	
					DiagnosticsPresent_OutputsGenerated=2,	
				}
	
			[Flags]
			public enum TypeFormatFlags {
					None=0x00000000,	
					WriteArrayAsGenericType=0x00000001,	
					UseTypeOfFunction=0x00000002,	
					NoTruncation=0x00000004,	
					WriteArrowStyleSignature=0x00000008,	
					WriteOwnNameForAnyLike=0x00000010,	
					WriteTypeArgumentsOfSignature=0x00000020,	
					InElementType=0x00000040,	
					UseFullyQualifiedType=0x00000080,	
				}
	
			[Flags]
			public enum SymbolFormatFlags {
					None=0x00000000,	
					WriteTypeParametersOrArguments=0x00000001,	
					UseOnlyExternalAliasing=0x00000002,	
				}
	
			[Flags]
			public enum SymbolAccessibility {
					Accessible,	
					NotAccessible,	
					CannotBeNamed,	
				}
	
			[Flags]
			public enum SymbolFlags {
					FunctionScopedVariable=0x00000001,	
					BlockScopedVariable=0x00000002,	
					Property=0x00000004,	
					EnumMember=0x00000008,	
					Function=0x00000010,	
					Class=0x00000020,	
					Interface=0x00000040,	
					ConstEnum=0x00000080,	
					RegularEnum=0x00000100,	
					ValueModule=0x00000200,	
					NamespaceModule=0x00000400,	
					TypeLiteral=0x00000800,	
					ObjectLiteral=0x00001000,	
					Method=0x00002000,	
					Constructor=0x00004000,	
					GetAccessor=0x00008000,	
					SetAccessor=0x00010000,	
					Signature=0x00020000,	
					TypeParameter=0x00040000,	
					TypeAlias=0x00080000,	
					ExportValue=0x00100000,	
					ExportType=0x00200000,	
					ExportNamespace=0x00400000,	
					Import=0x00800000,	
					Instantiated=0x01000000,	
					Merged=0x02000000,	
					Transient=0x04000000,	
					Prototype=0x08000000,	
					UnionProperty=0x10000000,	
					Optional=0x20000000,	
					Enum=RegularEnum|ConstEnum,	
					Variable=FunctionScopedVariable|BlockScopedVariable,	
					Value=Variable|Property|EnumMember|Function|Class|Enum|ValueModule|Method|GetAccessor|SetAccessor,	
					tsType=Class|Interface|Enum|TypeLiteral|ObjectLiteral|TypeParameter|TypeAlias,	
					Namespace=ValueModule|NamespaceModule,	
					Module=ValueModule|NamespaceModule,	
					Accessor=GetAccessor|SetAccessor,	
					FunctionScopedVariableExcludes=Value&~FunctionScopedVariable,	
					BlockScopedVariableExcludes=Value,	
					ParameterExcludes=Value,	
					PropertyExcludes=Value,	
					EnumMemberExcludes=Value,	
					FunctionExcludes=Value&~(Function|ValueModule),	
					ClassExcludes=(Value|tsType)&~ValueModule,	
					InterfaceExcludes=tsType&~Interface,	
					RegularEnumExcludes=(Value|tsType)&~(RegularEnum|ValueModule),	
					ConstEnumExcludes=(Value|tsType)&~ConstEnum,	
					ValueModuleExcludes=Value&~(Function|Class|RegularEnum|ValueModule),	
					NamespaceModuleExcludes=0,	
					MethodExcludes=Value&~Method,	
					GetAccessorExcludes=Value&~SetAccessor,	
					SetAccessorExcludes=Value&~GetAccessor,	
					TypeParameterExcludes=tsType&~TypeParameter,	
					TypeAliasExcludes=tsType,	
					ImportExcludes=Import,	
					ModuleMember=Variable|Function|Class|Interface|Enum|Module|TypeAlias|Import,	
					ExportHasLocal=Function|Class|Enum|ValueModule,	
					HasLocals=Function|Module|Method|Constructor|Accessor|Signature,	
					HasExports=Class|Enum|Module,	
					HasMembers=Class|Interface|TypeLiteral|ObjectLiteral,	
					IsContainer=HasLocals|HasExports|HasMembers,	
					PropertyOrAccessor=Property|Accessor,	
					Export=ExportNamespace|ExportType|ExportValue,	
				}
	
			[Flags]
			public enum NodeCheckFlags {
					TypeChecked=0x00000001,	
					LexicalThis=0x00000002,	
					CaptureThis=0x00000004,	
					EmitExtends=0x00000008,	
					SuperInstance=0x00000010,	
					SuperStatic=0x00000020,	
					ContextChecked=0x00000040,	
					EnumValuesComputed=0x00000080,	
				}
	
			[Flags]
			public enum TypeFlags {
					Any=0x00000001,	
					String=0x00000002,	
					Number=0x00000004,	
					Boolean=0x00000008,	
					Void=0x00000010,	
					Undefined=0x00000020,	
					Null=0x00000040,	
					Enum=0x00000080,	
					StringLiteral=0x00000100,	
					TypeParameter=0x00000200,	
					Class=0x00000400,	
					Interface=0x00000800,	
					Reference=0x00001000,	
					Tuple=0x00002000,	
					Union=0x00004000,	
					Anonymous=0x00008000,	
					FromSignature=0x00010000,	
					ObjectLiteral=0x00020000,	
					ContainsUndefinedOrNull=0x00040000,	
					ContainsObjectLiteral=0x00080000,	
					ESSymbol=0x00100000,	
					Intrinsic=Any|String|Number|Boolean|ESSymbol|Void|Undefined|Null,	
					Primitive=String|Number|Boolean|ESSymbol|Void|Undefined|Null|StringLiteral|Enum,	
					StringLike=String|StringLiteral,	
					NumberLike=Number|Enum,	
					ObjectType=Class|Interface|Reference|Tuple|Anonymous,	
					RequiresWidening=ContainsUndefinedOrNull|ContainsObjectLiteral,	
				}
	
			[Flags]
			public enum SignatureKind {
					Call,	
					Construct,	
				}
	
			[Flags]
			public enum IndexKind {
					String,	
					Number,	
				}
	
			[Flags]
			public enum DiagnosticCategory {
					Warning,	
					Error,	
					Message,	
				}
	
			[Flags]
			public enum ModuleKind {
					None=0,	
					CommonJS=1,	
					AMD=2,	
				}
	
			[Flags]
			public enum ScriptTarget {
					ES3=0,	
					ES5=1,	
					ES6=2,	
					Latest=ES6,	
				}
	
			[Flags]
			public enum CharacterCodes {
					nullCharacter=0,	
					maxAsciiCharacter=0x7F,	
					lineFeed=0x0A,	
					carriageReturn=0x0D,	
					lineSeparator=0x2028,	
					paragraphSeparator=0x2029,	
					nextLine=0x0085,	
					space=0x0020,	
					nonBreakingSpace=0x00A0,	
					enQuad=0x2000,	
					emQuad=0x2001,	
					enSpace=0x2002,	
					emSpace=0x2003,	
					threePerEmSpace=0x2004,	
					fourPerEmSpace=0x2005,	
					sixPerEmSpace=0x2006,	
					figureSpace=0x2007,	
					punctuationSpace=0x2008,	
					thinSpace=0x2009,	
					hairSpace=0x200A,	
					zeroWidthSpace=0x200B,	
					narrowNoBreakSpace=0x202F,	
					ideographicSpace=0x3000,	
					mathematicalSpace=0x205F,	
					ogham=0x1680,	
					_=0x5F,	
					dollar=0x24,	
					_0=0x30,	
					_1=0x31,	
					_2=0x32,	
					_3=0x33,	
					_4=0x34,	
					_5=0x35,	
					_6=0x36,	
					_7=0x37,	
					_8=0x38,	
					_9=0x39,	
					a=0x61,	
					b=0x62,	
					c=0x63,	
					d=0x64,	
					e=0x65,	
					f=0x66,	
					g=0x67,	
					h=0x68,	
					i=0x69,	
					j=0x6A,	
					k=0x6B,	
					l=0x6C,	
					m=0x6D,	
					n=0x6E,	
					o=0x6F,	
					p=0x70,	
					q=0x71,	
					r=0x72,	
					s=0x73,	
					t=0x74,	
					u=0x75,	
					v=0x76,	
					w=0x77,	
					x=0x78,	
					y=0x79,	
					z=0x7A,	
					A=0x41,	
					B=0x42,	
					C=0x43,	
					D=0x44,	
					E=0x45,	
					F=0x46,	
					G=0x47,	
					H=0x48,	
					I=0x49,	
					J=0x4A,	
					K=0x4B,	
					L=0x4C,	
					M=0x4D,	
					N=0x4E,	
					O=0x4F,	
					P=0x50,	
					Q=0x51,	
					R=0x52,	
					S=0x53,	
					T=0x54,	
					U=0x55,	
					V=0x56,	
					W=0x57,	
					X=0x58,	
					Y=0x59,	
					Z=0x5a,	
					ampersand=0x26,	
					asterisk=0x2A,	
					at=0x40,	
					backslash=0x5C,	
					backtick=0x60,	
					bar=0x7C,	
					caret=0x5E,	
					closeBrace=0x7D,	
					closeBracket=0x5D,	
					closeParen=0x29,	
					colon=0x3A,	
					comma=0x2C,	
					dot=0x2E,	
					doubleQuote=0x22,	
					equals=0x3D,	
					exclamation=0x21,	
					greaterThan=0x3E,	
					hash=0x23,	
					lessThan=0x3C,	
					minus=0x2D,	
					openBrace=0x7B,	
					openBracket=0x5B,	
					openParen=0x28,	
					percent=0x25,	
					plus=0x2B,	
					question=0x3F,	
					semicolon=0x3B,	
					singleQuote=0x27,	
					slash=0x2F,	
					tilde=0x7E,	
					backspace=0x08,	
					formFeed=0x0C,	
					byteOrderMark=0xFEFF,	
					tab=0x09,	
					verticalTab=0x0B,	
				}
	
			[Flags]
			public enum SymbolDisplayPartKind {
					aliasName,	
					className,	
					enumName,	
					fieldName,	
					interfaceName,	
					keyword,	
					lineBreak,	
					numericLiteral,	
					stringLiteral,	
					localName,	
					methodName,	
					moduleName,	
					tsOperator,	
					parameterName,	
					propertyName,	
					punctuation,	
					space,	
					text,	
					typeParameterName,	
					enumMemberName,	
					functionName,	
					regularExpressionLiteral,	
				}
	
			[Flags]
			public enum OutputFileType {
					JavaScript,	
					SourceMap,	
					Declaration,	
				}
	
			[Flags]
			public enum EndOfLineState {
					Start,	
					InMultiLineCommentTrivia,	
					InSingleQuoteStringLiteral,	
					InDoubleQuoteStringLiteral,	
					InTemplateHeadOrNoSubstitutionTemplate,	
					InTemplateMiddleOrTail,	
					InTemplateSubstitutionPosition,	
				}
	
			[Flags]
			public enum TokenClass {
					Punctuation,	
					Keyword,	
					Operator,	
					Comment,	
					Whitespace,	
					Identifier,	
					NumberLiteral,	
					StringLiteral,	
					RegExpLiteral,	
				}
	
			[Flags]
			public enum SemanticMeaning {
					None=0x0,	
					Value=0x1,	
					tsType=0x2,	
					Namespace=0x4,	
					All=Value|tsType|Namespace,	
				}
	
			[Flags]
			public enum BreakContinueSearchType {
					None=0x0,	
					Unlabeled=0x1,	
					Labeled=0x2,	
					All=Unlabeled|Labeled,	
				}
	

	  
	    interface TextRange {  
		    		          int pos  { get; set; }
		    		          int end  { get; set; }
		    	    } 
	  
	    interface Node {  
		    		          SyntaxKind kind  { get; set; }
		    		          NodeFlags flags  { get; set; }
		    		          ParserContextFlags parserContextFlags  { get; set; }
		    		          ModifiersArray modifiers  { get; set; }
		    		          int id  { get; set; }
		    		          Node parent  { get; set; }
		    		          Symbol symbol  { get; set; }
		    		          SymbolTable locals  { get; set; }
		    		          Node nextContainer  { get; set; }
		    		          Symbol localSymbol  { get; set; }
		    	    } 
	  
	    interface NodeArray<T> {  
		    		          bool hasTrailingComma  { get; set; }
		    	    } 
	  
	    interface ModifiersArray {  
		    		          int flags  { get; set; }
		    	    } 
	  
	    interface Identifier {  
		    		          string text  { get; set; }
		    	    } 
	  
	    interface QualifiedName {  
		    		          object left  { get; set; }
		    		          Identifier right  { get; set; }
		    	    } 
	  
	    interface Declaration {  
		    		          object _declarationBrand  { get; set; }
		    		          object name  { get; set; }
		    	    } 
	  
	    interface ComputedPropertyName {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface TypeParameterDeclaration {  
		    		          Identifier name  { get; set; }
		    		          TypeNode constraint  { get; set; }
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface SignatureDeclaration {  
		    		          NodeArray<TypeParameterDeclaration> typeParameters  { get; set; }
		    		          NodeArray<ParameterDeclaration> parameters  { get; set; }
		    		          TypeNode type  { get; set; }
		    	    } 
	  
	    interface VariableDeclaration {  
		    		          VariableDeclarationList parent  { get; set; }
		    		          object name  { get; set; }
		    		          TypeNode type  { get; set; }
		    		          Expression initializer  { get; set; }
		    	    } 
	  
	    interface VariableDeclarationList {  
		    		          NodeArray<VariableDeclaration> declarations  { get; set; }
		    	    } 
	  
	    interface ParameterDeclaration {  
		    		          Node dotDotDotToken  { get; set; }
		    		          object name  { get; set; }
		    		          Node questionToken  { get; set; }
		    		          TypeNode type  { get; set; }
		    		          Expression initializer  { get; set; }
		    	    } 
	  
	    interface BindingElement {  
		    		          Identifier propertyName  { get; set; }
		    		          Node dotDotDotToken  { get; set; }
		    		          object name  { get; set; }
		    		          Expression initializer  { get; set; }
		    	    } 
	  
	    interface PropertyDeclaration {  
		    		          object name  { get; set; }
		    		          Node questionToken  { get; set; }
		    		          TypeNode type  { get; set; }
		    		          Expression initializer  { get; set; }
		    	    } 
	  
	    interface ObjectLiteralElement {  
		    		          object _objectLiteralBrandBrand  { get; set; }
		    	    } 
	  
	    interface PropertyAssignment {  
		    		          object _propertyAssignmentBrand  { get; set; }
		    		          object name  { get; set; }
		    		          Node questionToken  { get; set; }
		    		          Expression initializer  { get; set; }
		    	    } 
	  
	    interface ShorthandPropertyAssignment {  
		    		          Identifier name  { get; set; }
		    		          Node questionToken  { get; set; }
		    	    } 
	  
	    interface VariableLikeDeclaration {  
		    		          Identifier propertyName  { get; set; }
		    		          Node dotDotDotToken  { get; set; }
		    		          object name  { get; set; }
		    		          Node questionToken  { get; set; }
		    		          TypeNode type  { get; set; }
		    		          Expression initializer  { get; set; }
		    	    } 
	  
	    interface BindingPattern {  
		    		          NodeArray<BindingElement> elements  { get; set; }
		    	    } 
	  
	    interface FunctionLikeDeclaration {  
		    		          object _functionLikeDeclarationBrand  { get; set; }
		    		          Node asteriskToken  { get; set; }
		    		          Node questionToken  { get; set; }
		    		          object body  { get; set; }
		    	    } 
	  
	    interface FunctionDeclaration {  
		    		          Identifier name  { get; set; }
		    		          Block body  { get; set; }
		    	    } 
	  
	    interface MethodDeclaration {  
		    		          Block body  { get; set; }
		    	    } 
	  
	    interface ConstructorDeclaration {  
		    		          Block body  { get; set; }
		    	    } 
	  
	    interface AccessorDeclaration {  
		    		          object _accessorDeclarationBrand  { get; set; }
		    		          Block body  { get; set; }
		    	    } 
	  
	    interface IndexSignatureDeclaration {  
		    		          object _indexSignatureDeclarationBrand  { get; set; }
		    	    } 
	  
	    interface TypeNode {  
		    		          object _typeNodeBrand  { get; set; }
		    	    } 
	  
	    interface FunctionOrConstructorTypeNode {  
		    		          object _functionOrConstructorTypeNodeBrand  { get; set; }
		    	    } 
	  
	    interface TypeReferenceNode {  
		    		          object typeName  { get; set; }
		    		          NodeArray<TypeNode> typeArguments  { get; set; }
		    	    } 
	  
	    interface TypeQueryNode {  
		    		          object exprName  { get; set; }
		    	    } 
	  
	    interface TypeLiteralNode {  
		    		          NodeArray<Node> members  { get; set; }
		    	    } 
	  
	    interface ArrayTypeNode {  
		    		          TypeNode elementType  { get; set; }
		    	    } 
	  
	    interface TupleTypeNode {  
		    		          NodeArray<TypeNode> elementTypes  { get; set; }
		    	    } 
	  
	    interface UnionTypeNode {  
		    		          NodeArray<TypeNode> types  { get; set; }
		    	    } 
	  
	    interface ParenthesizedTypeNode {  
		    		          TypeNode type  { get; set; }
		    	    } 
	  
	    interface Expression {  
		    		          object _expressionBrand  { get; set; }
		    		          Type contextualType  { get; set; }
		    	    } 
	  
	    interface UnaryExpression {  
		    		          object _unaryExpressionBrand  { get; set; }
		    	    } 
	  
	    interface PrefixUnaryExpression {  
		    		          SyntaxKind tsOperator  { get; set; }
		    		          UnaryExpression operand  { get; set; }
		    	    } 
	  
	    interface PostfixUnaryExpression {  
		    		          LeftHandSideExpression operand  { get; set; }
		    		          SyntaxKind tsOperator  { get; set; }
		    	    } 
	  
	    interface PostfixExpression {  
		    		          object _postfixExpressionBrand  { get; set; }
		    	    } 
	  
	    interface LeftHandSideExpression {  
		    		          object _leftHandSideExpressionBrand  { get; set; }
		    	    } 
	  
	    interface MemberExpression {  
		    		          object _memberExpressionBrand  { get; set; }
		    	    } 
	  
	    interface PrimaryExpression {  
		    		          object _primaryExpressionBrand  { get; set; }
		    	    } 
	  
	    interface DeleteExpression {  
		    		          UnaryExpression expression  { get; set; }
		    	    } 
	  
	    interface TypeOfExpression {  
		    		          UnaryExpression expression  { get; set; }
		    	    } 
	  
	    interface VoidExpression {  
		    		          UnaryExpression expression  { get; set; }
		    	    } 
	  
	    interface YieldExpression {  
		    		          Node asteriskToken  { get; set; }
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface BinaryExpression {  
		    		          Expression left  { get; set; }
		    		          Node operatorToken  { get; set; }
		    		          Expression right  { get; set; }
		    	    } 
	  
	    interface ConditionalExpression {  
		    		          Expression condition  { get; set; }
		    		          Expression whenTrue  { get; set; }
		    		          Expression whenFalse  { get; set; }
		    	    } 
	  
	    interface FunctionExpression {  
		    		          Identifier name  { get; set; }
		    		          object body  { get; set; }
		    	    } 
	  
	    interface LiteralExpression {  
		    		          string text  { get; set; }
		    		          bool isUnterminated  { get; set; }
		    	    } 
	  
	    interface StringLiteralExpression {  
		    		          object _stringLiteralExpressionBrand  { get; set; }
		    	    } 
	  
	    interface TemplateExpression {  
		    		          LiteralExpression head  { get; set; }
		    		          NodeArray<TemplateSpan> templateSpans  { get; set; }
		    	    } 
	  
	    interface TemplateSpan {  
		    		          Expression expression  { get; set; }
		    		          LiteralExpression literal  { get; set; }
		    	    } 
	  
	    interface ParenthesizedExpression {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface ArrayLiteralExpression {  
		    		          NodeArray<Expression> elements  { get; set; }
		    	    } 
	  
	    interface SpreadElementExpression {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface ObjectLiteralExpression {  
		    		          NodeArray<ObjectLiteralElement> properties  { get; set; }
		    	    } 
	  
	    interface PropertyAccessExpression {  
		    		          LeftHandSideExpression expression  { get; set; }
		    		          Identifier name  { get; set; }
		    	    } 
	  
	    interface ElementAccessExpression {  
		    		          LeftHandSideExpression expression  { get; set; }
		    		          Expression argumentExpression  { get; set; }
		    	    } 
	  
	    interface CallExpression {  
		    		          LeftHandSideExpression expression  { get; set; }
		    		          NodeArray<TypeNode> typeArguments  { get; set; }
		    		          NodeArray<Expression> arguments  { get; set; }
		    	    } 
	  
	    interface TaggedTemplateExpression {  
		    		          LeftHandSideExpression tag  { get; set; }
		    		          object template  { get; set; }
		    	    } 
	  
	    interface TypeAssertion {  
		    		          TypeNode type  { get; set; }
		    		          UnaryExpression expression  { get; set; }
		    	    } 
	  
	    interface Statement {  
		    		          object _statementBrand  { get; set; }
		    	    } 
	  
	    interface Block {  
		    		          NodeArray<Statement> statements  { get; set; }
		    	    } 
	  
	    interface VariableStatement {  
		    		          VariableDeclarationList declarationList  { get; set; }
		    	    } 
	  
	    interface ExpressionStatement {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface IfStatement {  
		    		          Expression expression  { get; set; }
		    		          Statement thenStatement  { get; set; }
		    		          Statement elseStatement  { get; set; }
		    	    } 
	  
	    interface IterationStatement {  
		    		          Statement statement  { get; set; }
		    	    } 
	  
	    interface DoStatement {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface WhileStatement {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface ForStatement {  
		    		          object initializer  { get; set; }
		    		          Expression condition  { get; set; }
		    		          Expression iterator  { get; set; }
		    	    } 
	  
	    interface ForInStatement {  
		    		          object initializer  { get; set; }
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface ForOfStatement {  
		    		          object initializer  { get; set; }
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface BreakOrContinueStatement {  
		    		          Identifier label  { get; set; }
		    	    } 
	  
	    interface ReturnStatement {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface WithStatement {  
		    		          Expression expression  { get; set; }
		    		          Statement statement  { get; set; }
		    	    } 
	  
	    interface SwitchStatement {  
		    		          Expression expression  { get; set; }
		    		          NodeArray<object> clauses  { get; set; }
		    	    } 
	  
	    interface CaseClause {  
		    		          Expression expression  { get; set; }
		    		          NodeArray<Statement> statements  { get; set; }
		    	    } 
	  
	    interface DefaultClause {  
		    		          NodeArray<Statement> statements  { get; set; }
		    	    } 
	  
	    interface LabeledStatement {  
		    		          Identifier label  { get; set; }
		    		          Statement statement  { get; set; }
		    	    } 
	  
	    interface ThrowStatement {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface TryStatement {  
		    		          Block tryBlock  { get; set; }
		    		          CatchClause catchClause  { get; set; }
		    		          Block finallyBlock  { get; set; }
		    	    } 
	  
	    interface CatchClause {  
		    		          VariableDeclaration variableDeclaration  { get; set; }
		    		          Block block  { get; set; }
		    	    } 
	  
	    interface ModuleElement {  
		    		          object _moduleElementBrand  { get; set; }
		    	    } 
	  
	    interface ClassDeclaration {  
		    		          Identifier name  { get; set; }
		    		          NodeArray<TypeParameterDeclaration> typeParameters  { get; set; }
		    		          NodeArray<HeritageClause> heritageClauses  { get; set; }
		    		          NodeArray<ClassElement> members  { get; set; }
		    	    } 
	  
	    interface ClassElement {  
		    		          object _classElementBrand  { get; set; }
		    	    } 
	  
	    interface InterfaceDeclaration {  
		    		          Identifier name  { get; set; }
		    		          NodeArray<TypeParameterDeclaration> typeParameters  { get; set; }
		    		          NodeArray<HeritageClause> heritageClauses  { get; set; }
		    		          NodeArray<Declaration> members  { get; set; }
		    	    } 
	  
	    interface HeritageClause {  
		    		          SyntaxKind token  { get; set; }
		    		          NodeArray<TypeReferenceNode> types  { get; set; }
		    	    } 
	  
	    interface TypeAliasDeclaration {  
		    		          Identifier name  { get; set; }
		    		          TypeNode type  { get; set; }
		    	    } 
	  
	    interface EnumMember {  
		    		          object name  { get; set; }
		    		          Expression initializer  { get; set; }
		    	    } 
	  
	    interface EnumDeclaration {  
		    		          Identifier name  { get; set; }
		    		          NodeArray<EnumMember> members  { get; set; }
		    	    } 
	  
	    interface ExportContainer {  
		    		          ExportDeclaration[] exportStars  { get; set; }
		    	    } 
	  
	    interface ModuleDeclaration {  
		    		          object name  { get; set; }
		    		          object body  { get; set; }
		    	    } 
	  
	    interface ModuleBlock {  
		    		          NodeArray<ModuleElement> statements  { get; set; }
		    	    } 
	  
	    interface ImportEqualsDeclaration {  
		    		          Identifier name  { get; set; }
		    		          object moduleReference  { get; set; }
		    	    } 
	  
	    interface ExternalModuleReference {  
		    		          Expression expression  { get; set; }
		    	    } 
	  
	    interface ImportDeclaration {  
		    		          ImportClause importClause  { get; set; }
		    		          Expression moduleSpecifier  { get; set; }
		    	    } 
	  
	    interface ImportClause {  
		    		          Identifier name  { get; set; }
		    		          object namedBindings  { get; set; }
		    	    } 
	  
	    interface NamespaceImport {  
		    		          Identifier name  { get; set; }
		    	    } 
	  
	    interface ExportDeclaration {  
		    		          object exportClause  { get; set; }
		    		          Expression moduleSpecifier  { get; set; }
		    	    } 
	  
	    interface NamedImportsOrExports {  
		    		          NodeArray<ImportOrExportSpecifier> elements  { get; set; }
		    	    } 
	  
	    interface ImportOrExportSpecifier {  
		    		          Identifier propertyName  { get; set; }
		    		          Identifier name  { get; set; }
		    	    } 
	  
	    interface ExportAssignment {  
		    		          Identifier exportName  { get; set; }
		    	    } 
	  
	    interface FileReference {  
		    		          string fileName  { get; set; }
		    	    } 
	  
	    interface CommentRange {  
		    		          bool hasTrailingNewLine  { get; set; }
		    	    } 
	  
	    interface SourceMapSpan {  
		    		          int emittedLine  { get; set; }
		    		          int emittedColumn  { get; set; }
		    		          int sourceLine  { get; set; }
		    		          int sourceColumn  { get; set; }
		    		          int nameIndex  { get; set; }
		    		          int sourceIndex  { get; set; }
		    	    } 
	  
	    interface SourceMapData {  
		    		          string sourceMapFilePath  { get; set; }
		    		          string jsSourceMappingURL  { get; set; }
		    		          string sourceMapFile  { get; set; }
		    		          string sourceMapSourceRoot  { get; set; }
		    		          string[] sourceMapSources  { get; set; }
		    		          string[] inputSourceFileNames  { get; set; }
		    		          string[] sourceMapNames  { get; set; }
		    		          string sourceMapMappings  { get; set; }
		    		          SourceMapSpan[] sourceMapDecodedMappings  { get; set; }
		    	    } 
	  
	    interface EmitResult {  
		    		          bool emitSkipped  { get; set; }
		    		          Diagnostic[] diagnostics  { get; set; }
		    		          SourceMapData[] sourceMaps  { get; set; }
		    	    } 
	  
	    interface SymbolVisibilityResult {  
		    		          SymbolAccessibility accessibility  { get; set; }
		    		          ImportEqualsDeclaration[] aliasesToMakeVisible  { get; set; }
		    		          string errorSymbolName  { get; set; }
		    		          Node errorNode  { get; set; }
		    	    } 
	  
	    interface SymbolAccessiblityResult {  
		    		          string errorModuleName  { get; set; }
		    	    } 
	  
	    interface Symbol {  
		    		          SymbolFlags flags  { get; set; }
		    		          string name  { get; set; }
		    		          int id  { get; set; }
		    		          int mergeId  { get; set; }
		    		          Declaration[] declarations  { get; set; }
		    		          Symbol parent  { get; set; }
		    		          SymbolTable members  { get; set; }
		    		          SymbolTable exports  { get; set; }
		    		          Symbol exportSymbol  { get; set; }
		    		          Declaration valueDeclaration  { get; set; }
		    		          bool constEnumOnlyModule  { get; set; }
		    	    } 
	  
	    interface SymbolLinks {  
		    		          Symbol target  { get; set; }
		    		          Type type  { get; set; }
		    		          Type declaredType  { get; set; }
		    		          TypeMapper mapper  { get; set; }
		    		          bool referenced  { get; set; }
		    		          bool exportAssignmentChecked  { get; set; }
		    		          Symbol exportAssignmentSymbol  { get; set; }
		    		          UnionType unionType  { get; set; }
		    		          SymbolTable resolvedExports  { get; set; }
		    	    } 
	  
	    interface NodeLinks {  
		    		          Type resolvedType  { get; set; }
		    		          Signature resolvedSignature  { get; set; }
		    		          Symbol resolvedSymbol  { get; set; }
		    		          NodeCheckFlags flags  { get; set; }
		    		          int enumMemberValue  { get; set; }
		    		          bool isIllegalTypeReferenceInConstraint  { get; set; }
		    		          bool isVisible  { get; set; }
		    		          string generatedName  { get; set; }
		    		          object generatedNames  { get; set; }
		    		          object assignmentChecks  { get; set; }
		    		          bool hasReportedStatementInAmbientContext  { get; set; }
		    		          Symbol importOnRightSide  { get; set; }
		    	    } 
	  
	    interface Type {  
		    		          TypeFlags flags  { get; set; }
		    		          int id  { get; set; }
		    		          Symbol symbol  { get; set; }
		    	    } 
	  
	    interface IntrinsicType {  
		    		          string intrinsicName  { get; set; }
		    	    } 
	  
	    interface StringLiteralType {  
		    		          string text  { get; set; }
		    	    } 
	  
	    interface InterfaceType {  
		    		          TypeParameter[] typeParameters  { get; set; }
		    		          object[] baseTypes  { get; set; }
		    		          Symbol[] declaredProperties  { get; set; }
		    		          Signature[] declaredCallSignatures  { get; set; }
		    		          Signature[] declaredConstructSignatures  { get; set; }
		    		          Type declaredStringIndexType  { get; set; }
		    		          Type declaredNumberIndexType  { get; set; }
		    	    } 
	  
	    interface TypeReference {  
		    		          GenericType target  { get; set; }
		    		          Type[] typeArguments  { get; set; }
		    	    } 
	  
	    interface GenericType {  
		    		          object instantiations  { get; set; }
		    	    } 
	  
	    interface TupleType {  
		    		          Type[] elementTypes  { get; set; }
		    		          TypeReference baseArrayType  { get; set; }
		    	    } 
	  
	    interface UnionType {  
		    		          Type[] types  { get; set; }
		    		          SymbolTable resolvedProperties  { get; set; }
		    	    } 
	  
	    interface ResolvedType {  
		    		          SymbolTable members  { get; set; }
		    		          Symbol[] properties  { get; set; }
		    		          Signature[] callSignatures  { get; set; }
		    		          Signature[] constructSignatures  { get; set; }
		    		          Type stringIndexType  { get; set; }
		    		          Type numberIndexType  { get; set; }
		    	    } 
	  
	    interface TypeParameter {  
		    		          Type constraint  { get; set; }
		    		          TypeParameter target  { get; set; }
		    		          TypeMapper mapper  { get; set; }
		    	    } 
	  
	    interface Signature {  
		    		          SignatureDeclaration declaration  { get; set; }
		    		          TypeParameter[] typeParameters  { get; set; }
		    		          Symbol[] parameters  { get; set; }
		    		          Type resolvedReturnType  { get; set; }
		    		          int minArgumentCount  { get; set; }
		    		          bool hasRestParameter  { get; set; }
		    		          bool hasStringLiterals  { get; set; }
		    		          Signature target  { get; set; }
		    		          TypeMapper mapper  { get; set; }
		    		          Signature[] unionSignatures  { get; set; }
		    		          Signature erasedSignatureCache  { get; set; }
		    		          object isolatedSignatureType  { get; set; }
		    	    } 
	  
	    interface TypeInferences {  
		    		          Type[] primary  { get; set; }
		    		          Type[] secondary  { get; set; }
		    	    } 
	  
	    interface InferenceContext {  
		    		          TypeParameter[] typeParameters  { get; set; }
		    		          bool inferUnionTypes  { get; set; }
		    		          TypeInferences[] inferences  { get; set; }
		    		          Type[] inferredTypes  { get; set; }
		    		          int failedTypeParameterIndex  { get; set; }
		    	    } 
	  
	    interface DiagnosticMessage {  
		    		          string key  { get; set; }
		    		          DiagnosticCategory category  { get; set; }
		    		          int code  { get; set; }
		    	    } 
	  
	    interface DiagnosticMessageChain {  
		    		          string messageText  { get; set; }
		    		          DiagnosticCategory category  { get; set; }
		    		          int code  { get; set; }
		    		          DiagnosticMessageChain next  { get; set; }
		    	    } 
	  
	    interface Diagnostic {  
		    		          SourceFile file  { get; set; }
		    		          int start  { get; set; }
		    		          int length  { get; set; }
		    		          object messageText  { get; set; }
		    		          DiagnosticCategory category  { get; set; }
		    		          int code  { get; set; }
		    	    } 
	  
	    interface CompilerOptions {  
		    		          bool allowNonTsExtensions  { get; set; }
		    		          string charset  { get; set; }
		    		          int codepage  { get; set; }
		    		          bool declaration  { get; set; }
		    		          bool diagnostics  { get; set; }
		    		          bool emitBOM  { get; set; }
		    		          bool help  { get; set; }
		    		          bool listFiles  { get; set; }
		    		          string locale  { get; set; }
		    		          string mapRoot  { get; set; }
		    		          ModuleKind module  { get; set; }
		    		          bool noEmit  { get; set; }
		    		          bool noEmitOnError  { get; set; }
		    		          bool noErrorTruncation  { get; set; }
		    		          bool noImplicitAny  { get; set; }
		    		          bool noLib  { get; set; }
		    		          bool noLibCheck  { get; set; }
		    		          bool noResolve  { get; set; }
		    		          string tsOut  { get; set; }
		    		          string outDir  { get; set; }
		    		          bool preserveConstEnums  { get; set; }
		    		          string project  { get; set; }
		    		          bool removeComments  { get; set; }
		    		          bool sourceMap  { get; set; }
		    		          string sourceRoot  { get; set; }
		    		          bool suppressImplicitAnyIndexErrors  { get; set; }
		    		          ScriptTarget target  { get; set; }
		    		          bool version  { get; set; }
		    		          bool watch  { get; set; }
		    		          bool stripInternal  { get; set; }
		    	    } 
	  
	    interface LineAndCharacter {  
		    		          int line  { get; set; }
		    		          int character  { get; set; }
		    	    } 
	  
	    interface ParsedCommandLine {  
		    		          CompilerOptions options  { get; set; }
		    		          string[] fileNames  { get; set; }
		    		          Diagnostic[] errors  { get; set; }
		    	    } 
	  
	    interface CommandLineOption {  
		    		          string name  { get; set; }
		    		          object type  { get; set; }
		    		          bool isFilePath  { get; set; }
		    		          string shortName  { get; set; }
		    		          DiagnosticMessage description  { get; set; }
		    		          DiagnosticMessage paramType  { get; set; }
		    		          DiagnosticMessage error  { get; set; }
		    		          bool experimental  { get; set; }
		    	    } 
	  
	    interface CompilerHost {  
		    		          object writeFile  { get; set; }
		    	    } 
	  
	    interface TextSpan {  
		    		          int start  { get; set; }
		    		          int length  { get; set; }
		    	    } 
	  
	    interface TextChangeRange {  
		    		          TextSpan span  { get; set; }
		    		          int newLength  { get; set; }
		    	    } 
	  
	    interface SourceFile {  
		    		          string version  { get; set; }
		    		          IScriptSnapshot scriptSnapshot  { get; set; }
		    		          object nameTable  { get; set; }
		    	    } 
	  
	    interface PreProcessedFileInfo {  
		    		          FileReference[] referencedFiles  { get; set; }
		    		          FileReference[] importedFiles  { get; set; }
		    		          bool isLibFile  { get; set; }
		    	    } 
	  
	    interface ClassifiedSpan {  
		    		          TextSpan textSpan  { get; set; }
		    		          string classificationType  { get; set; }
		    	    } 
	  
	    interface NavigationBarItem {  
		    		          string text  { get; set; }
		    		          string kind  { get; set; }
		    		          string kindModifiers  { get; set; }
		    		          TextSpan[] spans  { get; set; }
		    		          NavigationBarItem[] childItems  { get; set; }
		    		          int indent  { get; set; }
		    		          bool bolded  { get; set; }
		    		          bool grayed  { get; set; }
		    	    } 
	  
	    interface TodoCommentDescriptor {  
		    		          string text  { get; set; }
		    		          int priority  { get; set; }
		    	    } 
	  
	    interface TodoComment {  
		    		          TodoCommentDescriptor descriptor  { get; set; }
		    		          string message  { get; set; }
		    		          int position  { get; set; }
		    	    } 
	  
	    interface RenameLocation {  
		    		          TextSpan textSpan  { get; set; }
		    		          string fileName  { get; set; }
		    	    } 
	  
	    interface ReferenceEntry {  
		    		          TextSpan textSpan  { get; set; }
		    		          string fileName  { get; set; }
		    		          bool isWriteAccess  { get; set; }
		    	    } 
	  
	    interface NavigateToItem {  
		    		          string name  { get; set; }
		    		          string kind  { get; set; }
		    		          string kindModifiers  { get; set; }
		    		          string matchKind  { get; set; }
		    		          bool isCaseSensitive  { get; set; }
		    		          string fileName  { get; set; }
		    		          TextSpan textSpan  { get; set; }
		    		          string containerName  { get; set; }
		    		          string containerKind  { get; set; }
		    	    } 
	  
	    interface EditorOptions {  
		    		          int IndentSize  { get; set; }
		    		          int TabSize  { get; set; }
		    		          string NewLineCharacter  { get; set; }
		    		          bool ConvertTabsToSpaces  { get; set; }
		    	    } 
	  
	    interface FormatCodeOptions {  
		    		          bool InsertSpaceAfterCommaDelimiter  { get; set; }
		    		          bool InsertSpaceAfterSemicolonInForStatements  { get; set; }
		    		          bool InsertSpaceBeforeAndAfterBinaryOperators  { get; set; }
		    		          bool InsertSpaceAfterKeywordsInControlFlowStatements  { get; set; }
		    		          bool InsertSpaceAfterFunctionKeywordForAnonymousFunctions  { get; set; }
		    		          bool InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis  { get; set; }
		    		          bool PlaceOpenBraceOnNewLineForFunctions  { get; set; }
		    		          bool PlaceOpenBraceOnNewLineForControlBlocks  { get; set; }
		    	    } 
	  
	    interface DefinitionInfo {  
		    		          string fileName  { get; set; }
		    		          TextSpan textSpan  { get; set; }
		    		          string kind  { get; set; }
		    		          string name  { get; set; }
		    		          string containerKind  { get; set; }
		    		          string containerName  { get; set; }
		    	    } 
	  
	    interface SymbolDisplayPart {  
		    		          string text  { get; set; }
		    		          string kind  { get; set; }
		    	    } 
	  
	    interface QuickInfo {  
		    		          string kind  { get; set; }
		    		          string kindModifiers  { get; set; }
		    		          TextSpan textSpan  { get; set; }
		    		          SymbolDisplayPart[] displayParts  { get; set; }
		    		          SymbolDisplayPart[] documentation  { get; set; }
		    	    } 
	  
	    interface RenameInfo {  
		    		          bool canRename  { get; set; }
		    		          string localizedErrorMessage  { get; set; }
		    		          string displayName  { get; set; }
		    		          string fullDisplayName  { get; set; }
		    		          string kind  { get; set; }
		    		          string kindModifiers  { get; set; }
		    		          TextSpan triggerSpan  { get; set; }
		    	    } 
	  
	    interface SignatureHelpParameter {  
		    		          string name  { get; set; }
		    		          SymbolDisplayPart[] documentation  { get; set; }
		    		          SymbolDisplayPart[] displayParts  { get; set; }
		    		          bool isOptional  { get; set; }
		    	    } 
	  
	    interface SignatureHelpItem {  
		    		          bool isVariadic  { get; set; }
		    		          SymbolDisplayPart[] prefixDisplayParts  { get; set; }
		    		          SymbolDisplayPart[] suffixDisplayParts  { get; set; }
		    		          SymbolDisplayPart[] separatorDisplayParts  { get; set; }
		    		          SignatureHelpParameter[] parameters  { get; set; }
		    		          SymbolDisplayPart[] documentation  { get; set; }
		    	    } 
	  
	    interface SignatureHelpItems {  
		    		          SignatureHelpItem[] items  { get; set; }
		    		          TextSpan applicableSpan  { get; set; }
		    		          int selectedItemIndex  { get; set; }
		    		          int argumentIndex  { get; set; }
		    		          int argumentCount  { get; set; }
		    	    } 
	  
	    interface CompletionInfo {  
		    		          bool isMemberCompletion  { get; set; }
		    		          bool isNewIdentifierLocation  { get; set; }
		    		          CompletionEntry[] entries  { get; set; }
		    	    } 
	  
	    interface CompletionEntry {  
		    		          string name  { get; set; }
		    		          string kind  { get; set; }
		    		          string kindModifiers  { get; set; }
		    	    } 
	  
	    interface CompletionEntryDetails {  
		    		          string name  { get; set; }
		    		          string kind  { get; set; }
		    		          string kindModifiers  { get; set; }
		    		          SymbolDisplayPart[] displayParts  { get; set; }
		    		          SymbolDisplayPart[] documentation  { get; set; }
		    	    } 
	  
	    interface OutliningSpan {  
		    		          TextSpan textSpan  { get; set; }
		    		          TextSpan hintSpan  { get; set; }
		    		          string bannerText  { get; set; }
		    		          bool autoCollapse  { get; set; }
		    	    } 
	  
	    interface EmitOutput {  
		    		          OutputFile[] outputFiles  { get; set; }
		    		          bool emitSkipped  { get; set; }
		    	    } 
	  
	    interface OutputFile {  
		    		          string name  { get; set; }
		    		          bool writeByteOrderMark  { get; set; }
		    		          string text  { get; set; }
		    	    } 
	  
	    interface ClassificationResult {  
		    		          EndOfLineState finalLexState  { get; set; }
		    		          ClassificationInfo[] entries  { get; set; }
		    	    } 
	  
	    interface ClassificationInfo {  
		    		          int length  { get; set; }
		    		          TokenClass classification  { get; set; }
		    	    } 
	  
	    interface CompletionSession {  
		    		          string fileName  { get; set; }
		    		          int position  { get; set; }
		    		          CompletionEntry[] entries  { get; set; }
		    		          object symbols  { get; set; }
		    		          object typeChecker  { get; set; }
		    	    } 
	  
	    interface FormattingOptions {  
		    		          bool useTabs  { get; set; }
		    		          int spacesPerTab  { get; set; }
		    		          int indentSpaces  { get; set; }
		    		          string newLineCharacter  { get; set; }
		    	    } 
	  
	    interface HostFileInformation {  
		    		          string hostFileName  { get; set; }
		    		          string version  { get; set; }
		    		          IScriptSnapshot scriptSnapshot  { get; set; }
		    	    } 
	  
	    interface DocumentRegistryEntry {  
		    		          SourceFile sourceFile  { get; set; }
		    		          int refCount  { get; set; }
		    		          string[] owners  { get; set; }
		    	    } 
	 

    interface SymbolTable {
	string[] Symbol { get; set; }
    }

    interface IScriptSnapshot
    {
        string getText(int start, int end);
        int getLength();
        int[] getLineStartPositions();
        TextChangeRange getChangeRange(IScriptSnapshot oldSnapshot);
    }

    interface TypeMapper {
        object Type { get; set; }
    }
}

