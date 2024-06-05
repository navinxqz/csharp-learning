using System;
public class Program{
    public class LinkedList{
        public class Node{
        public Node? next;
        public object? data;
    }private Node? root;

    public Node First{get{return root;}}
    public Node? Last{
        get{
            Node curNode = root;
            if(curNode == null){
                return null;
            }
            while(curNode.next != null){
                curNode = curNode.next;
            }return curNode;
        }
    }
        public void Append(object value){
            Node node = new Node{data = value};
            if(root==null){
                root = node;
            }else{
                Last.next = node;
            }
        }
        public void Delete(Node node){
            if(root==node){
                root = node.next;
                node.next = null;
            }else{
                Node current = root;
                while(current.next != null){
                    if(current.next == node){
                        current.next = node.next;
                        node.next = null;
                        break;
                    }current = current.next;
                }
            }
        }
    }
    public static void Main(String[] args){}
}
