public class Ejercicio7
{
        public static void run()
    {
        System.Console.WriteLine("===== EJERCICIO 7: ABECEDARIO SIN MÚLTIPLOS DE 3 =====");

        // Creamos una lista con el abecedario
        List<char> abecedario = new List<char>();
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            abecedario.Add(letra);
        }

        // Creamos una nueva lista para guardar las letras que no están en múltiplos de 3
        List<char> resultado = new List<char>();

        for (int i = 0; i < abecedario.Count; i++)
        {
            // En C#, los índices empiezan en 0, por eso usamos (i+1)
            if ((i + 1) % 3 != 0) // Solo agregamos las letras que NO están en posiciones múltiplos de 3
            {
                resultado.Add(abecedario[i]);
            }
        }

        // Mostramos la lista resultante
        System.Console.WriteLine("\nAbecedario resultante:");
        foreach (char letra in resultado)
        {
            System.Console.Write(letra + " ");
        }

        System.Console.WriteLine("\n\nEjercicio 7 ejecutado correctamente.");
    }
}
