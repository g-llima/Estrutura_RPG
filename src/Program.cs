
class Program 
{
    static void Main(string[] args) 
    {
        Heroi h1 = new Heroi("Gabriel", 39, "Guerreiro");
        Heroi h2 = new Heroi("Luiz", 10, "Mago");
        h1.PrintHero();
        h2.PrintHero();

        h1.Atacar(h2);
        
        h1.PrintHero();
        h2.PrintHero();
    }
}

