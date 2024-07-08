class Program{
    public static void Main(String[] args){
    Console.WriteLine("Input the int in this manner: A B C");
    Console.Write("Input: ");
    var p = Console.ReadLine();
    var num = p.Split().Select(int.Parse).ToList();
    //splited the input into parts & turn them into int

    var c = num.Count(x => x==5) == 2 && num.Count(x => x==7) == 1 ? "Yes" : "No";
    //checking if list contains 2 '5' & 1 '7'

    Console.WriteLine(c);
    }
}