namespace SistemaArquivos;

public interface IComponenteSistemaArquivo
{
    void Imprimir(string indentacao);
    int ObterTamanho();
}