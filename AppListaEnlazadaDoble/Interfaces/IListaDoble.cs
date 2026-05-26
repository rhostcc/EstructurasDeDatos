using System;

namespace AppListaEnlazadaDoble.Interfaces;

public interface IListaDoble<T>
{
    void AgregarFinal(T Valor);
    void AgregarInicio(T Valor);
    void MostrarDerecho();
    void MostrarRevez();
    void EliminarNodo(T valor);
    bool EsVacio();
    // Para completar
    void AgreagarEn(int indice, T valor);
    void EliminarInicio();
    void EliminarFin();
    void EliminarEn(int indice);
}
