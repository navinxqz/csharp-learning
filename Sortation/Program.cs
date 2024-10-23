string[] p = ["B42", "A11", "B12", "M14", "A13", "M13", "C12"];
System.Console.WriteLine("Sorted...");
Array.Sort(p);

Array.Clear(p, 0, 3); //clears the first 3 elements
foreach (string s in p)
{
    System.Console.WriteLine("--> " +s);    //forward
}

System.Console.WriteLine("\nReversed...");
Array.Reverse(p);

foreach (string s in p)
{
    System.Console.WriteLine("--> " +s);    //reverse
}