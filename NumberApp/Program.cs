// See https://aka.ms/new-console-template for more information

namespace NumberApp
{

    class Program
    {
                   
        public static void Main()
        {
           var _service = new NumberAppService();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hey, please enter the first number? ");
            Console.ResetColor();
            var  num1 = Console.ReadLine();
            _service.AddNumberToList(Convert.ToInt32(num1));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the second number");
            Console.ResetColor();
            var num2 = Console.ReadLine();
            _service.AddNumberToList(Convert.ToInt32(num2));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the third number");
            Console.ResetColor();
            var num3 = Console.ReadLine();
            _service.AddNumberToList(Convert.ToInt32(num3));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the fourth number");
            Console.ResetColor();
            var num4 =  Console.ReadLine();
            _service.AddNumberToList(Convert.ToInt32(num4));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the fifth number");
            Console.ResetColor();
            var num5 =   Console.ReadLine();
            _service.AddNumberToList(Convert.ToInt32(num5));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("thank you for playing, please type continue if you want to see your results");
            Console.ResetColor();
            Console.ReadLine();
            var  total =  _service.GetTotalNumbers();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congradulations,here is the total numbers that you have entered {total} ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please type ENTER to see your average");
            Console.ResetColor();
            Console.ReadLine();

            var average = _service.GetAverage();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You are a star!, take a look at the average of you cool numbers {average}");
            Console.ResetColor();

            var highestNumber = _service.GetHighestNumber();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Look this is your highest number {highestNumber}");
            Console.ResetColor();
        }

    }
}