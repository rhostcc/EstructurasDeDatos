using System;
using AppListaEnlazadaDoble.Interfaces;

namespace AppListaEnlazadaDoble.Clases;

public class ListaDoble<T> : IListaDoble<T>
{
    private NodoDoble<T> _inicio;
    private NodoDoble<T> _fin;
    private int _cantidad;
    public ListaDoble()
    {
        _inicio = null;
        _fin = null;
        _cantidad = 0;
    }

    public void AgreagarEn(int indice, T valor)
    {
        throw new NotImplementedException();
    }

    public void AgregarFinal(T Valor)
    {
        NodoDoble<T> nuevoNodo = new NodoDoble<T>(Valor);
        if(EsVacio())
        {
            _inicio = nuevoNodo;
            _fin = nuevoNodo;
        } else
        {
            _fin.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = _fin;
            _fin = _fin.Siguiente;
        }
        _cantidad+=1;
    }

    public void AgregarInicio(T Valor)
    {
        NodoDoble<T> nuevoNodo = new NodoDoble<T>(Valor);
        if(EsVacio())
        {
            _inicio = nuevoNodo;
            _fin = nuevoNodo;
        } else
        {
            nuevoNodo.Siguiente = _inicio;
            _inicio.Anterior = nuevoNodo;
            _inicio = _inicio.Anterior;
        }
        _cantidad+=1;
    }

    public void EliminarEn(int indice)
    {
        throw new NotImplementedException();
    }

    public void EliminarFin()
    {
        if(EsVacio())
            return;
        else if(_cantidad == 1)
        {
            _inicio = null;
            _fin = null;
            _cantidad = 0;
        } else
        {
            _fin = _fin.Anterior;
            _fin.Siguiente = null;
            _cantidad-=1;
        }
    }

    public void EliminarInicio()
    {
        if(EsVacio())
            return;
        else if(_cantidad == 1)
        {
            _inicio = null;
            _fin = null;
            _cantidad = 0;
        } else
        {
            _inicio = _inicio.Siguiente;
            _inicio.Anterior = null;
            _cantidad-=1;
        }
    }

    public void EliminarNodo(T valor)
    {
        if(EsVacio())
            return;
        // Un solo nodo
        // Dos nodos
        // Mas nodos
    }

    public bool EsVacio()
    {
        return _cantidad == 0;
    }

    public void MostrarDerecho()
    {
        if(EsVacio())
            return;
        NodoDoble<T> temp = _inicio;
        Console.Write("null<=>");
        while(temp != null)
        {
            Console.Write($"[{temp.Valor}]<=>");
            temp = temp.Siguiente;
        }
        Console.Write("null\n");
    }

    public void MostrarRevez()
    {
        if(EsVacio())
            return;
        NodoDoble<T> temp = _fin;
        Console.Write("null<=>");
        while(temp != null)
        {
            Console.Write($"[{temp.Valor}]<=>");
            temp = temp.Anterior;
        }
        Console.Write("null\n");
    }
}
