using DR4_TP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DR4_TP2.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            var Pessoas = RecuperarPessoas();
            return View(Pessoas);
        }

        private static List<Pessoa> RecuperarPessoas() { 
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa { Nome = "Anna", Idade = 19, Cpf = "00011122233" });
            pessoas.Add(new Pessoa { Nome = "Igor", Idade = 21, Cpf = "11122233344" });
            pessoas.Add(new Pessoa { Nome = "Rango", Idade = 12, Cpf = "22233344455" });

            return pessoas;
        }
    }
}
