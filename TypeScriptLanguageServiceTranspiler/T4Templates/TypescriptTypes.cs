
	//interfaces
using System;
using System.Collections.Generic;

namespace TypeScriptLanguageService { 
	
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
	

       
        public interface ITextRange 
        {

            int pos { get; set; }
            int end { get; set; }
            
        } 
      
        public interface INode 
        {

            SyntaxKind kind { get; set; }
            NodeFlags flags { get; set; }
            ParserContextFlags parserContextFlags { get; set; }
            ModifiersArray modifiers { get; set; }
            int id { get; set; }
            Node parent { get; set; }
            Symbol symbol { get; set; }
            SymbolTable locals { get; set; }
            Node nextContainer { get; set; }
            Symbol localSymbol { get; set; }
            
        } 
      
        public interface INodeArray<T> 
        {

            bool hasTrailingComma { get; set; }
            
        } 
      
        public interface IModifiersArray 
        {

            int flags { get; set; }
            
        } 
      
        public interface IIdentifier 
        {

            string text { get; set; }
            
        } 
      
        public interface IQualifiedName 
        {

            object left { get; set; }
            Identifier right { get; set; }
            
        } 
      
        public interface IDeclaration 
        {

            object _declarationBrand { get; set; }
            object name { get; set; }
            
        } 
      
        public interface IComputedPropertyName 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface ITypeParameterDeclaration 
        {

            Identifier name { get; set; }
            TypeNode constraint { get; set; }
            Expression expression { get; set; }
            
        } 
      
        public interface ISignatureDeclaration 
        {

            NodeArray<TypeParameterDeclaration> typeParameters { get; set; }
            NodeArray<ParameterDeclaration> parameters { get; set; }
            TypeNode type { get; set; }
            
        } 
      
        public interface IVariableDeclaration 
        {

            VariableDeclarationList parent { get; set; }
            object name { get; set; }
            TypeNode type { get; set; }
            Expression initializer { get; set; }
            
        } 
      
        public interface IVariableDeclarationList 
        {

            NodeArray<VariableDeclaration> declarations { get; set; }
            
        } 
      
        public interface IParameterDeclaration 
        {

            Node dotDotDotToken { get; set; }
            object name { get; set; }
            Node questionToken { get; set; }
            TypeNode type { get; set; }
            Expression initializer { get; set; }
            
        } 
      
        public interface IBindingElement 
        {

            Identifier propertyName { get; set; }
            Node dotDotDotToken { get; set; }
            object name { get; set; }
            Expression initializer { get; set; }
            
        } 
      
        public interface IPropertyDeclaration 
        {

            object name { get; set; }
            Node questionToken { get; set; }
            TypeNode type { get; set; }
            Expression initializer { get; set; }
            
        } 
      
        public interface IObjectLiteralElement 
        {

            object _objectLiteralBrandBrand { get; set; }
            
        } 
      
        public interface IPropertyAssignment 
        {

            object _propertyAssignmentBrand { get; set; }
            object name { get; set; }
            Node questionToken { get; set; }
            Expression initializer { get; set; }
            
        } 
      
        public interface IShorthandPropertyAssignment 
        {

            Identifier name { get; set; }
            Node questionToken { get; set; }
            
        } 
      
        public interface IVariableLikeDeclaration 
        {

            Identifier propertyName { get; set; }
            Node dotDotDotToken { get; set; }
            object name { get; set; }
            Node questionToken { get; set; }
            TypeNode type { get; set; }
            Expression initializer { get; set; }
            
        } 
      
        public interface IBindingPattern 
        {

            NodeArray<BindingElement> elements { get; set; }
            
        } 
      
        public interface IFunctionLikeDeclaration 
        {

            object _functionLikeDeclarationBrand { get; set; }
            Node asteriskToken { get; set; }
            Node questionToken { get; set; }
            object body { get; set; }
            
        } 
      
        public interface IFunctionDeclaration 
        {

            Identifier name { get; set; }
            Block body { get; set; }
            
        } 
      
        public interface IMethodDeclaration 
        {

            Block body { get; set; }
            
        } 
      
        public interface IConstructorDeclaration 
        {

            Block body { get; set; }
            
        } 
      
        public interface IAccessorDeclaration 
        {

            object _accessorDeclarationBrand { get; set; }
            Block body { get; set; }
            
        } 
      
        public interface IIndexSignatureDeclaration 
        {

            object _indexSignatureDeclarationBrand { get; set; }
            
        } 
      
        public interface ITypeNode 
        {

            object _typeNodeBrand { get; set; }
            
        } 
      
        public interface IFunctionOrConstructorTypeNode 
        {

            object _functionOrConstructorTypeNodeBrand { get; set; }
            
        } 
      
        public interface ITypeReferenceNode 
        {

            object typeName { get; set; }
            NodeArray<TypeNode> typeArguments { get; set; }
            
        } 
      
        public interface ITypeQueryNode 
        {

            object exprName { get; set; }
            
        } 
      
        public interface ITypeLiteralNode 
        {

            NodeArray<Node> members { get; set; }
            
        } 
      
        public interface IArrayTypeNode 
        {

            TypeNode elementType { get; set; }
            
        } 
      
        public interface ITupleTypeNode 
        {

            NodeArray<TypeNode> elementTypes { get; set; }
            
        } 
      
        public interface IUnionTypeNode 
        {

            NodeArray<TypeNode> types { get; set; }
            
        } 
      
        public interface IParenthesizedTypeNode 
        {

            TypeNode type { get; set; }
            
        } 
      
        public interface IExpression 
        {

            object _expressionBrand { get; set; }
            Type contextualType { get; set; }
            
        } 
      
        public interface IUnaryExpression 
        {

            object _unaryExpressionBrand { get; set; }
            
        } 
      
        public interface IPrefixUnaryExpression 
        {

            SyntaxKind tsOperator { get; set; }
            UnaryExpression operand { get; set; }
            
        } 
      
        public interface IPostfixUnaryExpression 
        {

            LeftHandSideExpression operand { get; set; }
            SyntaxKind tsOperator { get; set; }
            
        } 
      
        public interface IPostfixExpression 
        {

            object _postfixExpressionBrand { get; set; }
            
        } 
      
        public interface ILeftHandSideExpression 
        {

            object _leftHandSideExpressionBrand { get; set; }
            
        } 
      
        public interface IMemberExpression 
        {

            object _memberExpressionBrand { get; set; }
            
        } 
      
        public interface IPrimaryExpression 
        {

            object _primaryExpressionBrand { get; set; }
            
        } 
      
        public interface IDeleteExpression 
        {

            UnaryExpression expression { get; set; }
            
        } 
      
        public interface ITypeOfExpression 
        {

            UnaryExpression expression { get; set; }
            
        } 
      
        public interface IVoidExpression 
        {

            UnaryExpression expression { get; set; }
            
        } 
      
        public interface IYieldExpression 
        {

            Node asteriskToken { get; set; }
            Expression expression { get; set; }
            
        } 
      
        public interface IBinaryExpression 
        {

            Expression left { get; set; }
            Node operatorToken { get; set; }
            Expression right { get; set; }
            
        } 
      
        public interface IConditionalExpression 
        {

            Expression condition { get; set; }
            Expression whenTrue { get; set; }
            Expression whenFalse { get; set; }
            
        } 
      
        public interface IFunctionExpression 
        {

            Identifier name { get; set; }
            object body { get; set; }
            
        } 
      
        public interface ILiteralExpression 
        {

            string text { get; set; }
            bool isUnterminated { get; set; }
            
        } 
      
        public interface IStringLiteralExpression 
        {

            object _stringLiteralExpressionBrand { get; set; }
            
        } 
      
        public interface ITemplateExpression 
        {

            LiteralExpression head { get; set; }
            NodeArray<TemplateSpan> templateSpans { get; set; }
            
        } 
      
        public interface ITemplateSpan 
        {

            Expression expression { get; set; }
            LiteralExpression literal { get; set; }
            
        } 
      
        public interface IParenthesizedExpression 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface IArrayLiteralExpression 
        {

