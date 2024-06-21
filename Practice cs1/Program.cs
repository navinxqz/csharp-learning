using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
class Program{
    static string[] s1 = ["a","b","c"];
    static int[] s2 = new int[] {1,4,6,7};   //we don't have to specify size another method for s1
    public static void Main(String[] args){
        
    /*    int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        var c = a>b ? true : false;
        Console.WriteLine(c);
        Console.WriteLine(typeof(bool));
        Console.WriteLine("Amrin said \"I Love You\".");
        
        for(int i=0; i<3; i++){
            for(int j=0; j<3; j++){
                Console.WriteLine($"i = {i.ToString()} j = {j.ToString()}");
            }
        }    */
        var names = new List<string> {"Navin", "Amrin", "Eva","yosha","Ash"};

        foreach (var item in names[1..4]){
            Console.WriteLine($"Hello {item}.");
        }

        for(int i=0;i<s1.Length;i++){
            Console.WriteLine(s1[i]);
        }for(int i=0;i<s2.Length;i++){
            Console.WriteLine(s2[i]);
        }
    }
}