namespace JewelCollector;
/// <summary>
    /// A classe Map implementa o espaço virtual através do qual o robô se locomove.
/// </summary>
public class Map
{

    /// <summary>
        /// A matrix é um array de duas dimensões e armazena objetos do tipo Entity.
    /// </summary>
    public Entidade[,] matrix = new Entidade[10, 10];

    /// <summary>
        /// O mapa mantém uma contagem de quantas joias ainda estão espalhadas.
    /// </summary>
    public int Jewels { get; set; }



        /// <summary>
        /// Armazena a dimensão do mapa.
    /// </summary>

    public int Dimension { get; set; }
        /// <summary>
        /// O construtor de Map atribui espaços vazios (Space) a todos os índices de sua matriz quando Map é inicializado.
    /// </summary>


    public Map() {

        Dimension = 10;
        
        for ( int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                matrix[i, j] = new Space(); 
            }
        }
        this.Jewels = 0;
    }

    /// <summary>
        /// A função picture() imprime a matrix de Map no console. 
    public void picture(){
        Console.Clear();
        for (int i = 0; i < Dimension; i++)
        {
            for (int j = 0; j < Dimension; j++)
            {
                if (matrix[i, j].GetType() == typeof(Robot)) 
                {

                    Console.Write(matrix[i, j]);

                }
                else if (matrix[i, j].GetType() == typeof(JewelBlue))
                {

                    Console.Write(matrix[i, j]);

                }
                else if (matrix[i, j].GetType() == typeof(JewelRed))
                {

                    Console.Write(matrix[i, j]);

                }
                else if (matrix[i, j].GetType() == typeof(JewelGreen))
                {

                    Console.Write(matrix[i, j]);

                }
                else if (matrix[i, j].GetType() == typeof(Tree))
                {

                    Console.Write(matrix[i, j]);

                }
                else if (matrix[i, j].GetType() == typeof(Water))
                {

                    Console.Write(matrix[i, j]);

                }
                else if (matrix[i, j].GetType() == typeof(Radioactive))
                {

                    Console.Write(matrix[i, j]);

                }
                else
                {
                    Console.Write(matrix[i, j]);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    /// <summary>
        /// A função newMap() cria um novo mapa baseado na propriedade Dimensão do próprio objeto.
    public void newMap()
    { 
        matrix = new Entidade[Dimension, Dimension];
        for (int i = 0; i < Dimension; i++)
        {
            for (int j = 0; j < Dimension; j++)
            {
                matrix[i, j] = new Space();
            }
        }
    }

    /// <summary>
        /// A função insertEntidade insere um elemento do jogo (obstáculo ou jóia) na coordenada especificada. 
    /// </summary>
    /// <param name="i">Especifica a coordenada x da matrix de Map</param>
    /// <param name="j">Especifica a coordenada y da matrix de Map</param>
    /// <param name="e">Especifica a entidade a ser inserida (Tree, Water ou Jewel)</param>
    public void insertEntidade(int i, int j, Entidade e){
        matrix[i, j] = e; 

        if (e.GetType() == typeof(JewelBlue) ||
            e.GetType() == typeof(JewelRed) ||
            e.GetType() == typeof(JewelGreen))
        {
            this.Jewels++;
        }
    }

    /// <summary>
        /// A função removeJewel retira uma joia do mapa, inserindo um espaço vazio em seu lugar e subtraindo 1 do contador de joias.
    /// </summary>
    /// <param name="x">Especifica a coordenada x da joia em Map</param>
    /// <param name="y">Especifica a coordenada y da joia em Map</param>
    public void removeJewel(int x, int y)
    {
        matrix[x, y] = new Space();
        Jewels--;
    }

    /// <summary>
        /// Esta função imprime uma mensagem de vitória .
    /// </summary>
    public void Win()
    {
        Console.WriteLine();

        Console.WriteLine("Parabéns!!!!!");

        Console.WriteLine();
    }

    /// <summary>
        /// Esta função imprime uma mensagem de derrota.
    /// </summary>
    public void Lose()
    {
        Console.WriteLine();

        Console.WriteLine("Game Over !!!!!!");

        Console.WriteLine();
    }
}
