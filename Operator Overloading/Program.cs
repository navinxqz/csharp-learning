//basic idea we've 2 3d box & want to sum it's properties with each other
//operator overloading meathod allow us to overload the +operator to add 2 boxes together

using System;
class Box{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height){
        this.length = length;
        this.width = width;
        this.height = height;   //'this' keyword ref the class memeber varibles
    }

    public double Length{
        get{ return length;}
        set{ length = value;}
        }
    public double Width{
        get{ return width;}
        set{ width = value;}
        }
    public double Height{
        get{ return height;}
        set{ height = value;}
        }

    public static Box operator +(Box box1, Box box2){
        return new Box(box1.Length + box2.Length,
        box1.Width + box2.Width, box1.Height + box2.Height);
    }
}

class Program{
    public static void Main(String[] args){
        Box b1 = new Box(2.5,2,6.9);
        Box b2 = new(0.5,2.5,3.1);  //simplified

        Box b3 = b1 + b2;
        Console.WriteLine($"\tBox3 properties:\nLength: {b3.Length} Width: {b3.Width} Height: {b3.Height}");
    }
}