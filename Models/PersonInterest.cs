using System.ComponentModel.DataAnnotations;

namespace Labb4__API.Models
{
    public class PersonInterest
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int InterestId { get; set; }
        public Intrest Interest { get; set; }

        public int LinkId { get; set; }

        public Link Link { get; set; }
    }
}
