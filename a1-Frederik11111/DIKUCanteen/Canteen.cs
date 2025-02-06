using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace DIKUCanteen;

public class Canteen : Room
{
    public int Cups { get; private set; }

    public Canteen(string name) : base(name)
    {
        Cups = 100; 
    }

    public Canteen(string name, int cups) : base(name)
    {
        Cups = cups;
    }

    public void AddCup()
    {
        Cups++;
    }

    public void RemoveCup()
    {
        if (Cups > 0)
        {
            Cups--;
        }
    }

    public override string ToString()
    {
        return $"{Name} - Cups Available: {Cups}";
    }
}
