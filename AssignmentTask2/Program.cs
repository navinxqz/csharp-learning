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
        Console.WriteLine($"ID: {ID}, Name: {Name}, Salary: {Salary:C}\nDept: {Dept}");
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
    }
}