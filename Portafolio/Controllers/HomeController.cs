﻿using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicioEmail servicioEmail;
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(IServicioEmail servicioEmail,ILogger<HomeController> logger,IRepositorioProyectos repositorioProyectos)
        {
            this.servicioEmail = servicioEmail;
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var modelo=new HomeIndexViewModel() { Proyectos=proyectos};
            return View(modelo);
        }

        
        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);

        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
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