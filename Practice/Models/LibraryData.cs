using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class LibraryData
    {
        [Display(Name="Назва")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Розташування")]
        [Required]
        public string Place { get; set; }
    }
}
