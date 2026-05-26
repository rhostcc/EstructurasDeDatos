using System;

namespace AppListaDobleCircular.Clases;

public class NodoDobleCircular<T>
{
    public T Valor { get; set; }
    public NodoDobleCircular<T> Siguiente { get; set; }
    public NodoDobleCircular<T> Anterior { get; set; }
    public NodoDobleCircular(T valor)
    {
        Valor = valor;
        Siguiente = this;
        Anterior = this;
    }
}
