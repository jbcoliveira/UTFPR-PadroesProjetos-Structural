namespace SistemaArquivos;

public class Pasta : IComponenteSistemaArquivo
{
    private string _nome;
    private List<IComponenteSistemaArquivo> _itens = new();

    public Pasta(string nome)
    {
        _nome = nome;
    }

    public void Adicionar(IComponenteSistemaArquivo item)
    {
        _itens.Add(item);
    }

    public void Imprimir(string indentacao)
    {
        Console.WriteLine($"{indentacao}Pasta: {_nome}");
        foreach (var item in _itens)
        {
            item.Imprimir(indentacao + "  ");
        }
    }

    public int ObterTamanho()
    {
        int tamanhoTotal = 0;
        foreach (var item in _itens)
        {
            tamanhoTotal += item.ObterTamanho();
        }
        return tamanhoTotal;
    }
}