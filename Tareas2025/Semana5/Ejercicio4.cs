public class Ejercicio4
{
    
    public static void run()
    {
        System.Console.WriteLine("===== EJERCICIO 4: LOTERÍA PRIMITIVA =====");

        // Pedimos al usuario cuántos números ganadores quiere ingresar
        System.Console.Write("¿Cuántos números ganadores desea ingresar?: ");
        int cantidad = int.Parse(System.Console.ReadLine());

        // Creamos un array para almacenar los números
        int[] numeros = new int[cantidad];

        // Pedimos los números al usuario
        for (int i = 0; i < cantidad; i++)
        {
            System.Console.Write($"Ingrese el número ganador #{i + 1}: ");
            numeros[i] = int.Parse(System.Console.ReadLine());
        }

        // Ordenamos los números de menor a mayor
        Array.Sort(numeros);

        // Mostramos los números ordenados
        System.Console.WriteLine("\nNúmeros ganadores ordenados de menor a mayor:");
        foreach (int n in numeros)
        {
            System.Console.WriteLine(n);
        }

        System.Console.WriteLine("\nEjercicio 4 ejecutado correctamente.");
    }
}
