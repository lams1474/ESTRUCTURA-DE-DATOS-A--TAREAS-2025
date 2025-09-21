public class TraductorBasico
{
    // MÉTODO run() — Obligatorio al inicio según plantilla del docente
    public static void run()
    {
        Console.WriteLine("=== TRADUCTOR BÁSICO INGLÉS-ESPAÑOL ===\n");

        // Diccionario: clave = inglés, valor = español
        Dictionary<string, string> diccionario = new Dictionary<string, string>();

        // Palabras iniciales (mínimo 10, aquí hay 21)
        diccionario.Add("time", "tiempo");
        diccionario.Add("person", "persona");
        diccionario.Add("year", "año");
        diccionario.Add("way", "camino");
        diccionario.Add("day", "día");
        diccionario.Add("thing", "cosa");
        diccionario.Add("man", "hombre");
        diccionario.Add("world", "mundo");
        diccionario.Add("life", "vida");
        diccionario.Add("hand", "mano");
        diccionario.Add("part", "parte");
        diccionario.Add("child", "niño/a");
        diccionario.Add("eye", "ojo");
        diccionario.Add("woman", "mujer");
        diccionario.Add("place", "lugar");
        diccionario.Add("work", "trabajo");
        diccionario.Add("week", "semana");
        diccionario.Add("case", "caso");
        diccionario.Add("point", "punto");
        diccionario.Add("government", "gobierno");
        diccionario.Add("company", "empresa");

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    TraducirFrase(diccionario);
                    break;
                case "2":
                    AgregarPalabra(diccionario);
                    break;
                case "0":
                    Console.WriteLine("\nGracias por usar el traductor! Hasta pronto.");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Por favor, seleccione 1, 2 o 0.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                //Console.ReadKey();
                // Console.Clear(); // Opcional: coméntalo si da error
            }
        }
    }

    // 👇 Método para traducir frase — SIN LINQ, estilo docente
    private static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese una frase en ESPAÑOL: ");
        string frase = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("La frase no puede estar vacía.");
            return;
        }

        string[] palabras = frase.Split(' ');
        Console.Write("\nTraducción: ");

        foreach (string palabra in palabras)
        {
            // Buscar si la palabra EXACTA está como valor en el diccionario
            bool encontrada = false;
            foreach (var kvp in diccionario)
            {
                if (kvp.Value == palabra) // Comparación exacta (sin ignorar mayúsculas)
                {
                    Console.Write(kvp.Key + " "); // Imprimir clave (inglés)
                    encontrada = true;
                    break;
                }
            }

            if (!encontrada)
            {
                Console.Write(palabra + " "); // Dejar palabra original
            }
        }

        Console.WriteLine(); // Salto de línea final
    }

    // 👇 Método para agregar palabra — estilo docente (con try-catch)
    private static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\n Ingrese la palabra en INGLÉS: ");
        string palabraIngles = Console.ReadLine();

        Console.Write(" Ingrese la traducción en ESPAÑOL: ");
        string palabraEspanol = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(palabraIngles) || string.IsNullOrWhiteSpace(palabraEspanol))
        {
            Console.WriteLine(" Las palabras no pueden estar vacías.");
            return;
        }

        try
        {
            diccionario.Add(palabraIngles, palabraEspanol);
            Console.WriteLine($" Palabra agregada: {palabraIngles} → {palabraEspanol}");
        }
        catch (ArgumentException)
        {
            Console.WriteLine($" Error: La palabra '{palabraIngles}' ya existe en el diccionario.");
        }
    }
}