namespace Hospital{
    public class Staff{
    public int ID{get;set;}
    public string Name{get;set;}
    public double Salary{get;set;}
    public string Dept{get;set;}
    public Staff(int ID,string Name,double Salary,string Dept){
        this.ID = ID;
        this.Name = Name;
        this.Salary = Salary;
        this.Dept = Dept;
    }
    public  virtual void ShowInfo(){
        Console.WriteLine($"ID: {ID}, Name: {Name}, Salary: {Salary} Taka\nDept: {Dept}");
    }
    public virtual bool staffStatus(){return false;}
    }
    public class Doctor : Staff{
        public string Specialization{get; set;}
        public int patientperMonth{get;set;}
        public Doctor(int ID,string Name,double Salary,string Dept,string Specialization,int patientperMonth):base(ID,Name,Salary,Dept){
            this.Specialization = Specialization;
            this.patientperMonth=patientperMonth;
        }
        public override void ShowInfo(){
            base.ShowInfo();
            Console.WriteLine($"Specialization: {Specialization}\nPatient per month: {patientperMonth}");
        }
        public override bool staffStatus(){return patientperMonth>50;}
    }
    public class Nurse : Staff{
        public string Shift{get;set;}
        public int patientHandled{get;set;}
        public Nurse(int ID,string Name,double Salary,string Dept,string shift,int patientHandled):base(ID,Name,Salary,Dept){
            this.Shift = shift;
            this.patientHandled = patientHandled;
        }
        public override void ShowInfo(){
            base.ShowInfo();
            Console.WriteLine($"Shift: {Shift}, Patient Handled: {patientHandled}");
        }
        public override bool staffStatus(){return patientHandled>200;}

        public double CalcEarning(){
            return patientHandled*(100.5); //per patient handled fee
        }
    }
    class Program{
        public static void Main(string[] args){
            Doctor d1= new(11,"Dr. K",30000,"Surgery","Mouth",100);
            Doctor d2= new(12,"Dr. G",25000.5,"Surgery","Eye",10);
            Nurse n= new(22,"Nurse Nai", 25000,"Burn Unit","Morning",200);

            d1.ShowInfo();
            Console.WriteLine($"Eligible for bonus: {d1.staffStatus()}\n");
            d2.ShowInfo();
            Console.WriteLine($"Eligible for bonus: {d2.staffStatus()}\n");
            n.ShowInfo();
            Console.WriteLine($"Total Earnings: {n.CalcEarning()} Taka");
        }
    }
}