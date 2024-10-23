string id = "E-616";
string name = "Wanda Maximoff";
string payment = "$3,000.00";

var lineFormat = id.PadRight(15);
lineFormat += name.PadRight(20);
lineFormat += payment.PadLeft(10);

System.Console.WriteLine(lineFormat);
