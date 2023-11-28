using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepository _projectsRepository;


        public HomeController(ILogger<HomeController> logger, IProjectsRepository projectsRepository)
        {
            _logger = logger;
            _projectsRepository = projectsRepository;
        }

        public IActionResult Index()
        {
            //var projectsRepository = new ProjectsRepository();
            var projects = _projectsRepository.GetProjects().ToList();
            var model = new HomeIndexDTO() { Projects = projects };
            return View(model);
        }

        public IActionResult Projects()
        {
            var projects = _projectsRepository.GetProjects();
            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}