            NodeArray<Expression> elements { get; set; }
            
        } 
      
        public interface ISpreadElementExpression 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface IObjectLiteralExpression 
        {

            NodeArray<ObjectLiteralElement> properties { get; set; }
            
        } 
      
        public interface IPropertyAccessExpression 
        {

            LeftHandSideExpression expression { get; set; }
            Identifier name { get; set; }
            
        } 
      
        public interface IElementAccessExpression 
        {

            LeftHandSideExpression expression { get; set; }
            Expression argumentExpression { get; set; }
            
        } 
      
        public interface ICallExpression 
        {

            LeftHandSideExpression expression { get; set; }
            NodeArray<TypeNode> typeArguments { get; set; }
            NodeArray<Expression> arguments { get; set; }
            
        } 
      
        public interface ITaggedTemplateExpression 
        {

            LeftHandSideExpression tag { get; set; }
            object template { get; set; }
            
        } 
      
        public interface ITypeAssertion 
        {

            TypeNode type { get; set; }
            UnaryExpression expression { get; set; }
            
        } 
      
        public interface IStatement 
        {

            object _statementBrand { get; set; }
            
        } 
      
        public interface IBlock 
        {

            NodeArray<Statement> statements { get; set; }
            
        } 
      
        public interface IVariableStatement 
        {

            VariableDeclarationList declarationList { get; set; }
            
        } 
      
        public interface IExpressionStatement 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface IIfStatement 
        {

            Expression expression { get; set; }
            Statement thenStatement { get; set; }
            Statement elseStatement { get; set; }
            
        } 
      
        public interface IIterationStatement 
        {

            Statement statement { get; set; }
            
        } 
      
        public interface IDoStatement 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface IWhileStatement 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface IForStatement 
        {

            object initializer { get; set; }
            Expression condition { get; set; }
            Expression iterator { get; set; }
            
        } 
      
        public interface IForInStatement 
        {

            object initializer { get; set; }
            Expression expression { get; set; }
            
        } 
      
        public interface IForOfStatement 
        {

            object initializer { get; set; }
            Expression expression { get; set; }
            
        } 
      
        public interface IBreakOrContinueStatement 
        {

            Identifier label { get; set; }
            
        } 
      
        public interface IReturnStatement 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface IWithStatement 
        {

            Expression expression { get; set; }
            Statement statement { get; set; }
            
        } 
      
        public interface ISwitchStatement 
        {

            Expression expression { get; set; }
            NodeArray<object> clauses { get; set; }
            
        } 
      
        public interface ICaseClause 
        {

            Expression expression { get; set; }
            NodeArray<Statement> statements { get; set; }
            
        } 
      
        public interface IDefaultClause 
        {

            NodeArray<Statement> statements { get; set; }
            
        } 
      
        public interface ILabeledStatement 
        {

            Identifier label { get; set; }
            Statement statement { get; set; }
            
        } 
      
        public interface IThrowStatement 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface ITryStatement 
        {

            Block tryBlock { get; set; }
            CatchClause catchClause { get; set; }
            Block finallyBlock { get; set; }
            
        } 
      
        public interface ICatchClause 
        {

            VariableDeclaration variableDeclaration { get; set; }
            Block block { get; set; }
            
        } 
      
        public interface IModuleElement 
        {

            object _moduleElementBrand { get; set; }
            
        } 
      
        public interface IClassDeclaration 
        {

            Identifier name { get; set; }
            NodeArray<TypeParameterDeclaration> typeParameters { get; set; }
            NodeArray<HeritageClause> heritageClauses { get; set; }
            NodeArray<ClassElement> members { get; set; }
            
        } 
      
        public interface IClassElement 
        {

            object _classElementBrand { get; set; }
            
        } 
      
        public interface IInterfaceDeclaration 
        {

            Identifier name { get; set; }
            NodeArray<TypeParameterDeclaration> typeParameters { get; set; }
            NodeArray<HeritageClause> heritageClauses { get; set; }
            NodeArray<Declaration> members { get; set; }
            
        } 
      
        public interface IHeritageClause 
        {

            SyntaxKind token { get; set; }
            NodeArray<TypeReferenceNode> types { get; set; }
            
        } 
      
        public interface ITypeAliasDeclaration 
        {

            Identifier name { get; set; }
            TypeNode type { get; set; }
            
        } 
      
        public interface IEnumMember 
        {

            object name { get; set; }
            Expression initializer { get; set; }
            
        } 
      
        public interface IEnumDeclaration 
        {

            Identifier name { get; set; }
            NodeArray<EnumMember> members { get; set; }
            
        } 
      
        public interface IExportContainer 
        {

            ExportDeclaration[] exportStars { get; set; }
            
        } 
      
        public interface IModuleDeclaration 
        {

            object name { get; set; }
            object body { get; set; }
            
        } 
      
        public interface IModuleBlock 
        {

            NodeArray<ModuleElement> statements { get; set; }
            
        } 
      
        public interface IImportEqualsDeclaration 
        {

            Identifier name { get; set; }
            object moduleReference { get; set; }
            
        } 
      
        public interface IExternalModuleReference 
        {

            Expression expression { get; set; }
            
        } 
      
        public interface IImportDeclaration 
        {

            ImportClause importClause { get; set; }
            Expression moduleSpecifier { get; set; }
            
        } 
      
        public interface IImportClause 
        {

            Identifier name { get; set; }
            object namedBindings { get; set; }
            
        } 
      
        public interface INamespaceImport 
        {

            Identifier name { get; set; }
            
        } 
      
        public interface IExportDeclaration 
        {

            object exportClause { get; set; }
            Expression moduleSpecifier { get; set; }
            
        } 
      
        public interface INamedImportsOrExports 
        {

            NodeArray<ImportOrExportSpecifier> elements { get; set; }
            
        } 
      
        public interface IImportOrExportSpecifier 
        {

            Identifier propertyName { get; set; }
            Identifier name { get; set; }
            
        } 
      
        public interface IExportAssignment 
        {

            Identifier exportName { get; set; }
            
        } 
      
        public interface IFileReference 
        {

            string fileName { get; set; }
            
        } 
      
        public interface ICommentRange 
        {

            bool hasTrailingNewLine { get; set; }
            
        } 
      
        public interface ISourceMapSpan 
        {

            int emittedLine { get; set; }
            int emittedColumn { get; set; }
            int sourceLine { get; set; }
            int sourceColumn { get; set; }
            int nameIndex { get; set; }
            int sourceIndex { get; set; }
            
        } 
      
        public interface ISourceMapData 
        {

            string sourceMapFilePath { get; set; }
            string jsSourceMappingURL { get; set; }
            string sourceMapFile { get; set; }
            string sourceMapSourceRoot { get; set; }
            string[] sourceMapSources { get; set; }
            string[] inputSourceFileNames { get; set; }
            string[] sourceMapNames { get; set; }
            string sourceMapMappings { get; set; }
            SourceMapSpan[] sourceMapDecodedMappings { get; set; }
            
        } 
      
        public interface IEmitResult 
        {

            bool emitSkipped { get; set; }
            Diagnostic[] diagnostics { get; set; }
            SourceMapData[] sourceMaps { get; set; }
            
        } 
      
        public interface ISymbolVisibilityResult 
        {

            SymbolAccessibility accessibility { get; set; }
            ImportEqualsDeclaration[] aliasesToMakeVisible { get; set; }
            string errorSymbolName { get; set; }
            Node errorNode { get; set; }
            
        } 
      
        public interface ISymbolAccessiblityResult 
        {

            string errorModuleName { get; set; }
            
        } 
      
        public interface ISymbol 
        {

            SymbolFlags flags { get; set; }
            string name { get; set; }
            int id { get; set; }
            int mergeId { get; set; }
            Declaration[] declarations { get; set; }
            Symbol parent { get; set; }
            SymbolTable members { get; set; }
            SymbolTable exports { get; set; }
            Symbol exportSymbol { get; set; }
            Declaration valueDeclaration { get; set; }
            bool constEnumOnlyModule { get; set; }
            
        } 
      
