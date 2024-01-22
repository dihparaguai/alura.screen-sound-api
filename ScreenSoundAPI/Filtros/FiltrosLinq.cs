using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class FiltrosLinq
{
    public static void FiltrarTodosGeneros (List <Musica> musicas)
    {
        var todosGeneros = musicas.Select(musica => musica.Genero).Distinct().ToList(); // pega o parametro, e seleciona todos os generos dos objetos, sendo não repetidos, convertidos numa lista
        Console.WriteLine("\nTodos os Generos:");
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($" --> {genero}"); // exibe cada um dos generos da lista que foi selecionada na var "todosGeneros"
        }

    }
}
