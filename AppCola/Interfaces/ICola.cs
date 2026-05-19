using System;

namespace AppCola.Interfaces;

public interface ICola<T>
{
    void Enqueue(T valor);
    T Dequeue();
    bool IsEmpty();
    bool IsFull();
    int Count();
    T Peek();
}
