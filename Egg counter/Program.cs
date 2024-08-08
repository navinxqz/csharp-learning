class Program{
    public static int HavingEggs(int n){
        if(n==1){ return 1;}
        return 2* HavingEggs(n-1);
    }
    public static void Main(string[] args){
        Console.Write("Total students in the classroom: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Pattern: ");

        for(int i=1; i <= n; i++){
            if(i==n){
                Console.Write(HavingEggs(i));
            }else{
                Console.Write(HavingEggs(i)+", ");
            }
        }Console.WriteLine($"\nThe last student has {HavingEggs(n)} eggs");
    }
}