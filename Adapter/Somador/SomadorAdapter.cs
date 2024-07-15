namespace Somador;

public class SomadorAdapter : ISomadorEsperado
{
    private SomadorExistente _somadorExistente;

    public SomadorAdapter(SomadorExistente somadorExistente)
    {
        _somadorExistente = somadorExistente;
    }

    public int SomaVetor(int[] vetor)
    {
        List<int> lista = vetor.ToList();
        return _somadorExistente.SomaLista(lista);
    }
}