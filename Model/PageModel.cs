using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_Navigation_App.Model
{
    public class PageModel
    {
        public int CustomerCount { get; set; }
        public string ProductStatus { get; set; }
        public DateOnly OrderDate { get; set; }
        public decimal TransactionValue { get; set; }
        public TimeOnly ShipmentDelivery { get; set; }
        public bool LocationStatus { get; set; }

    }
}
