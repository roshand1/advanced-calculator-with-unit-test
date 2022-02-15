// See https://aka.ms/new-console-template for more information
using Calculator;

var calculator = new AdvancedCalculator();

Console.WriteLine("Please Enter + to add and . to clear");

bool shouldContinue = true;

do
{
    Console.WriteLine("Please insert operations, + , - , .");
    char action = Console.ReadKey().KeyChar;
    Console.Clear();
    Console.WriteLine("Your TotalNumber is: " + calculator._result);

    if (action == '.')
    {
        calculator.Clear();
        //shouldContinue = false;
    }
    else
    {
        Console.WriteLine("Please Enter Number to add");
        decimal numberToAdd;
        string str = Console.ReadLine();
        decimal.TryParse(str, out numberToAdd);
        calculator.Add(numberToAdd);
        Console.WriteLine("Your Number is: " + calculator._result);
    }

} while (shouldContinue);

