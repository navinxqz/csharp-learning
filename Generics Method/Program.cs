class Generics<T>{
    public static void Print<T>(T obj){
        System.Console.WriteLine(obj.ToString());
    }public static void Print<T>(T obj, T obj2){
        System.Console.WriteLine(obj.ToString() + obj2.ToString());
    }
}class Program{
    static void Main(string[] args){
        Generics<string>.Print("\nHello World");
        Generics<double>.Print(9830.023);
        Generics<bool>.Print(false);

        Generics<string>.Print("Hello World"," I'm Navin");
    }
}