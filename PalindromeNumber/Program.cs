using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int x;
        int.TryParse(input, out x);
        char[] arr = new char[11];
        bool result = false;

        if (x < 0)
        {
            result = false;
        }

        if (x == 0)
        {
            result = true;
        }

        int count = 0;
        Console.WriteLine("Iteration while:");

        while (x > 0)
        {
            int modValue = x % 10;
            x = x / 10;
            Console.WriteLine("x:" + x + "\n");
            arr[count] = (char)('0' + modValue);
            count++;
        }

        Console.WriteLine("Iteration for:");
        int loopEnd = count-1;
        for (int i = 0; i < count/2; i++)
        {
            if(arr[i] != arr[loopEnd])
            {
                result = false;
                break;
            }
            loopEnd--;
            result = true;
            Console.WriteLine(" " + arr[i]);
        }
        Console.WriteLine("\n");
        Console.WriteLine(result);
    }
}



public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] arr = new char[11];
        if (x < 0)
        {
            return false;
        }

        if (x == 0)
        {
            return true;
        }

        int count = 0;
        while (x > 0)
        {
            int modValue = x % 10;
            x = x / 10;
            arr[count] = (char)('0' + modValue);
            count++;
        }

        int loopEnd = count - 1;
        for (int i = 0; i < count / 2; i++)
        {
            if (arr[i] != arr[loopEnd])
            {
                return false;
            }
            loopEnd--;            
        }
        return true;
    }
}

