﻿using Microsoft.EntityFrameworkCore;
using Sistema_Carnicería;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Precision(12, 2)]
        public decimal Monto { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
