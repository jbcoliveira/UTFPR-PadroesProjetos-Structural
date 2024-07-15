namespace HashMap_Dictionary;

class Program
{
    static void Main(string[] args)
    {
        object[][] matriz = new object[][] {
            new object[] { "Sun", "IBM", "FSF", "Berkley", "Microsoft", "Apple" },
            new object[] { "Solaris", "OS/2", "GNU/Linux", "BSD", "Windows", "MacOS" }
        };

        NovoMapa mapa = new NovoMapa(matriz);

        foreach (KeyValuePair<object, object> par in mapa)
        {
            Console.WriteLine($"{par.Key} => {par.Value}");
        }
    }
}