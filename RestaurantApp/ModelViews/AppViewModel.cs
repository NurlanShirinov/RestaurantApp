using RestaurantApp.Commands;
using RestaurantApp.Models;
using RestaurantApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RestaurantApp.ModelViews
{
    public class AppViewModel:BaseViewModel
    {
		public FakeRepo	 BeerRepository { get; set; }
		public ObservableCollection<Beer> Beers { get; set; }
        public Grid MyGrid { get; set; }

        private Beer beer;

		public Beer Beer
		{
			get { return beer; }
			set { beer = value; OnPropertyChanged(); }
		}


		public RelayCommand	 SelectedCommand { get; set; }

		public AppViewModel()
		{
			BeerRepository = new FakeRepo();
			Beers = new ObservableCollection<Beer> (BeerRepository.GetAll());

			SelectedCommand = new RelayCommand(o =>
			{
                var beer = o as Beer;
                beer = Beer;

			});

        }
	}
}
