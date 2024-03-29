﻿using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new()) // cria uma variavel com o objeto HttpClient, para usarmos os metodos dele
{
    try
    {
        Console.WriteLine("Iniciando...");
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        // Para melhor entendimento: antes de usarmos a classe "HttpClient" na variavel "client", primeiro será executado tudo dentro das chaves, e depois é passado para a variavel "client"
        // No caso acima: estamos requisitando ao endereço, todo o conteudo como string, para ser guardada na variavel resposta, e enquanto esta requisição não terminar, a linha vai esperar (await) até que o programa possa continuar
        // O metodo assincrono: garante que tudo da requisição será lido, mesmo que o programa continue executando, enquanto o "await" diz para a variavel "resposta" esperar todo o conteudo ser lido antes de ser atribuido a ela

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // desserializa (converte) o JSON para um objeto do tipo que a linguagem consegue manipilar
        musicas[2].ExibirDetalhesMusica();
        musicas[12].ExibirDetalhesMusica();
        musicas[24].ExibirDetalhesMusica();
        musicas[36].ExibirDetalhesMusica();
        musicas[48].ExibirDetalhesMusica();
        musicas[50].ExibirDetalhesMusica();
        musicas[52].ExibirDetalhesMusica();
        musicas[64].ExibirDetalhesMusica();
        musicas[76].ExibirDetalhesMusica();
        musicas[89].ExibirDetalhesMusica();
        musicas[97].ExibirDetalhesMusica();

        Console.WriteLine($"Quantidade de Musicas: {musicas.Count}\n");

        
        FiltrosLinq.FiltrarTodosGeneros(musicas);
        OrdernacaoLinq.ArtistasOrdenados(musicas);
        FiltrosLinq.FiltrarArtistasPorGenero(musicas, "R&B");
        FiltrosLinq.FiltrarMusicasPorArtista(musicas, "Michel Teló");
        FiltrosLinq.MusicasCSharp(musicas);

        var musicasPreferidasDoDiego = new MusicasPreferidas("Diego");
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[99]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[88]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[77]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[66]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[55]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[44]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[33]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[22]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[11]);
        musicasPreferidasDoDiego.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoDiego.ExibirMusicasFavoritas();

        musicasPreferidasDoDiego.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um probleminha: {ex.Message}"); // caso o endereço da requisição nao esteja disponivel, será gerado um erro, e este erro será capturado, então terá sua mensagem exibida no console
    }
}
