using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos;

internal class Musica
{
    private string[] tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
}; 
    [JsonPropertyName("song")] // anotação, serve para buscar o ID do json especifico, e atribuir a variavel que tem outro nome
    public string? Nome { get; set; } // a interrogação sinaliza que esta variavel PODE receber valores nulos
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade
    { 
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao/1000}");
        Console.WriteLine($"Genero Musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade} ({Key})");
        Console.WriteLine("");

    }
}
