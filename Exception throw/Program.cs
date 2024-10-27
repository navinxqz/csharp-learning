try
{
    Process1();
}
catch(Exception ex){ Console.WriteLine(ex.Message); }

static void Process1(){
    string[][] value = new string[][]{
        new string[] { "1", "two", "3" },
        new string[] { "0", "6","2" }
    };
    foreach(string[] v in value){
        try{

        }catch(Exception ex){
            //Console.WriteLine(ex.Message);
            if(ex.StackTrace.Contains("Process2")){
                if(ex is FormatException){
                    Console.WriteLine(ex.Message);
                    System.Console.WriteLine("Corrective action taken in Process1");
                }else if(ex is DivideByZeroException){
                    Console.WriteLine(ex.Message);
                    System.Console.WriteLine("Partial corrective action taken in Process1...further action required");
                    throw;
                }else{
                    throw new Exception("Unknown exception in Process1", ex);
                }
            }
        }
    }
}
static void Process2(string[] Entries){
    int value;
    foreach(string entry in Entries){
        try{
            value = int.Parse(entry);
            checked{ int calc = 4/value; }
        }
        catch(FormatException ex){
            FormatException fex = new FormatException("FormatException! Invalid entry in Process2");
            //throw invalidFormatException;
            throw fex;
        }
        catch(DivideByZeroException ex){
            DivideByZeroException zex = new DivideByZeroException("DivideByZeroException! Calculation in 'Process2' encountered an unexpected divide by zero");
            //throw unexpectedDivideByZeroException;
            throw zex;
        }
    }
}