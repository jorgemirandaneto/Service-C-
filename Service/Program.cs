using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste("http://www.mocky.io/", "v2/59b088b21000005e0bdb21da");
            string cep;

            Console.WriteLine("Digite seu cep:");
            cep = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");


            var endereco = Service.Service.TesteCorreios("http://correiosapi.apphb.com/", "cep/", cep);

            Console.WriteLine(endereco.cep);
            Console.WriteLine(endereco.cidade);
            Console.WriteLine(endereco.logradouro);
            Console.WriteLine(endereco.estado);
            Console.WriteLine(endereco.tipodelogradouro);



            Console.ReadKey();
        }
    }
}
