namespace Clases.Ejercicios.Ejercicio2
{
    /*
    Debajo tenemos una clase Persona la cual tiene 3 campos públicos. Como vimos, no es buena idea exponer 
    la data de nuestras clases usando campos. Esto es lo que debes hacer:

    1) Modifica la clase Persona para que ya no tenga los 3 campos, sino que tenga 3 propiedades públicas, 
    llamadas Nombre, Apellido y FechaNacimiento.

    2) Crea una nueva propiedad de solo-lectura, llamada NombreCompleto, la cual debe devolver la 
    concatenación de Nombre y Apellido, separados por un espacio en blanco. Es decir, si Nombre = "Felipe", 
    y Apellido = "Gavilán", entonces NombreCompleto = "Felipe Gavilán".

    3) Modifica el método ConstruirPersona de la clase Ejercicio, para que utilice las propiedades que acabas de crear.
     */

    public class Persona
    {
        public Persona(string nombre,string apellido,DateTime fechaNacimiento = default )
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; } = default;
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }

    public class Ejercicio
    {
        public Persona ConstruirPersona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            var persona = new Persona(nombre,apellido,fechaNacimiento);
            return persona;
        }
    }
}
    