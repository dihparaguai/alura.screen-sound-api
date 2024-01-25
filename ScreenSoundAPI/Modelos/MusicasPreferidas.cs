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
    }
}
