using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAPP.Model
{
    public class PaymentModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public decimal Value { get; set; }
        public int ApartmentId { get; set; }
        public ApartmentModel Apartment { get; set; }
    }
}
