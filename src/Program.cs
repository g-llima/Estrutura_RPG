
class Program 
{
    static void Main(string[] args) 
    {
        Heroi h1 = new Heroi("Gabriel", 18, "Guerreiro");
        Heroi h2 = new Heroi("Luiz", 16, "Guerreiro");

        h2.Defender();

        bool looping = true;
        while (looping) 
        {
            Console.WriteLine("\n===========| RPG |===========\n");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Defender");
            Console.WriteLine("3 - Usar Item");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("\n=============================\n");
            
            int option = Convert.ToInt16(Console.ReadLine());
            switch(option) 
            {
                case 1:
                    h1.Atacar(h2);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    looping = false;
                    break;
                default:
                    continue;
            }
        }
    }
}

