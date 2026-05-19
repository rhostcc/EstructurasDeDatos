using System;

namespace AppListaEnlazada.Clases;

public class NodoSimple<T>
{
    public T Valor { get; set; }
    public NodoSimple<T> Siguiente { get; set; }
    public NodoSimple(T valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}
