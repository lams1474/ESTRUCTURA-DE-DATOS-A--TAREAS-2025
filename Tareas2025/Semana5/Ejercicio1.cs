public class Ejercicio1
{
    public static void run()
    {
        System.Console.WriteLine("==== EJERCICIO 1: LISTA DE ASIGNATURAS ====");

        // Creamos un array de asignaturas
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        // Mostramos las asignaturas por pantalla
        System.Console.WriteLine("Asignaturas del curso: ");
        foreach (string materia in asignaturas)
        {
            System.Console.WriteLine(materia);
        }

        System.Console.WriteLine("Ejercicio 1 ejecutado correctamente.");
        
    }

}