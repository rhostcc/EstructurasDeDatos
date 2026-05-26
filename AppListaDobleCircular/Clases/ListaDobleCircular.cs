using System;
using AppListaDobleCircular.Interfaces;

namespace AppListaDobleCircular.Clases;

public class ListaDobleCircular<T> : IListaDobleCircular<T>
{
    private NodoDobleCircular<T> _inicio;
    private int _cantidad;
    public ListaDobleCircular()
    {
        _inicio = null;
        _cantidad = 0;
    }
    public void AgregarFin(T valor)
    {
        NodoDobleCircular<T> nuevoNodo = new NodoDobleCircular<T>(valor);
        if(EsVacio())
            _inicio = nuevoNodo;
        else
        {
            _inicio.Anterior.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = _inicio.Anterior;
            nuevoNodo.Siguiente = _inicio;
            _inicio.Anterior = nuevoNodo;
        }
        _cantidad+=1;
    }

    public void AgregarInicio(T valor)
    {
        NodoDobleCircular<T> nuevoNodo = new NodoDobleCircular<T>(valor);
        if(EsVacio())
            _inicio = nuevoNodo;
        else
        {
            _inicio.Anterior.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = _inicio.Anterior;
            nuevoNodo.Siguiente = _inicio;
            _inicio.Anterior = nuevoNodo;
            _inicio = nuevoNodo;
        }
        _cantidad+=1;
    }

    private void EliminarInicio()
    {
        if(_cantidad == 1)
        {
            _inicio = null;
            _cantidad = 0;
        } else {
            _inicio.Siguiente.Anterior = _inicio.Anterior;
            _inicio.Anterior.Siguiente = _inicio.Siguiente;
            _inicio = _inicio.Siguiente;
            _cantidad-=1;
        }
    }

    private void EliminarFin()
    {
        if(_cantidad == 1)
        {
            _inicio = null;
            _cantidad = 0;
        } else {
            _inicio.Anterior.Anterior.Siguiente = _inicio;
            _inicio.Anterior = _inicio.Anterior.Anterior;
            _cantidad-=1;
        }
    }

    public void EliminarEn(int indice)
    {
        if(EsVacio() || indice < 0 || indice >= _cantidad)
            return;
        // indice = 0 Eliminar inicio
        if(indice == 0)
            EliminarInicio();
        else if (indice == _cantidad - 1)
            EliminarFin();
        else
        {
            NodoDobleCircular<T> temp = _inicio;
            int indiceActual = 0;
            while(indiceActual != indice)
            {
                temp = temp.Siguiente;
                indiceActual+=1;
            }
            temp.Anterior.Siguiente = temp.Siguiente;
            temp.Siguiente.Anterior = temp.Anterior;
            _cantidad-=1;
        }
    }

    public bool EsVacio()
    {
        return _inicio == null;
    }

    public void RecorrerAdelante()
    {
        if(EsVacio())
            return;
        NodoDobleCircular<T> temp = _inicio;
        Console.Write("fin<=>");
        do
        {
            Console.Write($"[{temp.Valor}]<=>");
            temp = temp.Siguiente;
        } while(temp != _inicio);
        Console.Write("inicio\n");
    }

    public void RecorrerAtras()
    {
        if(EsVacio())
            return;
        NodoDobleCircular<T> temp = _inicio.Anterior;
        Console.Write("inicio<=>");
        do
        {
            Console.Write($"[{temp.Valor}]<=>");
            temp = temp.Anterior;
        } while(temp != _inicio.Anterior);
        Console.Write("fin\n");
    }
}
