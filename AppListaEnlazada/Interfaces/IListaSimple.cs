using System;

namespace AppListaEnlazada.Interfaces;

public interface IListaSimple<T>
{
    void InsertarInicio(T valor);
    void InsertarFin(T valor);
    bool EsVacio();
    int BuscarElemento();
    int Cantidad();
    void MostrarElementos();
    void Reemplazar(int indice, T valor);
}
