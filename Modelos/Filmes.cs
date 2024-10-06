using System.Text.Json.Serialization;

namespace ScreenSound_API.Modelos;

internal class Filmes
{
    [JsonPropertyName("title")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? Avaliacao { get; set; }

    public void ExibirOsDadosDoFilme()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Avaliacao: {Avaliacao}");
        Console.WriteLine("");
    }

}
