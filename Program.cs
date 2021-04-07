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

class Solution
{

    // Complete the kaprekarNumbers function below.
    static void kaprekarNumbers(int p, int q)
    {
        int count = 0;

        for (int n = p; n <= q; n++)
        {
            // Square it and convert it to a string
            int d = n.ToString().Length;
            string sq = ((long)n * (long)n).ToString();

            // Split it
            int right = int.Parse("0" + sq.Substring(sq.Length - d));
            int left = int.Parse("0" + sq.Substring(0, sq.Length - d));

            // Check it
            if (left + right == n)
            {
                // After the first one, add a space before the next.
                if (count > 0)
                    Console.Write(' ');

                // Kaprekar!
                count++;
                Console.Write(n);
            }
        }

        // Add a newline after our answer
        if (count > 0)
            Console.WriteLine();

        if (count == 0)
            Console.WriteLine("INVALID RANGE");
    }

    static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine());

        int q = Convert.ToInt32(Console.ReadLine());

        kaprekarNumbers(p, q);
    }
}
