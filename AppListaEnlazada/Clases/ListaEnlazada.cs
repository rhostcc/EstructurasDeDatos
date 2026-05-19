using System;
using AppListaEnlazada.Interfaces;

namespace AppListaEnlazada.Clases;

public class ListaEnlazada<T> : IListaSimple<T>
{
    private NodoSimple<T> _inicio;
    private int _cantidad;
    public ListaEnlazada()
    {
        _inicio = null;
        _cantidad = 0;
    }
    public int BuscarElemento()
    {
        throw new NotImplementedException();
    }

    public int Cantidad()
    {
        return _cantidad;
    }

    public bool EsVacio()
    {
        return _inicio == null;
    }

    public void InsertarInicio(T valor)
    {
        throw new NotImplementedException();
    }

    public void InsertarFin(T valor)
    {
        throw new NotImplementedException();
    }

    public void MostrarElementos()
    {
        throw new NotImplementedException();
    }

    public void Reemplazar(int indice, T valor)
    {
        throw new NotImplementedException();
    }
}
