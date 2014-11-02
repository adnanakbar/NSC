using System.Threading.Tasks;
using System.Web.Mvc;
using NumericSequenceCalculator.Common;

namespace NumericSequenceCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISequenceCalculatorManager _manager;

        public HomeController(ISequenceCalculatorManager manager)
        {
            _manager = manager;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "This application generates number sequence";

            return View();
        }

        public async Task<ActionResult> GetAllNumbers(string number)
        {
            ulong num;
            if (string.IsNullOrWhiteSpace(number) || !ulong.TryParse(number, out num))
                return View("PartialNumberSequenceResults");

            string model = await _manager.GetAllNumberSequence(num);
            return PartialView("PartialNumberSequenceResults", model);
            
        }

        public async Task<ActionResult> GetOddNumbers(string number)
        {
            ulong num;
            if (string.IsNullOrWhiteSpace(number) || !ulong.TryParse(number, out num))
                return View("PartialNumberSequenceResults");

            string model = await _manager.GetOddNumberSequence(num);
            return PartialView("PartialNumberSequenceResults", model);
        }

        public async Task<ActionResult> GetEvenNumbers(string number)
        {
            ulong num;
            if (string.IsNullOrWhiteSpace(number) || !ulong.TryParse(number, out num))
                return View("PartialNumberSequenceResults");

            string model = await _manager.GetEvenNumberSequence(num);
            return PartialView("PartialNumberSequenceResults", model);
        }

        public async Task<ActionResult> GetAllNumbersMultiple(string number)
        {
            ulong num;
            if (string.IsNullOrWhiteSpace(number) || !ulong.TryParse(number, out num))
                return View("PartialNumberSequenceResults");

            string model = await _manager.GetAllNumberMultipleSequence(num);
            return PartialView("PartialNumberSequenceResults", model);
        }

        public async Task<ActionResult> GetFibonacciSequence(string number)
        {
            ulong num;
            if (string.IsNullOrWhiteSpace(number) || !ulong.TryParse(number, out num))
                return View("PartialNumberSequenceResults");

            string model = await _manager.GetFibonacciSequence(num);
            return PartialView("PartialNumberSequenceResults", model);
        }
    }
}