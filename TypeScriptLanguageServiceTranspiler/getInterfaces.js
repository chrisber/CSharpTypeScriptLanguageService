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


function getInterfaceNodes(sf){
	host.log("+++ Interfaces +++" )
	var topLevelInterfaceNodes = [];
	function allNodes(n){
		ts.forEachChild(n, function (n) {
			if(n.kind === ts.SyntaxKind.InterfaceDeclaration ){
				topLevelInterfaceNodes.push(n);	
				host.log("interface: " + typeChecker.typeToString(typeChecker.getTypeAtLocation(n)));
			}
			allNodes(n);
		});
	}
	allNodes(sf);
	host.log("+++ Interfaces +++" )
	return topLevelInterfaceNodes;
}



function getInterfaceNodesWithMembers(sf) {
var topLevelInterfaceNodes = getInterfaceNodes(sf);
	var interfaces ={}
	for(var i = 0; i < topLevelInterfaceNodes.length; i++){
		//get interface name
		var interfaceName = typeChecker.typeToString(typeChecker.getTypeAtLocation(topLevelInterfaceNodes[i]));
		interfaces[interfaceName] = [];
		//for each interface
		ts.forEachChild(topLevelInterfaceNodes[i], function (currentNode) {
			if( currentNode.kind === ts.SyntaxKind.PropertySignature  ){
				interfaces[interfaceName].push(JSON.stringify(ts.getTextOfNodeFromSourceText( sf.text,currentNode)));
				host.log(interfaceName + " member: " +JSON.stringify(ts.getTextOfNodeFromSourceText( sf.text,currentNode)));
			}
		});
	}
	return interfaces;
}

var program = ls.getProgram();
var typeChecker = program.getTypeChecker(true);
var sf = program.getSourceFile(host.fileName);
var interfaces = getInterfaceNodesWithMembers(sf);
var jsons = { 
	"interfaces": interfaces
}
//host.typeScriptLanguageTypes(JSON.stringify(jsons));
JSON.stringify(jsons)