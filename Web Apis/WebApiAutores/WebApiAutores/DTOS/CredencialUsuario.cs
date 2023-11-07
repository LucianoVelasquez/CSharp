using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.DTOS
{
    public class CredencialUsuario
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required] 
        public string Paswword { get; set; }
    }
}
