string[][] Values = new string[][]
{
    new string[] { "1", "2", "3"},
    new string[] { "1", "two", "3"},
    new string[] { "0", "1", "2"}
};
string statusMessage = "";
statusMessage = Workflow1(Values);

if (statusMessage == "operating procedure complete")
{
    Console.WriteLine("'Workflow1' completed successfully.");
}else
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(statusMessage);
}

static string Workflow1(string[][] Values)
{
    string operationStatusMessage = "good";
    string processStatusMessage = "";

    foreach (string[] userEntries in Values)
    {
        processStatusMessage = Process1(userEntries);
        if (processStatusMessage == "process complete")
        {
            Console.WriteLine("'Process1' completed successfully.\n");
        }
        else
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(processStatusMessage + Environment.NewLine);
            operationStatusMessage = processStatusMessage;
        }
    }

    if (operationStatusMessage == "good")
    {
        operationStatusMessage = "operating procedure complete";
    }return operationStatusMessage;
}

static string Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
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
                returnMessage = "Invalid data. User input values must be non-zero values.";
                processStatus = "error";
            }
        }else
        {
            returnMessage = "Invalid data. User input values must be valid integers.";
            processStatus = "error";
        }
    }
    if (processStatus == "clean"){ returnMessage = "process complete"; }
    return returnMessage;
}