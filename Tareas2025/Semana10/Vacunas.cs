public class CampaniaVacunacionTarea
{
    public static void run()
    {
        // Generador de números aleatorios
        System.Random random = new System.Random();

        // Conjunto con 500 ciudadanos ficticios
        System.Collections.Generic.HashSet<string> todos = new System.Collections.Generic.HashSet<string>();
        for (int i = 1; i <= 500; i++)
            todos.Add("Ciudadano " + i);

        // Conjunto de vacunados con Pfizer (75 aleatorios)
        System.Collections.Generic.HashSet<string> pfizer = new System.Collections.Generic.HashSet<string>();
        while (pfizer.Count < 75)
            pfizer.Add("Ciudadano " + random.Next(1, 501));

        // Conjunto de vacunados con AstraZeneca (75 aleatorios)
        System.Collections.Generic.HashSet<string> astra = new System.Collections.Generic.HashSet<string>();
        while (astra.Count < 75)
            astra.Add("Ciudadano " + random.Next(1, 501));

        // Conjunto: solo Pfizer
        System.Collections.Generic.HashSet<string> soloPfizer = new System.Collections.Generic.HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astra);

        // Conjunto: solo AstraZeneca
        System.Collections.Generic.HashSet<string> soloAstra = new System.Collections.Generic.HashSet<string>(astra);
        soloAstra.ExceptWith(pfizer);

        // Conjunto: ambas dosis
        System.Collections.Generic.HashSet<string> ambas = new System.Collections.Generic.HashSet<string>(pfizer);
        ambas.IntersectWith(astra);

        // Conjunto: no vacunados
        System.Collections.Generic.HashSet<string> vacunados = new System.Collections.Generic.HashSet<string>(pfizer);
        vacunados.UnionWith(astra);
        System.Collections.Generic.HashSet<string> noVacunados = new System.Collections.Generic.HashSet<string>(todos);
        noVacunados.ExceptWith(vacunados);

        // Resultados en consola
        System.Console.WriteLine("=== Resultados de la campaña de vacunación ===\n");
        System.Console.WriteLine("Vacunados solo Pfizer: " + soloPfizer.Count);
        System.Console.WriteLine("Vacunados solo AstraZeneca: " + soloAstra.Count);
        System.Console.WriteLine("Vacunados con ambas dosis: " + ambas.Count);
        System.Console.WriteLine("No vacunados: " + noVacunados.Count);

        // (Opcional) Mostrar listados completos
        System.Console.WriteLine("\n--- Lista de no vacunados ---");
        foreach (var c in noVacunados) System.Console.WriteLine(c);

        System.Console.WriteLine("\n--- Lista de ambas dosis ---");
        foreach (var c in ambas) System.Console.WriteLine(c);

        System.Console.WriteLine("\n--- Lista de solo Pfizer ---");
        foreach (var c in soloPfizer) System.Console.WriteLine(c);

        System.Console.WriteLine("\n--- Lista de solo AstraZeneca ---");
        foreach (var c in soloAstra) System.Console.WriteLine(c);
    }
}
