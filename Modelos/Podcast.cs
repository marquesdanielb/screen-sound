namespace ScreenSound.Modelos;

internal class Podcast
{
    List<Episodio> episodios = new();
    public Podcast(string host, string nome)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Podcast: {Nome}. Host: {Host}\n");
        Console.WriteLine("Detalhes dos episodios:\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"{episodio.Resumo}");
        }
        Console.WriteLine($"Esse podcast tem um total de {TotalEpisodios}.");
    }
}
