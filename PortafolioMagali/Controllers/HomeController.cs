﻿using Microsoft.AspNetCore.Mvc;
using PortafolioMagali.Models;
using PortafolioMagali.Servicios;
using System.Diagnostics;

namespace PortafolioMagali.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos repositorioProyectos;
       
        public HomeController(
            IRepositorioProyectos repositorioProyectos
            )
        {
            
            this.repositorioProyectos = repositorioProyectos;
           
        }

        public IActionResult Index()
        {

           
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
          
            var modelo = new HomeIndexViewModel() { 
                Proyectos = proyectos
            };
            return View(modelo);
        }

      

        public IActionResult Privacy()
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
