// MathAssignment.cs
public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    // Constructor to initialize MathAssignment
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Method to display the homework list
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}
