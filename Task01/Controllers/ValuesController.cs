using Microsoft.AspNetCore.Mvc;
using Task01.Services;

namespace Task01.Controllers
{
    public class ValuesController : Controller
    {
        private readonly IValuesService _valuesService;

        public ValuesController(IValuesService valuesService)
        {
            _valuesService = valuesService;
        }

        public IActionResult Index()
        {
            var values = _valuesService.GetValues();
            return View(values);
        }
    }
}
