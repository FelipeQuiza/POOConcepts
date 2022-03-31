using System;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO CONCEPTS");
            Console.WriteLine("**************");

            try
            {
                Date date = new Date(2024, 3, 30);
                Console.WriteLine(date);
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
        }
    }
}
