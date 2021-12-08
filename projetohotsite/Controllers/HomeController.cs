using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
            try
            {
                  dbs.CadastraInteresse(cad);
                  ViewBag.Mensagem = "cadastro realizado com sucesso.";
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.ToString());
                ViewBag.Mensagem = "erro ao cadastrar" ;
            }
           
            return RedirectToAction("Index",ViewBag);
        }

    }
}
