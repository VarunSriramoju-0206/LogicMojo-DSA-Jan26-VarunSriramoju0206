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

class SinglyLinkedListNode
{
    public long data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(long nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public SinglyLinkedListNode head;
    public SinglyLinkedListNode tail;

    public SinglyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void InsertNode(long nodeData)
    {
        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            this.tail.next = node;
        }

        this.tail = node;
    }
}

class SinglyLinkedListPrintHelepr
{
    public static void PrintList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }
}

class Result
{

    /*
     * Complete the 'findLinkedList' function below.
     *
     * The function is expected to return a LONG_INTEGER_SINGLY_LINKED_LIST.
     * The function accepts following parameters:
     *  1. LONG_INTEGER_SINGLY_LINKED_LIST head
     *  2. INTEGER k
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     long data;
     *     SinglyLinkedListNode next;
     * }
     *
     */

     public static SinglyLinkedListNode findLinkedList(SinglyLinkedListNode head, int k)
    {
        SinglyLinkedListNode temp = head, nextNode = null, prev = null;
        
        while(temp  != null){
            
            SinglyLinkedListNode kthNode = GetKthNode(temp, k-1);
            
            if(kthNode == null){
                if(prev != null){
                    prev.next = temp;
                }
                break;
            }
            
            nextNode = kthNode.next;
            kthNode.next = null;
            
            Reverse(temp);
            
            if(temp == head){
                head = kthNode;
            }
            else{
                prev.next = kthNode;
            }
            
            prev = temp;
            temp = nextNode;
            
        }
        return head;
    }
    
    public static SinglyLinkedListNode GetKthNode(SinglyLinkedListNode head, int k){
        
        SinglyLinkedListNode temp = head;
        while(temp!=null && k > 0){
            temp = temp.next;
            k--;
        }
        
        return temp;
    }
    public static SinglyLinkedListNode Reverse(SinglyLinkedListNode head){
        
        SinglyLinkedListNode curr = head, prev = null;
        
        while(curr != null){
            SinglyLinkedListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr= next;
        }
        return prev;
        
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        SinglyLinkedList l = new SinglyLinkedList();

        int lCount = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < lCount; i++)
        {
            long lItem = Convert.ToInt64(Console.ReadLine().Trim());
            l.InsertNode(lItem);
        }

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        SinglyLinkedListNode result = Result.findLinkedList(l.head, k);

        SinglyLinkedListPrintHelepr.PrintList(result, " ", textWriter);
        textWriter.WriteLine();

        textWriter.Flush();
        textWriter.Close();
    }
}
