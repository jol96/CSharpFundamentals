using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Security.Cryptography;
using System;
using System.Collections;

public class Program
{
    public static int solution(int year)
    {
        int centurary = (year / 100) + 1;
        return centurary;
    }

    public static bool Palindrone(string text)
    {
        char[] textArr = text.ToCharArray();
        var textArrLastElementIndex = textArr.Length - 1;
        bool isPalindrone = false;
        int halfOfTextArr = (textArr.Length / 2);

        for (int i = 0; i <= halfOfTextArr; i++)
        {
            var firstHalfValue = textArr[i];
            var secondHalfValue = textArr[textArrLastElementIndex];


            if (firstHalfValue != secondHalfValue)
            {
                //Console.WriteLine($"textArr[{i}] value {textArr[i]} is not equal to textArr[{textArrLastElementIndex}] {textArr[textArrLastElementIndex]}");
                isPalindrone = false;
                Console.WriteLine($"{text} is not a palindron");
                break;
            }
            else if (firstHalfValue == secondHalfValue)
            {
                //Console.WriteLine($"textArr[{i}] value {textArr[i]} is equal to textArr[{textArrLastElementIndex}] {textArr[textArrLastElementIndex]}");
                textArrLastElementIndex--;
                if (i == halfOfTextArr) 
                {
                    Console.WriteLine($"{text} is a palindron");
                    isPalindrone = true;
                }
                else
                {
                    continue;
                }              
            }
        }

        return isPalindrone;
    }

    public static int LargetAdjacentProduct(int[] inputArray) 
    {
        int largestProduct = -1000;
        
        for(int i = 0; i < inputArray.Length-1;i++)
        {
            var currentValue = inputArray[i];
            var adjacentCalue = inputArray[i + 1];

            var product = currentValue * adjacentCalue;

            if(product > largestProduct)
            {
                largestProduct = product;
            }
        }
        Console.WriteLine($"Largest product {largestProduct}");
        return largestProduct;
    }

    public static int NInterestingPolygon(int n) 
    {
        return (n * n) + ((n - 1)*(n -1));
    }

    public static int[] MakeArrayConsecutive(int[] statues)
    {
        // Sorting the array from lowest to highest
        var sortedStatues = statues.OrderBy(num => num).ToArray();

        // get first and last elements of array
        var smallestStatue = sortedStatues[0];
        var largestStatue = sortedStatues[sortedStatues.Length - 1];

        ArrayList missingStatues = new ArrayList();

        Console.WriteLine($"smallestStatue {smallestStatue} \n largestStatue {largestStatue}");

        for(int i = smallestStatue + 1; i < largestStatue; i++)
        {
            bool containsStatue = Array.Exists(sortedStatues, element => element == i);

            if (!containsStatue)
            {
                missingStatues.Add(i);
                Console.WriteLine("Statue array does not contains statue of height " + i + ". Adding to missingStatues Array.");
            }
            else
            {
                Console.WriteLine("Statue array contains statue of height " + i + ": " + containsStatue);
            }
        }

        int[] missingStatuesArray = missingStatues.Cast<int>().ToArray();

        Console.WriteLine($"Missing statues:");
        foreach (int statue in missingStatuesArray)
        {
            Console.WriteLine(statue);
        }

        return missingStatuesArray;
    }

    public static void Main(string[] args)
    {
        //int year = 200;
        //Console.WriteLine($"centuary of {year} is {solution(year)}");

        //Palindrone("aaabbaaa");

        //int[] inputArray = { -23, 4, -3, 8, -12 };
        //LargetAdjacentProduct(inputArray);

        //int result = NInterestingPolygon(4);
        //Console.WriteLine(result);

        int[] inputArray = { 6,2,3,8};
        MakeArrayConsecutive(inputArray);

    }
}