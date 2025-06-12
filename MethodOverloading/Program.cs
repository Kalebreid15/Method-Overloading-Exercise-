namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(string numOne, string numTwo, bool isCurrency)
        {
            // Convert string inputs to integers for addition
            int numberOne = int.Parse(numOne);
            int numberTwo = int.Parse(numTwo);
            int sum = numberOne + numberTwo;

            if (isCurrency && sum > 1)
            {
                return $"${sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"${sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(numOne: 5, numTwo: 10)); // Output: 15

            Console.WriteLine(Add(numOne: 5.5m, numTwo: 10.2m)); // Output: 15.7

            Console.WriteLine(Add(numOne: "5", numTwo: "10", isCurrency: true)); // Output: $15 dollars
        }
    }
}
