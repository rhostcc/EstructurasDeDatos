using System;
using AppCola.Interfaces;

namespace AppCola.Clases;

public class Ficha: IRegistrable<Ficha>
{
    public Persona Paciente { get; set; }
    public Medico Medico { get; set; }
    public DateTime FechaAtencion { get; set; }
    public Ficha(Persona paciente, Medico medico, DateTime fa)
    {
        Paciente = paciente;
        Medico = medico;
        FechaAtencion = fa;
    }

    public void Insertar()
    {
        throw new NotImplementedException();
    }

    public Ficha Modificar()
    {
        throw new NotImplementedException();
    }

    public bool Eliminar()
    {
        throw new NotImplementedException();
    }

    public List<Ficha> Listar()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Paciente: {Paciente.Nombre} | Medico: {Medico.Nombre} | FechaAtencion: {FechaAtencion}";
    }
}
