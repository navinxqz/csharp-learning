string[] Animals = new string[] {
     "Dog", "Cat", "Bird", "Fish", "Elephant", "Lion", "Tiger", "Bear", "Wolf",
     "Duck", "Chicken", "Cow", "Horse", "Peppa Pig", "Suzy Sheep", "Ronaldo", 
     "Bunny", "Raccoon","Pikachu", "Dianosour", "Bulbasaur", "Squirtle" };

Visit("School X");
Visit("School Y",3);
Visit("School Z",2);

void Visit(string schoolName, int groupCount = 5)
{
    Console.WriteLine($"Visiting {schoolName} with {groupCount} groups");
    Random random = new Random();
    for (int i = 0; i < groupCount; i++)
    {
        int index = random.Next(Animals.Length);
        Console.WriteLine($"Group {i + 1} visit: {Animals[index]}");
    }
    Console.WriteLine();
}