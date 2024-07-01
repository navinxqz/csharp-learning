using MyQueue;

class Program{
    static void Main(string[] args){
        MyQ<string> q1 = new MyQ<string>(5);
        MyQ<int> q2 = new MyQ<int>(5);

        q1.Enqueue("Yosha");
        q1.Enqueue("Navin");
        q1.Enqueue("Ginger");
        q1.Enqueue("GurGur");

        foreach(var i in q1.ToString()){
            Console.WriteLine(q1.Dequeue());
        }

        //Console.WriteLine(q1.Dequeue());
            //Console.WriteLine(i);
        }
        
    }