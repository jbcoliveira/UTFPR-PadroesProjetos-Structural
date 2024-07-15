namespace Tabela;

public class Program
{
    public static void Main(string[] args)
    {
        // Criação das células
        Celula celula1 = new Celula("Celula 1");
        Celula celula2 = new Celula("Celula 2");
        Celula celula3 = new Celula("Celula 3");
        Celula celula4 = new Celula("Celula 4");
        Celula celula5 = new Celula("Celula 5");

        // Criação das linhas
        Linha linha1 = new Linha();
        Linha linha2 = new Linha();
        Linha linha3 = new Linha();

        // Adição de células às linhas
        linha1.Adicionar(celula1);
        linha1.Adicionar(celula2);
        linha2.Adicionar(celula3);
        linha2.Adicionar(celula4);
        linha3.Adicionar(celula5);

        // Criação da tabela
        Tabela tabela = new Tabela();

        // Adição de linhas à tabela
        tabela.Adicionar(linha1);
        tabela.Adicionar(linha2);
        tabela.Adicionar(linha3);

        // Impressão da tabela
        tabela.Imprimir();
    }
}