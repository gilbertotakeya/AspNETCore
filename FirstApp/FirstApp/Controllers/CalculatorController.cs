using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstApp.Models;
using System.IO;

namespace FirstApp.Controllers
{
    [Route("Calculadora")]
    public class CalculatorController : Controller
    {
        public CalculatorController()
        {            
        }

        [Route("Soma/{valor1:int}/{valor2:int}")]
        public IActionResult Plus(int valor1, int valor2)
        {
            return Content(Convert.ToString(valor1 + valor2));
        }

        [Route("Menos/{valor1:int}/{valor2:int}")]
        public IActionResult Minus(int valor1, int valor2)
        {
            return Content(Convert.ToString(valor1 - valor2));
        }

        [Route("Multiplicacao/{valor1:int}/{valor2:int}")]
        public IActionResult Multiplication(int valor1, int valor2)
        {
            if (valor1 == 0 || valor2 == 0)
                return BadRequest("Valor não pode ser zero!");

            return Content(Convert.ToString(valor1 * valor2));
        }

        [Route("Divisao/{valor1:int}/{valor2:int}")]
        public IActionResult Division(int valor1, int valor2)
        {
            if (valor1 == 0 || valor2 == 0)
                return BadRequest("Valor não pode ser zero!");

            return Content(Convert.ToString(valor1/valor2));
        }
    }
}