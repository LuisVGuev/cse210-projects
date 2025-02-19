public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"You have completed the goal: {Name} and earned {Points} points!");
        }
        else
        {
            Console.WriteLine($"The goal: {Name} is already completed.");
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{(IsComplete ? "[X]" : "[ ]")} {Name} - {Points} points");
    }
}
