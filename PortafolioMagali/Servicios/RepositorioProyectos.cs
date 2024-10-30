using PortafolioMagali.Models;

namespace PortafolioMagali.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
       
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo="Amazon",
                Descripcion="E-commerce realizado en ASP.NET Core",
                Link="https://amazon.com",
                ImagenURL ="/img/amazon.png"
            },
                new Proyecto
            {
                Titulo="NY Times ",
                Descripcion="Pag de noticias",
                Link="https://nytimes.com",
                ImagenURL ="/img/nyt.png"
            },
                new Proyecto
            {
                Titulo="Reddit",
                Descripcion="Red social",
                Link="https://reddit.com",
                ImagenURL ="/img/reddit.png"
            },
                new Proyecto
            {
                Titulo="Steam",
                Descripcion="Tienda en linea para comprar videojuegos",
                Link="https://store.steampowered.com",
                ImagenURL ="/img/steam.png"
            },
            };
        }
    }
}
