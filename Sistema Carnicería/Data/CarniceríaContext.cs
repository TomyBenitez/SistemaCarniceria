using FrmCosmopolita.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sistema_Carnicería.Enums;
using Sistema_Carnicería.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Data
{
    public class CarniceríaContext : DbContext
    {
        #region Declaración de los dbSets
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cobrador> Cobradores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        #endregion
        public CarniceríaContext(DbContextOptions<CarniceríaContext> options):base(options)
        {
        }

        public CarniceríaContext(){}

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Helper.GetConnectionStringForSQL());
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.LogTo(m => Debug.WriteLine(m), new[] { DbLoggerCategory.Database.Name }, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .UseMySql(Helper.GetConnectionString(),
                    ServerVersion.AutoDetect(Helper.GetConnectionString()),
                    options => options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: System.TimeSpan.FromSeconds(30),
                   errorNumbersToAdd: null));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region carga de Clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,
                    Apellido_Nombre = "Prueba de Cliente",
                    Dirección = "Direccion",
                    Teléfono = "123"
                },
                new Cliente
                {
                    Id = 2,
                    Apellido_Nombre = "Prueba de Cliente 2",
                    Dirección = "Direccion",
                    Teléfono = "123"
                }
                );
            #endregion

            #region Carga de Cobrador
            modelBuilder.Entity<Cobrador>().HasData(
                new Cobrador
                {
                    Id = 1,
                    Apellido_Nombre = "Admin",
                    Dirección = "Admin",
                    Teléfono = "123",
                    Username = "Admin",
                    Password = Helper.ObtenerHashSha256("root"),
                    Tipocobrador = TipoCobradorEnum.Administrador
                }
                );
            #endregion

            #region Carga de Productos
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "1kg pollo",
                    Monto = 2500
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "1kg Aguja",
                    Monto = 2500
                }
                );
            #endregion

            #region Carga de Ventas
            modelBuilder.Entity<Venta>().HasData(
                new Venta
                {
                    Id = 1,
                    ClienteId = 1,
                    CobradorId = 1,
                    ProductoId = 1,
                    Cantidad = 1,
                    Fecha = DateTime.Now,
                }
                );
            #endregion
        }
    }
}
