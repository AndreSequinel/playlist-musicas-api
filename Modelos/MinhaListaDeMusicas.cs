using System.Text.Json;

namespace ScreenSound_API.Modelos;

internal class MinhaListaDeMusicas
{

    public string Nome  { get; set; }
    public List<Musica> MinhaLista { get; set; }

    public MinhaListaDeMusicas(string nome)
    {
        Nome = nome;
        MinhaLista = new List<Musica>();
    }

    public static string NomeDoProprietario()
    {
        Console.WriteLine("\nQual nome deve ser atribuído a playlist?\n");
        string nome = Console.ReadLine()!.ToUpper();

        Console.WriteLine($"Nome -{nome}- foi desginado para sua playlist!");
        Console.WriteLine("Aguarde enquanto redirecionamos você.....");
        Thread.Sleep( 4000 );

        return nome;
    }

    public void AdicionarAsTresMusicas(List<Musica> listaDaApi)
    {
        Console.WriteLine("\nDIGITE O NÚMERO DA MÚSICA QUE DESEJA ADICIONAR");

        Console.WriteLine("\nMúsica 1:");
        int musica1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nMúsica 2:");
        int musica2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nMúsica 3:");
        int musica3 = int.Parse(Console.ReadLine()!);

        MinhaLista.Add(listaDaApi[musica1]);
        MinhaLista.Add(listaDaApi[musica2]);
        MinhaLista.Add(listaDaApi[musica3]);

        Console.WriteLine($"\nMÚSICAS ADICIONADAS À PLAYLIST: \n1- {listaDaApi[musica1].Nome} \n2- {listaDaApi[musica2].Nome} \n3- {listaDaApi[musica3].Nome} ");
    }

    public void ExportarJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = MinhaLista

        });

        string nomeDoArquivo = $"musicas-fav-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine("\nAquivo JSON exportado para:");
        string path = Path.GetFullPath(nomeDoArquivo);
        Console.WriteLine(path);
    }
}
