namespace JewelCollector;




public class Tree : Obstacle
{

    public Tree(int x, int y)
    {
        a = x;
        b = y;
        Tipo = ObstacleTipo.Tree;
    }

 public override string ToString()
    {
        return "$$";
    }
}
public class Water : Obstacle
{


    public Water(int x, int y)
    {
        a = x;
        b = y;
        Tipo = ObstacleTipo.Water;
    }
    public override string ToString()
    {
        return "##";
    }
}

public enum ObstacleTipo
{
    Water, Tree
}
public abstract class Obstacle : Entidade
{


    public int a { get; set; }
    public int b { get; set; }
    public ObstacleTipo Tipo { get; set; }
}