        public interface ISymbolLinks 
        {

            Symbol target { get; set; }
            Type type { get; set; }
            Type declaredType { get; set; }
            TypeMapper mapper { get; set; }
            bool referenced { get; set; }
            bool exportAssignmentChecked { get; set; }
            Symbol exportAssignmentSymbol { get; set; }
            UnionType unionType { get; set; }
            SymbolTable resolvedExports { get; set; }
            
        } 
      
        public interface INodeLinks 
        {

            Type resolvedType { get; set; }
            Signature resolvedSignature { get; set; }
            Symbol resolvedSymbol { get; set; }
            NodeCheckFlags flags { get; set; }
            int enumMemberValue { get; set; }
            bool isIllegalTypeReferenceInConstraint { get; set; }
            bool isVisible { get; set; }
            string generatedName { get; set; }
            object generatedNames { get; set; }
            object assignmentChecks { get; set; }
            bool hasReportedStatementInAmbientContext { get; set; }
            Symbol importOnRightSide { get; set; }
            
        } 
      
        public interface IType 
        {

            TypeFlags flags { get; set; }
            int id { get; set; }
            Symbol symbol { get; set; }
            
        } 
      
        public interface IIntrinsicType 
        {

            string intrinsicName { get; set; }
            
        } 
      
        public interface IStringLiteralType 
        {

            string text { get; set; }
            
        } 
      
        public interface IInterfaceType 
        {

            TypeParameter[] typeParameters { get; set; }
            object[] baseTypes { get; set; }
            Symbol[] declaredProperties { get; set; }
            Signature[] declaredCallSignatures { get; set; }
            Signature[] declaredConstructSignatures { get; set; }
            Type declaredStringIndexType { get; set; }
            Type declaredNumberIndexType { get; set; }
            
        } 
      
        public interface ITypeReference 
        {

            GenericType target { get; set; }
            Type[] typeArguments { get; set; }
            
        } 
      
        public interface IGenericType 
        {

            object instantiations { get; set; }
            
        } 
      
        public interface ITupleType 
        {

            Type[] elementTypes { get; set; }
            TypeReference baseArrayType { get; set; }
            
        } 
      
        public interface IUnionType 
        {

            Type[] types { get; set; }
            SymbolTable resolvedProperties { get; set; }
            
        } 
      
        public interface IResolvedType 
        {

            SymbolTable members { get; set; }
            Symbol[] properties { get; set; }
            Signature[] callSignatures { get; set; }
            Signature[] constructSignatures { get; set; }
            Type stringIndexType { get; set; }
            Type numberIndexType { get; set; }
            
        } 
      
        public interface ITypeParameter 
        {

            Type constraint { get; set; }
            TypeParameter target { get; set; }
            TypeMapper mapper { get; set; }
            
        } 
      
        public interface ISignature 
        {

            SignatureDeclaration declaration { get; set; }
            TypeParameter[] typeParameters { get; set; }
            Symbol[] parameters { get; set; }
            Type resolvedReturnType { get; set; }
            int minArgumentCount { get; set; }
            bool hasRestParameter { get; set; }
            bool hasStringLiterals { get; set; }
            Signature target { get; set; }
            TypeMapper mapper { get; set; }
            Signature[] unionSignatures { get; set; }
            Signature erasedSignatureCache { get; set; }
            object isolatedSignatureType { get; set; }
            
        } 
      
        public interface ITypeInferences 
        {

            Type[] primary { get; set; }
            Type[] secondary { get; set; }
            
        } 
      
        public interface IInferenceContext 
        {

            TypeParameter[] typeParameters { get; set; }
            bool inferUnionTypes { get; set; }
            TypeInferences[] inferences { get; set; }
            Type[] inferredTypes { get; set; }
            int failedTypeParameterIndex { get; set; }
            
        } 
      
        public interface IDiagnosticMessage 
        {

            string key { get; set; }
            DiagnosticCategory category { get; set; }
            int code { get; set; }
            
        } 
      
        public interface IDiagnosticMessageChain 
        {

            string messageText { get; set; }
            DiagnosticCategory category { get; set; }
            int code { get; set; }
            DiagnosticMessageChain next { get; set; }
            
        } 
      
        public interface IDiagnostic 
        {

            SourceFile file { get; set; }
            int start { get; set; }
            int length { get; set; }
            object messageText { get; set; }
            DiagnosticCategory category { get; set; }
            int code { get; set; }
            
        } 
      
        public interface ICompilerOptions 
        {

            bool allowNonTsExtensions { get; set; }
            string charset { get; set; }
            int codepage { get; set; }
            bool declaration { get; set; }
            bool diagnostics { get; set; }
            bool emitBOM { get; set; }
            bool help { get; set; }
            bool listFiles { get; set; }
            string locale { get; set; }
            string mapRoot { get; set; }
            ModuleKind module { get; set; }
            bool noEmit { get; set; }
            bool noEmitOnError { get; set; }
            bool noErrorTruncation { get; set; }
            bool noImplicitAny { get; set; }
            bool noLib { get; set; }
            bool noLibCheck { get; set; }
            bool noResolve { get; set; }
            string tsOut { get; set; }
            string outDir { get; set; }
            bool preserveConstEnums { get; set; }
            string project { get; set; }
            bool removeComments { get; set; }
            bool sourceMap { get; set; }
            string sourceRoot { get; set; }
            bool suppressImplicitAnyIndexErrors { get; set; }
            ScriptTarget target { get; set; }
            bool version { get; set; }
            bool watch { get; set; }
            bool stripInternal { get; set; }
            
        } 
      
        public interface ILineAndCharacter 
        {

            int line { get; set; }
            int character { get; set; }
            
        } 
      
        public interface IParsedCommandLine 
        {

            CompilerOptions options { get; set; }
            string[] fileNames { get; set; }
            Diagnostic[] errors { get; set; }
            
        } 
      
        public interface ICommandLineOption 
        {

            string name { get; set; }
            object type { get; set; }
            bool isFilePath { get; set; }
            string shortName { get; set; }
            DiagnosticMessage description { get; set; }
            DiagnosticMessage paramType { get; set; }
            DiagnosticMessage error { get; set; }
            bool experimental { get; set; }
            
        } 
      
        public interface ICompilerHost 
        {

            object writeFile { get; set; }
            
        } 
      
        public interface ITextSpan 
        {

            int start { get; set; }
            int length { get; set; }
            
        } 
      
        public interface ITextChangeRange 
        {

            TextSpan span { get; set; }
            int newLength { get; set; }
            
        } 
      
        public interface ISourceFile 
        {

            string version { get; set; }
            IScriptSnapshot scriptSnapshot { get; set; }
            object nameTable { get; set; }
            
        } 
      
        public interface IPreProcessedFileInfo 
        {

            FileReference[] referencedFiles { get; set; }
            FileReference[] importedFiles { get; set; }
            bool isLibFile { get; set; }
            
        } 
      
        public interface IClassifiedSpan 
        {

            TextSpan textSpan { get; set; }
            string classificationType { get; set; }
            
        } 
      
        public interface INavigationBarItem 
        {

            string text { get; set; }
            string kind { get; set; }
            string kindModifiers { get; set; }
            TextSpan[] spans { get; set; }
            NavigationBarItem[] childItems { get; set; }
            int indent { get; set; }
            bool bolded { get; set; }
            bool grayed { get; set; }
            
        } 
      
        public interface ITodoCommentDescriptor 
        {

            string text { get; set; }
            int priority { get; set; }
            
        } 
      
        public interface ITodoComment 
        {

            TodoCommentDescriptor descriptor { get; set; }
            string message { get; set; }
            int position { get; set; }
            
        } 
      
        public interface IRenameLocation 
        {

            TextSpan textSpan { get; set; }
            string fileName { get; set; }
            
        } 
      
        public interface IReferenceEntry 
        {

            TextSpan textSpan { get; set; }
            string fileName { get; set; }
            bool isWriteAccess { get; set; }
            
        } 
      
