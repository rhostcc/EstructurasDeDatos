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
        NodoSimple<T> nuevoNodo = new NodoSimple<T>(valor);
        if(EsVacio())
        {
            _inicio = nuevoNodo;
        } else
        {
            nuevoNodo.Siguiente = _inicio;
            _inicio = nuevoNodo;
        }
        _cantidad+=1;
    }

    public void InsertarFin(T valor)
    {
        NodoSimple<T> nuevoNodo = new NodoSimple<T>(valor);
        if(EsVacio())
        {
            _inicio = nuevoNodo;
        } else
        {
            NodoSimple<T> temp = _inicio;
            while(temp.Siguiente is not null)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = nuevoNodo;
        }
        _cantidad+=1;
    }

    public void InsertarEn(T valor, int indice)
    {
        NodoSimple<T> nuevoNodo = new NodoSimple<T>(valor);
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
                NodoSimple<T> temp = _inicio;
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

    public void MostrarElementos()
    {
        NodoSimple<T> temp = _inicio;
        while(temp is not null)
        {
            Console.Write($"[{temp.Valor}]->");
            temp = temp.Siguiente;
        }
        Console.Write("null\n");
    }

    public void Reemplazar(int indice, T valor)
    {
        if(indice >= 0 && indice < _cantidad - 1)
        {
            NodoSimple<T> temp = _inicio;
            int indiceActual = 0;
            while(indiceActual != indice)
            {
                indiceActual+=1;
                temp = temp.Siguiente;
            }
            temp.Valor = valor;
        }
    }

    public void EliminarInicio()
    {
        if(EsVacio() || _cantidad == 1)
        {
            _inicio = null;
        } else
        {
            _inicio = _inicio.Siguiente;
        }
        _cantidad-=1;
    }
    public void EliminarFin()
    {
        if(EsVacio() || _cantidad == 1)
        {
            _inicio = null;
        } else
        {
            NodoSimple<T> temp = _inicio;
            while(temp.Siguiente.Siguiente is not null)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = null;
        }
        _cantidad-=1;
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
            NodoSimple<T> temp = _inicio;
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

    public int BuscarElemento(T valor)
    {
        int indice = 0;
        bool encontrado = false;
        NodoSimple<T> temp = _inicio;
        while(temp is not null)
        {
            if(temp.Valor.Equals(valor))
            {
                encontrado = true;
                break;
            }
            indice+=1;
            temp = temp.Siguiente;
        }
        if(encontrado)
            return indice;
        else
            return -1;
    }
}
