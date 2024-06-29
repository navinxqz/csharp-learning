class Person{   //base class
    public string name;
    public int age;
    public Person(string name, int age){
        this.name = name;
        this.age = age;
        System.Console.WriteLine("\nPera cons called from Person...");
    }
    public virtual void DisplayInfo(){  //base
        System.Console.WriteLine($"Name: {name}, Age: {age}");
    }~Person(){System.Console.WriteLine("\nDestructor called from person...");}
}

class Employee : Person{
    public int empID;
    public string dept;
    private static int totalemp = 0;
    public Employee(string name,int age,int empID,string dept):base(name,age){
        this.empID = empID;
        this.dept = dept;
        totalemp++;
        System.Console.WriteLine("\nPera cons called from Employee...");
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        System.Console.WriteLine($"Emp ID: {empID}, Dept: {dept}");
    }public static void DisplayEmpCount(){
        System.Console.WriteLine("Total emp: {0}",totalemp);
    }~Employee(){System.Console.WriteLine("\nDestructor called from Employee...");}
}

class Manager : Employee{
    public int teamSize;
    public Manager(string name,int age, int empID,string dept,int teamSize):base(name,age,empID,dept){
        this.teamSize = teamSize;
        System.Console.WriteLine("\nPera cons called form Manager...");
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine("Team Size: {0}",teamSize);
    }~Manager(){System.Console.WriteLine("\nDestructor called form Manager...");}
}

class Teachnician : Employee{
    public string specialization;
    public Teachnician(string name,int age,int empID,string dept,string specialization):base(name,age,empID,dept){
        this.specialization = specialization;
        System.Console.WriteLine("\nPera cons called from Technician...");
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine("Specialization: {0}",specialization);
    }~Teachnician(){System.Console.WriteLine("\nDestructor called from Technisian...");}
}

class Program{
    public static void Main(string[] args){
        System.Console.Write("Manager name: "); //for manager
        string mname = Console.ReadLine();
        System.Console.Write("Manager Age: ");
        int mage = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Manager EmpID: ");
        int mid = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Manager Department: ");
        string mdept = Console.ReadLine();

        System.Console.Write("Manager Team Size: ");
        int mtsize = Convert.ToInt32(Console.ReadLine());

        Manager m1 = new(mname,mage,mid,mdept,mtsize);
        m1.DisplayInfo();

        System.Console.Write("\nTechnician name: "); //for Technician
        string tname = Console.ReadLine();
        System.Console.Write("Technician Age: ");
        int tage = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Technician EmpID: ");
        int tid = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Technician Department: ");
        string tdept = Console.ReadLine();

        System.Console.Write("Technician Specialization: ");
        string tsp = Console.ReadLine();

        Teachnician t1 = new(tname,tage,tid,tdept,tsp);
        t1.DisplayInfo();
        Employee.DisplayEmpCount();
        
    }
}
