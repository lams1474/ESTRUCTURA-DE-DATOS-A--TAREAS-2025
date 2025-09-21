public class Circulo
{
    // Método de ejecución en consola
    public static void run()
    {
        Console.Write(" ingrese el radio del circulo: ");
        double r = double.Parse(Console.ReadLine());  // Lee el radio desde consola
        Circulo c = new Circulo(r); // Crea un objeto Circulo con ese radio

        System.Console.WriteLine("Area: " + c.CalcularArea());  // Muestra el área
        System.Console.WriteLine("Perimetro: " + c.CalcularPerimetro());    // Muestra el perímetro

    }
    
    // Atributo encapsulador
    private double radio;

    // Constructor
    public Circulo(double r)
    {
        radio = r;
    }
    // metodo logico
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}