using RestaurantApp.Commands;
using RestaurantApp.Models;
using RestaurantApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RestaurantApp.ModelViews
{
    public class AppViewModel : BaseViewModel
    {
        public FakeRepo BeerRepository { get; set; }
        public ObservableCollection<Beer> Beers { get; set; }

        private Beer beer;
        public Beer Beer
        {
            get { return beer; }
            set { beer = value; OnPropertyChanged(); }
        }


        private int beerCount;
        public int BeerCount
        {
            get { return beerCount; }
            set { beerCount = value; OnPropertyChanged(); }
        }

        private double totalamount;

        public double TotalAmount
        {
            get { return totalamount; }
            set { totalamount = value; OnPropertyChanged(); }
        }

        


        public RelayCommand SelectedCommand { get; set; }
        public RelayCommand CountUpCommand { get; set; }
        public RelayCommand CountDownCommand { get; set; }
        public RelayCommand ResetCommand { get; set; }
        public RelayCommand BuyCommand { get; set; }
        public RelayCommand ChangedCommand { get; set; }



        public AppViewModel()
        {
            BeerRepository = new FakeRepo();
            Beers = new ObservableCollection<Beer>(BeerRepository.GetAll());


          

            SelectedCommand = new RelayCommand(o =>
            {
                var beer = o as Beer;
                beer = Beer;

            });

            CountUpCommand = new RelayCommand(o =>
            {

                BeerCount++;
                TotalAmount = BeerCount * Beer.Price;

            });

            CountDownCommand = new RelayCommand(o =>
            {
                if (BeerCount <= 0)
                {
                    MessageBox.Show("Count cannot be less than zero!");
                }
                else
                {
                    BeerCount--;
                }
            });

            ResetCommand = new RelayCommand(o =>
            {
                BeerCount=0;
                TotalAmount = 0;
                Beer = null;
            });

            BuyCommand = new RelayCommand(o =>
            {
                MessageBox.Show($"Succesfully Bought Price : {TotalAmount}$");
            });

         
            
          
     
        }
    }
}
