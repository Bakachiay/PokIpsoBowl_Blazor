using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PokIspoBowl_API.Model
{
    [Index(nameof(Email), IsUnique=true)]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; }

        [Phone]
        //Exemple uniquement Belge : [RegularExpression("^(?:0\\d{1,2}|\\+32\\s?\\d{1,2})(?:[\\s]?\\d{2,3}){2,3}$")]
        public string PhoneNB { get; set; }

        [EmailAddress, Required]
        //Exemple uniquement Gmail : [RegularExpression("^[a-zA-Z0-9._%+-]+@gmail\\.com$")]
        public string Email { get; set; }

        //Nous permet de retrouver la liste des commandes passées par le client
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
