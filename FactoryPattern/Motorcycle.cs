using System;

public class Motorcycle : IVehicle
{
	public Motorcycle()
	{
	}

    int price = 15000;
    string engineSound = "Vroom Vroom";

    void IVehicle.Drive()
    {
        Console.WriteLine($"Motorcycle\n" +
            $"Price: ${price}\n" +
            $"Engine Sound: {engineSound}");
    }
}


