using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningDatabas.Models
{
    internal class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        
        public virtual DbSet<Errand> Errands { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skolan\c#\InlamningDatabas\InlamningDatabas\Data\EntityFramework_WPF.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
    }
}