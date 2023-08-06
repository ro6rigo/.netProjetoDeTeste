using Microsoft.AspNetCore.Mvc;

namespace ProjetoDeTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
       

        public CalculadoraController()
        {
        }

        [HttpGet(Name = "Somar")]
        public Calculadora Get(int ValorA, int ValorB)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.ValorA = ValorA;
            calculadora.ValorB = ValorB;
            calculadora.Soma = ValorA + ValorB;
            return calculadora;
        }
    }
}