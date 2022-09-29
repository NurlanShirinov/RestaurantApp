using RestaurantApp.Models;
using RestaurantApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ModelViews
{
    public class AppViewModel:BaseViewModel
    {
		public FakeRepo	 BeerRepository { get; set; }
		public List<Beer> Beers { get; set; }

		//private Beer beer;

		//public Beer Beer
		//{
		//	get { return beer; }
		//	set { beer = value; }   
		//}

		public AppViewModel()
		{
			BeerRepository = new FakeRepo();
			Beers = BeerRepository.GetAll();

        }
	}
}
