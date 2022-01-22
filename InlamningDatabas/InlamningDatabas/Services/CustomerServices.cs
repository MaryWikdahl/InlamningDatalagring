using InlamningDatabas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InlamningDatabas.Services
{
    

    internal interface ICustomerServices {
        
        void CreateCustomer(Customer customer);
        Customer Get(int id);
        Customer GetByEmail(string email);
        IEnumerable<Customer> GetAll();
    }
    internal class CustomerServices : ICustomerServices
    {
        private readonly SqlContext _context = new SqlContext();
        public void CreateCustomer(Customer customer)
        {
            var _Customer = _context.Customers.Where(x => x.Email == customer.Email).FirstOrDefault();
            if (_Customer == null)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
        }
        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer GetByEmail(string email)
        {
            return _context.Customers.Where(c => c.Email == email).FirstOrDefault();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }
    }
}
