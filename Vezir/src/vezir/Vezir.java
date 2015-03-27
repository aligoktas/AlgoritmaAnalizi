/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vezir;

/**
 *
 * @author Ali
 */
public class Vezir {
    int capraztehdit = 0;
    int toplam=0;

    int[][] create(){
          System.out.println("Create Metodu çalıştı");
          int[][] dizi = new int[8][8];
          int rastgelesayi=0;
          for (int j = 0; j < dizi.length; j++) {
             rastgelesayi=(int)((Math.random()*8));
             dizi[rastgelesayi][j]=1;
          }
          return dizi;
    }
     int test(int[][] diziCreate ){
          System.out.println("Test Metodu çalıştı");
          int cakisma = 0;
         
          for (int i = 0; i < diziCreate.length; i++) {
            for (int j = 0; j < diziCreate.length; j++) {
                if (diziCreate[i][j]==1) 
                {
                  for (int k = 0; k < 8; k++) { 
                    // satırlarda çakışma sayısı
                    if (diziCreate[i][j]==diziCreate[i][k] && j!=k) {
                        cakisma++;
                    }
                  }
                    //köşegenlerde çakışma sayısı
                    int a = i;
                    int b = j;
                    //çapraz sol alt
                    while (a < 7 && b > 0) {
                        a++;
                        b--;
                        if (diziCreate[a][b] == 1){
                            capraztehdit++;
                        }
                    }
                    a = i;
                    b = j;
                    //çapraz sol üst 
                    while (a > 0 && b > 0) {
                        a--;
                        b--;
                        if (diziCreate[a][b] == 1) {
                            capraztehdit++;
                        }
                    }
                    a = i;
                    b = j;
                    while (a < 7 && b < 7) {
                    //sağ alt capraz kontrol
                        a++;
                        b++;
                        if (diziCreate[a][b] == 1) {
                            capraztehdit++;
                        }
                    }
                    a = i;
                    b = j;
                    while (a > 0 && b < 7) {
                    //sağ üst capraz kontrol
                        a--;
                        b++;
                        if (diziCreate[a][b] == 1) {
                            capraztehdit++;
                        }
                    } 
                    System.out.println(i +" satir "+j+" sütundaki vezir için tehdit sayısı : " + (capraztehdit+cakisma));
                    toplam= capraztehdit+cakisma+toplam;
                    capraztehdit=0;
                    cakisma=0;
                 }
             }   
        }
        return toplam;
    }
    public static void main(String[] args) {
       Vezir v = new Vezir();
       int[][] diziCreate = new int[8][8];
       diziCreate = v.create();
       for (int i = 0; i < diziCreate.length; i++) {
         for (int j = 0; j < diziCreate.length; j++){
            System.out.print(diziCreate[i][j]+ " ");
         }
            System.out.println(" ");
       }
       System.out.println(v.test(diziCreate)+" çakışma var");
    }
    
   }



       
        