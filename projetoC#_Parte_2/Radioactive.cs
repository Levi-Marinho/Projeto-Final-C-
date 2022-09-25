namespace JewelCollector;
/// <summary>
    /// Radioactive é um elemento que aparece a partir da fase 2 do mapa. O robô perde 10 pontos de energia ao se aproximar de um elemento radioativo, e 30 pontos de energia caso o atravesse.
/// </summary>
public class Radioactive : Entidade
{
    /// <summary>
        /// Especifica a coordenada x do objeto radioativo.
    /// </summary>
    public int X { get; set; }

    /// <summary>
        /// Especifica a coordenada y do objeto radioativo.
    /// </summary>
    public int Y { get; set; }

    /// <summary>
        /// O construtor inicia um elemento em uma coordenada (x, y) especifica.
    /// </summary>
    /// <param name="a">Especifica a coordenada x de Radioactive</param>
    /// <param name="b">Especifica a coordenada y de Radioactive</param>
    public Radioactive(int a, int b)
    {
        X = a;
        Y = b;
    }

    public override string ToString()
    {
        return "!!";
    }
}

