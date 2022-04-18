using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TF_CyberSecu_FirstMVC.Controllers
{
    public class MathController : Controller
    {
        [Route("Math/MultiplierPar2/{id}")]
        [Route("Math/{id}/FoisDeux")]
        [Route("Math/DeuxFois/{id}")]
        public int FoisDeux(int id)
        {
            return id * 2;
        }

        public string TableDe(int id)
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result += $"{i + 1} x {id} = {(i + 1) * id}\n";
            }
            return result;
        }

        [Route("Math/{id}/Premier")]
        public string Premier(int id)
        {
            string result = $"{id} n'est pas un nombre premier...";
            if (id <= 1) return result;
            bool isPrime = true;
            for (int i = 2; i <= (id/2) && isPrime; i++)
            {
                if (id % i == 0) isPrime = false;
            }
            if (isPrime) result = $"{id} est un nombre premier!";
            return result;
        }

        public int Fibonacci(int id) {
            int f0 = 0, f1 = 1;
            if (id == 0) return f0;
            if (id == 1) return f1;
            int result = f0 + f1;
            for (int i = 1; i < id; i++) {
                f0 = f1;
                f1 = result;
                result = f0 + f1;
            }
            return f1;
        }
    }
}
