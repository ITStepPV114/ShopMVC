using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Enitities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string IdsProduct { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }
        public string userId { get; set; }=string.Empty;
    }
}
