using System.Collections.Generic;

namespace movieRent.Core.Interfaces
{
    public interface IPeliculaRepositorio
    {
        void crearPelicula(Pelicula pelicula);
        void eliminarPelicula(Pelicula pelicula);
        bool peliculaExiste(int codigoPelicula);
    }
}

