using System.ComponentModel.DataAnnotations;

namespace APIWebServices.Model
{
    public class User {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        public string toString(){
            return $"User Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}