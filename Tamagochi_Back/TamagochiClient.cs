using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_Back
{
    internal class TamagochiClient
    {
        private readonly RestClient _restClient;

        public TamagochiClient()
        {
            const string tamagochiApiBaseUrl = "https://pokeapi.co/api/v2/";

            _restClient = new RestClient(tamagochiApiBaseUrl);
        }
        public List<Tamagochi> GetTamagochis()
        {
            var request = new RestRequest("pokemon");
            var tamagochis = _restClient.Get<PokemonList>(request);
            return tamagochis?.Results!;
        }


        public Tamagochi GetTamagochi(string name)
        {
            var request = new RestRequest($"pokemon/{name.ToLower()}");
            var tamagochi = _restClient.Get<Tamagochi>(request);
            return tamagochi!;
        }
    }
}
