class Program{
    public struct Stats{
        public int Atkpower{get;set;}
        public int Defence{get;set;}
        public readonly override string ToString(){
            return $"Atk power: {Atkpower} & Defence: {Defence}\n";
        }
    }
    public static void Main(string[] args){
        Stats s = new Stats{
            Atkpower = 600,
            Defence = 69
        };
        Console.WriteLine(s);
    }
}