using System;
using RestSharp;
using Newtonsoft.Json;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2");
            string svar = Console.ReadLine();
            RestRequest request = new RestRequest("pokemon/" + svar);
            IRestResponse response = client.Get(request);
            
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                System.Console.WriteLine("not found");
            }
            else
            {
                Pokemon ditto = JsonConvert.DeserializeObject<Pokemon>(response.Content);
                System.Console.WriteLine(ditto.name);
            }
            Console.ReadLine();
        }
    }
}
