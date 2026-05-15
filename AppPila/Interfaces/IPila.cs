using System;

namespace AppPila.Interfaces;

public interface IPila<T>
{
    void Push(T elemento);
    T Pop();
    T Peek();
    int Size();
    bool IsEmpty();
    bool IsFull();
}
