class Program{
    public static void Main(string[] args){
        Stack s = new();
        s.push('a');
        s.push(8);
        s.push(3);
        s.push('z');

        foreach(var i in s.ToString()){
            Console.WriteLine(s.Pop());
        }
    }
}
class Stack{
    const int MAX = 999;
    int top;
    object[] stack = new object[MAX];
    public Stack(){
        top = -1;   //to signify that the stack is empty
    }
    public void push(object obj){
        if(top <MAX-1){
            stack[++top] = obj;
        }else{
            System.Console.WriteLine("Stack overflow...");
        }
    }public object Pop(){
        if(top>=0){
            object o = stack[top];
            top--;
            return o;
        }else{
            //System.Console.WriteLine("Stack underflow...");
            return null;
        }
    }public object Peek(){
        if(top>=0){
        return stack[top];
        }else{
            System.Console.WriteLine("Stack empty!");
            return null;
        }
        }
}