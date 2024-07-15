using Refri.Refrigerante;
using Refri.Tamanho;

namespace Refri;

public class Program
{
    public static void Main(string[] args)
    {
        TomarCoca();
        TomarSprite();
        TomarFanta();
        TomarGuarana();
        TomarTubaina();
    }

    private static void TomarTubaina()
    {
        IImplementacaoRefrigerante refrigerante = new Tubaina();
        AbstracaoTamanho extraGrande = new TamanhoExtraGrande(refrigerante);
        extraGrande.Beber();

    }

    private static void TomarGuarana()
    {
        IImplementacaoRefrigerante refrigerante = new Guarana();
        AbstracaoTamanho pequeno = new TamanhoPequeno(refrigerante);
        AbstracaoTamanho medio = new TamanhoMedio(refrigerante);
        AbstracaoTamanho grande = new TamanhoGrande(refrigerante);
        pequeno.Beber();
        medio.Beber();
        grande.Beber();
    }

    private static void TomarCoca()
    {
        IImplementacaoRefrigerante refrigerante = new CocaCola();
        AbstracaoTamanho pequeno = new TamanhoPequeno(refrigerante);
        AbstracaoTamanho medio = new TamanhoMedio(refrigerante);

        pequeno.Beber();
        medio.Beber();
    }

    private static void TomarSprite()
    {
        IImplementacaoRefrigerante refrigerante = new Sprite();
        AbstracaoTamanho familia = new TamanhoFamilia(refrigerante);

        familia.Beber();
    }

    private static void TomarFanta()
    {
        IImplementacaoRefrigerante refrigerante = new Fanta();
        AbstracaoTamanho familia = new TamanhoFamilia(refrigerante);
        AbstracaoTamanho extraGrande= new TamanhoExtraGrande(refrigerante);

        familia.Beber();
        extraGrande.Beber();
    }
}