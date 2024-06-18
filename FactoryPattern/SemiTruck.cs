using System;
public class SemiTruck : IVehicle
{
	public SemiTruck()
	{
	}

    int price = 110000;
    int towCapacity = 45000;

    public void Drive()
    {
        Console.WriteLine($"Semitruck\n" +
            $"Price: ${price}\n" +
            $"Tow Capacity: {towCapacity} pounds");
    }
}


