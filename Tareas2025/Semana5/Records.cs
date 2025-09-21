public class Semana6_Records
{
    public static void run()
    {
        Console.WriteLine("=== Semana 6: Records ===");

        Estudiante est = new Estudiante("Luis", 20, 17.5);
        Console.WriteLine("Estudiante: " + est.Nombre + " - Edad: " + est.Edad + " - Nota: " + est.Nota);
    }

    public record Estudiante(string Nombre, int Edad, double Nota);
}
