using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokIspoBowl_API.Model
{
    [Index(nameof(Name),IsUnique=true)]
    public class Taste
    {
        [Key]
        public int TasteId { get; set; }

        [Required,MaxLength(40)]
        public string Name { get; set; }
        
        //La liste des desserts pour lesquels ce gout est disponible
        public ICollection<Dessert> Desserts { get; set; } = new List<Dessert>();


        //La liste des lignes de commande dans lequel il a été choisi
        public ICollection<OrderLine> SelectedInOrderLine { get; set; } = new List<OrderLine>();

    }
}
