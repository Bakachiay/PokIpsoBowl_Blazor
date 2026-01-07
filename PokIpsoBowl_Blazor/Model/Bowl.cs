using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokIspoBowl_API.Model
{
    public class Bowl : Product
    {

        //Booléen qui permet de savoir si le bowl a été créé par le magasin => IsPreset is true
        public bool IsPreset { get; set; }

        [Precision(4,2)]
        public decimal MediumPrice { get; set; }

        [Precision(4, 2)]
        public decimal LargePrice { get; set; }

        //Permet de retrouver les ingrédients liés au bowl preset
        public ICollection<SelectedIngredient> SelectedIngredients { get; set; } = new List<SelectedIngredient>();
    }
}
