using ronald.core;
using ronald.MVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ronald.MVM.view_model
{
    class MainViewModel : observableobject
    {

        public RelayCommand FeaturedViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel Homevm { get; set; }
        public DiscoveryViewModel Discoveryvm { get; set; }
        public FeaturedViewModel Featuredvm { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();

            }
        }

        public MainViewModel()
        {
            Homevm = new HomeViewModel();
            CurrentView = Homevm;
            Discoveryvm = new DiscoveryViewModel();
            Featuredvm = new FeaturedViewModel();

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = Homevm;
            }


            );

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = Discoveryvm   ;
            }
           );


            FeaturedViewCommand = new RelayCommand(o =>
            {
                CurrentView = Featuredvm;
            }


           );

        }

    }
}
