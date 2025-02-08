// Assignment.cs
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor to initialize the base class attributes
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get a summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter for the student name
    public string GetStudentName()
    {
        return _studentName;
    }
}
