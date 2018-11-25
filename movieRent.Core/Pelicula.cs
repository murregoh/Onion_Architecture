using System;

namespace movieRent.Core
{
    public class Pelicula
    {
        public int codigo { get; set; }
        public DateTime anoEntrega { get; set; }        
        public string descripcion { get; set; }
        public int estado { get; set; }
        public string genero { get; set; }
        public string nombre { get; set; }
        public string productora { get; set; }
    }
}
