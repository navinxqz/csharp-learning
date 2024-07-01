using MyQueue;
class Program{
    static void Main(string[] args){
        MyQ<string> q1 = new MyQ<string>(5);

        q1.Enqueue("Yosha");
        q1.Enqueue("Navin");
        q1.Enqueue("Ginger");
        q1.Enqueue("GurGur");

        while(!q1.IsEmpty()){
            Console.WriteLine(q1.Dequeue());
        }Console.WriteLine();
        MyQ<int> q2 = new MyQ<int>(5);

        q2.Enqueue(9);
        q2.Enqueue(8);
        q2.Enqueue(3);

        while(!q2.IsEmpty()){
            Console.WriteLine(q2.Dequeue());
        }
    }
}