﻿using System.Text.Json;

namespace ScreenSoundAPI.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; set; }

    public MusicasPreferidas (string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica> ();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasPreferidas.Add (musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"\nEssas são as musicas favoridas de {Nome}");
        foreach (var musica in  ListaDeMusicasPreferidas)
        {
            Console.WriteLine($" ==> \"{musica.Nome}\" de \"{musica.Artista}\"");
        }
        Console.WriteLine("");
    }

    public void GerarArquivoJson ()
    {
        string json = JsonSerializer.Serialize(new // este new é um objeto anonimo, que cria uma estrutura temporaria
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });
        string nomeDoArquivo = $"musicas-favoritas-de-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json); // cria arquivos 
        Console.WriteLine($"Arquivo Json criado com sucesso em {Path.GetFullPath(nomeDoArquivo)}"); // mostra o caminho de onde o json foi criado
    }
}
