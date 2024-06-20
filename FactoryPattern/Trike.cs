using System;

public class Trike : IVehicle
{
	public Trike()
	{
	}

    int price = 17000;
    string engineSound = "Vroo Vroom";                   
      
    public void Drive()  
    {
        Console.WriteLine($"Trike\n" +
            $"Price: ${price}\n" +
            $"Engine Sound: {engineSound}");
    }
}


