using System;

namespace AppListaCircular.Interfaces;

public interface IListaEnlazadaCircular<T>
{
    void InsertarInicio(T valor);
    void InsertarFin(T valor);
    void InsertarEn(T valor, int indice);
    bool EsVacio();
    int BuscarElemento(T valor);
    int Cantidad();
    void MostrarElementos();
    void Reemplazar(int indice, T valor);
    void EliminarInicio();
    void EliminarFin();
    void EliminarEn(int indice);
}
