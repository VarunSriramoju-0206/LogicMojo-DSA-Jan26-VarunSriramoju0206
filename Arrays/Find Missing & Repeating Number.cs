//Using Dictionary

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
     * Complete the 'find_missing' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> find_missing(List<int> arr)
    {
        
        Dictionary<int, int> dict = new();
        int n = arr.Count();
        
        for(int i=1; i<= n; i++){
                dict[i] = 0;
        }  
        
        for(int i=0; i< n; i++){
            if(dict.ContainsKey(arr[i])){
                dict[arr[i]]++;
            }
        }  
        
        List<int> result = new();
        
        var sortedByValueDescending = dict.OrderByDescending(kvp => kvp.Value).ToList();
        
        foreach (KeyValuePair<int, int> kvp in sortedByValueDescending)
        {
            if(kvp.Value > 1){
                result.Add(kvp.Key);
            }
            
            if(kvp.Value == 0){
                result.Add(kvp.Key);
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

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.find_missing(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}


//Using index approach pending
