﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BuscaCEPWF
{
    internal class CepResponse
    {
        [JsonProperty("cep")]
        public string CEP { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro {  get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("Unidade")]
        public string Unidade { get; set; }
        [JsonProperty("ibge")]
        public string Ibge{ get; set; }
        [JsonProperty("gia")]
        public string Gia { get; set; }
    }
}