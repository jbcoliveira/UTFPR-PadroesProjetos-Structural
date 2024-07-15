namespace Somador;

class Program
{
    static void Main(string[] args)
    {
        ISomadorEsperado somador = new SomadorAdapter(new SomadorExistente());
        Cliente cliente = new Cliente(somador);
        cliente.Executar();
    }
}