using System;

namespace pattern
{
    public class Program
    {
            public static void Main(string[] args)
            {
                for (int row = 1; row <= 8; ++row)
                {
                    for (int col = 1; col <= row; ++col)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        
    }
}
