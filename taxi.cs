public class Taxi{
	public string DriverName;
	public bool OnDuty;
	public int NumPassenger;

	//method
	public void TaxiInfo(){
		Console.WriteLine("Driver name: ", DriverName);
		Console.WriteLine("On Duty: ", OnDuty);
		Console.WriteLine("Number of Passenger: ", NumPassenger);
	}

	public void PickUpPassenger(){
		Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
	}

	public void DropOffPassenger(){
		Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
	}	

}



class Program
{
	static void Main(string[] args);

	Taxi taxi = new Taxi();

	taxi.DriverName = Andi;
	taxi.OnDuty = True;
	taxi.NumPassenger = 11;

	taxi.TaxiInfo();
	taxi.PickUpPassenger();
	taxi.DropOffPassenger();

}