        public interface INavigateToItem 
        {

            string name { get; set; }
            string kind { get; set; }
            string kindModifiers { get; set; }
            string matchKind { get; set; }
            bool isCaseSensitive { get; set; }
            string fileName { get; set; }
            TextSpan textSpan { get; set; }
            string containerName { get; set; }
            string containerKind { get; set; }
            
        } 
      
        public interface IEditorOptions 
        {

            int IndentSize { get; set; }
            int TabSize { get; set; }
            string NewLineCharacter { get; set; }
            bool ConvertTabsToSpaces { get; set; }
            
        } 
      
        public interface IFormatCodeOptions 
        {

            bool InsertSpaceAfterCommaDelimiter { get; set; }
            bool InsertSpaceAfterSemicolonInForStatements { get; set; }
            bool InsertSpaceBeforeAndAfterBinaryOperators { get; set; }
            bool InsertSpaceAfterKeywordsInControlFlowStatements { get; set; }
            bool InsertSpaceAfterFunctionKeywordForAnonymousFunctions { get; set; }
            bool InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis { get; set; }
            bool PlaceOpenBraceOnNewLineForFunctions { get; set; }
            bool PlaceOpenBraceOnNewLineForControlBlocks { get; set; }
            
        } 
      
        public interface IDefinitionInfo 
        {

            string fileName { get; set; }
            TextSpan textSpan { get; set; }
            string kind { get; set; }
            string name { get; set; }
            string containerKind { get; set; }
            string containerName { get; set; }
            
        } 
      
        public interface ISymbolDisplayPart 
        {

            string text { get; set; }
            string kind { get; set; }
            
        } 
      
        public interface IQuickInfo 
        {

            string kind { get; set; }
            string kindModifiers { get; set; }
            TextSpan textSpan { get; set; }
            SymbolDisplayPart[] displayParts { get; set; }
            SymbolDisplayPart[] documentation { get; set; }
            
        } 
      
        public interface IRenameInfo 
        {

            bool canRename { get; set; }
            string localizedErrorMessage { get; set; }
            string displayName { get; set; }
            string fullDisplayName { get; set; }
            string kind { get; set; }
            string kindModifiers { get; set; }
            TextSpan triggerSpan { get; set; }
            
        } 
      
        public interface ISignatureHelpParameter 
        {

            string name { get; set; }
            SymbolDisplayPart[] documentation { get; set; }
            SymbolDisplayPart[] displayParts { get; set; }
            bool isOptional { get; set; }
            
        } 
      
        public interface ISignatureHelpItem 
        {

            bool isVariadic { get; set; }
            SymbolDisplayPart[] prefixDisplayParts { get; set; }
            SymbolDisplayPart[] suffixDisplayParts { get; set; }
            SymbolDisplayPart[] separatorDisplayParts { get; set; }
            SignatureHelpParameter[] parameters { get; set; }
            SymbolDisplayPart[] documentation { get; set; }
            
        } 
      
        public interface ISignatureHelpItems 
        {

            SignatureHelpItem[] items { get; set; }
            TextSpan applicableSpan { get; set; }
            int selectedItemIndex { get; set; }
            int argumentIndex { get; set; }
            int argumentCount { get; set; }
            
        } 
      
        public interface ICompletionInfo 
        {

            bool isMemberCompletion { get; set; }
            bool isNewIdentifierLocation { get; set; }
            CompletionEntry[] entries { get; set; }
            
        } 
      
        public interface ICompletionEntry 
        {

            string name { get; set; }
            string kind { get; set; }
            string kindModifiers { get; set; }
            
        } 
      
        public interface ICompletionEntryDetails 
        {

            string name { get; set; }
            string kind { get; set; }
            string kindModifiers { get; set; }
            SymbolDisplayPart[] displayParts { get; set; }
            SymbolDisplayPart[] documentation { get; set; }
            
        } 
      
        public interface IOutliningSpan 
        {

            TextSpan textSpan { get; set; }
            TextSpan hintSpan { get; set; }
            string bannerText { get; set; }
            bool autoCollapse { get; set; }
            
        } 
      
        public interface IEmitOutput 
        {

            OutputFile[] outputFiles { get; set; }
            bool emitSkipped { get; set; }
            
        } 
      
        public interface IOutputFile 
        {

            string name { get; set; }
            bool writeByteOrderMark { get; set; }
            string text { get; set; }
            
        } 
      
        public interface IClassificationResult 
        {

            EndOfLineState finalLexState { get; set; }
            ClassificationInfo[] entries { get; set; }
            
        } 
      
        public interface IClassificationInfo 
        {

            int length { get; set; }
            TokenClass classification { get; set; }
            
        } 
      
        public interface ICompletionSession 
        {

            string fileName { get; set; }
            int position { get; set; }
            CompletionEntry[] entries { get; set; }
            object symbols { get; set; }
            object typeChecker { get; set; }
            
        } 
      
        public interface IFormattingOptions 
        {

            bool useTabs { get; set; }
            int spacesPerTab { get; set; }
            int indentSpaces { get; set; }
            string newLineCharacter { get; set; }
            
        } 
      
        public interface IHostFileInformation 
        {

            string hostFileName { get; set; }
            string version { get; set; }
            IScriptSnapshot scriptSnapshot { get; set; }
            
        } 
      
        public interface IDocumentRegistryEntry 
        {

            SourceFile sourceFile { get; set; }
            int refCount { get; set; }
            string[] owners { get; set; }
            
        } 
     

	  
	    public class TextRange : ITextRange 
        {

            public int pos { get; set; }
            public int end { get; set; }

        } 
	  
	    public class Node : INode 
        {

            public SyntaxKind kind { get; set; }
            public NodeFlags flags { get; set; }
            public ParserContextFlags parserContextFlags { get; set; }
            public ModifiersArray modifiers { get; set; }
            public int id { get; set; }
            public Node parent { get; set; }
            public Symbol symbol { get; set; }
            public SymbolTable locals { get; set; }
            public Node nextContainer { get; set; }
            public Symbol localSymbol { get; set; }

        } 
	  
	    public class NodeArray<T> : INodeArray<T> 
        {

            public bool hasTrailingComma { get; set; }

        } 
	  
	    public class ModifiersArray : IModifiersArray 
        {

            public int flags { get; set; }

        } 
	  
	    public class Identifier : IIdentifier 
        {

            public string text { get; set; }

        } 
	  
	    public class QualifiedName : IQualifiedName 
        {

            public object left { get; set; }
            public Identifier right { get; set; }

        } 
	  
	    public class Declaration : IDeclaration 
        {

            public object _declarationBrand { get; set; }
            public object name { get; set; }

        } 
	  
	    public class ComputedPropertyName : IComputedPropertyName 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class TypeParameterDeclaration : ITypeParameterDeclaration 
        {

            public Identifier name { get; set; }
            public TypeNode constraint { get; set; }
            public Expression expression { get; set; }

        } 
	  
	    public class SignatureDeclaration : ISignatureDeclaration 
        {

            public NodeArray<TypeParameterDeclaration> typeParameters { get; set; }
            public NodeArray<ParameterDeclaration> parameters { get; set; }
            public TypeNode type { get; set; }

        } 
	  
	    public class VariableDeclaration : IVariableDeclaration 
        {

            public VariableDeclarationList parent { get; set; }
            public object name { get; set; }
            public TypeNode type { get; set; }
            public Expression initializer { get; set; }

        } 
	  
	    public class VariableDeclarationList : IVariableDeclarationList 
        {

            public NodeArray<VariableDeclaration> declarations { get; set; }

        } 
	  
	    public class ParameterDeclaration : IParameterDeclaration 
        {

            public Node dotDotDotToken { get; set; }
            public object name { get; set; }
            public Node questionToken { get; set; }
            public TypeNode type { get; set; }
            public Expression initializer { get; set; }

        } 
	  
	    public class BindingElement : IBindingElement 
        {

            public Identifier propertyName { get; set; }
            public Node dotDotDotToken { get; set; }
            public object name { get; set; }
            public Expression initializer { get; set; }

        } 
	  
