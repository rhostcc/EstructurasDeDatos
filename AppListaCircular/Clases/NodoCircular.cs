using System;

namespace AppListaCircular.Clases;

public class NodoCircular<T>
{
    public T Valor { get; set; }
    public NodoCircular<T> Siguiente { get; set; }
    public NodoCircular(T valor)
    {
        Valor = valor;
        Siguiente = this;
    }
}
