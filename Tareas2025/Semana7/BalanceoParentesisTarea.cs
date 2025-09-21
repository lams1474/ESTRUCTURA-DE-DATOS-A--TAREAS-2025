public class BalanceoParentesisTarea
{
    public static void run()
    {
        // Leemos la expresión desde la entrada estándar
        System.Console.WriteLine("ingrese la expresion: ");
        string expr = System.Console.ReadLine();

        // Pila para almacenar los símbolos de apertura
        var pila = new System.Collections.Generic.Stack<char>();

        foreach (char c in expr)
        {
            // Si es símbolo de apertura lo apilamos
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                // Si encontramos un cierre pero la pila está vacía => no balanceado
                if (pila.Count == 0)
                {
                    System.Console.WriteLine("Formula no balanceada.");
                    return;
                }
                // Sacamos el último de la pila y comprobamos correspondencia
                char top = pila.Pop();
                if (!Corresponden(top, c))
                {
                    System.Console.WriteLine("Formua no balaneada.");
                    return;
                }
            }
            // otros caracteres se ignoran
        }
        // Al final debe quedar la pila vacía para estar balanceado
        if (pila.Count == 0)
            System.Console.WriteLine("Formula balanceada.");
        else
            System.Console.WriteLine("Formula no balanceada");
    }
    // Método auxiliar: devuelve true si 'apertura' y 'cierre' son pares correctos
    static bool Corresponden(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }
}