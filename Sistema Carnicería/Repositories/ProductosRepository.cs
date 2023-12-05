using Newtonsoft.Json;
using Sistema_Carnicería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Repositories
{
    public class ProductosRepository
    {
        const string Url = "https://carniceriadbtomy.azurewebsites.net/api/productos";

        HttpClient client = new HttpClient();
        public ProductosRepository()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            var response = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Producto>>(response);
        }
        public async Task<Producto> GetById(int id)
        {
            var response = await client.GetStringAsync($"{Url}/{id}");
            return JsonConvert.DeserializeObject<Producto>(response);
        }
        public async Task<bool> AddAsync(Producto producto)
        {
            var response = await client.PostAsync(Url,
                new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateAsync(Producto producto)
        {
            var response = await client.PutAsync($"{Url}/{producto.Id}",
                new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await client.DeleteAsync($"{Url}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
