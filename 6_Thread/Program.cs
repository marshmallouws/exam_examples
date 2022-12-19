

using System.Collections.Concurrent;
using System.Globalization;

class ThreadCreationProgram
{
    public static void CallToChildThread()
    {
        Console.WriteLine("Child thread starts");

        // the thread is paused for 5000 milliseconds
        int sleepfor = 1000;

        Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
        Thread.Sleep(sleepfor);
        Console.WriteLine("Child thread resumes");
    }

    static void Main(string[] args)
    {
        ThreadStart childref = new ThreadStart(CallToChildThread);
        Console.WriteLine("In Main: Creating the Child thread");

        Thread childThread = new Thread(childref);
        childThread.Start();
        Console.ReadKey();


        // Parallel
        var numbers = new List<int>();
        for(int i = 0; i < 100; i++)
        {
            numbers.Add(i);
        }

        foreach(var n in numbers)
        {
            if(IsPrime(n))
            {
                Console.WriteLine(n);
            }
        }

        Console.WriteLine("-------------------------------");

        Parallel.ForEach(numbers, n =>
        {
            if (IsPrime(n))
            {
                Console.WriteLine(n);
            }
        });
    }

    private static IList<int> GetPrimeListWithParallel(IList<int> numbers)
    {
        var primeNumbers = new ConcurrentBag<int>();

        Parallel.ForEach(numbers, number =>
        {
            if (IsPrime(number))
            {
                primeNumbers.Add(number);
            }
        });

        return primeNumbers.ToList();
    }

    /// <summary>
    /// IsPrime returns true if number is Prime, else false.(https://en.wikipedia.org/wiki/Prime_number)
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }
}