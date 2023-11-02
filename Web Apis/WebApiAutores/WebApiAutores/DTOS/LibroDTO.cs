namespace WebApiAutores.DTOS
{
    public class LibroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechadePublicacion { get; set; }
        public List<AutorDTO> Autores { get; set; } 
        //public List<ComentarioDTO> Comentarios { get; set; }
    }
}
