public class Heroi
{
    private string name;
    private int lv;
    private string hClass;
    private int maxHp;
    private int hp;
    private int maxMp;
    private int mp;
    private int baseDmg;
    private bool defending;

    public Heroi(string name, int lv, string hClass)
    {
        this.name = name;
        this.lv = lv;
        this.hClass = hClass;
        this.maxHp = 20 + (lv / 2);
        this.hp = maxHp;
        this.maxMp = 15 + (lv / 4);
        this.mp = maxMp;
        this.baseDmg = 5 + (lv / 4);
        this.defending = false;
    }


    public void Atacar(Heroi oponente) 
    {
        int diceValue = JogarD20();
        int damage;
        string msg;

        if (diceValue == 20) 
        {
            damage = baseDmg + (baseDmg * (baseDmg / 5));
            msg = "Um ataque extremamente poderoso e preciso é efetuado por " + this.name + ", causando o maximo de dano possivel em " + oponente.Name + ".";
        }
        else if (diceValue >= 15) 
        {
            damage = baseDmg + (baseDmg * (baseDmg / 10));
            msg = this.name + " acerta em cheio um forte golpe em " + oponente.Name;
        }
        else if (diceValue >= 10) 
        {
            damage = baseDmg;
            msg = this.name + " atinge " + oponente.Name + " com seu golpe.";
        }
        else if (diceValue >= 5) 
        {
            damage = baseDmg - (baseDmg * (baseDmg / 10));
            msg = this.name + " atinge de raspao a perna de " + oponente.Name + ".";
        }
        else
        {
            damage = 0;
            msg = this.name + " tentou acertar " + oponente.Name + " porem, errou.";
        }

        Console.WriteLine("\n=============ATAQUE=============\n");
        if (oponente.Defending) 
        {
            damage /= 2;
            oponente.Defending = false;
            System.Console.WriteLine(oponente.Name + " estava defendendo o ataque!\n");
        }      
        Console.WriteLine(Name + " tirou... " + diceValue);
        Console.WriteLine(msg);
        Console.WriteLine("Dano: " + damage);
        Console.WriteLine("=================================\n");

        if (oponente.Hp - damage < 0) 
        {
            oponente.Hp = 0;
            Console.WriteLine(oponente.name + " foi eliminado(a) no combate.");
        } 
        else 
        {
            oponente.Hp = oponente.Hp - damage;
        }
        
    }
    public void Defender() 
    {
        if (Defending) Console.WriteLine(Name + " já está defendendo.");
        else 
        {
            Defending = true;
            Console.WriteLine(Name + " está se defendendo do próximo ataque.");
        }

    }

    public int JogarD20()
    {
        Random rdn = new Random();
        return rdn.Next(1, 21);
    }

    public void PrintHero() 
    {
        Console.WriteLine(this.name + ": " + this.hp + "/" + this.maxHp + " HP");
    }

    public string Name {get => name; }
    public int MaxHp { get => maxHp; }
    public int MaxMp { get => maxMp; }
    public int Hp {get => hp; set => hp = value; }
    public int Mp {get => mp; set => mp = value; }
    public bool Defending {get => defending; set => defending = value; }

}