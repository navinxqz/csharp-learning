class Colors{
    public int R{ get; set; }
    public int G{ get; set; }
    public int B{ get; set; }
    public Colors(int r, int g, int b){
        this.R = r;
        this.G = g;
        this.B = b;
    }
    public override string ToString(){
        return $"RGBcode= ({R},{G},{B})";
    }
}enum Color{Black,White};

class Program{
    static Colors GetColors(Color color) =>
    color switch{   //for lamda option first switch later
        Color.Black => new Colors(0,0,0),
        Color.White => new Colors(255,255,255),
        _ => new Colors(255,0,0)    //'_' for the deafult case
    };

    public static void Main(string[] args){
        Color c1 = Color.Black;
        Color c2 = Color.White;

        Colors code1 = GetColors(c1);
        Colors code2 = GetColors(c2);
        Console.WriteLine($"{c1} {code1}");
        Console.WriteLine($"{c2} {code2}\n");

        /*  Colors black = GetColors(Color.Black);
        Colors white = GetColors(Color.White);
        Console.WriteLine($"Black RGBcode= {black.R},{black.G},{black.B}");
        Console.WriteLine($"White RGBcode= {white.R},{white.G},{white.B}");   */
    }
}