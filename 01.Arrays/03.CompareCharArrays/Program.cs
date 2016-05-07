namespace _03.CompareCharArrays
{
    using System;

    class Program
    {
        static void Main()
        {
            char[] firstArr = Console.ReadLine().ToCharArray();
            char[] secondArr = Console.ReadLine().ToCharArray();

            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                bool areEqual = true;

                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine(">");
                        areEqual = false;
                        break;
                    }
                    else if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("<");
                        areEqual = false;
                        break;
                    }
                }

                if (areEqual)
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}
