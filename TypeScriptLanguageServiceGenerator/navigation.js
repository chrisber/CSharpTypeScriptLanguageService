var nav = ls.getNavigationBarItems(host.fileName);
var jsons = { 
	"navigationbar": nav
}
host.updateLexicalStructure(conv(jsons));