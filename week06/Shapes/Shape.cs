// Shape.cs
public class Shape
{
    public string Color { get; set; }

    // Constructor color
    public Shape(string color)
    {
        Color = color;
    }

    // calculate the area
    public virtual double GetArea()
    {
        return 0;  
    }
}
