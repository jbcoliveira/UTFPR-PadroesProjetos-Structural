namespace Tabela;

public class Linha : IComponenteTabela
{
    private List<IComponenteTabela> _celulas = new List<IComponenteTabela>();

    public void Adicionar(IComponenteTabela componente)
    {
        _celulas.Add(componente);
    }

    public void Imprimir()
    {

        // Imprime as células da linha.
        foreach (var celula in _celulas)
        {
            celula.Imprimir();
        }
        Console.WriteLine(" |");

        // Imprime a linha separadora.
        int tamanho = (_celulas.Count * 17) +3;
        char[] linha = new char[tamanho];
        for (int i = 0; i < tamanho; i++)
            linha[i] = '-';
        Console.WriteLine(" " + new string(linha));
    }
}