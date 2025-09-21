public class TorresDeHanoiTarea
{
    public static void run()
    {
        System.Console.Write("Número de discos (ej: 3): ");
        string linea = System.Console.ReadLine();
        if (!int.TryParse(linea, out int n) || n <= 0)
        {
            System.Console.WriteLine("Número inválido. Use un entero positivo.");
            return;
        }

        var A = new System.Collections.Generic.Stack<int>(); // origen
        var B = new System.Collections.Generic.Stack<int>(); // auxiliar
        var C = new System.Collections.Generic.Stack<int>(); // destino

        // Inicializar A: disco más grande abajo (n) ... disco más pequeño arriba (1)
        for (int i = n; i >= 1; i--) A.Push(i);

        System.Console.WriteLine("\nEstado inicial:");
        ImprimirPilas(A, B, C);

        // Resolver recursivamente (cada movimiento pop/push en las pilas)
        MoverDiscos(n, A, C, B, "A", "C", "B", A, B, C);

        System.Console.WriteLine("\nEstado final:");
        ImprimirPilas(A, B, C);
    }

    // Mover n discos desde 'origen' a 'destino' usando 'auxiliar'
    static void MoverDiscos(int n,
        System.Collections.Generic.Stack<int> origen,
        System.Collections.Generic.Stack<int> destino,
        System.Collections.Generic.Stack<int> auxiliar,
        string nombreOrigen, string nombreDestino, string nombreAux,
        System.Collections.Generic.Stack<int> A,
        System.Collections.Generic.Stack<int> B,
        System.Collections.Generic.Stack<int> C)
    {
        if (n == 1)
        {
            int disco = origen.Pop();     // quitar disco de la torre origen
            destino.Push(disco);          // poner disco en la torre destino
            System.Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            ImprimirPilas(A, B, C);      // mostrar estado tras el movimiento
            return;
        }

        // Mover n-1 discos de origen a auxiliar (dejando el mayor en origen)
        MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAux, nombreDestino, A, B, C);

        // Mover el disco restante (el mayor del subproblema) al destino
        int top = origen.Pop();
        destino.Push(top);
        System.Console.WriteLine($"Mover disco {top} de {nombreOrigen} a {nombreDestino}");
        ImprimirPilas(A, B, C);

        // Mover los n-1 discos desde auxiliar al destino
        MoverDiscos(n - 1, auxiliar, destino, origen, nombreAux, nombreDestino, nombreOrigen, A, B, C);
    }

    // Muestra el contenido de las pilas (tope primero)
    static void ImprimirPilas(System.Collections.Generic.Stack<int> A,
                             System.Collections.Generic.Stack<int> B,
                             System.Collections.Generic.Stack<int> C)
    {
        System.Console.WriteLine("A: [" + string.Join(", ", A.ToArray()) + "]");
        System.Console.WriteLine("B: [" + string.Join(", ", B.ToArray()) + "]");
        System.Console.WriteLine("C: [" + string.Join(", ", C.ToArray()) + "]");
        System.Console.WriteLine();
    }
}
