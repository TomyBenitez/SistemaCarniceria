using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Models
{
    public class Venta
    {
        public int Id { get; set; }
        [Required]
        public int CobradorId { get; set; }
        public Cobrador? Cobrador { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        [NotMapped]
        public string NombreCliente { get; set; }
        [Required]
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }
        [NotMapped]
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        [Precision(12, 2)]
        public decimal MontoTotal { get; set; }
    }
}
