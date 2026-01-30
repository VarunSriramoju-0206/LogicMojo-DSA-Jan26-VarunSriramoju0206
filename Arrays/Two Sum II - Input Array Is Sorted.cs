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
     * Complete the 'twoSum' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER target
     *  2. INTEGER n
     *  3. INTEGER_ARRAY arr
     */

    public static List<int> twoSum(int target, int n, List<int> arr)
    {
        
        int i =0, j =n-1;
        
        List<int> result = new();
        
        //2 7 11 15
        while(i < j){
            
            int sum = arr[i]+ arr[j];
            
            if(sum == target){
                result.Add(i+1);
                result.Add(j+1);
                break;
            }
            else if(sum < target){
                i++;
            }
            else{
                j--;
            } 
        }
        
        return result;
            

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int targert = Convert.ToInt32(Console.ReadLine().Trim());

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.twoSum(targert, n, arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
