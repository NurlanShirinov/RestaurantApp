using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Repositories
{
    public class FakeRepo
    {
        public List<Beer> GetAll()
        {
            return new List<Beer>()
            {
                new Beer{Name="Carib", Volume="0.5", Image="Images/Carib.png", Price=5.0 },
                new Beer{Name="Efes", Volume="0.3", Image="Images/Efes.png", Price=3.0 },
                new Beer{Name="Heineken", Volume="0.7", Image="Images/Heineken.png", Price=7.5 },
                new Beer{Name="Pale-Ale", Volume="0.3", Image="Images/pale-ale.png", Price=5.0 },
                new Beer{Name="Sapporo", Volume="0.5", Image="Images/Sapporo.png", Price=5.0 },
                new Beer{Name="Stag-Lager", Volume="0.5", Image="Images/stag-lager.png", Price=5.0 },
            };
        }
    }
}
