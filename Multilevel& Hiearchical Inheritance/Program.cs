class Person{
    public string name;
    public int age;
    public Person(string name, int age){
        this.name = name;
        this.age = age;
        System.Console.WriteLine("Pera cons called from Person...");
    }
    public virtual void DisplayInfo(){
        System.Console.WriteLine($"Name: {name}, Age: {age}");
    }~Person(){System.Console.WriteLine("Destructor called from person...");}
}

class Employee : Person{
    public int empID;
    public string dept;
    private static int totalemp = 0;
    public Employee(string name,int age,int empID,string dept):base(name,age){
        this.empID = empID;
        this.dept = dept;
        totalemp++;
        System.Console.WriteLine("Pera cons called from Employee...");
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        System.Console.WriteLine($"Emp ID: {empID}, Dept: {dept}");
    }public static void DisplayEmpCount(){
        System.Console.WriteLine("Total emp: {0}",totalemp);
    }~Employee(){System.Console.WriteLine("Destructor called from Employee...");}
}

class Manager : Employee{
    public int teamSize;
    public Manager(string name,int age, int empID,string dept,int teamSize):base(name,age,empID,dept){
        this.teamSize = teamSize;
        System.Console.WriteLine("Pera cons called form Manager...");
    }
}
