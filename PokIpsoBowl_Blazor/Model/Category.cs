using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokIspoBowl_API.Model
{
    [Index(nameof(Name), IsUnique =true)]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        // Produits qui font partie de cette catégorie
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
