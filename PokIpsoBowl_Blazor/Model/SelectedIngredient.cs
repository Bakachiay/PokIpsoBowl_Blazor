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
    [Index(nameof(OrderLineId), nameof(IngredientId), IsUnique = true)]
    public class SelectedIngredient
    {
        [Key]
        public long SelectedIngredientId { get; set; }

        public bool IsExtra { get; set; }


        public int BowlId { get; set; }
        [ForeignKey("BowlId")]
        public Bowl BowlPreset { get; set; }

        public long OrderLineId { get; set; }
        [ForeignKey("OrderLineId")]
        public OrderLine OrderLine { get; set; }

        public int IngredientId { get; set; }
        [ForeignKey("IngredientId")]
        public Ingredient Ingredient { get; set; }
    }
}
