using System;

public class Car : IVehicle
{
	public Car()
	{
	}

    int price = 25000;
    int towCapacity = 2000;

    public void Drive()
    {
        Console.WriteLine($"Motorcycle\n" +
            $"Price: ${price}\n" +
            $"Tow Capacity: {towCapacity} pounds");
    }
}

