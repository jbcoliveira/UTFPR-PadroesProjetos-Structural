namespace HashMap_Dictionary;

public class NovoMapa : Dictionary<object, object>
{
    public NovoMapa(object[][] matriz)
    {
        if (matriz.Length != 2)
            throw new ArgumentException();

        object[] chaves = matriz[0];
        object[] colunas = matriz[1];

        for (int i = 0; i < chaves.Length; i++)
            this[chaves[i]] = colunas[i];
    }
}