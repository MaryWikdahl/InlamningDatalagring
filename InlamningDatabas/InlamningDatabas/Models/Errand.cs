using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningDatabas.Models
{
    public class Errand
    {

        [Required]
        public int CustomerId { get; set; }

        //public string Email { get; set; }
        
        [Key]
        public int Id { get; set; }

        [Required]

        [StringLength(50)]
        public string? Title { get; set; }

        [Required]

        [StringLength(150)]
        public string? Description { get; set; }

        [Required]
        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedTime { get; set; }

        [Required]
        public State State { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        //public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
    public enum State
        {
            NotRunning,
            UnderProcess,
            Finished
        }
}