	    public class PropertyDeclaration : IPropertyDeclaration 
        {

            public object name { get; set; }
            public Node questionToken { get; set; }
            public TypeNode type { get; set; }
            public Expression initializer { get; set; }

        } 
	  
	    public class ObjectLiteralElement : IObjectLiteralElement 
        {

            public object _objectLiteralBrandBrand { get; set; }

        } 
	  
	    public class PropertyAssignment : IPropertyAssignment 
        {

            public object _propertyAssignmentBrand { get; set; }
            public object name { get; set; }
            public Node questionToken { get; set; }
            public Expression initializer { get; set; }

        } 
	  
	    public class ShorthandPropertyAssignment : IShorthandPropertyAssignment 
        {

            public Identifier name { get; set; }
            public Node questionToken { get; set; }

        } 
	  
	    public class VariableLikeDeclaration : IVariableLikeDeclaration 
        {

            public Identifier propertyName { get; set; }
            public Node dotDotDotToken { get; set; }
            public object name { get; set; }
            public Node questionToken { get; set; }
            public TypeNode type { get; set; }
            public Expression initializer { get; set; }

        } 
	  
	    public class BindingPattern : IBindingPattern 
        {

            public NodeArray<BindingElement> elements { get; set; }

        } 
	  
	    public class FunctionLikeDeclaration : IFunctionLikeDeclaration 
        {

            public object _functionLikeDeclarationBrand { get; set; }
            public Node asteriskToken { get; set; }
            public Node questionToken { get; set; }
            public object body { get; set; }

        } 
	  
	    public class FunctionDeclaration : IFunctionDeclaration 
        {

            public Identifier name { get; set; }
            public Block body { get; set; }

        } 
	  
	    public class MethodDeclaration : IMethodDeclaration 
        {

            public Block body { get; set; }

        } 
	  
	    public class ConstructorDeclaration : IConstructorDeclaration 
        {

            public Block body { get; set; }

        } 
	  
	    public class AccessorDeclaration : IAccessorDeclaration 
        {

            public object _accessorDeclarationBrand { get; set; }
            public Block body { get; set; }

        } 
	  
	    public class IndexSignatureDeclaration : IIndexSignatureDeclaration 
        {

            public object _indexSignatureDeclarationBrand { get; set; }

        } 
	  
	    public class TypeNode : ITypeNode 
        {

            public object _typeNodeBrand { get; set; }

        } 
	  
	    public class FunctionOrConstructorTypeNode : IFunctionOrConstructorTypeNode 
        {

            public object _functionOrConstructorTypeNodeBrand { get; set; }

        } 
	  
	    public class TypeReferenceNode : ITypeReferenceNode 
        {

            public object typeName { get; set; }
            public NodeArray<TypeNode> typeArguments { get; set; }

        } 
	  
	    public class TypeQueryNode : ITypeQueryNode 
        {

            public object exprName { get; set; }

        } 
	  
	    public class TypeLiteralNode : ITypeLiteralNode 
        {

            public NodeArray<Node> members { get; set; }

        } 
	  
	    public class ArrayTypeNode : IArrayTypeNode 
        {

            public TypeNode elementType { get; set; }

        } 
	  
	    public class TupleTypeNode : ITupleTypeNode 
        {

            public NodeArray<TypeNode> elementTypes { get; set; }

        } 
	  
	    public class UnionTypeNode : IUnionTypeNode 
        {

            public NodeArray<TypeNode> types { get; set; }

        } 
	  
	    public class ParenthesizedTypeNode : IParenthesizedTypeNode 
        {

            public TypeNode type { get; set; }

        } 
	  
	    public class Expression : IExpression 
        {

            public object _expressionBrand { get; set; }
            public Type contextualType { get; set; }

        } 
	  
	    public class UnaryExpression : IUnaryExpression 
        {

            public object _unaryExpressionBrand { get; set; }

        } 
	  
	    public class PrefixUnaryExpression : IPrefixUnaryExpression 
        {

            public SyntaxKind tsOperator { get; set; }
            public UnaryExpression operand { get; set; }

        } 
	  
	    public class PostfixUnaryExpression : IPostfixUnaryExpression 
        {

            public LeftHandSideExpression operand { get; set; }
            public SyntaxKind tsOperator { get; set; }

        } 
	  
	    public class PostfixExpression : IPostfixExpression 
        {

            public object _postfixExpressionBrand { get; set; }

        } 
	  
	    public class LeftHandSideExpression : ILeftHandSideExpression 
        {

            public object _leftHandSideExpressionBrand { get; set; }

        } 
	  
	    public class MemberExpression : IMemberExpression 
        {

            public object _memberExpressionBrand { get; set; }

        } 
	  
	    public class PrimaryExpression : IPrimaryExpression 
        {

            public object _primaryExpressionBrand { get; set; }

        } 
	  
	    public class DeleteExpression : IDeleteExpression 
        {

            public UnaryExpression expression { get; set; }

        } 
	  
	    public class TypeOfExpression : ITypeOfExpression 
        {

            public UnaryExpression expression { get; set; }

        } 
	  
	    public class VoidExpression : IVoidExpression 
        {

            public UnaryExpression expression { get; set; }

        } 
	  
	    public class YieldExpression : IYieldExpression 
        {

            public Node asteriskToken { get; set; }
            public Expression expression { get; set; }

        } 
	  
	    public class BinaryExpression : IBinaryExpression 
        {

            public Expression left { get; set; }
            public Node operatorToken { get; set; }
            public Expression right { get; set; }

        } 
	  
	    public class ConditionalExpression : IConditionalExpression 
        {

            public Expression condition { get; set; }
            public Expression whenTrue { get; set; }
            public Expression whenFalse { get; set; }

        } 
	  
	    public class FunctionExpression : IFunctionExpression 
        {

            public Identifier name { get; set; }
            public object body { get; set; }

        } 
	  
	    public class LiteralExpression : ILiteralExpression 
        {

            public string text { get; set; }
            public bool isUnterminated { get; set; }

        } 
	  
	    public class StringLiteralExpression : IStringLiteralExpression 
        {

            public object _stringLiteralExpressionBrand { get; set; }

        } 
	  
	    public class TemplateExpression : ITemplateExpression 
        {

            public LiteralExpression head { get; set; }
            public NodeArray<TemplateSpan> templateSpans { get; set; }

        } 
	  
	    public class TemplateSpan : ITemplateSpan 
        {

            public Expression expression { get; set; }
            public LiteralExpression literal { get; set; }

        } 
	  
	    public class ParenthesizedExpression : IParenthesizedExpression 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class ArrayLiteralExpression : IArrayLiteralExpression 
        {

            public NodeArray<Expression> elements { get; set; }

        } 
	  
	    public class SpreadElementExpression : ISpreadElementExpression 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class ObjectLiteralExpression : IObjectLiteralExpression 
        {

            public NodeArray<ObjectLiteralElement> properties { get; set; }

        } 
	  
	    public class PropertyAccessExpression : IPropertyAccessExpression 
        {

            public LeftHandSideExpression expression { get; set; }
            public Identifier name { get; set; }

        } 
	  
	    public class ElementAccessExpression : IElementAccessExpression 
        {

            public LeftHandSideExpression expression { get; set; }
            public Expression argumentExpression { get; set; }

        } 
	  
	    public class CallExpression : ICallExpression 
        {

            public LeftHandSideExpression expression { get; set; }
            public NodeArray<TypeNode> typeArguments { get; set; }
            public NodeArray<Expression> arguments { get; set; }

        } 
	  
	    public class TaggedTemplateExpression : ITaggedTemplateExpression 
        {

            public LeftHandSideExpression tag { get; set; }
            public object template { get; set; }

        } 
	  
	    public class TypeAssertion : ITypeAssertion 
        {

            public TypeNode type { get; set; }
            public UnaryExpression expression { get; set; }

        } 
	  
	    public class Statement : IStatement 
        {

            public object _statementBrand { get; set; }

        } 
	  
