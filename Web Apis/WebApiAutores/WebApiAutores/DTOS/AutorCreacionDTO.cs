using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.DTOS
{
    public class AutorCreacionDTO
    {
        [Required(ErrorMessage = "Compo requerido")] //Decorador para nombre.
        [StringLength(maximumLength: 4, ErrorMessage = "El campo {0} no debe tener mas de 4 caracteres.")]
        public string Nombre { get; set; }

    }
}
