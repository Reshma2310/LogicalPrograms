// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Fibonacci\n2. Perfect Number");
int input = Convert.ToInt32(Console.ReadLine());
switch(input)
{
    case 1:
        LogicalPrograms.Fibonacci fibonacci = new LogicalPrograms.Fibonacci();
        fibonacci.FibonacciSeries();
        break;
    case 2:
        LogicalPrograms.PerfectNumber perfect = new LogicalPrograms.PerfectNumber();
        perfect.Perfect();
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}