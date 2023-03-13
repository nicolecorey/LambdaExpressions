namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numArr = new double[2];
            Console.WriteLine("Please enter 2 numbers with decimals.");
            for (int i = 0; i < 2; i++)
            {
                numArr[i] = Convert.ToDouble(Console.ReadLine());
            }

            var sum = (double x, double y) => x + y;
           
            var result = (double x, double y) => x * y;
           
            var smallerValue = (double x, double y) =>
            {
                if (x < y)
                    return x;
                else
                    return y;
            };


            for (int x = 0; x < numArr.Length - 1; x++)
            {
                Console.WriteLine($"Your chosen numbers are: {numArr[x]}  and  {numArr[x + 1]}");
                Console.WriteLine($"Your numbers added equal: {sum(numArr[x], numArr[x + 1])}");
                Console.WriteLine($"Your numbers multiplied equal: {result(numArr[x], numArr[x + 1])}");
                Console.WriteLine($"The smaller number is: {smallerValue(numArr[x], numArr[x + 1])}");
                Console.WriteLine();
            }

        }
    }
}