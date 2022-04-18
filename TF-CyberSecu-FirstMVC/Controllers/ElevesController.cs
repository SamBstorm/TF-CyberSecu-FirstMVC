using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TF_CyberSecu_FirstMVC.Controllers
{
    public class ElevesController : Controller
    {
        //Attention, si une variable membre de votre contrôleur doit mémoriser une information variant de pages en pages,
        //alors cette variable se doit d'être static, car lors de chaque appel, le controleur est instancié.
        public static List<string> studentNames = new List<string> { "Cedrick", "Hajer", "Eric", "Jason", "Alexandre", "Aurélien", "Anas", "Jean", "Lucas", "Dorian", "Raphael", "Philippe" };

        private static Random _rng = new Random();

        public string[] Index()
        {
            return studentNames.ToArray();
        }

        public string Random() {
            return studentNames[_rng.Next(studentNames.Count)];
        }

        public IActionResult Ajouter(string id) {
            if (id is null) return BadRequest();
            if (id.Trim().Length <= 0) return BadRequest();
            studentNames.Add(id);
            return Ok();
        }
    }
}
