/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package uygulama2;

import java.util.Random;

/**
 *
 * @author BM
 */
public class Uygulama2 {
 static int swap=0 ;
 static  int comparation=0;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
          
    int[] dizi = new int[10];
 
  int gecici=0;
   
       Random   rnd = new Random();
        for (int i = 0; i < 10; i++) {
            int sayi = rnd.nextInt(100);
            dizi[i]=sayi;
        } 
      //  BubbleSort(dizi); 
        SelectionSort(dizi);
         for (int i = 1; i < 10; i++) {
             System.out.println(dizi[i]);
        }
      
        System.out.println("swap:" + swap  +" Comparation : "+comparation);
        
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
      public static void  SelectionSort(int[] arr) {
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

}
    
    


   
        

    


