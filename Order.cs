using System.Collections.Generic;
namespace AcuCafe
{
    public class Order
    {
        public List<Coffee> Coffees { get; set; }
        public List<Coffee> Teas { get; set; }
        public decimal Price { get; set; }
    }
}
