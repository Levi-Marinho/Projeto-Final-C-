namespace JewelCollector;
/// <summary>
    /// A classe Obstacle especifica as propriedades que todos os obstáculos devem ter: coordenadas (x, y) e um tipo (Tree ou Water).
/// </summary>
public abstract class Obstacle : Entidade
{

        /// <summary>
        /// Especifica o tipo de obstáculo.
    /// </summary>
    public ObstacleType Type { get; set; }


    /// <summary>
        /// Especifica a coordenada x do obstáculo no mapa.
    /// </summary>
    public int X { get; set; }

    /// <summary>
        /// Especifica a coordenada y do obstáculo no mapa.
    /// </summary>
    public int Y { get; set; }


}



/// <summary>
    /// Tree é um tipo de obstáculo intransponível do mapa. 
/// </summary>
public class Tree : Obstacle
{   
    /// <summary>
        /// O obstáculo do tipo árvore, assim como a joia azul, fornece energia ao robô (joia azul fornece 5 pontos de energia, e árvore fornece 3). O jogador pode coletar a energia de uma árvore por até 6 vezes. Depois disso, a energia da árvore se esgota.
    /// </summary>
    /// <value></value>
    public int Energia { get; set; }
    public Tree(int a, int b)
    {
        X = a;
        Y = b;
        Type = ObstacleType.Tree;
        Energia = 6;
    }

 public override string ToString()
    {
        return "$$";
    }
}

/// <summary>
    /// ObstacleType enumera os tipos de obstáculos do mapa
/// </summary>
public enum ObstacleType
{
    Water, Tree
}

/// <summary>
    /// Water é um tipo de obstáculo intransponível do mapa. 
/// </summary>
public class Water : Obstacle
{
    public Water(int a, int b)
    {
        X = a;
        Y = b;
        Type = ObstacleType.Water;
    }
    public override string ToString()
    {
        return "##";
    }
}