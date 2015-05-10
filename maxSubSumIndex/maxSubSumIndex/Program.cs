
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class maxSubSumIndex
{
    private static int seqStart = 0;
    private static int seqEnd = -1;

    static Dictionary<ArrayList, int> data = new Dictionary<ArrayList, int>(); 
      // Array de indexler tutulacak, Integer olarak maxSubSum tutulacak. 

  static ArrayList list = new ArrayList();  
    // Cubic maximum contiguous subsequence sum algorithm.
    // seqStart and seqEnd represent the actual best sequence.
  public static Dictionary<ArrayList, int> MaxSubSum1(int[] a)
    {
        int maxSum = 0;
        data.Clear();        
        list.Clear();        
        for( int i = 0; i < a.Length; i++ )
            for( int j = i; j < a.Length; j++ )
            {
                int thisSum = 0;
                int k = 0;
                for( k = i; k <= j; k++ )
                    thisSum += a[ k ];

                if( thisSum > maxSum )
                {
                    list.Add(k - 1);
                    maxSum = thisSum;
                    seqStart = i;
                    seqEnd = j;
                }
            }
        data.Add(list, maxSum);
        return data;
    }

    // Quadratic maximum contiguous subsequence sum algorithm.
    // seqStart and seqEnd represent the actual best sequence.
  public static Dictionary<ArrayList, int> MaxSubSum2(int[] a)
    {
        int maxSum = 0;
        
        data.Clear();
        list.Clear();
      
        for( int i = 0; i < a.Length; i++ )
        {
            int thisSum = 0;
            for( int j = i; j < a.Length; j++ )
            {
                thisSum += a[ j ];

                if( thisSum > maxSum )
                {
                    list.Add(j);
                    maxSum = thisSum;
                    seqStart = i;
                    seqEnd = j;
                }
            }
        }
        data.Add(list, maxSum);
        return data;
    }

    // Linear-time maximum contiguous subsequence sum algorithm.
    // seqStart and seqEnd represent the actual best sequence.
  public static Dictionary<ArrayList, int> MaxSubSum3(int[] a)
    {
        int maxSum = 0;
        int thisSum = 0;

        data.Clear();
        list.Clear();

        for( int i = 0, j = 0; j < a.Length; j++ )
        {
            thisSum += a[ j ];

            if( thisSum > maxSum )
            {
                list.Add(j);
                maxSum = thisSum;
                seqStart = i;
                seqEnd = j;
            }
            else if( thisSum < 0 )
            {
                i = j + 1;
                thisSum = 0;
            }
        }
        data.Add(list, maxSum);
        return data;
    }

    // Recursive maximum contiguous subsequence sum algorithm.
    // Finds maximum sum in subarray spanning a[left..right].
    // Does not attempt to maintain actual best sequence.
    private static int MaxSumRec( int[ ] a, int left, int right )
    {
        int maxLeftBorderSum = 0, maxRightBorderSum = 0;
        int leftBorderSum = 0, rightBorderSum = 0;
        int center = ( left + right ) / 2;

        if( left == right )  // Base case
            return a[ left ] > 0 ? a[ left ] : 0;

        int maxLeftSum = MaxSumRec( a, left, center );
        int maxRightSum = MaxSumRec( a, center + 1, right );

        for( int i = center; i >= left; i-- )
        {
            leftBorderSum += a[ i ];
            if( leftBorderSum > maxLeftBorderSum )
                maxLeftBorderSum = leftBorderSum;
        }

        for( int i = center + 1; i <= right; i++ )
        {
            rightBorderSum += a[ i ];
            if( rightBorderSum > maxRightBorderSum )
                maxRightBorderSum = rightBorderSum;
        }

        return Max3( maxLeftSum, maxRightSum,
                     maxLeftBorderSum + maxRightBorderSum );
    }

    // Return maximum of three integers.
    private static int Max3( int a, int b, int c )
    {
        return a > b ? a > c ? a : c : b > c ? b : c;
    }

    // Driver for divide-and-conquer maximum contiguous
    // subsequence sum algorithm.
    public static int MaxSubSum4( int[ ] a )
    {
        return a.Length > 0 ? MaxSumRec( a, 0, a.Length - 1 ) : 0;
    }

    // Simple test program.
    public static void Main( string[ ] args )
    {
        int[ ] a = { 4, -3, 5, -2, -1, 2, 6, -2 };
     
        int maxSum;
        Dictionary<ArrayList, int> dictionary = new Dictionary<ArrayList,int>();
        dictionary = MaxSubSum1(a);
        int i = 0;

         foreach(KeyValuePair<ArrayList,int> item in dictionary)
         {
             for (int k = 0; k < item.Key.Count; k++)
             {
                 Console.WriteLine("MaxSubSum of maxSubSum1 : " + item.Key[k] + " Indexes :" + item.Value);
                 i++;
             }
            
         }


         Console.WriteLine("");
         i = 0;
         dictionary = MaxSubSum2(a);

         foreach (KeyValuePair<ArrayList, int> item in dictionary)
         {
             for (int k = 0; k < item.Key.Count; k++)
             {
                 Console.WriteLine("MaxSubSum of maxSubSum2 : " + item.Key[k] + " Indexes :" + item.Value);
                 i++;
             }

         }
         Console.WriteLine("");
         dictionary = MaxSubSum3(a);
        i=0;
        foreach (KeyValuePair<ArrayList, int> item in dictionary)
        {
            for (int k = 0; k < item.Key.Count; k++)
            {
                Console.WriteLine("MaxSubSum of maxSubSum3 : " + item.Key[k] + " Indexes :" + item.Value);
                i++;
            }

        }
       
    }
}