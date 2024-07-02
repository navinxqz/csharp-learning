class Program{
    static int Fib(int n){
        if(n == 0 || n == 1){
            return n;
        }return Fib(n-1) +Fib(n-2);     //recursion method
    }
    public static void Main(string[] args){
        Console.Write("Input the value: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fib value: {0}",Fib(n));
    }
}