using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IProjectsRepository
    {
        List<ProjectDTO> GetProjects();
    }
    public class ProjectsRepository : IProjectsRepository
    {
        public List<ProjectDTO> GetProjects()
        {
            return new List<ProjectDTO>()
            {
                new ProjectDTO
                {
                    Title = "Amazon",
                    Description = "E-commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImageURL = "/images/amazon.png"
                },
                new ProjectDTO
                {
                    Title = "Reddit",
                    Description = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImageURL = "/images/reddit.png"
                },
                new ProjectDTO
                {
                    Title = "Steam",
                    Description = "Tienda en linea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImageURL = "/images/steam.png"
                },
            };
        }
    }
}
