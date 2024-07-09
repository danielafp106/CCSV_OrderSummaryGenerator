using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OrderSummaryGenerator.Models
{
    public class OrderSummary
    {
        [Display(Name = "Case")]
        public string productName { get; set; }
        [Display(Name = "Modelo")]
        public string model { get; set; }
        [Display(Name = "Cliente")]
        public string client { get; set; }
        [Display(Name = "Contacto")]
        public string phoneContact { get; set; }
        [Display(Name = "Lugar de Entrega")]
        public string deliveryPlace { get; set; }
        [Display(Name = "Día")]
        public string deliveryDay { get; set; }
        [Display(Name = "Hora")]
        public string deliveryTime { get; set; }
        [Display(Name = "Total a Pagar")]
        public decimal amountToPay { get; set;}
        [Display(Name = "Tipo de Pago")]
        public string paymentType { get; set; }
        [Display(Name = "Indicaciones")]
        public string indications { get; set; }
        public string orderSummaryText { get; set; }



    }
}
