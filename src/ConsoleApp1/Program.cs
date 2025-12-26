namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 101; i++)
        {
            if (IsPrime(i))
                Console.WriteLine(i);
        }
    }

    /// <summary>
    /// JS devs download a package for this.
    /// </summary>
    static bool IsPrime(int inputNumber)
    {
        var sqrt = Math.Sqrt(inputNumber);

        for (int i = 2; i <= sqrt; i++)
        {
            if (inputNumber % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}