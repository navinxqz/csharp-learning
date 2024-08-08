class Program{
    public static int HavingEggs(int n){
        if(n==1){ return 1;}
        return 2* HavingEggs(n-1);
    }
    public static void Main(string[] args){
        Console.Write("Total students in the classroom: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The last student has --> {HavingEggs(n)} eggs");
    }
}