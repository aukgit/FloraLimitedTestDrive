using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Employee {
        [Key]
        public string EmpoyeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]

        public DateTime JoinDate { get; set; }
    }
}
