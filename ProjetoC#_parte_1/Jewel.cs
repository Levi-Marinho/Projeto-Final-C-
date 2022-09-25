namespace JewelCollector;

public abstract class Jewel : Entidade
{


    public int Pontos { get; set; }

    public int a { get; set; }

    public int b { get; set; }
}





public class JewelBlue : Jewel
{

    
    public JewelBlue(int x, int y)
    {
        a = x;
        b = y;
        Pontos = 10;
    }

public override string ToString()
    {

        
        return "JB";
    }
}


public class JewelRed : Jewel
{

    public JewelRed(int x, int y)
    {
        a = x;
        b = y;
        Pontos = 100;
    }

public override string ToString()
    {

        
        return "JR";
    }
}

public class JewelGreen : Jewel
{

    
    public JewelGreen(int x, int y)
    {
        a = x;
        b = y;
        Pontos = 50;
    }

public override string ToString()
    {

        
        return "JG";
    }
}
