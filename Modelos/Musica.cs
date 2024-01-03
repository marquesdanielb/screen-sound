namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"{Nome} - {Artista.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        }
        else
        {
            Console.WriteLine($"Adquira o plano Plus+");
        }
    }
}
