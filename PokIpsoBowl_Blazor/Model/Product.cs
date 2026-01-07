using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokIspoBowl_API.Model
{
    [Index(nameof(Name), IsUnique=true)]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        // Présent sur le diagramme : prix générique au niveau Product.
        // Pour Bowl on utilisera MediumPrice/LargePrice (ce Price peut rester à 0).
        [Precision(4,2)]
        public decimal Price { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}
