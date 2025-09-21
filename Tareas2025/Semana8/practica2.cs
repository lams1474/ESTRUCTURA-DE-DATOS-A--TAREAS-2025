public class ColaAsientosTarea
{
    // Clase interna que representa a una persona
    class Persona
    {
        public string Nombre { get; set; }
        public int NumeroTurno { get; set; }

        public Persona(string nombre, int turno)
        {
            Nombre = nombre;
            NumeroTurno = turno;
        }
    }

    // Clase interna que gestiona la cola de asientos
    class ColaAsientos
    {
        private System.Collections.Generic.Queue<Persona> cola;
        private int capacidadMaxima;

        public ColaAsientos(int capacidad)
        {
            capacidadMaxima = capacidad;
            cola = new System.Collections.Generic.Queue<Persona>();
        }

        public bool EncolarPersona(Persona persona)
        {
            if (cola.Count >= capacidadMaxima)
            {
                System.Console.WriteLine("\nNo se pueden asignar más asientos. Cupo lleno.");
                return false;
            }

            cola.Enqueue(persona);
            System.Console.WriteLine($"Turno {persona.NumeroTurno}: {persona.Nombre} ha sido encolado.");
            return true;
        }

        public void MostrarAsientosAsignados()
        {
            System.Console.WriteLine("\nLista de personas con asiento asignado:");
            foreach (var persona in cola)
            {
                System.Console.WriteLine($"Turno {persona.NumeroTurno}: {persona.Nombre}");
            }
        }

        public int TotalAsignados()
        {
            return cola.Count;
        }
    }

    // Método requerido en la plantilla
    public static void run()
    {
        ColaAsientos cola = new ColaAsientos(30);
        int turno = 1;

        System.Console.WriteLine("=== Sistema de Asignación de 30 Asientos ===\n");

        while (true)
        {
            System.Console.Write("Ingrese el nombre de la persona (o 'fin' para terminar): ");
            string nombre = System.Console.ReadLine()?.Trim() ?? "";

            if (nombre.ToLower() == "fin")
                break;

            Persona p = new Persona(nombre, turno);
            bool encolado = cola.EncolarPersona(p);
            if (encolado) turno++;

            if (cola.TotalAsignados() == 30)
            {
                System.Console.WriteLine("\nSe han asignado los 30 asientos disponibles.");
                break;
            }
        }

        cola.MostrarAsientosAsignados();
        System.Console.WriteLine("\nTotal de personas atendidas: " + cola.TotalAsignados());
    }
}
