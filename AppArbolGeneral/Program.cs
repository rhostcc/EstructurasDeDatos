


using AppArbolGeneral.Clases;

ArbolGeneral<string> arbol = new ArbolGeneral<string>("html");
arbol.AgregarNodo("html", "head");
arbol.AgregarNodo("html", "body");
arbol.AgregarNodo("head", "meta");
arbol.AgregarNodo("head", "title");
arbol.AgregarNodo("body", "header");
arbol.AgregarNodo("header", "img");
arbol.AgregarNodo("body", "nav");
arbol.AgregarNodo("nav", "ul");
arbol.AgregarNodo("ul", "li");
arbol.AgregarNodo("ul", "li");
arbol.AgregarNodo("ul", "li");
arbol.AgregarNodo("body", "article");
arbol.AgregarNodo("article", "h1");
arbol.AgregarNodo("article", "p");
arbol.AgregarNodo("body", "footer");
arbol.MostrarConDecoradores();
arbol.EliminarNodo("title");
arbol.MostrarConDecoradores();
arbol.EliminarNodo("ul");
arbol.MostrarConDecoradores();