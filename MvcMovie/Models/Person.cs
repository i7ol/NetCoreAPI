using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models{
    [Table("Persons")]
    public class Person{
        [Key]
        public int Id { get; set;}
        public string PersonId { get; set;}
        public string FullName { get; set;}
        public int Age { get; set;}

    }
}