using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public string? EmployeeId { get; set; }  
        public string? FullName{get;set;}
        public string? Address{get;set;}
        public int Age { get; set; } 
    }
}
