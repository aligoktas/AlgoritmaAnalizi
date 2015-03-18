/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sorting;

import java.util.Random;

/**
 *
 * @author BM
 */
public class Sorting {

    static int swap = 0;
    static int comparation = 0;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int[] dizi = new int[500];

        int gecici = 0;

        Random rnd = new Random();
        for (int i = 0; i < 500; i++) {
            int sayi = rnd.nextInt(100);
            dizi[i] = sayi;
        }
         // BubbleSort(dizi); 
       // SelectionSort(dizi);
      // ShellSort(dizi);
       InsertionSort(dizi);
        for (int i = 1; i < 50; i++) {
            System.out.println(dizi[i]);
        }

        System.out.println("swap:" + swap + " Comparation : " + comparation);
    }

    public static void BubbleSort(int[] dizi) {
        int temp;   // Yer değiştirmede kullanılacak geçici değişken

        for (int i = 1; i < dizi.length; i++) {
            for (int j = 0; j < dizi.length - i; j++) {
                comparation++;
                if (dizi[j] > dizi[j + 1]) {
                    swap++;
                    temp = dizi[j];
                    dizi[j] = dizi[j + 1];
                    dizi[j + 1] = temp;
                }//Önce gelen elaman bir sonrakinden büyükse ikisi yer değiştiriyor
            }// Dizinin ardışık elamanlarını karşılaştırmak için kullandığımız döngü
        }// Her karşılaştırmadan sonra yeniden kaldığımız yerden devam etmemizi sağlayan döngü

    }

    public static void SelectionSort(int[] arr) {
        int i, j, minIndex, tmp;
        int n = arr.length;
        for (i = 0; i < n - 1; i++) {
            minIndex = i;
            for (j = i + 1; j < n; j++) {
                comparation++;
                if (arr[j] < arr[minIndex]) {
                    minIndex = j;
                }
            }
            if (minIndex != i) {
                tmp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = tmp;
                swap++;
            }

        }
    }

    public static void InsertionSort(int[] num) {
        int j;                     // the number of items sorted so far
        int key;                // the item to be inserted
        int i;

        for (j = 1; j < num.length; j++) // Start with 1 (not 0)
        {
            key = num[ j];
              
           
            for (i = j - 1; (i >= 0) && (num[ i] < key); i--) // Smaller values are moving up
            {
                num[ i + 1] = num[ i];
             comparation++;  
             swap++;
               
            }
            num[ i + 1] = key;    // Put the key in its proper location
            comparation++;  
            
        }
    }

    public static void ShellSort(int[] a) {
        int increment = a.length / 2;
        while (increment > 0) {
            comparation++;
            for (int i = increment; i < a.length; i++) {
              
                int j = i;
                int temp = a[i];
                while (j >= increment && a[j - increment] > temp) {
                    swap++;
                    a[j] = a[j - increment];
                    j = j - increment;
                }
                a[j] = temp;
                 comparation++; 
            }
            if (increment == 2) {
                increment = 1;
            } else {
                increment *= (5.0 / 11);
            }
        }
    }

}







   