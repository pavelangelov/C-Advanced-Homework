namespace _02.GetLargestNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int firstNum = int.Parse(numbers[0]);
            int secondNum = int.Parse(numbers[1]);
            int thirdNum = int.Parse(numbers[2]);

            int largest = GetMax(GetMax(firstNum, secondNum), thirdNum);

            Console.WriteLine(largest);
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
