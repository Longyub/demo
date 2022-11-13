using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   //                      0                   1
            Mega();

        }
        static void Mega()
        {
            string[,] Mega = {
                    { "01", "02", "03", "08", "05", "06" }, //[0, 0]
                    { "07", "08", "09", "10", "11", "12" }, //[1, 0]
                    { "13", "14", "15", "16", "17", "18" },
                    { "19", "02", "06", "25", "23", "30" },    //[2, 0]
                    { "25", "26", "27", "28", "29", "30" }
            };
            string[,] Megafetch = {
                    { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }, //[0, 0]
                    { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }, //[1, 0]
                    { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                    { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                    { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }//[2, 0]
            };
            int row = 0;
            for (int i = 0; i < Mega.GetLength(0); i++)
            {
                for (int j = 0; j < Mega.GetLength(1); j++)
                {
                    for (int e = j + 1; e < Mega.GetLength(1); e++)
                    {
                        Console.Write(Mega[i, j] + Mega[i, e] + "     ");
                        Megafetch[i, row] = Mega[i, j] + Mega[i, e];
                        if (row < 14) row++;
                    }
                    Console.WriteLine();

                }
                row = 0;
                Console.WriteLine();
            }
            //printf Megafetch

            for (int i = 0; i < Megafetch.GetLength(0); i++)
            {
                for (int j = 0; j < Megafetch.GetLength(1); j++)
                {
                    Console.Write(Megafetch[i, j] + "   ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < Megafetch.GetLength(0); i++)
            {
                for (int j = 0; j < Megafetch.GetLength(1); j++)
                {
                    for (int e = i + 1; e < Megafetch.GetLength(0); e++)
                    {
                        for (int f = 0; f < Megafetch.GetLength(1); f++)
                        {
                            //Console.Write(Megafetch[i, j] + " " + Megafetch[e, f] + "     ");
                            if (Megafetch[i, j] == Megafetch[e, f])
                            {
                                Console.Write(Megafetch[i, j] + " " + Megafetch[e, f] + "     ");
                            }
                            //Console.Write(Megafetch[i, j] + " " + Megafetch[e, f] + "     ");
                        }
                        Console.WriteLine();
                        //Console.Write(Megafetch[i, j] + " " + Megafetch[e, j] + "     ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }

    }
}   
