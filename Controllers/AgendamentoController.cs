using ElysiumBeauty.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ElysiumBeauty.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly ILogger<AgendamentoController> _logger;

        public AgendamentoController(ILogger<AgendamentoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro_Agendamento()
        {
            return View();
        }

        public IActionResult Gerenciamento_Agendamento_Usuarios()
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
