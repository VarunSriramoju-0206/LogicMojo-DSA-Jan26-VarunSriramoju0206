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
     * Complete the 'rain_water' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY hei as parameter.
     */

    public static int rain_water(List<int> hei)
    {
        
        int n = hei.Count();
        
        int[] maxLeft = new int[n];
        int[] maxRight = new int[n];
        
        
        maxLeft[0] = hei[0]; maxRight[n-1]= hei[n-1];
        
        for(int i=1; i<n; i++){
            maxLeft[i] = Math.Max(hei[i], maxLeft[i-1]);
        }
        
        for(int i=n-2; i>=0; i--){
            maxRight[i] = Math.Max(hei[i], maxRight[i+1]);
        }
        
        int count =0;
        
        for(int i=0;i<n; i++ ){
            
            count += Math.Min(maxLeft[i], maxRight[i]) - hei[i];
        }
        
        return count;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> hei = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heiTemp => Convert.ToInt32(heiTemp)).ToList();

        int result = Result.rain_water(hei);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
