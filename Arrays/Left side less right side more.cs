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
     * Complete the 'left_right' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int left_right(List<int> arr)
    {
        int n=arr.Count();
        
        for(int i=1; i<n-1; i++){
            
            if(IsMaxLeft(arr, i, n) && IsMaxRight(arr, i , n)){
                return arr[i];
            }
        }
        
        return -1;

    }
    
    public static bool IsMaxLeft(List<int> arr, int i, int n){
        
        int element = arr[i];
        // 4 3 2 1 5 9 8 7
        for(int j=i-1; i>=0; i--){
            
            if(element < arr[i]){
                return false;
            }
            
        }
        
        return true;
    }
    
    public static bool IsMaxRight(List<int> arr, int i, int n){
        
        int element = arr[i];
        
        for(int j=i+1; i<n; i++){
            
            if(arr[i] < element){
                return false;
            }
            
        }
        
        return true;
    }
    
    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.left_right(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
