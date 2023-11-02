using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public List<Comentario> Comentarios { get; set; } //relacion uno a muchos
        public List<AutorLibro> AutoresLibros { get; set; } //relacion muchos a muchos


    }
}
