//Cycling.cs
using System;

public class Cycling : Activity
{
    private double _speed; // in miles per hour

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * Duration) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
