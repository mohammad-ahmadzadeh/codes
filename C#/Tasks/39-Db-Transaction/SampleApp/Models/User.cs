using SampleApp.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SampleApp.Models
{
    public class User:IUser
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
