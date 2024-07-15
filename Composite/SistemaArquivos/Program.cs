namespace SistemaArquivos;

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Criação dos arquivos
        Arquivo arquivo1 = new Arquivo("arquivo1.txt", 100);
        Arquivo arquivo2 = new Arquivo("arquivo2.txt", 200);
        Arquivo arquivo3 = new Arquivo("arquivo3.txt", 300);

        // Criação das pastas
        Pasta pasta1 = new Pasta("pasta1");
        Pasta pasta2 = new Pasta("pasta2");
        Pasta pasta3 = new Pasta("pasta3");

        // Construção da estrutura do sistema de arquivos
        pasta1.Adicionar(arquivo1);
        pasta1.Adicionar(arquivo2);
        pasta2.Adicionar(arquivo3);
        pasta3.Adicionar(pasta1);
        pasta3.Adicionar(pasta2);

        // Impressão da estrutura e tamanho
        pasta3.Imprimir("");
        Console.WriteLine($"Tamanho total da pasta3: {pasta3.ObterTamanho()} KB");
    }
}