/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recursivelinearsearch;

import java.util.Scanner;

/**
 *
 * @author Ali
 */
public class RecursiveLinearSearch {

     public void linSearch2(int[] arr, int fIndex, int lIndex, int searchNum) {

        if (fIndex == lIndex) {

            System.out.print("-1");

        } else {

            if (arr[fIndex] == searchNum) {

                System.out.print(fIndex);

            } else {

                linSearch2(arr, fIndex + 1, lIndex, searchNum);

            }

        }

    }
    public static void main(String[] args) {
       Scanner input = new Scanner(System.in);
 
        System.out.print("Enter the size of the array: ");
        int size = input.nextInt();
        
 
        int[] arr = new int[size];
 
        for(int i=0; i<arr.length; i++)
        {
            arr[i]= (int)(Math.random()*100);
            System.out.print(arr[i] +" | ");
        }
        System.out.println("");
        System.out.println("Enter the number you want to search: ");
        int search = input.nextInt();
        RecursiveLinearSearch access = new RecursiveLinearSearch();
 
        System.out.print("The position of the search item is at array index ");
        access.linSearch2(arr, 0, arr.length, search);
        System.out.println("");
    }
    
}
