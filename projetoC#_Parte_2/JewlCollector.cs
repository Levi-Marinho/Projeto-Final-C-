namespace JewelCollector;

/// <summary>
/// A classe JewelCollector é responsável por criar o mapa, inserir as joias, obstáculos, instanciar o robô e ler os comandos do teclado.
/// </summary>
public class JewelCollector
{
        public JewelCollector()
            /// <summary>
        ///  Round, inicia com valor igual a 1.
    /// </summary>
        
    {
        Round = 1;
    }





    /// <summary>
        /// A propriedade Round armazena a rodada atual
    /// </summary>
    /// <value>Inteiro não negativo</value>
    public int Round { get; set; }




    public void BuildMap(Map m, Robot r)
        /// <summary>
        /// A função BuildMap insere os elementos do jogo no mapa. A partir da fase 2, os elementos são inseridos de maneira aleatória.
            /// <param name="m">Especifica o objeto do tipo Map no qual serão inseridos os elementos</param>
    /// <param name="r">Especifica o robô que irá interagir com o mapa</param>
    /// </summary>
    {
        m.insertEntidade(0, 0, r);
        if (Round == 1)
        {
        m.insertEntidade(0, 0, r);
        m.insertEntidade(5, 7, new Tree(5, 7));
        m.insertEntidade(3, 7, new Tree(3, 7));
        m.insertEntidade(8, 3, new Tree(8, 3));
        m.insertEntidade(1, 3, new Tree(1, 3));
        m.insertEntidade(1, 4, new Tree(1, 4));
        m.insertEntidade(7, 1, new Water(7, 1));
        m.insertEntidade(7, 2, new Water(7, 2));
        m.insertEntidade(7, 3, new Water(7, 3));
        m.insertEntidade(7, 4, new Water(7, 4));
        m.insertEntidade(5, 5, new Water(5, 5));
        m.insertEntidade(5, 0, new Water(5, 0));
        m.insertEntidade(1, 6, new JewelRed(1, 6));
        m.insertEntidade(8, 6, new JewelRed(8, 6));
        m.insertEntidade(9, 7, new JewelGreen(9, 7));
        m.insertEntidade(7, 6, new JewelGreen(7, 6));
        m.insertEntidade(3, 4, new JewelBlue(3, 4));
        m.insertEntidade(2, 1, new JewelBlue(2, 1));
        }
        
        else
        {
            for (int i = 0; i < m.Dimension; i++)
            {
                for (int j = 0; j < m.Dimension; j++)
                {
                    if (i != 0 && j != 0)
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(1, 24);
                        if (num <= 6)
                        {
                            switch (num)
                            {
                                case 1: 
                                    m.insertEntidade(i, j, new Water(i, j));
                                    break;
                                case 2:
                                    m.insertEntidade(i, j, new Tree(i, j));
                                    break;
                                case 3:
                                    m.insertEntidade(i, j, new JewelBlue(i, j));
                                    break;
                                case 4:
                                    m.insertEntidade(i, j, new JewelRed(i, j));
                                    break;
                                case 5:
                                    m.insertEntidade(i, j, new JewelGreen(i, j));
                                    break;
                                case 6:
                                    m.insertEntidade(i, j, new Radioactive(i, j));
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>
        /// O método Main é o ponto de início da execução. Os elementos do jogo são criados e um loop é iniciado.
    /// </summary>
    public static void Main()
    {
        Map m = new Map();
        Robot r = new Robot(0, 0);
        JewelCollector j = new JewelCollector();
        j.BuildMap(m, r);
        ConsoleKeyInfo keyInfo;

        do
        {
            m.picture();
            r.ShowTotalJewels();
            r.ValorTotal();
            r.Power();
            keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                r.Norte(m);
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                r.Esquerda(m);
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                r.Sul(m);
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                r.Direita(m);
            }
            else if (keyInfo.Key == ConsoleKey.G)
            {
                r.CollectEnergy(m);
                r.CollectJewel(m);
            }
            if (m.Jewels == 0)
            {
                m.picture();
                j.Round++;
                m.Dimension++;
                r.X = 0;
                r.Y = 0;
                r.Bag = new List<Jewel>();
                m.newMap();
                j.BuildMap(m, r);
            }
            if (r.Energia <= 0)
            {
                m.Lose();
                break;
            }
            if (j.Round == 10)
            {
                m.Win();
                break;
            }
        } while (keyInfo.Key != ConsoleKey.X);
    }
}
