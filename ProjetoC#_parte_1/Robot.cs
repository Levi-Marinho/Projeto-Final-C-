namespace JewelCollector;

public class Robot : Entidade
{


    public Robot(int x, int y)
    {
        a = x;
        b = y;
    }


    public void direita(Map m)
    {

        
        try
        {
            if (m.matrix[a, b + 1].GetType() == typeof(Space))
            {
                m.matrix[a, b + 1] = m.matrix[a, b];
                m.matrix[a, b] = new Space();
                this.b++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalido!");
        }
    }

    public void esquerda(Map m)
    {

        
        try
        {
            if (m.matrix[a, b - 1].GetType() == typeof(Space))
            {
                m.matrix[a, b - 1] = m.matrix[a, b];
                m.matrix[a, b] = new Space();
                this.b--;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalido");
        }
    }
    
    public void Norte(Map m)
    {


        try
        {
            if (m.matrix[a - 1, b].GetType() == typeof(Space))
            {
                m.matrix[a - 1, b] = m.matrix[a, b];
                m.matrix[a, b] = new Space();
                a--;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalido");
        }

    }

    public void sul(Map m)
    {

        
        try
        {
            if (m.matrix[a + 1, b].GetType() == typeof(Space))
            {
                m.matrix[a + 1, b] = m.matrix[a, b];
                m.matrix[a, b] = new Space();
                this.a++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalido!");
        }
    }

    public void coleta(Map m)
    {

        this.Coletaesquerda(m);
        this.Coletadireita(m);        
        this.Coletacima(m);
        this.Coletabaixo(m);

    }

    private void Coletaesquerda(Map m)
    {

        
        try
        {
            if (m.matrix[a, b - 1].GetType() != typeof(JewelBlue) ||
                m.matrix[a, b - 1].GetType() != typeof(JewelRed) ||
                m.matrix[a, b - 1].GetType() != typeof(JewelGreen))
            {
                Bolsa.Add((Jewel)m.matrix[a, b - 1]);
                m.removeJ(a, b - 1);
            }
        }
        catch (Exception) { }
    }

    private void Coletadireita(Map m)
    {

        
        try
        {
            if (m.matrix[a, b + 1].GetType() != typeof(JewelBlue) ||
                m.matrix[a, b + 1].GetType() != typeof(JewelRed) ||
                m.matrix[a, b + 1].GetType() != typeof(JewelGreen))
            {
                this.Bolsa.Add((Jewel)m.matrix[a, b + 1]);
                m.removeJ(a, b + 1);
            }
        }
        catch (Exception) { }
    }

    private void Coletacima(Map m)
    {

        
        try
        {

            if (m.matrix[a - 1, b].GetType() == typeof(JewelBlue) ||
            m.matrix[a - 1, b].GetType() == typeof(JewelRed) ||
            m.matrix[a - 1, b].GetType() == typeof(JewelGreen))
            {
                this.Bolsa.Add((Jewel)m.matrix[a - 1, b]);
                m.removeJ(a - 1, b);
            }
        }
        catch (Exception) { }
    }

    private void Coletabaixo(Map m)
    {

        
        try
        {

            if (m.matrix[a + 1, b].GetType() != typeof(JewelBlue) ||
                m.matrix[a + 1, b].GetType() != typeof(JewelRed) ||
                m.matrix[a + 1, b].GetType() != typeof(JewelGreen))
            {
                this.Bolsa.Add((Jewel)m.matrix[a + 1, b]);
                m.removeJ(a + 1, b);
            }
        }
        catch (Exception) { }
    }

    public void TotalJewels()
    {

        
        Console.Write("Bag total items: " + this.Bolsa.Count + " | ");
    }
    public void ValorTotal()
    {

        
        int total = 0;
        for (int i = 0; i < Bolsa.Count; i++)
        {
            total += Bolsa[i].Pontos;
        }
        Console.WriteLine("Bag total value: " + total);
    }

    public override string ToString()
    {
        return "ME";
    }


    public int a { get; set; }
    public int b { get; set; }
    public List<Jewel> Bolsa { get; set; } = new List<Jewel>(); 
}
