using System;
using System.Net;
using AppCola.Clases;

namespace AppCola.Repositorio;

public static class Local
{
    public static List<Persona> Personas = new List<Persona>()
    {
        new Persona("Luis Lopez", 0, "A")
    };
    public static List<Especialidad> Especialidades = new List<Especialidad>()
    {
        new Especialidad("Cardiologia", "CAR"),
        new Especialidad("Nefrologia", "NEF"),
        new Especialidad("Pediatria", "PED")
    };
    public static List<Medico> Medicos = new List<Medico>()
    {
        new Medico(new Persona("Juan Perez", 1, "B"), new Especialidad("Nefrologia", "NEF"), 123)
    };
    public static List<Ficha> Fichas = new List<Ficha>();
}
