// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Fibonacci\n2. Perfect Number\n3. Prime Numbers between Range\n4. Reverse a Number\n5. Coupon Number\n6. Stopwatch Simulation\n7. Fewer Notes from Vending Machine");
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
    case 4:
        LogicalPrograms.ReverseNumber number = new LogicalPrograms.ReverseNumber();
        number.Reverse();
        break;
    case 5:
        LogicalPrograms.CouponNumbers coupon = new LogicalPrograms.CouponNumbers();
        coupon.Coupon();
        break;
    case 6:
        LogicalPrograms.StopWatch watch = new LogicalPrograms.StopWatch();
        watch.StopwatchOutput();
        break;
    case 7:
        LogicalPrograms.VendingMachine vending = new LogicalPrograms.VendingMachine();
        vending.Machine();
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}