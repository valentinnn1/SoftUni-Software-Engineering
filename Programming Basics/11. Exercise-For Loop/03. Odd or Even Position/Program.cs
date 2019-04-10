using System;

namespace _03.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;


            if (num == 0)
            {
                Console.WriteLine("Oddsum=" + num);
                Console.WriteLine("Oddmin=No");
                Console.WriteLine("Oddmax=No");
                Console.WriteLine("Evensum=" + num);
                Console.WriteLine("Evenmin=No");
                Console.WriteLine("Evenmax=No");


            }
            else if (num == 1)
            {
                double curr = double.Parse(Console.ReadLine());
                Console.WriteLine("Oddsum=" + curr);
                Console.WriteLine("Oddmin=" + curr);
                Console.WriteLine("Oddmax=" + curr);
                Console.WriteLine("Evensum=0");
                Console.WriteLine("Evenmin=No");
                Console.WriteLine("Evenmax=No");

            }
            else
            {
                for (int i = 1; i <= num; i++)
                {

                    double curr = double.Parse(Console.ReadLine());

                    if (i % 2 != 0)
                    {
                        oddSum += curr;
                        if (curr > oddMax)
                        {
                            oddMax = curr;
                        }
                        if (curr < oddMin)
                        {
                            oddMin = curr;
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        evenSum += curr;
                        if (curr > evenMax)
                        {
                            evenMax = curr;
                        }
                        if (curr < evenMin)
                        {
                            evenMin = curr;
                        }
                    }
                }

                Console.WriteLine("Oddsum=" + oddSum);
                Console.WriteLine("Oddmin=" + oddMin);
                Console.WriteLine("Oddmax=" + oddMax);
                Console.WriteLine("Evensum=" + evenSum);
                Console.WriteLine("Evenmin=" + evenMin);
                Console.WriteLine("Evenmax=" + evenMax);
            }

            //2 вариант!!!

            // int n = int.Parse(Console.ReadLine());
            // double evenSum = 0;
            // double oddSum = 0;
            // double evenMaxValue = double.MinValue;
            // double evenMinValue = double.MaxValue;
            // double oddMaxValue = double.MinValue;
            // double oddMinValue = double.MaxValue;

            // for (int i = 1; i <= n; i++)
            // {
            //    double number = double.Parse(Console.ReadLine());
            //    if (i % 2 == 0)
            //    {
            //        evenSum += number;
            //        if (number > evenMaxValue)
            //        {
            //            evenMaxValue = number;
            //        }
            //       if (number < evenMinValue)
            //        {
            //            evenMinValue = number;
            //        }
            //    }
            //    else
            //    {
            //        oddSum += number;
            //        if (number > oddMaxValue)
            //        {
            //            oddMaxValue = number;
            //        }
            //        if (number < oddMinValue)
            //        {
            //            oddMinValue = number;
            //        }
            //    }
            // }
            // Console.WriteLine($"OddSum={oddSum}");
            // if (oddMinValue == double.MaxValue)
            // {
            //    Console.WriteLine($"OddMin=No");
            // }
            // else
            // {
            //    Console.WriteLine($"OddMin={oddMin}");
            // }
            // if (oddMaxValue == double.MinValue)
            // {
            //    Console.WriteLine($"OddMax=No");
            // }
            // else
            // {
            //    Console.WriteLine($"OddMax={oddMaxValue}");
            // }
            // Console.WriteLine($"EvenSum={evenSum}");
            // if (evenMinValue == double.MaxValue)
            // {
            //    Console.WriteLine($"EvenMin=No");
            // }
            // else
            // {
            //    Console.WriteLine($"EvenMin={evenMinValue}");
            // }
            // if (evenMaxValue == double.MinValue)
            // {
            //    Console.WriteLine($"EvenMax=No");
            // }
            // else
            // {
            //    Console.WriteLine($"EvenMax={evenMaxValue}");
            // }
        }
    }
}