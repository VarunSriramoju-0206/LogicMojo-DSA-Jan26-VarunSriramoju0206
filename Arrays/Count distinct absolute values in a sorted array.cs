//Brute force

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
     * Complete the 'findDistinctCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static int findDistinctCount(int n, List<int> arr)
    {
        for(int i=0; i<n; i++){
            arr[i] = Math.Abs(arr[i]);
        }
        HashSet<int> hs = new HashSet<int>();
        
        for(int i=0; i<n;i++){
            hs.Add(arr[i]);
        }
        
        
        return hs.Count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.findDistinctCount(n, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}



//Optimal approach
class Result
{

    /*
     * Complete the 'findDistinctCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static int findDistinctCount(int n, List<int> arr)
    {
        int i = 0, j = n - 1;
        int count = 0;

        while (i <= j) {

            int left = Math.Abs(arr[i]);
            int right = Math.Abs(arr[j]);

            int currentAbs;

            if (left > right) {
                currentAbs = left;
                while (i <= j && Math.Abs(arr[i]) == currentAbs) {
                    i++;
                }
            } else if (left < right) {
                currentAbs = right;
                while (i <= j && Math.Abs(arr[j]) == currentAbs) {
                    j--;
                }
            } else { // left == right
                currentAbs = left;
                while (i <= j && Math.Abs(arr[i]) == currentAbs) {
                    i++;
                }
                while (i <= j && Math.Abs(arr[j]) == currentAbs) {
                    j--;
                }
            }

            count++;
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

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.findDistinctCount(n, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
