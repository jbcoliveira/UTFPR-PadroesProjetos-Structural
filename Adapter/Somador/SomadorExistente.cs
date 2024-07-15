namespace Somador;

public class SomadorExistente
{
    public int SomaLista(List<int> lista)
    {
        int resultado = 0;
        foreach (int i in lista)
        {
            resultado += i;
        }
        return resultado;
    }
}