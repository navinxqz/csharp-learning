namespace MyQueue{
    class MyQ<T>{
        private int head;
        private int tail;
        private int count;  //tracking the num of elements
        private T[] queue;  //ary to store the q elements
        private const int QSize = 20;

        public MyQ(){
            queue = new T[QSize];
            count =0;
            head =0;
            tail =0;
        }public MyQ(int size){
            if(size>0){
                queue = new T[size];
                count = 0;
                head = 0;
                tail = 0;
            }else{
                Console.WriteLine("Size has to be grater than 0!\nIntiallizing with default values...");
                queue = new T[QSize];
                count = 0;
                head = 0;
                tail = 0;
            }
        }
        public void Enqueue(T obj){
            if(count>=queue.Length){
                System.Console.WriteLine("Queue Full!");
            }else{
                queue[head] = obj;  //insrt the obj in head
                head = (head+1) % queue.Length;
                count++;
            }
        }public T Dequeue(){
            if(count<=0){
                //System.Console.WriteLine("Empty Queue!");
                return default(T);
            }else{
                T obj = queue[tail];    //pick obj frm the tail
                tail = (tail+1) % queue.Length;
                count--;
                return obj;
            }
        }
    }
}