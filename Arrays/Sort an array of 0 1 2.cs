//Counting 0, 1, 2 approach

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'sort_an_array' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> sort_an_array(int n, List<int> arr)
    {
        int ones =0, twos =0, zeros =0;
        
        for(int i=0; i<n; i++){
            
            if(arr[i] == 0){
                zeros++;
            }
            else if(arr[i] == 1){
                ones++;
            }
            else{
                twos++;
            }
        }
        
        for(int i=0; i<zeros; i++){
            arr[i] = 0;
        }
        
        for(int i=zeros; i<zeros+ones; i++){
            arr[i] = 1;
        }
        
        for(int i=zeros+ones; i<n; i++){
            arr[i] =2;
        } 
        
        return arr;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.sort_an_array(n, arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}


//Using DNF approach

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'sort_an_array' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> sort_an_array(int n, List<int> arr)
    {
        
        //Using DNF Method
        
        int low =0, mid=0, high =n-1;
        
        while(mid<=high){
            
            if(arr[mid] == 1){
                mid++;
            }
            else if(arr[mid] == 0){
                Swap(arr, low, mid);
                low++;
                mid++;
            }
            else{
                Swap(arr,mid, high);
                high--;
            }   
        }
        
        return arr;
        

    }
    
    public static void Swap(List<int> arr, int x, int y){
        
        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.sort_an_array(n, arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
