public class Ejercicio10
{
        public static void run()
    {
        System.Console.WriteLine("===== EJERCICIO 10: PRECIOS MÍNIMO Y MÁXIMO =====");

        // Creamos una lista con los precios
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

        // Obtenemos el precio mínimo y máximo usando LINQ
        int minimo = precios.Min();
        int maximo = precios.Max();

        // Mostramos los resultados
        System.Console.WriteLine("\nLista de precios:");
        foreach (int p in precios)
        {
            System.Console.Write(p + " ");
        }

        System.Console.WriteLine($"\n\nEl precio más bajo es: {minimo}");
        System.Console.WriteLine($"El precio más alto es: {maximo}");

        System.Console.WriteLine("\nEjercicio 10 ejecutado correctamente.");
    }
}
