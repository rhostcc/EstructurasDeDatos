using System;
using AppCola.Interfaces;

namespace AppCola.Clases;


public class Persona : IRegistrable<Persona>
{
    public string Nombre { get; set; }
    public int CI { get; set; }
    public string TipoSangre { get; set; }
    public Persona(string nombre, int ci, string tipoSangre)
    {
        Nombre = nombre;
        CI = ci;
        TipoSangre = tipoSangre;
    }

    public void Insertar()
    {
        Repositorio.Local.Personas.Add(this);
    }

    public Persona Modificar()
    {
        Persona aux = Repositorio.Local.Personas.FirstOrDefault(this);
        return aux;
    }

    public bool Eliminar()
    {
        return true;
    }

    public List<Persona> Listar()
    {
        return Repositorio.Local.Personas;
    }
    public override string ToString()
    {
        return $"{Nombre} | {CI} | {TipoSangre}";
    }
}
