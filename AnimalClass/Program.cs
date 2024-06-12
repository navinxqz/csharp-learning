class Animal{
    public string name;
    public string sound;
    static int animalNum = 0;

    public Animal(){    //default parameter
        name = "nothing";
        sound = "nothing";
        animalNum++;
    }
    public Animal(string name,string sound){
        this.name = name;
        this.sound = sound;
        animalNum++;
    }
     public void Sound(){
        Console.WriteLine("{0} says {1}...", name,sound);
     }public static int getAnimalNum(){
        return animalNum;
     }
}
class Program{
    public static void Main(String[] args){
        Animal a1 = new Animal();
        Console.Write("\nEmpty Cons called:  ");
        a1.Sound();

        Animal a2 = new ("Cat","Meaow");
        Console.Write("Perameterized cons called:  ");
        a2.Sound();

        Animal a3 = new Animal{
            name = "Kutta",
            sound = "Bhau Bhau"
        };
        Console.Write("Empty Cons called:  ");
        a3.Sound();

        Console.WriteLine("\nAnimals created: {0}\n",Animal.getAnimalNum());
    }
}