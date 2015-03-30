/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package arraylist;

import java.util.Arrays;

public class ArrayList<E> {
  private int size = 0;
  private static final int DEFAULT_CAPACITY = 10;
  private Object elements[]; 
  
  
  public ArrayList() {
    elements = new Object[DEFAULT_CAPACITY];
  }
  
  public void add(E e) {
    if (size == elements.length) {
      resize();
    }  
    elements[size++] = e;
  }
   private void resize() {
     int newSize = elements.length * 2; // kapasite 2 katına çıkartılıyor
     elements = Arrays.copyOf(elements, newSize);
   }
  public E get(int i) {
    if (i>= size || i <0) {
      throw new IndexOutOfBoundsException("Index: " + i + ", Size " + i);
    }
    return (E) elements[i];
  }
  public Object remove(int i) {
    if (i<0 || i >=size) {
      throw new IndexOutOfBoundsException("Index: " + i + ", Size " + i);
    }
    Object temp = elements[i];
      for (int j = i+1; j < size; j++) {
          elements[j-1]=elements[j];
      }
      size--;
    return  temp;
  }



    public static void main(String[] args) {
        
      ArrayList<Integer> list = new ArrayList<Integer>();
      list.add(1);
      System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length  );
      list.add(2);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
      list.add(3);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
      list.add(4);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
      list.add(5);
      list.add(6);
      list.add(7);
      list.add(8);
      list.add(9);
      list.add(10);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
      list.add(0);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
      list.add(1);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
      list.add(2);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
      list.add(3);
       System.out.println("Size: " +list.size + " Kapasite: "+list.elements.length );
     
       int b =list.get(9); // eleman çekme
       System.out.println(b );
        list.remove(9); // listeden eleman silindi
        b =list.get(9);
       System.out.println(b );
    }
}
