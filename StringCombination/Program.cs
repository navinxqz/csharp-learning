string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = string.Empty;

foreach (string value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value; //+ Environment.NewLine for new line;
    }
}
System.Console.WriteLine("Message: " + message);
System.Console.WriteLine("Total: " + total);