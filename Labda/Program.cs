internal class Program // 1.0 - Use of Lambda, List Creation, and foreach loop.
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 13, 244, 334, 433, 54, 69, 76, 88, 92, 101, 4, 3, 8, 23, 15, 18 };

        // this filter all the numbers that's divisible by 2 -- even numbers.
        // the queuery syntax
        var ListedNo = from number in numbers
                       where number %2 == 0
                       select number ;
       
        // the lambda expression -- which
        var EvenNums = numbers.Where(number => number > 30) ;



       foreach ( var EvenNum in EvenNums )
        {
            if( EvenNum %2 == 0)
            {
                Console.WriteLine("This number is Divisible by two!");
                Console.WriteLine(EvenNum);
                Console.WriteLine("\n");
            }

            else
            {
                Console.WriteLine("This number is NOT Divisible by two!");
                Console.WriteLine(EvenNum);

                Console.WriteLine("\n");

            }
        }

    }
}