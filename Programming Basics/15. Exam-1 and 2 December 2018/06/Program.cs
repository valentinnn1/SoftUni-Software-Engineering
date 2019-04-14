using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxCount = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= maxCount; )
            {
                for (char firstSym = (char)35; firstSym <= (char)55;)
                {
                    for (char secondSym = (char)64; secondSym <= (char)96;)
                    {
                        for (int thirdSym = 1; thirdSym <= a;)
                        {
                            for (int fourthSym = 1; fourthSym <= b;)
                            {
                                for (char fifthSym = (char)64; fifthSym <= (char)96;)
                                {
                                    for (char sixthSym = (char)35; sixthSym <= (char)55;)
                                    {
                                        if (fourthSym > b)
                                        {
                                            fourthSym = 1;
                                            thirdSym++;
                                        }
                                        
                                        Console.Write($"{firstSym}{secondSym}{thirdSym}{fourthSym}{fifthSym}{sixthSym}|");
                                        firstSym++;
                                        secondSym++;
                                        fifthSym++;
                                        sixthSym++;
                                        counter++;

                                        if (firstSym > (char)55)
                                        {
                                            firstSym = (char)35;
                                        }
                                        if (secondSym > (char)96)
                                        {
                                            secondSym = (char)64;
                                        }
                                        if (fifthSym > (char)96)
                                        {
                                            fifthSym = (char)64;
                                        }
                                        if (sixthSym > (char)55)
                                        {
                                            sixthSym = (char)35;
                                        }

                                        if (counter > maxCount)
                                        {
                                            return;
                                        }
                                        if (thirdSym == a && fourthSym == b)
                                        {
                                            return;
                                        }
                                        else
                                        {
                                            fourthSym++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
