using System;

public class Storm
{
    public double EyeRadius { get; protected set; }
    public Tuple<double, double> EyePosition { get; protected set; }

    public Storm(double eyeRadius, Tuple<double, double> eyePosition)
    {
        EyeRadius = eyeRadius;
        EyePosition = eyePosition;
    }

    public bool IsInEyeOfTheStorm(Tuple<double, double> position)
    {
        double distance = Math.Sqrt(Math.Pow(position.Item1 - EyePosition.Item1, 2) +
                                    Math.Pow(position.Item2 - EyePosition.Item2, 2));
        return distance < EyeRadius;
    }
}

public class RainStorm : Storm
{


    public RainStorm(double eyeRadius, Tuple<double, double> eyePosition) : base(eyeRadius, eyePosition) { }



    public double AmountOfRain()
    {
        return EyeRadius * 20;
    }
}

public class SnowStorm : Storm
{


    public double AmountOfSnow { get; private set; }

    public SnowStorm(double eyeRadius, Tuple<double, double> eyePosition, double amountOfSnow)
    {
        this.EyeRadius = eyeRadius;
        this.EyePosition = eyePosition;
        this.AmountOfSnow = amountOfSnow;
    }


}