

using AppCola.Clases;

Cola<int> colaNumeros = new Cola<int>();
do
{
    System.Console.WriteLine("\tMENU");
    System.Console.WriteLine("1. Encolar");
    System.Console.WriteLine("2. Desencolar");
    System.Console.WriteLine("3. Mostrar");
    System.Console.WriteLine("0. salir");
    System.Console.Write("Seleccionar: ");
    int opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case 1:
            Console.Write("Ingresar numero: ");
            colaNumeros.Enqueue(int.Parse(Console.ReadLine()));
            break;
        case 2:
            Console.WriteLine($"Se quito el valor {colaNumeros.Dequeue()}");
            break;
        case 3:
            Console.WriteLine($"Cantidad: {colaNumeros.Count()}\n Turno: {colaNumeros.Peek()}");
            break;
        case 0:
            
            break;
    }
} while (true);