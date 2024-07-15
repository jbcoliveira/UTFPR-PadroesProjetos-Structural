namespace Tabela;

public class Celula : IComponenteTabela
{
    private string _conteudo;

    public Celula(string conteudo)
    {
        if (conteudo.Length > 15)
        {
            _conteudo = conteudo.Substring(0, 15);
        }
        else
        {
            _conteudo = conteudo.PadRight(15);
        }
    }

    public void Adicionar(IComponenteTabela componente)
    {
        throw new NotImplementedException("Não é possível adicionar a uma célula.");
    }

    public void Imprimir()
    {
        // Imprime na mesma linha e com borda lateral.
        Console.Write(" | " + _conteudo);
    }
}