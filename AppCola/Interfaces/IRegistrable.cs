using System;

namespace AppCola.Interfaces;

public interface IRegistrable<T>
{
    void Insertar();
    T Modificar();
    bool Eliminar();
    List<T> Listar();
}
