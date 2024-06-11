class Student{
    private int id;
    private string name;
    private double gpa;
    private bool isFullTime;
    
    public Student(int id,string name,double gpa,bool isFullTime){
        this.id = id;
        this.name = name;
        this.gpa = gpa;
        this.isFullTime = isFullTime;
    }

    public int Id{
        get{return id;}
        set{id = value;}
        }
    public string Name{
        get{return name;}
        set{name = value;}
        }
    public double GPA{
        get{return gpa;}
        set{gpa = value;}
        }
    public bool IsFullTime{
        get{return isFullTime;}
        set{isFullTime = value;}
        }
}

class Program{
    public static void display(Student[] students){
        Console.WriteLine("\nStudent details:");
        for(int i=0;i<students.Length;i++){
            Console.Write($"ID: {students[i].Id}, Name: {students[i].Name}, ");
            Console.WriteLine($"GPA: {students[i].GPA}, FullTime: {students[i].IsFullTime}\n");
        }
    }
    public static double avgGpa(Student[] students){
        double gpasum = 0;
        foreach(var student in students){
            gpasum += student.GPA;
        }return gpasum/students.Length;
    }

    public static void Main(String[] args){
        Console.Write("Enter the number of student: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Student[] students = new Student[n];

        for(int i=0;i<n;i++){
            Console.WriteLine($"Enter details of student: {i+1}");
            Console.Write("ID: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            var b = Console.ReadLine();
            Console.Write("GPA: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Is Full-Time: ");
            bool d = Convert.ToBoolean(Console.ReadLine());

             students[i] = new Student(a, b, c, d);
        }display(students);

        var avg = avgGpa(students);
        Console.WriteLine($"Avg GPA: {avg}");
    }
}