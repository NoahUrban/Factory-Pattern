using System;

public class VehicleFactory
{
	public VehicleFactory()
	{
	}

	public static IVehicle GetVehicle(int wheels)
	{

		switch(wheels)
		{
			case 2:
				return new Motorcycle();
            case 3:
                return new Trike();
            case 4:
                return new Car();
			default:
				return new SemiTruck();
        }
	}
}


