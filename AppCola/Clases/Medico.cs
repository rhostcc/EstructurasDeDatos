using System;
using AppCola.Interfaces;

namespace AppCola.Clases;

public class Medico : Persona, IRegistrable<Medico>
{
    public Especialidad Especialidad { get; set; }
    public int NroProfesional { get; set; }

    public Medico(Persona per, Especialidad esp, int nroProfesional) : base(per.Nombre, per.CI, per.TipoSangre)
    {
        Especialidad = esp;
        NroProfesional = nroProfesional;
    }
    public override string ToString()
    {
        return $"{Nombre} | {CI} | {Especialidad.Nombre}";
    }
    Medico IRegistrable<Medico>.Modificar()
    {
        throw new NotImplementedException();
    }

    List<Medico> IRegistrable<Medico>.Listar()
    {
        throw new NotImplementedException();
    }
}
