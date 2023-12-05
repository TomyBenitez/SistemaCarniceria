using Newtonsoft.Json;
using Sistema_Carnicería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Carnicería.Repositories
{
    public class CobradoresRepository
    {
        const string Url = "https://carniceriadbtomy.azurewebsites.net/api/cobradores";

        HttpClient client = new HttpClient();
        public CobradoresRepository()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Cobrador>> GetAllAsync()
        {
            var response = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Cobrador>>(response);
        }
        public async Task<Cobrador> GetById(int id)
        {
            var response = await client.GetStringAsync($"{Url}/{id}");
            return JsonConvert.DeserializeObject<Cobrador>(response);
        }
        public async Task<bool> AddAsync(Cobrador cobrador)
        {
            var response = await client.PostAsync(Url,
                new StringContent(JsonConvert.SerializeObject(cobrador), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateAsync(Cobrador cobrador)
        {
            var response = await client.PutAsync($"{Url}/{cobrador.Id}",
                new StringContent(JsonConvert.SerializeObject(cobrador), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await client.DeleteAsync($"{Url}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
