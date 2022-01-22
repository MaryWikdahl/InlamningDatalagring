using InlamningDatabas.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningDatabas.Models.ViewModel
{
    
    internal class MainWindowViewModel : ObservableObjects

    {
       
        public RelayCommand CustomerViewCommand { get; set; }
        public RelayCommand CreateCustomerViewCommand { get; set; }
        public RelayCommand ErrandViewCommand { get; set; }
        public RelayCommand CreateErrandViewCommand { get; set; }


        public CustomerViewModel CustomerViewModel { get; set; }
        public CreateCustomerViewModel CreateCustomerViewModel { get; set; }

        public ErrandViewModel ErrandViewModel { get; set; }
        public CreateErrandViewModel CreateErrandViewModel { get; set; }

        private object _CurrentView;
        public object CurrentView
        {
    
                get { return _CurrentView; }
                set{
                    _CurrentView = value;
                OnPropertyChanged();
                    }
            

        }

        public MainWindowViewModel()
        {
            CustomerViewModel= new CustomerViewModel();

            CreateCustomerViewModel  =new CreateCustomerViewModel();

            ErrandViewModel = new ErrandViewModel();

            CreateErrandViewModel = new CreateErrandViewModel();

            
            CurrentView = CustomerViewModel; 
            
            CustomerViewCommand = new RelayCommand(x => CurrentView = CustomerViewModel);

            CreateCustomerViewCommand = new RelayCommand(x => CurrentView= CreateCustomerViewModel);
            ErrandViewCommand = new RelayCommand(x => CurrentView = ErrandViewModel);

            CreateErrandViewCommand = new RelayCommand(x => CurrentView = CreateErrandViewModel);

        }
    }
}
