namespace ConsoleApp1;

public static class TryCatching
{
    static bool doThrow = false;

    public static void Do(bool doThrow)
    {
        TryCatching.doThrow = doThrow;
        With();
        WithFail();
        Without();
        WithoutFail();
    }

    static void MightThrow()
    {
        if (doThrow)
            throw new MyException();
    }

    static void With()
    {
        try
        {
            Console.WriteLine("try");
            MightThrow();
            return;
        }
        catch (MyException)
        {
            Console.WriteLine("catch");
        }
        finally
        {
            Console.WriteLine("finally");
        }

        Console.WriteLine("after");
    }

    static void WithFail()
    {
        try
        {
            Console.WriteLine("try");
            MightThrow();
            return;
        }
        catch (WrongException)
        {
            Console.WriteLine("catch");
        }
        finally
        {
            Console.WriteLine("finally");
        }

        Console.WriteLine("after");
    }

    static void Without()
    {
        try
        {
            Console.WriteLine("try");
            MightThrow();
            return;
        }
        catch (MyException)
        {
            Console.WriteLine("catch");
        }

        Console.WriteLine("after");
    }

    static void WithoutFail()
    {
        try
        {
            Console.WriteLine("try");
            MightThrow();
            return;
        }
        catch (WrongException)
        {
            Console.WriteLine("catch");
        }


        Console.WriteLine("after");
    }
}


class MyException : Exception { }
class WrongException : Exception { }