using InlamningDatabas.Services;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace InlamningDatabas.Views
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        public CustomersView()
        {

        

            InitializeComponent();
            ICustomerServices CustomerServices = new CustomerServices();

            var data = CustomerServices.GetAll();
            tbListCustomers.ItemsSource = data.Select(d => $"{d.FirstName}, {d.LastName}, {d.Email}, {d.StreetName}, {d.ZipCode}, {d.City}");
        }

        

        
    }

}
