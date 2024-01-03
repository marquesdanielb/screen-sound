namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = ValidarNota(nota);
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }

    public int ValidarNota(int nota)
    {
        if (nota < 0 && nota > 10)
        {
            return 0;
        }

        return nota;
    }
}