using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        
        public int OrderId { get; set; }
        
        public int AstronomicalObjectId { get; set; }
        
        public int Amount { get; set; }
        
        public decimal Price { get; set; }
        
        public virtual AstronomicalObject AstronomicalObject { get; set; }
        
        public virtual Order Order { get; set; }
    }
}