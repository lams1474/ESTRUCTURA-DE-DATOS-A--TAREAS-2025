public class Ejercicio3
{
    
    public static void run()
    {
        System.Console.WriteLine("===== EJERCICIO 3: NOTAS DE ASIGNATURAS =====");

        // Lista de asignaturas
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Etica" };

        // Array para almacenar las notas
        double[] notas = new double[asignaturas.Length];

        // Pedimos al usuario las notas de cada asignatura
        for (int i = 0; i < asignaturas.Length; i++)
        {
            System.Console.Write($"Ingrese la nota de {asignaturas[i]}: ");
            notas[i] = double.Parse(System.Console.ReadLine());
        }

        // Mostramos las asignaturas con sus notas
        System.Console.WriteLine("\nResultados:");
        for (int i = 0; i < asignaturas.Length; i++)
        {
            System.Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }

        System.Console.WriteLine("\nEjercicio 3 ejecutado correctamente.");
    }
}
