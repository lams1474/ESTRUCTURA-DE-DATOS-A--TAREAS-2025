public class Semana5_Structs
{
    public static void run()
    {
        Console.WriteLine("=== Semana 5: Structs ===");

        Estudiante est = new Estudiante("Luis", 20, 17.5);
        Console.WriteLine("Nombre: " + est.Nombre + ", Edad: " + est.Edad + ", Nota: " + est.Nota);
    }

    public struct Estudiante
    {
        public string Nombre;
        public int Edad;
        public double Nota;

        public Estudiante(string nombre, int edad, double nota)
        {
            Nombre = nombre;
            Edad = edad;
            Nota = nota;
        }
    }
}
