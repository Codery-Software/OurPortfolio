using System.ComponentModel.DataAnnotations;

namespace OurPortfolio.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
