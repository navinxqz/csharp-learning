string a = "Puta Madre" ;
object b = a is string ? "Yes" : "No" ;
var c = a is char ? "Yes" : "No";

System.Console.WriteLine(b);
System.Console.WriteLine(c);

object d = a as string;
System.Console.WriteLine(d);