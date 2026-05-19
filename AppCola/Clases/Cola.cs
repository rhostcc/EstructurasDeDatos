using System;
using AppCola.Interfaces;

namespace AppCola.Clases;

public class Cola<T> : ICola<T>
{
    private T[] _elementos;
    private int _inicio;
    private int _fin;
    private int _tamano;
    private int _cantidad;
    public Cola(int tamano = 5)
    {
        _tamano = tamano;
        _elementos = new T[tamano];
        _inicio = 0;
        _fin = 0;
        _cantidad = 0;
    }

    public T Dequeue()
    {
        if(IsEmpty())
            throw new Exception("La estructura esta vacia");
        T valor = _elementos[_inicio];
        _inicio++;
        if(_inicio == _tamano)
            _inicio=0;
        _cantidad--;
        return valor;
    }

    public void Enqueue(T valor)
    {
        if(IsFull())
            throw new Exception("La estructura esta llena");
        _elementos[_fin] = valor;
        _fin++;
        if(_fin == _tamano)
            _fin=0;
        _cantidad++;
    }

    public bool IsEmpty()
    {
        return _cantidad == 0;
    }

    public bool IsFull()
    {
        return _cantidad == _tamano;
    }

    public int Count()
    {
        return _cantidad;
    }
    public T Peek()
    {
        if(IsEmpty())
            throw new Exception("La estructura esta vacia");
        return _elementos[_inicio];
    }
}
