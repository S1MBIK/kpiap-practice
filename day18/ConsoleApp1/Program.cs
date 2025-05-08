using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "abcasd#af##asdasd##asdasd#d##c";
        string outputString = TransformString(inputString);
        Console.WriteLine(outputString);  
    }

    static string TransformString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop(); 
                }
            }
            else
            {
                stack.Push(c);  
            }
        }

        char[] result = new char[stack.Count];
        int index = stack.Count - 1;
        while (stack.Count > 0)
        {
            result[index--] = stack.Pop();
        }

        return new string(result);
    }
}