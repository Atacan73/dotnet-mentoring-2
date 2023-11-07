using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();

            GetFirstChar(input);
        }

        private static void GetFirstChar(string input)
        {
            try
            {
                Console.WriteLine("First char: " + input[0]);
            }
            catch (Exception ex)
            {
                // Might be the Index out of range exception unnecceseary? because always returns first element and if it is null, then array is empty.
                if (ex is IndexOutOfRangeException || ex is ArgumentNullException || ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex);
                    return;
                }

                throw new Exception("Error occured when trying to get the first element: " + ex);
            }
            finally
            {
                Console.WriteLine("\nPlease enter a new string:");
                input = Console.ReadLine();
                GetFirstChar(input);
            }
        }
    }
}