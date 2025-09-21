public class Rectangulo
{
    public static void run()     // Método de ejecución en consola
    {
        Console.Write("ingrese el ancho del rectangulo: ");
        double a = double.Parse(Console.ReadLine()); // Lee el ancho
        Console.Write("ingrese el alto del rectangulo: ");
        double h = double.Parse(Console.ReadLine());    // lee el alto

        Rectangulo r = new Rectangulo(a, h);   // Crea un objeto Rectangulo con esos valores

        System.Console.WriteLine("Area: " + r.CalcularArea());
        System.Console.WriteLine("Perimetro: " + r.CalcularPerimetro());
    }
    
    // Atributos encapsulados
    private double ancho;
    private double alto;

    // constructor 
    public Rectangulo(double a, double h)
    {
        ancho = a;
        alto = h;
    }

    // Métodos de lógica
    public Double CalcularArea()
    {
        return ancho * alto;
    }
    
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto); 
    }
}