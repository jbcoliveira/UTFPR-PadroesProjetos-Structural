namespace HierarquiaLista;

// Hierarquia da Esquerda

// Hierarquia da Direita

// Exemplo de uso
public class Program
{
    public static void Main(string[] args)
    {
        IImpressoraLista impressoraNumerada = new ImpressoraNumerada();
        IImpressoraLista impressoraLetras = new ImpressoraLetras();
        IImpressoraLista impressoraMarcadores = new ImpressoraMarcadores("*");

        ILista listaOrdenada = new ListaOrdenada(impressoraNumerada);
        listaOrdenada.Adicionar("Banana");
        listaOrdenada.Adicionar("Maçã");
        listaOrdenada.Adicionar("Abacaxi");
        listaOrdenada.Imprimir();

        ILista listaNaoOrdenada = new ListaNaoOrdenada(impressoraLetras);
        listaNaoOrdenada.Adicionar("Cachorro");
        listaNaoOrdenada.Adicionar("Gato");
        listaNaoOrdenada.Adicionar("Elefante");
        listaNaoOrdenada.Imprimir();

        ILista listaOrdenadaComMarcador = new ListaOrdenada(impressoraMarcadores);
        listaOrdenadaComMarcador.Adicionar("Item 1");
        listaOrdenadaComMarcador.Adicionar("Item 2");
        listaOrdenadaComMarcador.Adicionar("Item 4");
        listaOrdenadaComMarcador.Adicionar("Item 3");
        listaOrdenadaComMarcador.Imprimir();
    }
}