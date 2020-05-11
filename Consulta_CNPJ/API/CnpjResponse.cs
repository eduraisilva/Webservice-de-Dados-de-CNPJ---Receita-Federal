using Newtonsoft.Json;

namespace Consulta_CNPJ.API
{
    public class CnpjResponse
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("fantasia")]
        public string Fantasia { get; set; }
        [JsonProperty("uf")]
        public string UF { get; set; }
        [JsonProperty("telefone")]
        public string Telefone { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("numero")]
        public string Numero { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("municipio")]
        public string Municipio { get; set; }
        [JsonProperty("porte")]
        public string Porte { get; set; }
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }
        [JsonProperty("tipo")]
        public string Tipo { get; set; }
        [JsonProperty("capital_social")]
        public string Capital_Social { get; set; }
        [JsonProperty("situacao")]
        public string Situação { get; set; }
        [JsonProperty("abertura")]
        public string Data_Abertura { get; set; }



    }
}
