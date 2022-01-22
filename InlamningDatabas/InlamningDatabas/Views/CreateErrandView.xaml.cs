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
    /// Interaction logic for CreateErrandView.xaml
    /// </summary>
    public partial class CreateErrandView : UserControl
    {
        public CreateErrandView()
        {
            InitializeComponent();
        }

        internal ErrandServices IErrandServices { get; private set; }

        private void tbButtonCreate_Click(object sender, RoutedEventArgs e)
        {


            if (!string.IsNullOrEmpty(tbErrand.Text) && !string.IsNullOrEmpty(tbDescription.Text))
            {
                ICustomerServices customerServices = new CustomerServices();

                var customerToHandle = customerServices.GetByEmail(tbEmail.Text);
                if(customerToHandle is null)
                {
                    MessageBox.Show("Kunden finns inte!");
                    return;
                }
                IErrandServices ErrandServices = new ErrandServices();

                try
                {
                    ErrandServices.CreateErrand(new Errand
                    {
                        CustomerId = customerToHandle.Id,
                        Title = tbErrand.Text,
                        Description = tbDescription.Text,
                        CreatedTime = DateTime.Now,
                        UpdatedTime = DateTime.Now,
                        State = State.NotRunning
                    });
                    MessageBox.Show($"Sparade ärende med titel {tbErrand.Text}");

                    tbErrand.Text = "";
                    tbDescription.Text = "";
                    tbEmail.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Kunde inte spara ärendet pga felkod: {ex.Message}");
                }
            }


        }
    }
    
}
