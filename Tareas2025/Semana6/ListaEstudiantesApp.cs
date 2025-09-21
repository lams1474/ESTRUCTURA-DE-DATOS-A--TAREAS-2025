public class ListaEstudiantesApp
{
    // MÉTODO run() — Obligatorio al inicio
    public static void run()
    {
        Console.WriteLine("=== Lista Enlazada de Estudiantes ===\n");

        ListaEnlazadaEstudiantes registro = new ListaEnlazadaEstudiantes();

        registro.AgregarEstudiante(new EstudianteNodo("0101", "Luis", "Maigua", "luis@correo.com", 8.5));
        registro.AgregarEstudiante(new EstudianteNodo("0102", "Ana", "Pérez", "ana@correo.com", 6.4));
        registro.AgregarEstudiante(new EstudianteNodo("0103", "Carlos", "Vera", "carlos@correo.com", 9.2));

        Console.WriteLine("Estudiantes registrados:");
        registro.MostrarEstudiantes();

        Console.WriteLine($"\nTotal aprobados: {registro.TotalAprobados()}");
        Console.WriteLine($"Total reprobados: {registro.TotalReprobados()}");

        Console.WriteLine("\nBuscar por cédula (0102):");
        var estudiante = registro.BuscarPorCedula("0102");
        if (estudiante != null)
            Console.WriteLine($"Encontrado: {estudiante.GetNombre()} {estudiante.GetApellido()} - Nota: {estudiante.GetNota()}");
        else
            Console.WriteLine("Estudiante no encontrado.");

        Console.WriteLine("\nEliminando estudiante con cédula 0102...");
        registro.EliminarPorCedula("0102");

        Console.WriteLine("\nEstudiantes actualizados:");
        registro.MostrarEstudiantes();

        Console.WriteLine("\nEjercicio ListaEstudiantesApp ejecutado correctamente.");
    }
}

// CLASE EstudianteNodo — ¡RENOMBRADA para evitar conflicto!
public class EstudianteNodo
{
    // run() al inicio
    public static void run()
    {
        Console.WriteLine("=== CLASE EstudianteNodo (NODO DE LISTA ENLAZADA) ===");
        Console.WriteLine("Campos: Cedula, Nombre, Apellido, Correo, Nota, Siguiente.");
        Console.WriteLine("Se usa como nodo en ListaEnlazadaEstudiantes.");
        Console.WriteLine("Clase lista para ser usada en estructuras de datos.");
    }

    // Campos privados
    private string cedula;
    private string nombre;
    private string apellido;
    private string correo;
    private double nota;
    public EstudianteNodo? Siguiente; // Puede ser público — parte de la estructura

    // Constructor
    public EstudianteNodo(string cedula, string nombre, string apellido, string correo, double nota)
    {
        this.cedula = cedula;
        this.nombre = nombre;
        this.apellido = apellido;
        this.correo = correo;
        this.nota = nota;
        this.Siguiente = null;
    }

    // Getters
    public string GetCedula() => cedula;
    public string GetNombre() => nombre;
    public string GetApellido() => apellido;
    public string GetCorreo() => correo;
    public double GetNota() => nota;

    public void SetNota(double nuevaNota) => this.nota = nuevaNota;
}

// CLASE ListaEnlazadaEstudiantes — ¡También renombrada para claridad!
public class ListaEnlazadaEstudiantes
{
    // run() al inicio
    public static void run()
    {
        ListaEstudiantesApp.run(); // Reutiliza lógica
    }

    // Campo privado: cabeza de la lista
    private EstudianteNodo? head;

    // Agregar estudiante: aprobados al inicio, reprobados al final
    public void AgregarEstudiante(EstudianteNodo estudiante)
    {
        if (estudiante.GetNota() >= 7)
        {
            estudiante.Siguiente = head;
            head = estudiante;
        }
        else
        {
            if (head == null)
            {
                head = estudiante;
            }
            else
            {
                EstudianteNodo actual = head;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = estudiante;
            }
        }
    }

    // Buscar por cédula
    public EstudianteNodo? BuscarPorCedula(string cedula)
    {
        EstudianteNodo? actual = head;
        while (actual != null)
        {
            if (actual.GetCedula() == cedula)
                return actual;
            actual = actual.Siguiente;
        }
        return null;
    }

    // Eliminar por cédula
    public void EliminarPorCedula(string cedula)
    {
        if (head == null) return;

        if (head.GetCedula() == cedula)
        {
            head = head.Siguiente;
            return;
        }

        EstudianteNodo? actual = head;
        while (actual.Siguiente != null && actual.Siguiente.GetCedula() != cedula)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }

    // Contar aprobados
    public int TotalAprobados()
    {
        int count = 0;
        EstudianteNodo? actual = head;
        while (actual != null)
        {
            if (actual.GetNota() >= 7)
                count++;
            actual = actual.Siguiente;
        }
        return count;
    }

    // Contar reprobados
    public int TotalReprobados()
    {
        int count = 0;
        EstudianteNodo? actual = head;
        while (actual != null)
        {
            if (actual.GetNota() < 7)
                count++;
            actual = actual.Siguiente;
        }
        return count;
    }

    // Mostrar todos los estudiantes
    public void MostrarEstudiantes()
    {
        EstudianteNodo? actual = head;
        if (actual == null)
        {
            Console.WriteLine("   (No hay estudiantes registrados)");
            return;
        }

        while (actual != null)
        {
            Console.WriteLine($"{actual.GetCedula()} - {actual.GetNombre()} {actual.GetApellido()} - {actual.GetCorreo()} - Nota: {actual.GetNota()}");
            actual = actual.Siguiente;
        }
    }
}