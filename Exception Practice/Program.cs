checked{
    try{
        int a = int.MaxValue;
        int b = int.MaxValue;
        int sum = a + b;

        Console.WriteLine("Sum: " + sum);
    }catch(OverflowException ex){
        Console.WriteLine("Error! The num is too large to be represented as an integer." + ex.Message);
    }
}
try{
    string? s = null;
    int length = s.Length;
    System.Console.WriteLine("Length: " + length);
}catch(NullReferenceException ex){
    Console.WriteLine("Error! The string/refrence is null." + ex.Message);
}
try{
    int[] arr = new int[5];
    arr[5] = 10;
    System.Console.WriteLine("Num at index 5: " + arr[5]);
    }catch(IndexOutOfRangeException ex){
        Console.WriteLine("Error! The index is out of range." + ex.Message);
    }
try{
    int num = 10;
    int div = 0;
    int result = num/div;
    System.Console.WriteLine("Result: " + result);
}catch(DivideByZeroException ex){
    Console.WriteLine("Error! The num cannot be divided by zero." + ex.Message);
}
System.Console.WriteLine("End of program...");  