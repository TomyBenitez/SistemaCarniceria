using Newtonsoft.Json;
using Sistema_Carnicería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Repositories
{
    public class VentasRepository
    {
        const string Url = "https://carniceriadbtomy.azurewebsites.net/api/ventas";

        HttpClient client = new HttpClient();
        public VentasRepository()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Venta>> GetAllAsync()
        {
            var response = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Venta>>(response);
        }
        public async Task<Venta> GetById(int id)
        {
            var response = await client.GetStringAsync($"{Url}/{id}");
            return JsonConvert.DeserializeObject<Venta>(response);
        }
        public async Task<bool> AddAsync(Venta venta)
        {
            var response = await client.PostAsync(Url,
                new StringContent(JsonConvert.SerializeObject(venta), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateAsync(Venta venta)
        {
            var response = await client.PutAsync($"{Url}/{venta.Id}",
                new StringContent(JsonConvert.SerializeObject(venta), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }

        //eliminamos una nota
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await client.DeleteAsync($"{Url}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
