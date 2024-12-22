using System.ComponentModel.DataAnnotations;

namespace WA_MVC.Models
{
    public class Book
    {
        public Book()
        {
            Id = 0;
            Name = string.Empty;
            CatId = string.Empty;
            Author = string.Empty;
            Price = 0;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public string CatId { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(50, MinimumLength = 2)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public long Price { get; set; }
    }
}
