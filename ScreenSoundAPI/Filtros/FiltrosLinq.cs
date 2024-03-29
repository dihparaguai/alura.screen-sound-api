﻿using ScreenSoundAPI.Modelos;

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

    public static void FiltrarArtistasPorGenero (List <Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList(); // pega o primeiro parametro, e filtra (Where) os generos se conter (Contains) o valor do segundo parametro, depois seleciona (Select) todos esses artistas dos objetos, sendo não repetidos (Distinct), convertidos numa "list" de string (ToList)

        Console.WriteLine("\nArtistas Filtados por Genero:");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($" --> {artista}"); // exibe cada um dos artistas da list na var "artistasPorGenero"
        }
    }

    public static void FiltrarMusicasPorArtista (List <Musica> musicas, string artista)
    {
        var musicaPorArtista = musicas.Where(musica => musica.Artista.Equals(artista)).Select(musica => musica.Nome).ToList();
        Console.WriteLine($"\nMusicas Filtadas do Artista {artista}:");
        foreach (var musica in musicaPorArtista)
        {
            Console.WriteLine($" --> {musica}");
        }

    }

    public static void MusicasCSharp (List<Musica> musicas)
    {
        var musicasCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine("\nMusicas de Tonalidade C#:");
        foreach (var musica in musicasCSharp)
        {
            Console.WriteLine($"{musica}");
        }
    }
}
