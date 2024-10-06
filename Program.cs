using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

static async Task<List<Musica>?> ObterListaDeMusicas()
{
    using (HttpClient clientMusicas = new())
    {
        try
        {
            string respostas = await clientMusicas.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            var musicas = JsonSerializer.Deserialize<List<Musica>>(respostas)!;
            return musicas;
        }
        catch (Exception msg)
        {
            Console.WriteLine($"houve um problema durante a execução: {msg}");
            return null;
        }        
    }
}

static async Task<List<Filmes>?> ExibirListaDeFilmes()
{
    using (HttpClient clientFilmes = new())
    {
        try
        {
            string respostas2 = await clientFilmes.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

            var filmes = JsonSerializer.Deserialize<List<Filmes>>(respostas2)!;
            return filmes;
        }
        catch (Exception msg)
        {
            Console.WriteLine($"houve um problema durante a execução: {msg}");
            return null;
        }
    }
}

static async Task ExibirOpcoesDoMenu()
{
    var musicas = await ObterListaDeMusicas();
    var filmes = await ExibirListaDeFilmes();

    Console.WriteLine("\n-OPÇÕES-");
    Console.WriteLine("1- Exibir Músicas");
    Console.WriteLine("2- Exibir Filmes");
    Console.WriteLine("3- Criar minha playlist de 5 músicas");
    Console.WriteLine("4- Sair");

    Console.WriteLine("\nQual a opção desejada?\n");
    int escolha = int.Parse(Console.ReadLine()!);

    switch (escolha)
    {
        case 1:
            
            LinqOrder.RealizarOrdencacaoDaListaDeMusicaPorNome(musicas);
            Console.WriteLine($"\nForam exibidos um total de: {musicas.Count} músicas\n");

            await ExibirOpcoesDoMenu();
            break;

        case 2:
            
            LinqOrder.RealizarOrdencacaoDaListaDeFilmesPorNome(filmes);
            Console.WriteLine($"\nForam exibidos um total de: {filmes.Count} filmes\n");

            await ExibirOpcoesDoMenu();
            break;

        case 3:
            Console.Clear();
            string nome = MinhaListaDeMusicas.NomeDoProprietario();
            MinhaListaDeMusicas list = new(nome);

            Console.Clear();
            LinqOrder.ExibirAs15PrimeirasMusicas(musicas);

            list.AdicionarAsTresMusicas(musicas);
            list.ExportarJson();
            break;

        case 4:
            Console.WriteLine("Tchau tchau =D");
            break;

        default:
            Console.WriteLine("Digite uma opção válida");
            await ExibirOpcoesDoMenu();
            break;
    }

}

await ExibirOpcoesDoMenu();
