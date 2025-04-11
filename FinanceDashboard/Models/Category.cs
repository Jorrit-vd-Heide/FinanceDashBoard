using System.ComponentModel.DataAnnotations;

namespace FinanceDashboard.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
