namespace JewelCollector;
/// <summary>
/// A classe abstrata Jewel  devem ter: coordenadas (x, y) e um valor (pontuação). 
/// </summary>
public abstract class Jewel : Entidade

{


    public int Y { get; set; }
        /// <summary>
    /// Coordenada Y da joia
    /// </summary>
    /// <value></value>
    

        public int X { get; set; }
            /// <summary>
    /// Coordenada X da joia
    /// </summary>
    /// <value></value>

    public int Pontos { get; set; }
        /// <summary>
    /// Pontuação da joia
    /// </summary>
    /// <value></value>
    
}



/// <summary>
/// A classe JewelGreen armazena informações das joias verdes do mapa, com seu valor (50 pontos). 
/// </summary>
public class JewelGreen : Jewel
{
    /// <summary>
    /// O construtor recebe as coordenadas das joias no mapa
    /// </summary>
    /// <param name="a">Coordenada X</param>
    /// <param name="b">Coordenada Y</param>
    public JewelGreen(int a, int b)
    {
        X = a;
        Y = b;
        Pontos = 50;
    }

/// <summary>
/// Este método sobrescreve a função ToString(), retornando uma string (JG) para ser impressa no mapa.
/// </summary>
/// <returns></returns>
public override string ToString()
    {
        return "JG";
    }
}

/// <summary>
/// A classe JewelBlue armazena informações das joias azuis do mapa, como a sua coordenada e seu valor (10 pontos).
/// </summary>
public class JewelBlue : Jewel
{
    /// <summary>
    /// O construtor recebe as coordenadas da joia no mapa
    /// </summary>
    /// <param name="a">Coordenada X</param>
    /// <param name="b">Coordenada Y</param>
    public JewelBlue(int a, int b)
    {
        X = a;
        Y = b;
        Pontos = 10;
    }

/// <summary>
/// Este método sobrescreve a função ToString(), retornando uma string (JB) para ser impressa no mapa.
/// </summary>
/// <returns></returns>
public override string ToString()
    {
        return "JB";
    }
}

/// <summary>
/// A classe JewelRed armazena informações das joias vermelhas do mapa, como a sua coordenada e seu valor (100 pontos). 
/// </summary>
public class JewelRed : Jewel
{
    /// <summary>
    /// O construtor recebe as coordenadas da joia no mapa
    /// </summary>
    /// <param name="a">Coordenada X</param>
    /// <param name="b">Coordenada Y</param>
    public JewelRed(int a, int b)
    {
        X = a;
        Y = b;
        Pontos = 100;
    }

/// <summary>
/// Este método sobrescreve a função ToString(), retornando uma string (JR) para ser impressa no mapa.
/// </summary>
public override string ToString()
    {
        return "JR";
    }
}