	    public class Block : IBlock 
        {

            public NodeArray<Statement> statements { get; set; }

        } 
	  
	    public class VariableStatement : IVariableStatement 
        {

            public VariableDeclarationList declarationList { get; set; }

        } 
	  
	    public class ExpressionStatement : IExpressionStatement 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class IfStatement : IIfStatement 
        {

            public Expression expression { get; set; }
            public Statement thenStatement { get; set; }
            public Statement elseStatement { get; set; }

        } 
	  
	    public class IterationStatement : IIterationStatement 
        {

            public Statement statement { get; set; }

        } 
	  
	    public class DoStatement : IDoStatement 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class WhileStatement : IWhileStatement 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class ForStatement : IForStatement 
        {

            public object initializer { get; set; }
            public Expression condition { get; set; }
            public Expression iterator { get; set; }

        } 
	  
	    public class ForInStatement : IForInStatement 
        {

            public object initializer { get; set; }
            public Expression expression { get; set; }

        } 
	  
	    public class ForOfStatement : IForOfStatement 
        {

            public object initializer { get; set; }
            public Expression expression { get; set; }

        } 
	  
	    public class BreakOrContinueStatement : IBreakOrContinueStatement 
        {

            public Identifier label { get; set; }

        } 
	  
	    public class ReturnStatement : IReturnStatement 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class WithStatement : IWithStatement 
        {

            public Expression expression { get; set; }
            public Statement statement { get; set; }

        } 
	  
	    public class SwitchStatement : ISwitchStatement 
        {

            public Expression expression { get; set; }
            public NodeArray<object> clauses { get; set; }

        } 
	  
	    public class CaseClause : ICaseClause 
        {

            public Expression expression { get; set; }
            public NodeArray<Statement> statements { get; set; }

        } 
	  
	    public class DefaultClause : IDefaultClause 
        {

            public NodeArray<Statement> statements { get; set; }

        } 
	  
	    public class LabeledStatement : ILabeledStatement 
        {

            public Identifier label { get; set; }
            public Statement statement { get; set; }

        } 
	  
	    public class ThrowStatement : IThrowStatement 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class TryStatement : ITryStatement 
        {

            public Block tryBlock { get; set; }
            public CatchClause catchClause { get; set; }
            public Block finallyBlock { get; set; }

        } 
	  
	    public class CatchClause : ICatchClause 
        {

            public VariableDeclaration variableDeclaration { get; set; }
            public Block block { get; set; }

        } 
	  
	    public class ModuleElement : IModuleElement 
        {

            public object _moduleElementBrand { get; set; }

        } 
	  
	    public class ClassDeclaration : IClassDeclaration 
        {

            public Identifier name { get; set; }
            public NodeArray<TypeParameterDeclaration> typeParameters { get; set; }
            public NodeArray<HeritageClause> heritageClauses { get; set; }
            public NodeArray<ClassElement> members { get; set; }

        } 
	  
	    public class ClassElement : IClassElement 
        {

            public object _classElementBrand { get; set; }

        } 
	  
	    public class InterfaceDeclaration : IInterfaceDeclaration 
        {

            public Identifier name { get; set; }
            public NodeArray<TypeParameterDeclaration> typeParameters { get; set; }
            public NodeArray<HeritageClause> heritageClauses { get; set; }
            public NodeArray<Declaration> members { get; set; }

        } 
	  
	    public class HeritageClause : IHeritageClause 
        {

            public SyntaxKind token { get; set; }
            public NodeArray<TypeReferenceNode> types { get; set; }

        } 
	  
	    public class TypeAliasDeclaration : ITypeAliasDeclaration 
        {

            public Identifier name { get; set; }
            public TypeNode type { get; set; }

        } 
	  
	    public class EnumMember : IEnumMember 
        {

            public object name { get; set; }
            public Expression initializer { get; set; }

        } 
	  
	    public class EnumDeclaration : IEnumDeclaration 
        {

            public Identifier name { get; set; }
            public NodeArray<EnumMember> members { get; set; }

        } 
	  
	    public class ExportContainer : IExportContainer 
        {

            public ExportDeclaration[] exportStars { get; set; }

        } 
	  
	    public class ModuleDeclaration : IModuleDeclaration 
        {

            public object name { get; set; }
            public object body { get; set; }

        } 
	  
	    public class ModuleBlock : IModuleBlock 
        {

            public NodeArray<ModuleElement> statements { get; set; }

        } 
	  
	    public class ImportEqualsDeclaration : IImportEqualsDeclaration 
        {

            public Identifier name { get; set; }
            public object moduleReference { get; set; }

        } 
	  
	    public class ExternalModuleReference : IExternalModuleReference 
        {

            public Expression expression { get; set; }

        } 
	  
	    public class ImportDeclaration : IImportDeclaration 
        {

            public ImportClause importClause { get; set; }
            public Expression moduleSpecifier { get; set; }

        } 
	  
	    public class ImportClause : IImportClause 
        {

            public Identifier name { get; set; }
            public object namedBindings { get; set; }

        } 
	  
	    public class NamespaceImport : INamespaceImport 
        {

            public Identifier name { get; set; }

        } 
	  
	    public class ExportDeclaration : IExportDeclaration 
        {

            public object exportClause { get; set; }
            public Expression moduleSpecifier { get; set; }

        } 
	  
	    public class NamedImportsOrExports : INamedImportsOrExports 
        {

            public NodeArray<ImportOrExportSpecifier> elements { get; set; }

        } 
	  
	    public class ImportOrExportSpecifier : IImportOrExportSpecifier 
        {

            public Identifier propertyName { get; set; }
            public Identifier name { get; set; }

        } 
	  
	    public class ExportAssignment : IExportAssignment 
        {

            public Identifier exportName { get; set; }

        } 
	  
	    public class FileReference : IFileReference 
        {

            public string fileName { get; set; }

        } 
	  
	    public class CommentRange : ICommentRange 
        {

            public bool hasTrailingNewLine { get; set; }

        } 
	  
	    public class SourceMapSpan : ISourceMapSpan 
        {

            public int emittedLine { get; set; }
            public int emittedColumn { get; set; }
            public int sourceLine { get; set; }
            public int sourceColumn { get; set; }
            public int nameIndex { get; set; }
            public int sourceIndex { get; set; }

        } 
	  
	    public class SourceMapData : ISourceMapData 
        {

            public string sourceMapFilePath { get; set; }
            public string jsSourceMappingURL { get; set; }
            public string sourceMapFile { get; set; }
            public string sourceMapSourceRoot { get; set; }
            public string[] sourceMapSources { get; set; }
            public string[] inputSourceFileNames { get; set; }
            public string[] sourceMapNames { get; set; }
            public string sourceMapMappings { get; set; }
            public SourceMapSpan[] sourceMapDecodedMappings { get; set; }

        } 
	  
	    public class EmitResult : IEmitResult 
        {

            public bool emitSkipped { get; set; }
            public Diagnostic[] diagnostics { get; set; }
            public SourceMapData[] sourceMaps { get; set; }

        } 
	  
	    public class SymbolVisibilityResult : ISymbolVisibilityResult 
        {

            public SymbolAccessibility accessibility { get; set; }
            public ImportEqualsDeclaration[] aliasesToMakeVisible { get; set; }
            public string errorSymbolName { get; set; }
            public Node errorNode { get; set; }

        } 
	  
	    public class SymbolAccessiblityResult : ISymbolAccessiblityResult 
        {

            public string errorModuleName { get; set; }

        } 
	  
	    public class Symbol : ISymbol 
        {

            public SymbolFlags flags { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public int mergeId { get; set; }
            public Declaration[] declarations { get; set; }
            public Symbol parent { get; set; }
            public SymbolTable members { get; set; }
            public SymbolTable exports { get; set; }
            public Symbol exportSymbol { get; set; }
            public Declaration valueDeclaration { get; set; }
            public bool constEnumOnlyModule { get; set; }

        } 
	  
	    public class SymbolLinks : ISymbolLinks 
        {

