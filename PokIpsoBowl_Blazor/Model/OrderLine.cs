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
    [Index(nameof(ProductId),nameof(OrderId), IsUnique=true)]
    public class OrderLine
    {
        [Key]
        public long OrderLineId { get; set; }

        [Required, Range(1,99)]
        public int Quantity { get; set; }

        // Référence vers le produit polymorphe (Bowl/Dessert/Drink…)
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        //Lien vers la commande correspondante à la ligne
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        //TODO : Uniquement si le produit est un dessert
        public ICollection<Taste> SelectedTastes { get; set; } = new List<Taste>();

        //TODO : Uniquement si le produit est un bowl non pre set
        public ICollection<SelectedIngredient> SelectedIngredients { get; set; } = new List<SelectedIngredient>();
    }
}
