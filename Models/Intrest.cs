using System.ComponentModel.DataAnnotations;

namespace Labb4__API.Models
{
    public class Intrest
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<PersonInterest> PersonInterests { get; set; }
        public ICollection<Link> Links { get; set; }
    }
}
