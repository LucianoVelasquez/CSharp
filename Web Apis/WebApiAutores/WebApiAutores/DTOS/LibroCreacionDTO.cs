﻿namespace WebApiAutores.DTOS
{
    public class LibroCreacionDTO
    {
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public List<int> AutoresIds { get; set; }   

    }
}
