string[][] Values = new string[][]
{
    new string[] { "1", "2", "3"},
    new string[] { "1", "two", "3"},
    new string[] { "0", "1", "2"}
};
try
{
    Workflow1(Values);
    Console.WriteLine("'Workflow1' completed successfully.");

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'!");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    //string operationStatusMessage = "good";
    //string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.\n");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue! process aborted.");
            Console.WriteLine(ex.Message + Environment.NewLine);
        }
    }
}

static void Process1(String[] userEntries)
{
    // string processStatus = "clean";
    // string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);
        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked { int calculatedValue = 4 / valueEntered; }
            }
            else
            {
                //returnMessage = "Invalid data. User input values must be non-zero values.";
                //processStatus = "error";
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }else
        {
            //returnMessage = "Invalid data. User input values must be valid integers.";
            //processStatus = "error";
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
    //if (processStatus == "clean"){ returnMessage = "process complete"; }
   // return returnMessage;
}