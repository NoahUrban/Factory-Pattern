using System;

public class VehicleFactory
{
	public VehicleFactory()
	{
	}

	Motorcycle instance1 = new Motorcycle();
	Trike instance2 = new Trike();
	Car instance3 = new Car();
	SemiTruck instance4 = new SemiTruck();

	public static IVehicle GetVehicle(string wheels)
	{

		switch(wheels)
		{
			case "2":
				return new Motorcycle();
            case "3":
                return new Trike();
            case "4":
                return new Car();
			default:
				return new SemiTruck();
        }
	}
}


