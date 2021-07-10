using System;

namespace ErrorPractice
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter your name: ");

            string name = null;

            try {
                printName(name);

            }
            catch(DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }

        private static void printName(string std)
        {
            if(std == null)
            {
                throw new NullReferenceException("Name is null.");
            }

            Console.WriteLine(std);
        }
    }
}
