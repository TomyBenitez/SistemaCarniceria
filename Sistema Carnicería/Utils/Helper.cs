using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FrmCosmopolita.Utils
{
    public class Helper
    {
        public static string ObtenerHashSha256(string textoAEncriptar)
        {
            // Create a SHA256   
            using SHA256 sha256Hash = SHA256.Create();
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(textoAEncriptar));
            // Convert byte array to a string   
            StringBuilder hashObtenido = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                hashObtenido.Append(bytes[i].ToString("x2"));
            }
            return hashObtenido.ToString();
        }

        public static string GetConnectionString()
        {
            var server = Sistema_Carnicería.Properties.Settings.Default.server;
            var database = Sistema_Carnicería.Properties.Settings.Default.database;
            var user = Sistema_Carnicería.Properties.Settings.Default.user;
            var password = Sistema_Carnicería.Properties.Settings.Default.password;
            return $"Server={server};Database={database};Uid={user};Pwd={password}";
        }

        public static string GetConnectionStringForSQL()
        {
            var server = Sistema_Carnicería.Properties.Settings.Default.server;
            var database = Sistema_Carnicería.Properties.Settings.Default.database;
            var user = Sistema_Carnicería.Properties.Settings.Default.user;
            var password = Sistema_Carnicería.Properties.Settings.Default.password;
            return $@"Data Source={server};Initial Catalog={database};User Id={user};Pwd={password};TrustServerCertificate=True";
        }
    }
}
