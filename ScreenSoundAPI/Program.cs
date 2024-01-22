
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new()) // cria uma variavel com o objeto HttpClient, para usarmos os metodos dele
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        // Para melhor entendimento: antes de usarmos a classe "HttpClient" na variavel "client", primeiro será executado tudo dentro das chaves, e depois é passado para a variavel "client"
        // No caso acima: estamos requisitando ao endereço, todo o conteudo como string, para ser guardada na variavel resposta, e enquanto esta requisição não terminar, a linha vai esperar (await) até que o programa possa continuar
        // O metodo assincrono: garante que tudo da requisição será lido, mesmo que o programa continue executando, enquanto o "await" diz para a variavel "resposta" esperar todo o conteudo ser lido antes de ser atribuido a ela

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // desserializa (converte) o JSON para um objeto do tipo que a linguagem consegue manipilar
        Console.WriteLine(musicas.Count);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um probleminha: {ex.Message}"); // caso o endereço da requisição nao esteja disponivel, será gerado um erro, e este erro será capturado, então terá sua mensagem exibida no console
    }
}
