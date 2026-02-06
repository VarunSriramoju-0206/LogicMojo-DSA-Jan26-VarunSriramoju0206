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
     * Complete the 'singlelement' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static int singlelement(int n, List<int> arr)
    {
        //Base Cases
        if(n == 1) { return arr[0];}
        if(arr[0] != arr[1]){return arr[0];}
        if(arr[n-1] != arr[n-2]){ return arr[n-1];}
        
        
        int low = 1, high =n-2;
        
        while(low < high){
            
            int mid = low+(high - low)/2;
            
            if(arr[mid] != arr[mid+1] && arr[mid] != arr[mid-1]){
                return arr[mid];
            }
            
            
            if((mid%2 == 0 && arr[mid] == arr[mid+1]) || (mid%2 !=0 && arr[mid] == arr[mid-1])){
                low = mid+1;
            }
            else{
                high = mid-1;
            }
        }
        
        return -1;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.singlelement(n, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
