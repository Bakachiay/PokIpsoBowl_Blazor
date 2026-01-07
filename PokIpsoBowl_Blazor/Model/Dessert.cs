using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PokIspoBowl_API.Model
{
    public class Dessert : Product
    {
        // nombre de pièces par unité
        [Required, Range(1,20)]
        public int PiecesNb { get; set; }

        // Goûts possibles pour un dessert donné
        public ICollection<Taste> AvailableTastes { get; set; } = new List<Taste>();

    }
}
