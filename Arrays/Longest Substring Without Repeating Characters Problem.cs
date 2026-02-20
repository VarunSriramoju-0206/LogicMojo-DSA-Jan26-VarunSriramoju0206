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
     * Complete the 'longestSubstringWithoutRepeatingCharacters' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int longestSubstringWithoutRepeatingCharacters(string s)
    {
        
        int n = s.Length;
        
        //Base Check
        if(n == 0){ return 0;}
        
        int[] freq = new int[128];//Ascii Code because string contains English letters, digits, symbols and spaces.
        
        int i=0, j=0, max = Int32.MinValue;
        
        while(j < n){
            
            freq[s[j]]++;
            
            while(freq[s[j]] > 1){
                
                freq[s[i]]--;
                
                i++;
            }
            
            max = Math.Max(max, j-i+1);
            j++;
        }
        
        return max;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.longestSubstringWithoutRepeatingCharacters(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
