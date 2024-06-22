using System;
class Test {
    public static void Main(String[] args) {
        bool isFun = true;
        char dollar = '$';
        bool sad = false;
        string fullName = "John Doe";

        Console.WriteLine("isFun = " + isFun);
        Console.WriteLine("dollar = " + dollar);
        Console.WriteLine("sad = " + sad);
        Console.WriteLine("fullName = " + fullName);
        Console.WriteLine($"Hello my name is {fullName} and I like {dollar}");//string interpolation
    }
}