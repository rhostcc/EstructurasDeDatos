using System;

namespace AppListaDobleCircular.Interfaces;

public interface IListaDobleCircular<T>
{
    void AgregarInicio(T valor);
    void AgregarFin(T valor);
    void EliminarEn(int indice);
    void RecorrerAdelante();
    void RecorrerAtras();
    bool EsVacio();
}
