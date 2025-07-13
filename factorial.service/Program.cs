int[] numbers = { 4, 3,1 };

foreach (int n in numbers)
{
    Thread tread = new Thread(() =>
    {
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine($"Factorial of is {fact}" );
    });
    tread.Start();
}
Thread.Sleep(1000);