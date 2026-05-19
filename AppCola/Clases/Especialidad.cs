using System;
using AppCola.Interfaces;

namespace AppCola.Clases;

public class Especialidad: IRegistrable<Especialidad>
{
    public string Nombre { get; set; }
    public string Sigla { get; set; }
    public Especialidad(string nombre, string sigla)
    {
        Nombre = nombre;
        Sigla = sigla;
    }

    public void Insertar()
    {
        throw new NotImplementedException();
    }

    public Especialidad Modificar()
    {
        throw new NotImplementedException();
    }

    public bool Eliminar()
    {
        throw new NotImplementedException();
    }

    public List<Especialidad> Listar()
    {
        throw new NotImplementedException();
    }
}
