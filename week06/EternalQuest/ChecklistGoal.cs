public class ChecklistGoal : Goal
{
    public int TimesRequired { get; set; }
    public int TimesCompleted { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int timesRequired, int bonusPoints) 
        : base(name, points)
    {
        TimesRequired = timesRequired;
        TimesCompleted = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (TimesCompleted < TimesRequired)
        {
            TimesCompleted++;
            Console.WriteLine($"You completed {Name} {TimesCompleted}/{TimesRequired} times and earned {Points} points!");
            if (TimesCompleted == TimesRequired)
            {
                Console.WriteLine($"Bonus points earned: {BonusPoints}!");
                Points += BonusPoints;
            }
        }
        else
        {
            Console.WriteLine($"The goal {Name} is already completed.");
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{(TimesCompleted == TimesRequired ? "[X]" : "[ ]")} {Name} - {Points} points - {TimesCompleted}/{TimesRequired} completed");
    }
}
