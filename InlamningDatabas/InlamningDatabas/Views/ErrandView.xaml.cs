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
    /// Interaction logic for ErrandView.xaml
    /// </summary>
    public partial class ErrandView : UserControl
    {
        public ErrandView()
        {
            InitializeComponent();

            IErrandServices ErrandServices = new ErrandServices();

            var data = ErrandServices.GetAll();
            tbListErrand.ItemsSource = data.Select(d => $"{ d.Title}, { d.Description}, { d.CreatedTime}, { d.UpdatedTime}, { d.State}");
        }

       

      

       
    }
}
