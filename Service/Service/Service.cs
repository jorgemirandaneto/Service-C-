using Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    class Service
    {
        public static void Teste(string url, string resource)
        {
            var Client = new RestClient(url);
            var request = new RestRequest(resource, Method.GET);
            IRestResponse response = Client.Execute(request);
            var pessoa = Newtonsoft.Json.JsonConvert.DeserializeObject<Pessoa>(response.Content);

            var lista = new List<Pessoa>();
            lista.Add(pessoa);

            foreach (var item in lista)
            {
                Console.WriteLine(item.nome);
                Console.WriteLine(item.email);
                Console.WriteLine(item.endereco);
            }
        }

        public static Endereco TesteCorreios(string url, string resource, string cep)
        {
            var Client = new RestClient(url);
            var request = new RestRequest(resource + cep, Method.GET);
            IRestResponse response = Client.Execute(request);
            var endereco = Newtonsoft.Json.JsonConvert.DeserializeObject<Endereco>(response.Content);
            return endereco;
        }
    }
}
