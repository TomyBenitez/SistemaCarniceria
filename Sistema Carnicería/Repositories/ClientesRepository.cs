using FrmCosmopolita.Utils;
using Newtonsoft.Json;
using Sistema_Carnicería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Repositories
{
    public class ClientesRepository
    {
        const string Url = "https://carniceriadbtomy.azurewebsites.net/api/clientes";
        HttpClient client = new HttpClient();
        public ClientesRepository()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var response = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Cliente>>(response);
        }
        public async Task<Cliente> GetById(int id)
        {
            var response = await client.GetStringAsync($"{Url}/{id}");
            return JsonConvert.DeserializeObject<Cliente>(response);
        }
        public async Task<bool> AddAsync(Cliente cliente)
        {
            var response = await client.PostAsync(Url,
                new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateAsync(Cliente cliente)
        {
            var response = await client.PutAsync($"{Url}/{cliente.Id}",
                new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await client.DeleteAsync($"{Url}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
