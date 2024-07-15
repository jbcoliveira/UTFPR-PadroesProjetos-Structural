namespace Somador;

public class Cliente
{
    private ISomadorEsperado _somador;

    public Cliente(ISomadorEsperado somador)
    {
        _somador = somador;
    }

    public void Executar()
    {
        int[] vetor = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int soma = _somador.SomaVetor(vetor);
        Console.WriteLine("Resultado: " + soma);
    }


}