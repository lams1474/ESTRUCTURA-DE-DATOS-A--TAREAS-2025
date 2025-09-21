public class Estudiante
{
    public static void run()
    {
        System.Console.WriteLine("===== CLASE ESTUDIANTE =====");

        // CREAMOS LA INSTANCIA DE ESTUDIANTE 
        Estudiante est = new Estudiante("1474", "Luis Alfonso", "Maigua Sisalema", "Calle rafael morales pasaje A", new string[] { "0996813865", "0960698503", "0999999999" });

        // mostrar los datos usando getters
        System.Console.WriteLine("Codigo: " + est.getCodigo());
        System.Console.WriteLine("Nombre: " + est.getNombre());
        System.Console.WriteLine("Apellido:" + est.getApellido());
        System.Console.WriteLine("Direccion: " + est.getDireccion());
        System.Console.WriteLine("Telefonos:" + string.Join(", ", est.getTelefono()));

        System.Console.WriteLine("ejercicio estudiante ejecutado correctamente.");
    }

    // Campos privados 
    private string codigo;
    private string nombre;
    private string apellido;
    private string direccion;
    private string[] telefono;

    // constructor 
    public Estudiante(string _codigo, string _nombre, string _apellido, string _direccion, string[] _telefonos)
    {
        this.codigo = _codigo;
        this.nombre = _nombre;
        this.apellido = _apellido;
        this.direccion = _direccion;
        this.telefono = _telefonos;
    }

    // getters acceso controlado a los campos privados
    public string getCodigo() => codigo;
    public string getNombre() => nombre;
    public string getApellido() => apellido;
    public string getDireccion() => direccion;
    public string[] getTelefono() => telefono;

}