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
            string model = await _manager.GetAllNumberSequence(ulong.Parse(number));
            return PartialView("PartialNumberSequenceResults", model);
        }

        public async Task<ActionResult> GetOddNumbers(string number)
        {
            string model = await _manager.GetOddNumberSequence(ulong.Parse(number));
            return PartialView("PartialNumberSequenceResults", model);
        }

        public async Task<ActionResult> GetEvenNumbers(string number)
        {
            string model = await _manager.GetEvenNumberSequence(ulong.Parse(number));
            return PartialView("PartialNumberSequenceResults", model);
        }

        public async Task<ActionResult> GetAllNumbersMultiple(string number)
        {
            string model = await _manager.GetAllNumberMultipleSequence(ulong.Parse(number));
            return PartialView("PartialNumberSequenceResults", model);
        }

        public async Task<ActionResult> GetFibonacciSequence(string number)
        {
            string model = await _manager.GetFibonacciSequence(ulong.Parse(number));
            return PartialView("PartialNumberSequenceResults", model);
        }
    }
}