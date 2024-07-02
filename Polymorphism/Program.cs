class Base{
    public virtual void Run(){
    System.Console.WriteLine("\tOutput from Base class");
    }
}class Child : Base{
    public override void Run(){
        System.Console.WriteLine("\tOutput from Child class");
    }
}class Program{
    public static void Main(string[] args){
        Base obj = new Child();
        //base method of the same name takes precedence, only
        //if virtual and override keyword not implemented
        obj.Run();
    }
}