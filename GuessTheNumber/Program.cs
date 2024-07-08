class Program{
    public static void Main(String[] args){
        Random random = new Random();   //creating Random cls obj
        int snum = random.Next(0,10);   //Range
        bool guess = false;

        for(int i=5; i>0; i--){
            Console.WriteLine($"\n{i} attempts Left to guess...");
            Console.Write("Guess a number between 0 to 20: ");
            int g = Convert.ToInt32(Console.ReadLine());

            if(g>snum){
                Console.WriteLine("Your guess is higher than the secret num!");
            }else if(g<snum){
                Console.WriteLine("Your guess is lesser than the secret num!");
            }else{
                guess = true;
                break;
            }
        }
        var output = (guess==false) ? $"You loose! Stop guessing you fool.\nThe secret num was {snum}" : "BOOM! You got it right";
        Console.WriteLine(output+"\n");
    }
}