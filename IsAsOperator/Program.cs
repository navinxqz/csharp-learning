public class class1{}
public class class2 : class1{}

class Program{
    public static void Main(String[] args){
        //use of is operator
        bool a = "Hello Word" is string;
        bool b = "Hi" is float;

        System.Console.WriteLine($"variable 'a' returns: {a}");    //return true
        System.Console.WriteLine($"variable 'b' returns: {b}");

        class2 c2 = new class2();
        bool c = c2 is class1;  //due to inheritance
        System.Console.WriteLine($"variable 'c' returns: {c}");

        //use of as operator
        string s1 = "Alive!";
        object obj = s1;
        string s2 = obj as string;
        System.Console.WriteLine($"variable 's2' returns: {s2}");
        System.Console.WriteLine();

        //tarnary operator
        double x = 3.85;
        double y = 3.8;
        double z = 3.75;

        var isGreater1 = x>y ? true : false;
        var isGreater2 = z>x ? true : false;

        System.Console.WriteLine($"x > y : {isGreater1}");
        System.Console.WriteLine($"z > x : {isGreater2}");
        System.Console.WriteLine($"sizeof(char): {sizeof(char)}");  //sizeof() op
        System.Console.WriteLine($"typeof(int): {typeof(int)}");  //typeof() op
    }
}