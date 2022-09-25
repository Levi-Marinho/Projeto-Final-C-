namespace JewelCollector;



public class Map

{







    public Map() {

        
        for ( int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                matrix[i, j] = new Space(); 
            }
        }

        this.Jewels = 0;
        
    }


    public void insertEntidade(int i, int j, Entidade e){

        
        matrix[i, j] = e; 

        if (e.GetType() == typeof(JewelBlue) ||
            e.GetType() == typeof(JewelRed) ||
            e.GetType() == typeof(JewelGreen))
        {
            Jewels++;
        }
    }


    public void picture(){

        

        string line = "";
         for ( int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                line += matrix[i, j] + " "; 
            }
            line += "\n";
        }
        Console.WriteLine(line);
    }
    public void Win()
    {
        Console.WriteLine();
        Console.WriteLine("Parabéns!!!");
        Console.WriteLine();
    }

        public void removeJ(int a, int b)
    {

        
        matrix[a, b] = new Space();
        Jewels--;
    }
        public int Jewels { get; set; }
        public Entidade[,] matrix = new Entidade[10, 10];

}

