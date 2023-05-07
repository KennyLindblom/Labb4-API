using System.ComponentModel.DataAnnotations;

namespace Labb4__API.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public ICollection<PersonInterest> PersonIntrests { get; set; }

    }
}
