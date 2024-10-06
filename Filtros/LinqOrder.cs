using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqOrder
{
    public static void RealizarOrdencacaoDaListaDeMusicaPorNome(List<Musica> lista)
    {
        var nomesOrdenados = lista.OrderBy(x => x.Nome).Select(x => x.Nome).Distinct().ToList();

        foreach (var x in nomesOrdenados)
        {
            Console.WriteLine(x);
        }
    }

    public static void RealizarOrdencacaoDaListaDeFilmesPorNome(List<Filmes> lista)
    {
        var nomesOrdenados = lista.OrderBy(x => x.Nome).Select(x => x.Nome).Distinct().ToList();

        foreach (var x in nomesOrdenados)
        {
            Console.WriteLine(x);
        }
    }

    public static void ExibirAs15PrimeirasMusicas(List<Musica> music)
    {
        Console.WriteLine("AQUI ESTÁ UMA CONSULTA DA LISTA DE MÚSICAS PARA AUXILIAR NA SUA PLAYLIST!\n");
        for (int i = 50; i < 81; i++)
        {
            Console.WriteLine($"{i} - {music[i].Nome}");
        }
        Console.WriteLine();
    }
}
