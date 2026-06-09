using Microsoft.AspNetCore.Mvc;
using CalculoIMC.Models;

namespace CalculoIMC.Controllers
{
    public class IMCController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(IMC imc)
        {
            if (!ModelState.IsValid)
            {
                return View(imc);
            }

            imc.Resultado = imc.Peso / (imc.Altura * imc.Altura);

            return View("Resultado", imc);
        }
    }
}