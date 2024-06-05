using System;   //statement
class Program{  //class

    public static void Main(String[] args){ //main method
        Console.WriteLine("My name is Navin.");    //statement: specific line perform
        for(int i=0;i<20;i++){
            Console.Write("Operator: ");
            char op = Console.ReadLine()[0];

            float a,b;
            Console.Write("1st num:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("2nd num:");
            b = Convert.ToSingle(Console.ReadLine());
            
            switch(op){
                    case '+':
                    Console.WriteLine("Result: "+(a+b));
                    break;
                    case '-':
                    Console.WriteLine("Result: "+(a-b));
                    break;
                    case '*':
                    Console.WriteLine("Result: "+(a*b));
                    break;
                    case '/':
                    if(b!=0){
                    Console.WriteLine("Result: "+(a/b));
                    }else{
                        System.Console.WriteLine("Can't be divided");
                    }break;

                    default:
                    System.Console.WriteLine("Invalid operator! exiting...");
                    Environment.Exit(0);
                    break;
                }
        }
    }
}