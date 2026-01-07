using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokIspoBowl_API.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public bool IsDelivery { get; set; }

        // string comme sur le diagramme (on pourra passer à un enum plus tard)
        [Required, MaxLength(50)]
        public string PaymentMode { get; set; }

        public string Commentary { get; set; }

        // null => "le plus vite possible"
        public DateTime? PickupOrDeliveryTime { get; set; }

        [MaxLength(200)]
        public string DeliveryAddress { get; set; }

        public DateTime OrderCreationTime { get; set; } = DateTime.UtcNow;

        public bool IsEnded { get; set; }

        //Chaque commande a un client
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        //Chaque commande peut avoir plusieurs lignes
        public ICollection<OrderLine> Lines { get; set; } = new List<OrderLine>();
    }
}
