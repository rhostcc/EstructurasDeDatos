using System;
using AppPila.Interfaces;

namespace AppPila.Clases;

public class Pila<T> : IPila<T>
{
    private T[] _elementos;
    private int _cima;
    private int _longitud;
    private int _cantidad;
    public Pila(int longitud = 5)
    {
        _longitud = longitud;
        _elementos = new T[longitud];
        _cima = -1;
        _cantidad = 0;
    }
    public bool IsEmpty()
    {
        return _cima == -1;
    }

    public bool IsFull()
    {
        return _longitud == _cantidad;
    }

    public T Peek()
    {
        if(IsEmpty()) throw new NullReferenceException("La pila esta vacia");
        return _elementos[_cima];
    }

    public T Pop()
    {
        if(IsEmpty())
            throw new Exception("La pila esta vacia");
        return _elementos[_cima--];
        
    }

    public void Push(T elemento)
    {
        if(IsFull())
            throw new Exception("La pila esta llena");
        _cima++;
        _elementos[_cima] = elemento;
        _cantidad++;
    }

    public int Size()
    {
        return _cantidad;
    }
}
