namespace SistemaArquivos;

public class Arquivo : IComponenteSistemaArquivo
{
    private string _nome;
    private int _tamanho;

    public Arquivo(string nome, int tamanho)
    {
        _nome = nome;
        _tamanho = tamanho;
    }

    public void Imprimir(string indentacao)
    {
        Console.WriteLine($"{indentacao}Arquivo: {_nome} ({_tamanho} KB)");
    }

    public int ObterTamanho()
    {
        return _tamanho;
    }
}