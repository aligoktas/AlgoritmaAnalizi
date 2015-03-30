/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package stack;
public class Stack {
      private int top;
      private int[] storage;
      Stack(int capacity) {
            if (capacity <= 0)
                  throw new IllegalArgumentException(
                             "Stack's capacity must be positive");
            storage = new int[capacity];
            top = -1;
      }
     
      void push(int value) {
            if (top == storage.length)
                System.out.println("Stack's underlying storage is overflow");
   
            top++;
            storage[top] = value;
      }
      int pop() {
            if (top == -1)
                  System.out.println("Stack is empty");
            return storage[top--];
              
      }
      boolean isEmpty() {
            return (top == -1);
      }
      
    public static void main(String[] args) {
       Stack a = new Stack(10); // 
       a.push(5);
       a.push(3);
       a.push(2);
       
       int b= 0;// pop edilen değerkeri çekmek için
         b=a.pop();//2
       System.out.println(b+" "); 
         b=a.pop();//3
       System.out.println(b+" ");
         b=a.pop();//5
       System.out.println(b+" ");
     
       System.out.println(a.isEmpty());
   
    }
}
