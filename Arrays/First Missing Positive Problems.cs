//Using Two loops

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
     * Complete the 'first_missing_positive' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static int first_missing_positive(int n, List<int> arr)
    {
        
        
        for(int i=1; i<=n;i++){
            
            bool isFound = false;
            for(int j=0; j<n; j++){
                if(i == arr[j]){
                    isFound= true;
                    break;
                }
                
                isFound = false;
            }
            
            if(!isFound){
                return i;
            }
        }

        return n+1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.first_missing_positive(n, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}



//Using Marking technique

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
     * Complete the 'first_missing_positive' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static int first_missing_positive(int n, List<int> arr)
    {
 //Using Marking Technique
        //1) if arr<0 or arr > n
        
        for(int i=0; i<n; i++){
            if(arr[i] <= 0 || arr[i] > n){
                arr[i] = n+1;
            }
        }
        
        //Console.WriteLine(string.Join(",", arr));
        
        //2) MArking
        for(int i=0;i<n; i++){
            int number = Math.Abs(arr[i]);
            number = number -1;
            
            if(number <= n-1 && arr[number] > 0){
                arr[number] = arr[number] * -1;
            }
        }
        
        //Console.WriteLine(string.Join(",", arr));
        
        //3) Checking not visited
        for(int i=0; i<n; i++){
            
            if(arr[i] > 0){
                return i+1;
            }
            
        }
        
        return n+1;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.first_missing_positive(n, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
