using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;

namespace DIKUCanteen;

public class Student : Person
{
    public bool HasCup { get; private set; } = false;

    public Student(string name, string occupation, int age) : base(name, occupation, age)
    {
        HasCup = false;
    }

    public void TakeCup(Canteen canteen)
    {
        if (!HasCup && canteen.Cups > 0)
        {
            HasCup = true;
            canteen.RemoveCup();
            Console.WriteLine($"{Name} took a cup. Cups left: {canteen.Cups}");
        }
        else if (HasCup)
        {
            Console.WriteLine($"{Name} already has a cup.");
        }
        else
        {
            Console.WriteLine($"No cups available in {canteen.Name}.");
        }
    }

    public void ReturnCup(Canteen canteen)
    {
        if (HasCup)
        {
            HasCup = false;
            canteen.AddCup();
            Console.WriteLine($"{Name} returned a cup. Cups available: {canteen.Cups}");
        }
        else
        {
            Console.WriteLine($"{Name} has no cup to return.");
        }
    }
}


   
