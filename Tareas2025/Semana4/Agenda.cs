public class Agenda
{
    public static void run()
    {
        System.Console.WriteLine("===== AGENDA DE TURNOS CLINICA =====");

        // Creamos un array de pasientes
        Paciente[] pacientes = new Paciente[3];
        pacientes[0] = new Paciente("01010101", "Luis", "Maigua", 21, "Consulta general");
        pacientes[1] = new Paciente("02020202", "Piedad", "Cango", 30, "Odontologia");
        pacientes[2] = new Paciente("03030303", "Juan", "Torres", 42, "Pediatria");

        // Creamos un array de turnos
        Turno[] turnos = new Turno[pacientes.Length];
        for (int i = 0; i < pacientes.Length; i++)
        {
            turnos[i] = new Turno(i + 1, pacientes[i]);
        }

        // Mostrar la agenda
        System.Console.WriteLine("listado de turnos: ");
        foreach (Turno t in turnos)
        {
            System.Console.WriteLine($"Turno {t.Numero}: {t.PacienteAsignado.Nombre} {t.PacienteAsignado.Apellido}, {t.PacienteAsignado.Edad} años, Motivo: {t.PacienteAsignado.Motivo}");
        }

        System.Console.WriteLine("Agenda ejecutada correctamente.");
    }

        
    // Record Paciente
    public record Paciente(string Cedula, string Nombre, string Apellido, int Edad, string Motivo);

    // Struct Turno
    public struct Turno
    {
        public int Numero;  // numero de turno 
        public Paciente PacienteAsignado;  // paciente que ocupa el turno

        public Turno(int numero, Paciente paciente)
        {
            Numero = numero;
            PacienteAsignado = paciente;
        }

    }

}