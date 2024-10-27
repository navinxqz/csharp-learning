try
{

}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
static void Process(){
    string[][] value = new string[][]{
        new string[] { "1", "two", "3" },
        new string[] { "0", "6","2" }
    };
    foreache(string[] v in value){
        try{

        }catch(Exception ex){
            //Console.WriteLine(ex.Message);
            if(ex.StackTrace.Contains("Process")){
                if(ex is FormatException){
                    Console.WriteLine(ex.Message);
                    System.Console.WriteLine("Corrective action taken in Process");
                }else if(ex is DivideByZeroException){
                    Console.WriteLine(ex.Message);
                    System.Console.WriteLine("Partial corrective action taken in Process...further action required");
                    throw;
                }else{
                    throw new Exception("Unknown exception in Process", ex);
                }
            }
        }
    }
}