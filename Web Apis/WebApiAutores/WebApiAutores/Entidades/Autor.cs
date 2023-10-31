using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Compo requerido")] //Decorador para nombre.
        [StringLength(maximumLength:4,ErrorMessage = "El campo {0} no debe tener mas de 4 caracteres.")]
        public string Nombre { get; set; }

        
        public List<AutorLibro> AutoresLibros { get; set; } //Relacion muchos a muchos

    }
}
