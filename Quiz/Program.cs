public enum Catagory{
    electronics=1,groceries,clothing
}
class Product{
    public string Name{ get; set; }
    public int Price{ get; set; }
    public Catagory catagory{ get; set; }

    static Product(){int count = 0;}
    public Product(string name, int price, Catagory c){
        Name = name;
        Price = price;
        Catagory catagory = c;
    }public void Details(){
        System.Console.WriteLine($"Name: {Name}, Price: {Price}, Count: {catagory}");
    }
}class Program{
    static void Main(string[] args){
        Product p1 = new Product("Shirt",500,Catagory.electronics);
        p1.Details();
    }
}
//The goal was there should be a count variable to store how much the client want that product
//and when the details func call it will show the amount with its catagoty
//but it didn't go as expected