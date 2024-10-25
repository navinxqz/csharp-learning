using System;
string[] Animals = new string[] {
     "Dog", "Cat", "Bird", "Fish", "Elephant", "Lion", "Tiger", "Bear", "Wolf",
     "Duck", "Chicken", "Cow", "Horse", "Peppa Pig", "Suzy Sheep", "Ronaldo", 
     "Bunny", "Raccoon","Pikachu", "Dianosour", "Bulbasaur", "Squirtle" };

Visit("School X");
Visit("School Y",3);
Visit("School Z",2);

void Visit(string schoolName, int groupCount = 5)
{
    Console.WriteLine($"From {schoolName}");
    RandomizeAnimals();
    string[,] groups = AssignGroup(groupCount);
    PrintGroups(groups);
    Console.WriteLine();
}
void RandomizeAnimals()
{
    Random random = new Random();
    for (int i = 0; i < Animals.Length; i++)
    {
        int index = random.Next(i, Animals.Length);
        string temp = Animals[index];
        Animals[index] = Animals[i];
        Animals[i] = temp;
    }
}
string[,] AssignGroup(int groupCount=5)
{
    int groupSize = Animals.Length / groupCount;
    string[,] groups = new string[groupCount,groupSize];

    for (int i = 0; i < groupCount; i++)
    {
        for (int j = 0; j < groupSize; j++)
        {
            groups[i, j] = Animals[i * groupSize + j];
        }
    }
    return groups;
}
void PrintGroups(string[,] groups)
{
    for (int i = 0; i < groups.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1} visiting: ");

        for (int j = 0; j < groups.GetLength(1); j++)
        {
            Console.Write(groups[i, j]+", ");
        }System.Console.WriteLine();
    }
}