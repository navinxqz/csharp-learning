class Program : IExample,IExample2{
    public static void Main(String[] args){}

    public void Example(){
        System.Console.WriteLine("Hi");
    }

    public int Example2(){
        return 1;
    }

    public string Example3(string s1, string s2){
        return s1+" "+s2;
    }
}
interface IExample{
        void Example();
        int Example2();
        string Example3(string s1, string s2);
    }
interface IExample2{}