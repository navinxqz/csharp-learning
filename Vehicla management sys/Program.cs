class Vehicle{  //base
    public static int vehicleCount=0;
    private string vehicleID;
    public string brand{get;set;}
    public double price{get;set;}

    public Vehicle(string vehicleID,string brand,double price){
        this.vehicleID = vehicleID;
        this.brand = brand;
        this.price = price;
        vehicleCount++;
    }
    public string VehicleID{
        get{return vehicleID;}
        set{vehicleID=value;}
    }
    public static int VehicleCount{
        get {return vehicleCount;}
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Vehicle ID: {vehicleID}\nBrand: {brand}\nPrice: {price}");
    }
    public static void ShowVehiceDetails(Vehicle vehicle){
        if(vehicle is Car car){
            car.DisplayCarInfo();
        }else if(vehicle is Motorcycle motorcycle){
            motorcycle.DisplayMotorcycleInfo();
        }else{
            vehicle.DisplayInfo();
        }
    }
}
class Car : Vehicle{
    public int NumOfDoors{get;set;}
    public string FuelType{get;set;}

    public Car(string vehicleID,string brand,double price,int numOfDoors,string fuelType):base(vehicleID,brand,price){
        this.NumOfDoors=numOfDoors;
        this.FuelType=fuelType;
    }public override void DisplayInfo(){
        Console.WriteLine($"\n--Car Info--");
        base.DisplayInfo();
        Console.WriteLine($"Num of Doors: {NumOfDoors}\nFuel Type: {FuelType}");
    }public void DisplayCarInfo(){
        DisplayInfo();
    }
}
class Motorcycle : Vehicle{
    public int EngineCapacity{get;set;}
    public string Type{get;set;}

    public Motorcycle(string vehicleID,string brand,double price,int EngineCapacity,string Type):base(vehicleID,brand,price){
        this.EngineCapacity=EngineCapacity;
        this.Type=Type;
    }public override void DisplayInfo(){
        Console.WriteLine($"\n--Motorcycle Info--");
        base.DisplayInfo();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}cc\nType: {Type}");
    }public void DisplayMotorcycleInfo(){
        DisplayInfo();
    }
}

class Program{
    static void Main(string[] args){
        Vehicle vehicle= new Vehicle("ultra900","Runner",200000);
        Car car = new Car("Atx7","Toyota",500000,4,"Petrol");
        Motorcycle motorcycle= new Motorcycle("B360","Yamaha",300000,700,"General");

        System.Console.WriteLine("\n--Vehicle Info--");
        Vehicle.ShowVehiceDetails(vehicle);
        Vehicle.ShowVehiceDetails(car);
        Vehicle.ShowVehiceDetails(motorcycle);

        Console.WriteLine("\n-Total num of vehicles: {0}\n",Vehicle.vehicleCount);
    }
}