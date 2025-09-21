public class TiposdeDatos
{
    public static void run()
    {
        int edad = 51; // variable entero (guarda numero entero)
        float salario = 1000.52f; // variable flotante con decimales (se usa una f al final)
        double varios = -500.52;
        char inicial = 'L'; // variable caracter, guarda una sola letra
        bool estudiante = true; // variable booleano, solo puede ser true o false

        System.Console.WriteLine("Edad: " + edad);  // imprimir la edad
        System.Console.WriteLine("Salario: " + salario);  // imprimi salario
        System.Console.WriteLine("Varios:" + varios);  // imprimi varios
        System.Console.WriteLine("Inicial: " + inicial); // imprimi el caracter inicial
        System.Console.WriteLine("¿Es estudiante?: " + estudiante);  // imprimi el valor booleano

        // casting (conversion de tipos)
        double salarioDoble = (double)salario; // convierte el float a double
        System.Console.WriteLine("Salario en double: " + salarioDoble);  // imprime el salario convertido 
    }

}