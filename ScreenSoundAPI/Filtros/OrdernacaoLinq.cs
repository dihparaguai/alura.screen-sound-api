using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class OrdernacaoLinq
{
    public static void ArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("\nArtistas Ordenados:"); // pega o parametro, e ordena os artidas por ordem alfabetica, depois seleciona todos esses artistas dos objetos, sendo não repetidos (distinct), convertidos numa "list" de string
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($" --> {artista}"); // exibe cada um dos artistas da list na var "artistasOrdenados"
        }
    }
}
