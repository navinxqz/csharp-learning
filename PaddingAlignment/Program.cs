string id = "E-616";
string name = "Wanda Maximoff";
string payment = "$3,000.00";
string notes = "Monthly payment for contract #E-616.";

var lineFormat = id.PadRight(15);
lineFormat += name.PadRight(20);
lineFormat += payment.PadLeft(10);

System.Console.WriteLine(lineFormat);
System.Console.WriteLine(notes.PadLeft(12));    //one space added to the left
