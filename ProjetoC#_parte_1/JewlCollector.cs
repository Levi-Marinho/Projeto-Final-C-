namespace JewelCollector;

public class JewelCollector
{

    public static void Main()
    {
        Map m = new Map();
        Robot r = new Robot(0, 0);
        JewelCollector j = new JewelCollector(m, r);

        bool running = true;

        do
        {
            m.picture();
            r.TotalJewels();
            r.ValorTotal();
            Console.Write("Enter the command: ");
            string command = Console.ReadLine();

            if (command.Equals("quit"))
            {
                running = false;
            } 
            else if (command.Equals("w"))
            {
                r.Norte(m);

            } 
            else if (command.Equals("a"))
            {
                r.esquerda(m);
            }
            else if (command.Equals("s"))
            {
                r.sul(m);

            }
            else if (command.Equals("d"))
            {
                r.direita(m);

            }
            else if (command.Equals("g"))
            {
                r.coleta(m);
            }
            if (m.Jewels == 0)
            {
                m.picture();
                m.Win();
                running = false;
            }

        } while (running);
    }
        public JewelCollector(Map m, Robot r)
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
}
