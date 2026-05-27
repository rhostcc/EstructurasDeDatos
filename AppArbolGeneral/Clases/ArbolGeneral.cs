using System;
using AppArbolGeneral.Interfaces;

namespace AppArbolGeneral.Clases;

public class ArbolGeneral<T> : IArbolGeneral<T>
{
    public NodoGeneral<T> Raiz;
    public ArbolGeneral(T valor)
    {
        Raiz = new NodoGeneral<T>(valor);
    }
    public bool AgregarNodo(T valorPadre, T nuevoValor)
    {
        NodoGeneral<T> Padre = BuscarNodo(Raiz, valorPadre);
        if(Padre is null)
            return false;
        var nuevoNodo = new NodoGeneral<T>(nuevoValor);
        Padre.Hijos.Add(nuevoNodo);
        //Padre.Hijos.Add(new NodoGeneral<T>(nuevoValor));
        return true;
    }

    public NodoGeneral<T> BuscarNodo(NodoGeneral<T> nodo, T valor)
    {
        if(nodo == null) return null;

        if(nodo.Valor.Equals(valor)) return nodo;

        foreach (var hijo in nodo.Hijos)
        {
            NodoGeneral<T> encontrado = BuscarNodo(hijo, valor);
            if(encontrado is not null)
                return encontrado;
        }
        return null;
    }

    public bool EliminarNodo(T valor)
    {
        if(Raiz is null) return false;

        if(Raiz.Valor.Equals(valor))
        {
            Raiz = null;
            return true;
        }
        return EliminarRecursivo(Raiz, valor);
    }

    private bool EliminarRecursivo(NodoGeneral<T> nodo, T valor)
    {
        foreach (var hijo in nodo.Hijos)
        {
            if(hijo.Valor.Equals(valor))
            {
                nodo.Hijos.Remove(hijo);
                return true;
            }
            if(EliminarRecursivo(hijo, valor))
                return true;
        }
        return false;
    }

    public void Mostrar(NodoGeneral<T> nodo, string indent = "")
    {
        if(nodo is null) return;
        Console.WriteLine($"{indent}- {nodo.Valor}");
        foreach (var hijo in nodo.Hijos)
        {
            Mostrar(hijo, indent + "  ");
        }
    }

    public void MostrarConDecoradores()
    {
        MostrarRecursivo(Raiz, "", false);
    }

    private void MostrarRecursivo(NodoGeneral<T> nodo, string prefijo, bool esUltimo)
    {
        Console.WriteLine(prefijo + (esUltimo ? "└───" : "├───") + nodo.Valor);
        for (int i = 0; i < nodo.Hijos.Count; i++)
        {
            bool esUltimoHijo = i == nodo.Hijos.Count - 1;
            string nuevoPrefijo = prefijo + (esUltimo ? "  " : "│  ");
            MostrarRecursivo(nodo.Hijos[i], nuevoPrefijo, esUltimoHijo);
        }
    }
}
