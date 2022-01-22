using InlamningDatabas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningDatabas.Models.ViewModel
{
    internal class CreateCustomerViewModel 
    {
        public CustomerServices customerServices = new CustomerServices();
        
        public void Init()
        {
           
        }

    }
}
