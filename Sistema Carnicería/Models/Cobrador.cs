using Sistema_Carnicería.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Models
{
    public class Cobrador
    {
        public int Id { get; set; }
        [Required]
        public string Apellido_Nombre { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public TipoCobradorEnum Tipocobrador { get; set; }
        public override string ToString()
        {
            return Apellido_Nombre;
        }
    }
}
