namespace HierarquiaLista;

public class ImpressoraMarcadores : IImpressoraLista
{
    private string _marcador;

    public ImpressoraMarcadores(string marcador)
    {
        _marcador = marcador;
    }

    public void Imprimir(List<string> itens)
    {
        foreach (var item in itens)
        {
            Console.WriteLine($"{_marcador} {item}");
        }
    }
}