// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Fibonacci\n2. Perfect Number\n3. Prime Numbers between Range");
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
    case 3:
        LogicalPrograms.PrimeNumber prime = new LogicalPrograms.PrimeNumber();
        prime.Prime();
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}