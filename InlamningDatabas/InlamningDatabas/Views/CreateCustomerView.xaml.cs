using InlamningDatabas.Models;
using InlamningDatabas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InlamningDatabas.Views
{
    /// <summary>
    /// Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCustomerView : UserControl
    {
        public Customer Customer { get; set; }
        public CreateCustomerView()
        {
            InitializeComponent();
            DataContext = this;
            Customer = new Customer();
        }

        private void tbButtonCreate_Click(object sender, RoutedEventArgs e)

        {
            try { 
            if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbStreetName.Text) && !string.IsNullOrEmpty(tbZipCode.Text) && !string.IsNullOrEmpty(tbCity.Text))
            {

                ICustomerServices CustomerServices = new CustomerServices();

                CustomerServices.CreateCustomer(new Customer
                {
                    FirstName = tbName.Text,
                    LastName = tbLastName.Text,
                    Email = tbEmail.Text,
                    StreetName = tbStreetName.Text, 
                    ZipCode = tbZipCode.Text,  
                    City = tbCity.Text

       
                });
            }
                MessageBox.Show($"Sparade Kunden med Namnet {tbName.Text}");

                tbName.Text = "";
                tbLastName.Text = "";
                tbEmail.Text = "";
                tbStreetName.Text = "";
                tbZipCode.Text = "";
                tbCity.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte spara ärendet pga felkod: {ex.Message}");
            }
        }

        
    }
}
