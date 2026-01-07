using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokIspoBowl_API.Model
{
    [Index(nameof(Name), nameof(Type), IsUnique=true)]
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required, MaxLength(40)]
        public string Name { get; set; }

        // supplementPrice = surcoût quand pris en supplément
        [Required, Precision(4,2)]
        public decimal SupplementPrice { get; set; }

        // price = prix pour ajouter cet ingrédient en plus des ingrédients de base (extra)
        [Required, Precision(4, 2)]
        public decimal Price { get; set; }

        //Bowls preset dans lequel il est présent
        public ICollection<SelectedIngredient> SelectedInBowlPreset { get; set; } = new List<SelectedIngredient>();

        // Chaque ingrédient a un type (voir l'énum IngredientType
        [Required, EnumDataType(typeof(IngredientType))]
        public IngredientType Type { get; set; }

        [RegularExpression(@"^.*\.(jpg|jpeg|png)$",
        ErrorMessage = "L'image doit être un fichier se terminant par .jpg, .jpeg ou .png.")]
        public string? Picture { get; set; }
    }
}
