using System.Collections.Generic;
using movieRent.Core.Dominio;

namespace movieRent.Core.ServicioDominio
{
    public interface IPeliculaRepositorio
    {
        Pelicula crearPelicula(Pelicula pelicula);
        Pelicula eliminarPelicula(Pelicula pelicula);
        Pelicula peliculaExiste(int codigoPelicula);
    }
}

