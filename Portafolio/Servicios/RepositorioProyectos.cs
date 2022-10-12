
using Portafolio.Models;

namespace Portafolio.Servicios
{

    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo="Amazon",
                    Descripcion="E-Commerce realizado en ASP.NET core",
                    Link="https://amazon.com",
                    ImagenURL="/imagenes/amazon.png"

                },
                   new Proyecto
                {
                    Titulo="Steam",
                    Descripcion="Tienda en linea para comprar videojuegos",
                    Link="https://store.steampowered.com",
                    ImagenURL="/imagenes/steam.png"

                },
                   new Proyecto
                {
                    Titulo="New York Time",
                    Descripcion=" Paginas de noticias",
                    Link="https://nytime.com",
                    ImagenURL="/imagenes/nyt.png"

                },
                   new Proyecto
                {
                    Titulo="Reddit",
                    Descripcion="red social para compartir en comunidad",
                    Link="https://reddit.com",
                    ImagenURL="/imagenes/reddit.png"

                },
            };
        }
        }
}
