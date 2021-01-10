using System.Web.Mvc;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: calculator
        public ActionResult Index()
        {
            return View(new Calculator());  
        }

        [HttpPost]
        public ActionResult Index(Calculator calc, string calculate)
        {
            if (calculate == "plus")
            {
                calc.Result = calc.Number1 + calc.Number2;
            }

            else if (calculate == "minus")
            {
                calc.Result = calc.Number1 - calc.Number2;
            }

            else if (calculate == "multiplication")
            {
                calc.Result = calc.Number1 * calc.Number2;
            }
            else
            {
                calc.Result = calc.Number1 / calc.Number2;
            }

            return View(calc);
        }
    }
}