            public Symbol target { get; set; }
            public Type type { get; set; }
            public Type declaredType { get; set; }
            public TypeMapper mapper { get; set; }
            public bool referenced { get; set; }
            public bool exportAssignmentChecked { get; set; }
            public Symbol exportAssignmentSymbol { get; set; }
            public UnionType unionType { get; set; }
            public SymbolTable resolvedExports { get; set; }

        } 
	  
	    public class NodeLinks : INodeLinks 
        {

            public Type resolvedType { get; set; }
            public Signature resolvedSignature { get; set; }
            public Symbol resolvedSymbol { get; set; }
            public NodeCheckFlags flags { get; set; }
            public int enumMemberValue { get; set; }
            public bool isIllegalTypeReferenceInConstraint { get; set; }
            public bool isVisible { get; set; }
            public string generatedName { get; set; }
            public object generatedNames { get; set; }
            public object assignmentChecks { get; set; }
            public bool hasReportedStatementInAmbientContext { get; set; }
            public Symbol importOnRightSide { get; set; }

        } 
	  
	    public class Type : IType 
        {

            public TypeFlags flags { get; set; }
            public int id { get; set; }
            public Symbol symbol { get; set; }

        } 
	  
	    public class IntrinsicType : IIntrinsicType 
        {

            public string intrinsicName { get; set; }

        } 
	  
	    public class StringLiteralType : IStringLiteralType 
        {

            public string text { get; set; }

        } 
	  
	    public class InterfaceType : IInterfaceType 
        {

            public TypeParameter[] typeParameters { get; set; }
            public object[] baseTypes { get; set; }
            public Symbol[] declaredProperties { get; set; }
            public Signature[] declaredCallSignatures { get; set; }
            public Signature[] declaredConstructSignatures { get; set; }
            public Type declaredStringIndexType { get; set; }
            public Type declaredNumberIndexType { get; set; }

        } 
	  
	    public class TypeReference : ITypeReference 
        {

            public GenericType target { get; set; }
            public Type[] typeArguments { get; set; }

        } 
	  
	    public class GenericType : IGenericType 
        {

            public object instantiations { get; set; }

        } 
	  
	    public class TupleType : ITupleType 
        {

            public Type[] elementTypes { get; set; }
            public TypeReference baseArrayType { get; set; }

        } 
	  
	    public class UnionType : IUnionType 
        {

            public Type[] types { get; set; }
            public SymbolTable resolvedProperties { get; set; }

        } 
	  
	    public class ResolvedType : IResolvedType 
        {

            public SymbolTable members { get; set; }
            public Symbol[] properties { get; set; }
            public Signature[] callSignatures { get; set; }
            public Signature[] constructSignatures { get; set; }
            public Type stringIndexType { get; set; }
            public Type numberIndexType { get; set; }

        } 
	  
	    public class TypeParameter : ITypeParameter 
        {

            public Type constraint { get; set; }
            public TypeParameter target { get; set; }
            public TypeMapper mapper { get; set; }

        } 
	  
	    public class Signature : ISignature 
        {

            public SignatureDeclaration declaration { get; set; }
            public TypeParameter[] typeParameters { get; set; }
            public Symbol[] parameters { get; set; }
            public Type resolvedReturnType { get; set; }
            public int minArgumentCount { get; set; }
            public bool hasRestParameter { get; set; }
            public bool hasStringLiterals { get; set; }
            public Signature target { get; set; }
            public TypeMapper mapper { get; set; }
            public Signature[] unionSignatures { get; set; }
            public Signature erasedSignatureCache { get; set; }
            public object isolatedSignatureType { get; set; }

        } 
	  
	    public class TypeInferences : ITypeInferences 
        {

            public Type[] primary { get; set; }
            public Type[] secondary { get; set; }

        } 
	  
	    public class InferenceContext : IInferenceContext 
        {

            public TypeParameter[] typeParameters { get; set; }
            public bool inferUnionTypes { get; set; }
            public TypeInferences[] inferences { get; set; }
            public Type[] inferredTypes { get; set; }
            public int failedTypeParameterIndex { get; set; }

        } 
	  
	    public class DiagnosticMessage : IDiagnosticMessage 
        {

            public string key { get; set; }
            public DiagnosticCategory category { get; set; }
            public int code { get; set; }

        } 
	  
	    public class DiagnosticMessageChain : IDiagnosticMessageChain 
        {

            public string messageText { get; set; }
            public DiagnosticCategory category { get; set; }
            public int code { get; set; }
            public DiagnosticMessageChain next { get; set; }

        } 
	  
	    public class Diagnostic : IDiagnostic 
        {

            public SourceFile file { get; set; }
            public int start { get; set; }
            public int length { get; set; }
            public object messageText { get; set; }
            public DiagnosticCategory category { get; set; }
            public int code { get; set; }

        } 
	  
	    public class CompilerOptions : ICompilerOptions 
        {

            public bool allowNonTsExtensions { get; set; }
            public string charset { get; set; }
            public int codepage { get; set; }
            public bool declaration { get; set; }
            public bool diagnostics { get; set; }
            public bool emitBOM { get; set; }
            public bool help { get; set; }
            public bool listFiles { get; set; }
            public string locale { get; set; }
            public string mapRoot { get; set; }
            public ModuleKind module { get; set; }
            public bool noEmit { get; set; }
            public bool noEmitOnError { get; set; }
            public bool noErrorTruncation { get; set; }
            public bool noImplicitAny { get; set; }
            public bool noLib { get; set; }
            public bool noLibCheck { get; set; }
            public bool noResolve { get; set; }
            public string tsOut { get; set; }
            public string outDir { get; set; }
            public bool preserveConstEnums { get; set; }
            public string project { get; set; }
            public bool removeComments { get; set; }
            public bool sourceMap { get; set; }
            public string sourceRoot { get; set; }
            public bool suppressImplicitAnyIndexErrors { get; set; }
            public ScriptTarget target { get; set; }
            public bool version { get; set; }
            public bool watch { get; set; }
            public bool stripInternal { get; set; }

        } 
	  
	    public class LineAndCharacter : ILineAndCharacter 
        {

            public int line { get; set; }
            public int character { get; set; }

        } 
	  
	    public class ParsedCommandLine : IParsedCommandLine 
        {

            public CompilerOptions options { get; set; }
            public string[] fileNames { get; set; }
            public Diagnostic[] errors { get; set; }

        } 
	  
	    public class CommandLineOption : ICommandLineOption 
        {

            public string name { get; set; }
            public object type { get; set; }
            public bool isFilePath { get; set; }
            public string shortName { get; set; }
            public DiagnosticMessage description { get; set; }
            public DiagnosticMessage paramType { get; set; }
            public DiagnosticMessage error { get; set; }
            public bool experimental { get; set; }

        } 
	  
	    public class CompilerHost : ICompilerHost 
        {

            public object writeFile { get; set; }

        } 
	  
	    public class TextSpan : ITextSpan 
        {

            public int start { get; set; }
            public int length { get; set; }

        } 
	  
	    public class TextChangeRange : ITextChangeRange 
        {

            public TextSpan span { get; set; }
            public int newLength { get; set; }

        } 
	  
	    public class SourceFile : ISourceFile 
        {

            public string version { get; set; }
            public IScriptSnapshot scriptSnapshot { get; set; }
            public object nameTable { get; set; }

        } 
	  
	    public class PreProcessedFileInfo : IPreProcessedFileInfo 
        {

            public FileReference[] referencedFiles { get; set; }
            public FileReference[] importedFiles { get; set; }
            public bool isLibFile { get; set; }

        } 
	  
	    public class ClassifiedSpan : IClassifiedSpan 
        {

            public TextSpan textSpan { get; set; }
            public string classificationType { get; set; }

        } 
	  
	    public class NavigationBarItem : INavigationBarItem 
        {

            public string text { get; set; }
            public string kind { get; set; }
            public string kindModifiers { get; set; }
            public TextSpan[] spans { get; set; }
            public NavigationBarItem[] childItems { get; set; }
            public int indent { get; set; }
            public bool bolded { get; set; }
            public bool grayed { get; set; }

        } 
	  
