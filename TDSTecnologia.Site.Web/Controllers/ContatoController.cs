using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDSTecnologia.Site.Infrastructure.Integrations;
using TDSTecnologia.Site.Web.ViewModels;

namespace TDSTecnologia.Site.Web.Controllers
{
    public class ContatoController : Controller
    {
        private readonly Email _email;

        public ContatoController(Email email)
        {
            _email = email;
        }

        public IActionResult Index()
        {
            var viewModel = new ContatoViewModel();

            return View("Contato",viewModel);
        }

        [HttpGet]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contato([Bind("EmailDestinatario,Nome,Mensagem")] ContatoViewModel contato)
        {
            if (ModelState.IsValid && contato != null)
            {
                await _email.EnviarEmail(contato.EmailDestinatario, contato.Nome, contato.Mensagem);

                return RedirectToAction(nameof(Index));
            }

            return View("Contato");
        }
    }

}
