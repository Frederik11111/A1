namespace DIKUCanteen;

public class CanteenBoardMember : Student
{
    public static int CupBudget = 50; // Shared across all members

    public CanteenBoardMember(string name, string occupation, int age) : base(name, occupation, age) {}

    public void BuyCup(Canteen canteen)
    {
        if (CupBudget > 0)
        {
            canteen.AddCup();
            CupBudget--;
            Console.WriteLine($"{Name} bought a cup! Cups now: {canteen.Cups}, Budget left: {CupBudget}");
        }
        else
        {
            Console.WriteLine($"{Name} cannot buy cups, budget is empty!");
        }
    }
}
