using System;
using movieRent.Core.ServicioDominio;
using movieRent.Core.Dominio;
using movieRent.Infraestructure;

namespace movieRent.Core.ServicioAplicacion
{
    public class PeliculaRepositorio : IPeliculaRepositorio
    {

        public Pelicula crearPelicula(Pelicula pelicula){

            using (AppDbContext context = new AppDbContext())
            {
                // the implementation goes here

                return new Pelicula{};
            }
            
        }

        public Pelicula eliminarPelicula(Pelicula pelicula){

            using (AppDbContext context = new AppDbContext())
            {
                // the implementation goes here

                return new Pelicula{};
            }

        }

        public Pelicula peliculaExiste(int codigoPelicula){

            using (AppDbContext context = new AppDbContext())
            {
                // the implementation goes here

                return new Pelicula{};
            }
            
        }

    }
}
