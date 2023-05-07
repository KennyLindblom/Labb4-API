using System.ComponentModel.DataAnnotations;

namespace Labb4__API.Models
{
    public class Link
    {
        [Key]
        public int Id { get; set; }

        public int PersonId { get; set; }
        public string Url { get; set; }
        public int InterestId { get; set; }
        public Intrest Interest { get; set; }
    }
}
