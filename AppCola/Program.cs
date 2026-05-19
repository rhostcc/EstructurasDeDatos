

using AppCola.Clases;
using AppCola.Repositorio;

Cola<Ficha> colaEspera = new Cola<Ficha>(); 
do
{
    System.Console.WriteLine("\n\tMENU");
    System.Console.WriteLine("1. Encolar");
    System.Console.WriteLine("2. Desencolar");
    System.Console.WriteLine("3. Mostrar");
    System.Console.WriteLine("0. salir");
    System.Console.Write("Seleccionar: ");
    int opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case 1:
            Console.WriteLine("\nSeleccione paciente:");
            int indicePaciente = 1;
            foreach (Persona p in Local.Personas)
            {
                Console.WriteLine($"{indicePaciente++}. {p}");
            }
            Console.Write("Opcion: ");
            int optP = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSeleccione medico:");
            int indiceMedico = 1;
            foreach (Medico m in Local.Medicos)
            {
                Console.WriteLine($"{indiceMedico++}. {m}");
            }
            Console.Write("Opcion: ");
            int optM = int.Parse(Console.ReadLine());

            colaEspera.Enqueue(new Ficha(
                Local.Personas[--optP],
                Local.Medicos[--optM],
                DateTime.Now
            ));
            break;
        case 2:
            Console.WriteLine($"Se quito el valor {colaEspera.Dequeue()}");
            break;
        case 3:
            Console.WriteLine($"\nCantidad: {colaEspera.Count()}\n{colaEspera.Peek()}");
            break;
        case 0:
            
            break;
    }
} while (true);