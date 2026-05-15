using AppPila.Clases;

Pila<string> nombres = new Pila<string>();
nombres.Push("Juan");
nombres.Push("Maria");
Console.WriteLine(nombres.Pop());
Console.WriteLine(nombres.Peek());
nombres.Pop();
Console.WriteLine(nombres.Peek());