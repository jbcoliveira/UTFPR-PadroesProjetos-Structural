namespace Interceptador53;

using System;
using System.Globalization;
using System.Threading;

public interface IComponente
{
    void ExecutarTarefa();
}

public class ComponenteConcreto : IComponente
{
    public void ExecutarTarefa()
    {
        Console.Write("Dormindo 2 segundos... ");

        try
        {
            Thread.Sleep(2000);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro!");
            return;
        }

        Console.WriteLine(" OK!");
    }
}
public class InterceptadorCronometro : IComponente
{
    private IComponente componente;
    public InterceptadorCronometro(IComponente componente)
    {
        this.componente = componente;
    }

    public void ExecutarTarefa()
    {
        long antes = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        componente.ExecutarTarefa();
        long depois = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        Console.WriteLine("[CRN] " + (depois - antes) + " ms");
    }
}

public class InterceptadorLog : IComponente
{
    private IComponente componente;

    private DateTimeFormatInfo timestampFormat = CultureInfo.CurrentCulture.DateTimeFormat;
    public InterceptadorLog(IComponente componente)
    {
        this.componente = componente;
    }

    public void ExecutarTarefa()
    {
        Console.WriteLine("[LOG] " + DateTime.Now.ToString(timestampFormat.ShortDatePattern + " " + timestampFormat.ShortTimePattern) + ": executando a tarefa.");
        componente.ExecutarTarefa();
    }
}

public class InterceptadorVerificaMinuto : IComponente
{
    private IComponente componente;

    private DateTimeFormatInfo timestampFormat = CultureInfo.CurrentCulture.DateTimeFormat;

    public InterceptadorVerificaMinuto(IComponente componente)
    {
        this.componente = componente;
    }

    public void ExecutarTarefa()
    {
        DateTime agora = DateTime.Now;
        int minuto = agora.Minute;

        if ((minuto % 2) == 0)
        {
            Console.WriteLine("[MIN] Execução interrompida em minuto par: " + agora.ToString(timestampFormat.ShortTimePattern));
        }
        else
        {
            componente.ExecutarTarefa();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IComponente comp = new InterceptadorLog(new InterceptadorVerificaMinuto(new InterceptadorCronometro(new ComponenteConcreto())));

        comp.ExecutarTarefa();
    }
}