﻿using System;

namespace _6._1.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int K = firstNumber; K <= 8; K++)
            {
                for (int L = 9; L >= secondNumber; L--)
                {
                    for (int M = thirdNumber; M <= 8; M++)
                    {
                        for (int N = 9; N >= fourNumber; N--)
                        {

                            if (K == M && L == N && K % 2 == 0 && L % 2 != 0)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else if (K % 2 == 0 && L % 2 != 0 && M % 2 == 0 && N % 2 != 0)
                            {
                                Console.WriteLine($"{K}{L} - {M}{N}");
                                counter++;
                            }
                            if (counter == 6)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}

