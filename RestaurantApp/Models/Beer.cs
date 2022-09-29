using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class Beer:Entity
    {
        public string Name { get; set; }
        public string Volume { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
