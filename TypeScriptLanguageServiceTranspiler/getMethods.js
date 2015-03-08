//debug helper function 
function conv (item){
var cache = [];
	var diagnostics = JSON.stringify(item, function(key, value) {
	    if (typeof value === 'object' && value !== null) {
	        if (cache.indexOf(value) !== -1) {
	            // Circular reference found, discard key
	            return;
	        }
	        // Store value in our collection
	        cache.push(value);
	    }
	    return value;
	});
	cache = null;
	return diagnostics;
}
//	        case SyntaxKind.MethodDeclaration:
//                case SyntaxKind.MethodSignature:

function getInterfaceNodes(sf){
	host.log("+++ languageService +++" )
	var topLevelInterfaceNodes = [];
	function allNodes(n){
		ts.forEachChild(n, function (n) {
			if(
				n.kind === ts.SyntaxKind.InterfaceDeclaration && 
				typeChecker.typeToString(typeChecker.getTypeAtLocation(n)) == "LanguageService"
			){
				topLevelInterfaceNodes.push(n);	
				host.log("languageService: " + typeChecker.typeToString(typeChecker.getTypeAtLocation(n)));
			}
			allNodes(n);
		});
	}
	allNodes(sf);
	host.log("+++ languageService +++" )
	return topLevelInterfaceNodes;
}





function getInterfaceNodesWithMembers(sf) {
	var languageServiceInterface = getInterfaceNodes(sf)[0];
	var methods ={}
		ts.forEachChild(languageServiceInterface, function (tsFunction) {
			var functionSignature = JSON.stringify(ts.getTextOfNodeFromSourceText( sf.text,tsFunction));
			methods[functionSignature] = [];
			//for each interface
			ts.forEachChild(tsFunction, function (parameter) {
				host.log(functionSignature + " parameter: " + ts.getTextOfNodeFromSourceText( sf.text,parameter));
				methods[functionSignature].push(ts.getTextOfNodeFromSourceText( sf.text,parameter));
			});
		});
	
	return methods;
}

var program = ls.getProgram();
var typeChecker = program.getTypeChecker(true);
var sf = program.getSourceFile(host.fileName);
var methods = getInterfaceNodesWithMembers(sf);
var jsons = { 
	"methods": methods
}
//host.typeScriptLanguageTypes(JSON.stringify(jsons));
JSON.stringify(jsons)