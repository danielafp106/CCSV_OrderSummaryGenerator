using Microsoft.AspNetCore.Mvc;
using OrderSummaryGenerator.Models;

namespace OrderSummaryGenerator.Controllers
{
    public class GeneratorController : Controller
    {
        public IActionResult Index()
        {
            List<string> paymentTypes = new List<string>(){
                "PAGO EN EFECTIVO CONTRA ENTREGA",
                "PAGO POR TRANSFERENCIA PREVIO A ENTREGA",
                "PAQUETE PAGADO" };
            ViewBag.PaymentTypes = paymentTypes;
            return View();
        }

        public IActionResult GenerateSummary(OrderSummary m) {
            return View("Index",m);
        }
    }
}
