using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BingoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountAns1 = 0;
            int CountAns2 = 0;
            int CountAns3 = 0;
            int CountAns4 = 0;
            int CountAns5 = 0;
            int CountAns6 = 0;
            int CountAns7 = 0;
            int CountAns8 = 0;
            int CountAns9 = 0;
            int CountAns10 = 0;
            int CountAns11 = 0;
            int CountAns12 = 0;
            //row
            int[] ArrayAns1 = new int[] { 1, 2, 3, 4, 5 };
            int[] ArrayAns2 = new int[] { 6, 7, 8, 9, 10 };
            int[] ArrayAns3 = new int[] { 11, 12, 13, 14, 15 };
            int[] ArrayAns4 = new int[] { 16, 17, 18, 19, 20 };
            int[] ArrayAns5 = new int[] { 21, 22, 23, 24, 25 };
            //colum
            int[] ArrayAns6 = new int[] { 1, 6, 11, 16, 21 };
            int[] ArrayAns7 = new int[] { 2, 7, 12, 17, 22 };
            int[] ArrayAns8 = new int[] { 3, 8, 13, 18, 23 };
            int[] ArrayAns9 = new int[] { 4, 9, 14, 19, 24 };
            int[] ArrayAns10 = new int[] { 5, 10, 15, 20, 25 };
            //diagonal
            int[] ArrayAns11 = new int[] { 1, 7, 13, 19, 25 };
            int[] ArrayAns12 = new int[] { 21, 17, 13, 9, 5 };

            while (true)
            {
                Console.WriteLine($"Please input number or input exit.");
                Console.WriteLine("Input : ");
                var inputData = Console.ReadLine();
                if (!int.TryParse(inputData, out int inputNumber))
                {
                    if (inputData.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    Console.WriteLine($"{inputData} is not a number.");
                }
                else
                {
                    //Console.WriteLine($"{inputNumber} is a number");
                    foreach (int c1 in ArrayAns1)
                    {
                        if (c1 == inputNumber)
                        {
                            CountAns1++;
                            int numToRemove = c1;
                            ArrayAns1 = ArrayAns1.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c1);
                    }

                    foreach (int c2 in ArrayAns2)
                    {
                        if (c2 == inputNumber)
                        {
                            CountAns2++;
                            int numToRemove = c2;
                            ArrayAns2 = ArrayAns2.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c2);
                    }

                    foreach (int c3 in ArrayAns3)
                    {
                        if (c3 == inputNumber)
                        {
                            CountAns3++;
                            int numToRemove = c3;
                            ArrayAns3 = ArrayAns3.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c3);
                    }

                    foreach (int c4 in ArrayAns4)
                    {
                        if (c4 == inputNumber)
                        {
                            CountAns4++;
                            int numToRemove = c4;
                            ArrayAns4 = ArrayAns4.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c4);
                    }

                    foreach (int c5 in ArrayAns5)
                    {
                        if (c5 == inputNumber)
                        {
                            CountAns5++;
                            int numToRemove = c5;
                            ArrayAns5 = ArrayAns5.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c5);
                    }

                    foreach (int c6 in ArrayAns6)
                    {
                        if (c6 == inputNumber)
                        {
                            CountAns6++;
                            int numToRemove = c6;
                            ArrayAns6 = ArrayAns6.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c6);
                    }

                    foreach (int c7 in ArrayAns7)
                    {
                        if (c7 == inputNumber)
                        {
                            CountAns7++;
                            int numToRemove = c7;
                            ArrayAns7 = ArrayAns7.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c7);
                    }

                    foreach (int c8 in ArrayAns8)
                    {
                        if (c8 == inputNumber)
                        {
                            CountAns8++;
                            int numToRemove = c8;
                            ArrayAns8 = ArrayAns8.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c8);
                    }

                    foreach (int c9 in ArrayAns9)
                    {
                        if (c9 == inputNumber)
                        {
                            CountAns9++;
                            int numToRemove = c9;
                            ArrayAns9 = ArrayAns9.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c9);
                    }

                    foreach (int c10 in ArrayAns10)
                    {
                        if (c10 == inputNumber)
                        {
                            CountAns10++;
                            int numToRemove = c10;
                            ArrayAns10 = ArrayAns10.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c10);
                    }

                    foreach (int c11 in ArrayAns11)
                    {
                        if (c11 == inputNumber)
                        {
                            CountAns11++;
                            int numToRemove = c11;
                            ArrayAns11 = ArrayAns11.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c11);
                    }

                    foreach (int c12 in ArrayAns12)
                    {
                        if (c12 == inputNumber)
                        {
                            CountAns12++;
                            int numToRemove = c12;
                            ArrayAns12 = ArrayAns12.Where(val => val != numToRemove).ToArray();
                        }
                        //Console.WriteLine(c12);
                    }

                    //check Bingo
                    if (CountAns1 == 5 || CountAns2 == 5 || CountAns3 == 5 || CountAns4 == 5 || CountAns5 == 5 || CountAns6 == 5 || CountAns7 == 5 || CountAns8 == 5 || CountAns9 == 5 || CountAns10 == 5 || CountAns11 == 5 || CountAns12 == 5)
                    {
                        Console.WriteLine($"Bingo\n");
                    }
                    else
                    {
                        Console.WriteLine($"Not Bingo\n");
                    }
                    
                }
       
            }


        }
    }
}
