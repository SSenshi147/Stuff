namespace ConsoleApp1;

/// <summary>
/// 2023.12.08 Betsson
/// </summary>
public static class InterviewStuff
{
    public static void Main()
    {
        Console.WriteLine(solution(new int[] { 1, 1 }, new int[] { 12223, 4 }));
        Console.WriteLine(solution(new int[] { 3, 2, 1 }, new int[] { 1, 2, 1, 32, 41 }));

        //int a = 5, b = 10;
        //a = a * b;
        //b = a / b;
        //a = a / b;

        //Console.WriteLine(a);
        //Console.WriteLine(b);

        Console.ReadLine();
    }

    public static int ints(int[] A)
    {
        int sum = 0;

        foreach (int i in A)
        {
            if (i >= 10 && i <= 99 || i <= -10 && i >= -99)
            {
                sum += i;
            }
        }

        return sum;
    }

    public static int solution(int[] A, int[] B)
    {
        //var intersect = A.Intersect(B);
        //return intersect.Any() ? intersect.Min(x => x) : -1;

        int n = A.Length;
        int m = B.Length;
        Array.Sort(A);
        Array.Sort(B);
        int i = 0;
        for (int k = 0; k < n; k++)
        {
            while (i < m - 1 && B[i] < A[k])
                i += 1;
            if (A[k] == B[i])
                return A[k];
        }
        return -1;
    }
}