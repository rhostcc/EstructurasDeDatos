using System;
using System.Runtime.CompilerServices;
using AppListaCircular.Interfaces;

namespace AppListaCircular.Clases;

public class ListaEnlazadaCircular<T> : IListaEnlazadaCircular<T>
{
    private NodoCircular<T> _fin;
    private int _cantidad;
    public ListaEnlazadaCircular()
    {
        _fin = null;
        _cantidad = 0;
    }
    
    public int Cantidad()
    {
        return _cantidad;
    }
    
    public bool EsVacio()
    {
        return _fin == null;
    }

    public void InsertarEn(T valor, int indice)
    {
        NodoCircular<T> nuevoNodo = new NodoCircular<T>(valor);
        if(indice >= 0 && indice < _cantidad)
        {
            if(indice == 0)
            {
                InsertarInicio(valor);
            } else if(indice == _cantidad)
            {
                InsertarFin(valor);
            } else
            {
                NodoCircular<T> temp = _fin.Siguiente;
                int indiceActual = 0;
                while (indiceActual != indice - 1)
                {
                    indiceActual+=1;
                    temp = temp.Siguiente;
                }
                nuevoNodo.Siguiente = temp.Siguiente;
                temp.Siguiente = nuevoNodo;
            }
            _cantidad+=1;
        }
    }

    public void InsertarFin(T valor)
    {
        NodoCircular<T> nuevoNodo = new NodoCircular<T>(valor);
        if(EsVacio())
            _fin = nuevoNodo;
        else
        {
                nuevoNodo.Siguiente = _fin.Siguiente;
                _fin.Siguiente = nuevoNodo;
                _fin = nuevoNodo;
        }
        _cantidad+=1;
    }

    public void InsertarInicio(T valor)
    {
        NodoCircular<T> nuevoNodo = new NodoCircular<T>(valor);
        if(EsVacio())
            _fin = nuevoNodo;
        else
        {
                nuevoNodo.Siguiente = _fin.Siguiente;
                _fin.Siguiente = nuevoNodo;
        }
        _cantidad+=1;
    }

    public void MostrarElementos()
    {
        if(EsVacio())
            return;
        NodoCircular<T> temp = _fin.Siguiente;
        do
        {
            Console.Write($"[{temp.Valor}]->");
            temp = temp.Siguiente;
        } while (temp != _fin.Siguiente);
        Console.Write("inicio\n");
    }

    public void EliminarEn(int indice)
    {
        if(indice < 0 || indice >= _cantidad)
            return;

        if(indice == 0)
            EliminarInicio();
        else if(indice == _cantidad - 1)
            EliminarFin();
        else
        {
            NodoCircular<T> temp = _fin.Siguiente;
            int indiceActual = 0;
            while(indiceActual != indice - 1)
            {
                indiceActual+=1;
                temp = temp.Siguiente;
            }
            temp.Siguiente = temp.Siguiente.Siguiente;
            _cantidad-=1;
        }
    }

    public void EliminarFin()
    {
        if(EsVacio())
            return;
        else if(_cantidad == 1)
        {
            _cantidad = 0;
            _fin = null;
        } else
        {
            NodoCircular<T> temp = _fin.Siguiente;
            do
            {
                temp = temp.Siguiente;
            } while (temp.Siguiente != _fin);
            temp.Siguiente = _fin.Siguiente;
            _fin = temp;
            _cantidad-=1;
        }
    }

    public void EliminarInicio()
    {
        if(EsVacio())
            return;
        else if(_cantidad == 1)
        {
            _cantidad = 0;
            _fin = null;
        } else
        {
            _fin.Siguiente = _fin.Siguiente.Siguiente;
            _cantidad-=1;
        }
    }

    public void Reemplazar(int indice, T valor)
    {
        if(indice >= 0 && indice < _cantidad - 1)
        {
            NodoCircular<T> temp = _fin.Siguiente;
            int indiceActual = 0;
            while(indiceActual != indice)
            {
                indiceActual+=1;
                temp = temp.Siguiente;
            }
            temp.Valor = valor;
        }
    }

    public int BuscarElemento(T valor)
    {
        int indice = 0;
        bool encontrado = false;
        NodoCircular<T> temp = _fin.Siguiente;
        do
        {
            if(temp.Valor.Equals(valor))
            {
                encontrado = true;
                break;
            }
            indice+=1;
            temp = temp.Siguiente;
        } while(temp != _fin.Siguiente);
        if(encontrado)
            return indice;
        else
            return -1;
    }
}
