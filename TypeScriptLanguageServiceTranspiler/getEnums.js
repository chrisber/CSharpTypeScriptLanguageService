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


function getEnumNodes(sf){
	host.log("+++ Enum +++" )
	var topLevelEnumNodes = [];
	function allNodes(n){
		ts.forEachChild(n, function (n) {
			if(n.kind === ts.SyntaxKind.EnumDeclaration ){
				topLevelEnumNodes.push(n);	
				host.log("Enum: " + typeChecker.typeToString(typeChecker.getTypeAtLocation(n)));
			}
			allNodes(n);
		});
	}
	allNodes(sf);
	host.log("+++ Enum +++" )
	return topLevelEnumNodes;
}



function getEnumNodesWithMembers(sf) {
var topLevelEnumNodes = getEnumNodes(sf);
	var enums ={}
	for(var i = 0; i < topLevelEnumNodes.length; i++){
		//get enum name
		var interfaceName = typeChecker.typeToString(typeChecker.getTypeAtLocation(topLevelEnumNodes[i]));
		enums[interfaceName] = [];
		//for each enum
		ts.forEachChild(topLevelEnumNodes[i], function (currentNode) {
			if( currentNode.kind === ts.SyntaxKind.EnumMember  ){
				enums[interfaceName].push(JSON.stringify(ts.getTextOfNodeFromSourceText( sf.text,currentNode)));
				host.log(interfaceName + " member: " +JSON.stringify(ts.getTextOfNodeFromSourceText( sf.text,currentNode)));
			}
		});
	}
	return enums;
}

var program = ls.getProgram();
var typeChecker = program.getTypeChecker(true);
var sf = program.getSourceFile(host.fileName);
var enums = getEnumNodesWithMembers(sf);
var jsons = { 
	"enums": enums
}
//host.typeScriptLanguageTypes(JSON.stringify(jsons));
JSON.stringify(jsons)

