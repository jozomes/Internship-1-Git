using System;

public class Diamond
{
    public static void Main()
    {
        int n;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 0);
        for (int i = 1; i <= n; i++)
        {
            
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

           
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        
        for (int i = n - 1; i >= 1; i--)
        {
            
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}