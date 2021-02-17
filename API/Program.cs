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
            RestRequest request = new RestRequest("pokemon/ditto");
            IRestResponse response = client.Get(request);
            Pokemon ditto = JsonConvert.DeserializeObject<Pokemon>(response.Content);
            System.Console.WriteLine(ditto.name);
            Console.ReadLine();
        }
    }
}