	    public class TodoCommentDescriptor : ITodoCommentDescriptor 
        {

            public string text { get; set; }
            public int priority { get; set; }

        } 
	  
	    public class TodoComment : ITodoComment 
        {

            public TodoCommentDescriptor descriptor { get; set; }
            public string message { get; set; }
            public int position { get; set; }

        } 
	  
	    public class RenameLocation : IRenameLocation 
        {

            public TextSpan textSpan { get; set; }
            public string fileName { get; set; }

        } 
	  
	    public class ReferenceEntry : IReferenceEntry 
        {

            public TextSpan textSpan { get; set; }
            public string fileName { get; set; }
            public bool isWriteAccess { get; set; }

        } 
	  
	    public class NavigateToItem : INavigateToItem 
        {

            public string name { get; set; }
            public string kind { get; set; }
            public string kindModifiers { get; set; }
            public string matchKind { get; set; }
            public bool isCaseSensitive { get; set; }
            public string fileName { get; set; }
            public TextSpan textSpan { get; set; }
            public string containerName { get; set; }
            public string containerKind { get; set; }

        } 
	  
	    public class EditorOptions : IEditorOptions 
        {

            public int IndentSize { get; set; }
            public int TabSize { get; set; }
            public string NewLineCharacter { get; set; }
            public bool ConvertTabsToSpaces { get; set; }

        } 
	  
	    public class FormatCodeOptions : IFormatCodeOptions 
        {

            public bool InsertSpaceAfterCommaDelimiter { get; set; }
            public bool InsertSpaceAfterSemicolonInForStatements { get; set; }
            public bool InsertSpaceBeforeAndAfterBinaryOperators { get; set; }
            public bool InsertSpaceAfterKeywordsInControlFlowStatements { get; set; }
            public bool InsertSpaceAfterFunctionKeywordForAnonymousFunctions { get; set; }
            public bool InsertSpaceAfterOpeningAndBeforeClosingNonemptyParenthesis { get; set; }
            public bool PlaceOpenBraceOnNewLineForFunctions { get; set; }
            public bool PlaceOpenBraceOnNewLineForControlBlocks { get; set; }

        } 
	  
	    public class DefinitionInfo : IDefinitionInfo 
        {

            public string fileName { get; set; }
            public TextSpan textSpan { get; set; }
            public string kind { get; set; }
            public string name { get; set; }
            public string containerKind { get; set; }
            public string containerName { get; set; }

        } 
	  
	    public class SymbolDisplayPart : ISymbolDisplayPart 
        {

            public string text { get; set; }
            public string kind { get; set; }

        } 
	  
	    public class QuickInfo : IQuickInfo 
        {

            public string kind { get; set; }
            public string kindModifiers { get; set; }
            public TextSpan textSpan { get; set; }
            public SymbolDisplayPart[] displayParts { get; set; }
            public SymbolDisplayPart[] documentation { get; set; }

        } 
	  
	    public class RenameInfo : IRenameInfo 
        {

            public bool canRename { get; set; }
            public string localizedErrorMessage { get; set; }
            public string displayName { get; set; }
            public string fullDisplayName { get; set; }
            public string kind { get; set; }
            public string kindModifiers { get; set; }
            public TextSpan triggerSpan { get; set; }

        } 
	  
	    public class SignatureHelpParameter : ISignatureHelpParameter 
        {

            public string name { get; set; }
            public SymbolDisplayPart[] documentation { get; set; }
            public SymbolDisplayPart[] displayParts { get; set; }
            public bool isOptional { get; set; }

        } 
	  
	    public class SignatureHelpItem : ISignatureHelpItem 
        {

            public bool isVariadic { get; set; }
            public SymbolDisplayPart[] prefixDisplayParts { get; set; }
            public SymbolDisplayPart[] suffixDisplayParts { get; set; }
            public SymbolDisplayPart[] separatorDisplayParts { get; set; }
            public SignatureHelpParameter[] parameters { get; set; }
            public SymbolDisplayPart[] documentation { get; set; }

        } 
	  
	    public class SignatureHelpItems : ISignatureHelpItems 
        {

            public SignatureHelpItem[] items { get; set; }
            public TextSpan applicableSpan { get; set; }
            public int selectedItemIndex { get; set; }
            public int argumentIndex { get; set; }
            public int argumentCount { get; set; }

        } 
	  
	    public class CompletionInfo : ICompletionInfo 
        {

            public bool isMemberCompletion { get; set; }
            public bool isNewIdentifierLocation { get; set; }
            public CompletionEntry[] entries { get; set; }

        } 
	  
	    public class CompletionEntry : ICompletionEntry 
        {

            public string name { get; set; }
            public string kind { get; set; }
            public string kindModifiers { get; set; }

        } 
	  
	    public class CompletionEntryDetails : ICompletionEntryDetails 
        {

            public string name { get; set; }
            public string kind { get; set; }
            public string kindModifiers { get; set; }
            public SymbolDisplayPart[] displayParts { get; set; }
            public SymbolDisplayPart[] documentation { get; set; }

        } 
	  
	    public class OutliningSpan : IOutliningSpan 
        {

            public TextSpan textSpan { get; set; }
            public TextSpan hintSpan { get; set; }
            public string bannerText { get; set; }
            public bool autoCollapse { get; set; }

        } 
	  
	    public class EmitOutput : IEmitOutput 
        {

            public OutputFile[] outputFiles { get; set; }
            public bool emitSkipped { get; set; }

        } 
	  
	    public class OutputFile : IOutputFile 
        {

            public string name { get; set; }
            public bool writeByteOrderMark { get; set; }
            public string text { get; set; }

        } 
	  
	    public class ClassificationResult : IClassificationResult 
        {

            public EndOfLineState finalLexState { get; set; }
            public ClassificationInfo[] entries { get; set; }

        } 
	  
	    public class ClassificationInfo : IClassificationInfo 
        {

            public int length { get; set; }
            public TokenClass classification { get; set; }

        } 
	  
	    public class CompletionSession : ICompletionSession 
        {

            public string fileName { get; set; }
            public int position { get; set; }
            public CompletionEntry[] entries { get; set; }
            public object symbols { get; set; }
            public object typeChecker { get; set; }

        } 
	  
	    public class FormattingOptions : IFormattingOptions 
        {

            public bool useTabs { get; set; }
            public int spacesPerTab { get; set; }
            public int indentSpaces { get; set; }
            public string newLineCharacter { get; set; }

        } 
	  
	    public class HostFileInformation : IHostFileInformation 
        {

            public string hostFileName { get; set; }
            public string version { get; set; }
            public IScriptSnapshot scriptSnapshot { get; set; }

        } 
	  
	    public class DocumentRegistryEntry : IDocumentRegistryEntry 
        {

            public SourceFile sourceFile { get; set; }
            public int refCount { get; set; }
            public string[] owners { get; set; }

        } 
	


    public class SymbolTable {
	public string[] Symbol { get; set; }
    }

    public interface IScriptSnapshot
    {
        string getText(int start, int end);
        int getLength();
        int[] getLineStartPositions();
        TextChangeRange getChangeRange(IScriptSnapshot oldSnapshot);
    }

    public class TypeMapper {
       public object Type { get; set; }
    }

        // text change information 
    public class TextChange {
		public int pos { get; set; }
		public int deleteLen { get; set; }
		public string insertedText { get; set; }
        }

    public interface ICancellationToken {
              bool isCancellationRequested();
    }
   public interface ILanguageServiceHost {
        CompilerOptions getCompilationSettings();
        string getNewLine();
        string[] getScriptFileNames();
        string getScriptVersion(string fileName);
        IScriptSnapshot getScriptSnapshot(string fileName);
        string getLocalizedDiagnosticMessages();
        ICancellationToken getCancellationToken();
        string getCurrentDirectory();
        string getDefaultLibFileName(CompilerOptions options);
        void log   (string s);
        void trace (string s);
        void error (string s);
    }

    public class Program
    {

    }
}

