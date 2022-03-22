using System;
using System.IO;
namespace Lab03_SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputNumber();
                Console.WriteLine("=======================================================");
                GetNumberForAverageNumber();
                Console.WriteLine("=======================================================");
                Shape();
                Console.WriteLine("=======================================================");
                int[] arrNum = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
                Console.WriteLine($"The Most Frequency Number: {MostCommonNumber(arrNum)}");
                Console.WriteLine("=======================================================");
                int[] arrNum1 = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
                for (int i = 0; i < arrNum1.Length; i++)
                {
                    Console.Write($"{arrNum1[i]}, ");
                }
                Console.WriteLine();
                Console.WriteLine($"The Max Number in array is: {GetMaxNumber(arrNum1)}");
                Console.WriteLine("=======================================================");
                WriteInExternalFile();
                Console.WriteLine("=======================================================");
                ReadInExternalFile();
                Console.WriteLine("=======================================================");
                RemoveFirstWord();
                Console.WriteLine("=======================================================");
                Inputword();
                Console.WriteLine("=======================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ooops!, Error {e.Message}");
            }
           

        }

        // Challenge 1
        static void InputNumber()
        {
            Console.Write("Please enter 3 numbers: ");
            string str = Console.ReadLine();
            string[] strNums = str.Split(' ');
            Console.WriteLine("The product of these 3 numbers is: " + GetProudct(strNums));
        }
        public static int GetProudct(string[] strNums)
        {
            int product = 1;
            if (strNums.Length < 3)
            {
                return 0;
            }
            else if (strNums.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        int nums = Convert.ToInt32(strNums[i]);
                        product *= nums;
                    }
                    catch (FormatException e)
                    {
                        product *= 1;
                    }
                }
            }
            return product;
        }

        // Challenge 2
        public static int GetNumberForAverageNumber()
        {
            Console.Write("Please enter a number between 2-10: ");
            int num = Convert.ToInt32(Console.ReadLine());
           
            while (num > 10 || num < 2)
            {
                Console.WriteLine("The number out of range!");
                Console.Write("Please enter a number between 2-10: ");
                num = Convert.ToInt32(Console.ReadLine());

            }
            int[] numberArray = new int[num];
            for (int i = 0; i< num; i++)
            {
                Console.Write($"{i+1} of {num} - Enter a number: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
                while (numberArray[i] < 0)
                {
                    Console.WriteLine("Error! you prompt negative numbers ");
                    Console.Write($"{i + 1} of {num} - Enter a number: ");
                    numberArray[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return AverageNumber(numberArray);

        }
        public static int AverageNumber(int[] arr)
        {
            int sum = 0;
            int average = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            average = sum / arr.Length;
            Console.WriteLine($"The average of these  numbers is: {average}");
            return average;
        }
        // Challenge 3
        public static void Shape()
        {
            int i, j, k;

            for (i = 1; i <= 5; i++)
            {
                for (j = 0; j < (5 - i); j++)
                    Console.Write(" ");
              for (j = 1; j <= i; j++)
                    Console.Write("*");
              for (k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (i = 5 - 1; i >= 1; i--)
            {
                for (j = 0; j < (5 - i); j++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                for (k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        // Challenge 4
        public static int MostCommonNumber(int[] arr)
        {
                int finalyCount = 0;
                int count = 0;
                int currentNumber;
                int currentCount;

                for (int i = 0; i < arr.Length; i++)
                {
                    currentNumber = arr[i];
                    currentCount = 1;

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == currentNumber)
                        {
                            currentCount++;
                        }
                    }
                    if (currentCount > count)
                    {
                        finalyCount = currentNumber;
                        count = currentCount;
                    }
                }
                return finalyCount;
            
        }
        // Challenge 5
        public static int GetMaxNumber(int[] arr)
        {
            int maxNum=0;
            for (int i =0; i< arr.Length; i++)
            {
                if (maxNum < arr[i])
                {
                    maxNum = arr[i];
                }
            }
            return maxNum;
        }
        // Challenge 6
        public static void WriteInExternalFile()
        {
            Console.Write("Enter word to saves that into an external file: ");
            string path = "../../../words.txt";
            string word = Console.ReadLine();
            File.AppendAllText(path, "\n");
            File.AppendAllText(path, word);

        }
        // Challenge 7
        public static void ReadInExternalFile()
        {
            string path = "../../../words.txt";
            string output = File.ReadAllText(path);
            Console.WriteLine(output);
        }
        // Challenge 8
        public static void RemoveFirstWord()
        {
            string path = "../../../words.txt";
            string text = File.ReadAllText(path);

            string firstWord = text.Substring(0, text.IndexOf(" "));
            string newText = text.Remove(0, firstWord.Length+1);
            Console.WriteLine(newText);

        }
        // Challenge 9
        public static void Inputword()
        {
            Console.Write("Enter any sentence: ");
            string sentence = Console.ReadLine();
            wordWithLength(sentence);
        }
        public static string[] wordWithLength(string sentence)
        {
            string[] arrSentence = sentence.Split(" ");
           string[] arrString = new string[arrSentence.Length];
            for (int i = 0; i < arrSentence.Length; i++)
            {
                arrString[i] = $"{arrSentence[i]}: {arrSentence[i].Length}, ";
                Console.Write(arrString[i]);
            }
            Console.WriteLine();
            return arrString;
        }

    }
}
