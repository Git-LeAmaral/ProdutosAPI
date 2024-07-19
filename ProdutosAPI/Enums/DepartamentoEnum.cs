using System.Text.Json.Serialization;

namespace ProdutosAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        MASCULINO,
        FEMININO,
        INFANTIL
    }
}
