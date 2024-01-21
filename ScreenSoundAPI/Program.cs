using (HttpClient client = new HttpClient()) // cria uma variavel com o objeto HttpClient, para usarmos os metodos dele
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
}
