using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;

namespace TecnicaturasPresentacion.Cliente
{
    public class SingletonHttpClient
    {
        private static SingletonHttpClient instancia;
        private HttpClient cliente;

        private SingletonHttpClient()
        {
            cliente = new HttpClient();
        }

        public static SingletonHttpClient ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new SingletonHttpClient();
            return instancia;
        }

        public async Task<string> GetAsync(string url)
        {
            var response = await cliente.GetAsync(url);
            var responseString = "";
            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }
            return responseString;
        }

        public async Task<string> PostAsync(string url, string json)
        {
            var response = await cliente.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
            var responseString = "";
            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }
            return responseString;
        }

        public async Task<string> PutAsync(string url, string json)
        {
            var response = await cliente.PutAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
            var responseString = "";
            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }
            return responseString;
        }

        public async Task<string> DeleteAsync(string url)
        {
            var response = await cliente.DeleteAsync(url);
            var responseString = "";
            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }
            return responseString;
        }
        


    }
}
