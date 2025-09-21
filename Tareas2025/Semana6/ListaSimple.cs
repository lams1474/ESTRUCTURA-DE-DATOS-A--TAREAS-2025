using System;

public class ListaSimple
{
       public static void run()
    {
        Console.WriteLine("===== EJERCICIO LISTA SIMPLE =====");

        // Creamos la lista y agregamos nodos
        ListaSimple lista = new ListaSimple();
        lista.InsertarInicio(10);
        lista.InsertarInicio(20);
        lista.InsertarInicio(30);
        lista.InsertarInicio(40);

        // Mostrar lista original
        Console.WriteLine("\nLista original:");
        lista.Mostrar();

        // Invertir lista
        lista.Invertir();

        // Mostrar lista invertida
        Console.WriteLine("\nLista invertida:");
        lista.Mostrar();

        Console.WriteLine("\nEjercicio lista simple ejecutado correctamente.");
    }

    // =======================
    // Clase Nodo
    // =======================
    private class Nodo
    {
        public int Dato;
        public Nodo? Siguiente;

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // =======================
    // Atributo de la lista
    // =======================
    private Nodo? head;

    // =======================
    // Métodos de lógica
    // =======================

    // Inserta un nodo al inicio
    public void InsertarInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = head;
        head = nuevo;
    }

    // Muestra todos los elementos de la lista
    public void Mostrar()
    {
        Nodo? actual = head;
        while (actual != null)
        {
            Console.Write("[" + actual.Dato + "] -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // Invierte el orden de la lista
    public void Invertir()
    {
        Nodo? anterior = null;
        Nodo? actual = head;
        Nodo? siguiente;

        while (actual != null)
        {
            siguiente = actual.Siguiente;  // Guardamos el siguiente
            actual.Siguiente = anterior;   // Invertimos el puntero
            anterior = actual;             // Avanzamos anterior
            actual = siguiente;            // Avanzamos actual
        }

        head = anterior; // Nuevo inicio de la lista
    }
}
