using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chama.Inscricao.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Chama.Inscricao.API.Controllers
{
    public class InscricaoController : Controller
    {
        private readonly InscricaoService _service;
        public IActionResult Index()
        {
            var lista = _service.ObterTodos();

            if (!ModelState.IsValid) return BadRequest();
            
            return View(lista);
        }
    }
}
