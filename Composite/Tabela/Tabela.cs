namespace Tabela;

public class Tabela : IComponenteTabela
{
    private List<IComponenteTabela> _linhas = new();

    public void Adicionar(IComponenteTabela componente)
    {
        _linhas.Add(componente);
    }

    public void Imprimir()
    {
        foreach (var linha in _linhas)
        {
            linha.Imprimir();
        }
        Console.WriteLine();
    }
}