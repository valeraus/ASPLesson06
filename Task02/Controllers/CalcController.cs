using Microsoft.AspNetCore.Mvc;
using Task02.Models;
using Task02.Services;

namespace Task02.Controllers
{
    public class CalcController : Controller
    {
        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Index()
        {
            var model = new CalcViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate(double? a, double? b, string operation)
        {
            var model = new CalcViewModel { A = a, B = b };
            if (a.HasValue && b.HasValue)
            {
                switch (operation)
                {
                    case "Add":
                        model.Result = _calcService.Add(a.Value, b.Value);
                        break;
                    case "Subtract":
                        model.Result = _calcService.Subtract(a.Value, b.Value);
                        break;
                    case "Multiply":
                        model.Result = _calcService.Multiply(a.Value, b.Value);
                        break;
                    case "Divide":
                        model.Result = _calcService.Divide(a.Value, b.Value);
                        break;
                }
            }
            return View("Index", model);
        }
    }

}
