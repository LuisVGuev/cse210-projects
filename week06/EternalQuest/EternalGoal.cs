public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = false;  // Eternal goals never complete
            Console.WriteLine($"You have earned {Points} points for: {Name}!");
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{(IsComplete ? "[X]" : "[ ]")} {Name} - {Points} points (Eternal)");
    }
}

