namespace Numero;

public class Program
{
    public static void Main(string[] args)
    {
        // Número simples
        INumero numero = new NumeroUm();
        Console.Write("Número simples: ");
        numero.Imprimir();
        Console.WriteLine();

        // Número com parênteses
        INumero numeroParenteses = new ParentesesDecorator(new NumeroUm());
        Console.Write("Número com parênteses: ");
        numeroParenteses.Imprimir();
        Console.WriteLine();

        // Número com colchetes
        INumero numeroColchetes = new ColchetesDecorator(new NumeroUm());
        Console.Write("Número com colchetes: ");
        numeroColchetes.Imprimir();
        Console.WriteLine();

        // Número com chaves
        INumero numeroChaves = new ChavesDecorator(new NumeroUm());
        Console.Write("Número com chaves: ");
        numeroChaves.Imprimir();
        Console.WriteLine();

        // Número com parênteses e colchetes
        INumero numeroParentesesColchetes = new ColchetesDecorator(new ParentesesDecorator(new NumeroUm()));
        Console.Write("Número com parênteses e colchetes: ");
        numeroParentesesColchetes.Imprimir();
        Console.WriteLine();

        // Número com colchetes e chaves
        INumero numeroColchetesChaves = new ChavesDecorator(new ColchetesDecorator(new NumeroUm()));
        Console.Write("Número com colchetes e chaves: ");
        numeroColchetesChaves.Imprimir();
        Console.WriteLine();

        // Número com parênteses, colchetes e chaves
        INumero numeroCompleto = new ChavesDecorator(new ColchetesDecorator(new ParentesesDecorator(new NumeroUm())));
        Console.Write("Número com parênteses, colchetes e chaves: ");
        numeroCompleto.Imprimir();
        Console.WriteLine();
    }
}