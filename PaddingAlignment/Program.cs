string id = "E-616";
string name = "Wanda Maximoff";
string payment = "$3,000.00";
string notes = "Monthly payment for contract #E-616.";

var lineFormat = id.PadRight(15);
lineFormat += name.PadRight(20);
lineFormat += payment.PadLeft(10);

System.Console.WriteLine(lineFormat);
System.Console.WriteLine(notes.PadLeft(12));    //one space added to the left

//practice

string person = "Matthew Murdock";
string product1 = "Daredevil";
int currentShares = 100;

decimal currentReturn = 50.55m;
decimal currentProfit = 55000.00m;

string product2 = "Jessica Jones";
decimal newReturn = 25.25m;
decimal newProfit = 25000.00m;

Console.WriteLine($"\nDear {person},");
Console.WriteLine($"As a customer of our {product1} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {product2} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = product1.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(20);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += product2.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(20);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage + Environment.NewLine);
