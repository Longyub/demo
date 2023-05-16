using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  // include the System.IO namespace

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Mega();
            Power();
        }
        static void Mega()
        {
            // Specify a name for your top-level folder.
            string path = @"C:\tmp\MyTest.txt"; string data = @"C:\tmp\data.txt"; string Sum = @"C:\tmp\sum.txt"; string inputmega = @"C:\tmp\inputmega.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("mega--------------------------->"+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            }
            if (File.Exists(data))
            {
                File.Delete(data);
                File.Delete(Sum);

            }
            // Read data from file into megaNumbers array
            string[,] megaNumbers = new string[10, 6];
            string[] lines = File.ReadAllLines(inputmega);
            for (int i = 0; i < megaNumbers.GetLength(0); i++)
            {
                string[] numbers = lines[i].Split(' ');
                for (int j = 0; j < megaNumbers.GetLength(1); j++)
                {
                    megaNumbers[i, j] = numbers[j].Trim();
                }
            }
            string[,] megaFetch = new string[10, 15]; // Increase size if needed
            int row = 0;

            for (int i = 0; i < megaNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < megaNumbers.GetLength(1); j++)
                {
                    using (StreamWriter sw = File.AppendText(data))
                    {
                        sw.WriteLine("INSERT INTO Mega VALUES(N'" + megaNumbers[i, j] + "'); ");
                    }
                    for (int e = j + 1; e < megaNumbers.GetLength(1); e++)
                    {
                        //Console.Write(Mega[i, j] + Mega[i, e] + "     ");
                        megaFetch[i, row] = megaNumbers[i, j] + megaNumbers[i, e];
                        if (row < 14) row++;
                    }
                    //Console.WriteLine();
                }
                row = 0;
                Console.WriteLine();
            }
            //printf Megafetch
            /*
            for (int i = 0; i < Megafetch.GetLength(0); i++)
            {
                for (int j = 0; j < Megafetch.GetLength(1); j++)
                {
                    //Console.Write(Megafetch[i, j] + "   ");
                }
                //Console.WriteLine();
            }*/

            for (int i = 0; i < megaFetch.GetLength(0); i++)
            {
                for (int j = 0; j < megaFetch.GetLength(1); j++)
                {
                    for (int e = i + 1; e < megaFetch.GetLength(0); e++)
                    {
                        for (int f = 0; f < megaFetch.GetLength(1); f++)
                        {
                            using (StreamWriter sw = File.AppendText(Sum))
                            {
                                sw.WriteLine("INSERT INTO MegaSum VALUES(N'" + megaFetch[i, j] + megaFetch[e, f] + "'); ");
                            }
                            //Console.Write(Megafetch[i, j] + " " + Megafetch[e, f] + "     ");
                            if (megaFetch[i, j] == megaFetch[e, f])
                            {
                                Console.Write(megaFetch[i, j] + " " + megaFetch[e, f] + "     ");
                                using (StreamWriter sw = File.AppendText(path))
                                {
                                    sw.WriteLine(megaFetch[i, j] + " " + megaFetch[e, f]);
                                }
                            }
                            //Console.Write(Megafetch[i, j] + " " + Megafetch[e, f] + "     ");
                        }
                        //Console.WriteLine();
                        //Console.Write(Megafetch[i, j] + " " + Megafetch[e, j] + "     ");
                    }
                    //Console.WriteLine();
                }
                //Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Power()
        {
            // Specify a name for your top-level folder.
            string path = @"C:\tmp\MyTest.txt"; string data = @"C:\tmp\data.txt"; string Sum = @"C:\tmp\sum.txt"; string inputpower = @"C:\tmp\inputpower.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Power--------------------------->" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            }

            string[,] Power = new string[10, 6];
            string[] lines = File.ReadAllLines(inputpower);
            for (int i = 0; i < Power.GetLength(0); i++)
            {
                string[] numbers = lines[i].Split(' ');
                for (int j = 0; j < Power.GetLength(1); j++)
                {
                    Power[i, j] = numbers[j].Trim();
                }
            }
            string[,] Powerfetch = new string[10, 15]; // Increase size if needed
            int row = 0;
            for (int i = 0; i < Power.GetLength(0); i++)
            {
                for (int j = 0; j < Power.GetLength(1); j++)
                {
                    using (StreamWriter sw = File.AppendText(data))
                    {
                        sw.WriteLine("INSERT INTO Power VALUES(N'" + Power[i, j]+"'); ");
                    }

                    for (int e = j + 1; e < Power.GetLength(1); e++)
                    {
                        //Console.Write(Power[i, j] + Power[i, e] + "     ");
                        Powerfetch[i, row] = Power[i, j] + Power[i, e];
                        if (row < 20) row++;
                    }
                    //Console.WriteLine();

                }
                row = 0;
                //Console.WriteLine();
            }
            //printf Powerfetch
            /*
            for (int i = 0; i < Powerfetch.GetLength(0); i++)
            {
                for (int j = 0; j < Powerfetch.GetLength(1); j++)
                {
                    //Console.Write(Powerfetch[i, j] + "   ");
                }
                //Console.WriteLine();
            }*/
            for (int i = 0; i < Powerfetch.GetLength(0); i++)
            {
                for (int j = 0; j < Powerfetch.GetLength(1); j++)
                {
                    for (int e = i + 1; e < Powerfetch.GetLength(0); e++)
                    {
                        for (int f = 0; f < Powerfetch.GetLength(1); f++)
                        {
                            using (StreamWriter sw = File.AppendText(Sum))
                            {
                                sw.WriteLine("INSERT INTO PowerSum VALUES(N'" + Powerfetch[i, j] + Powerfetch[e, f] + "'); ");
                            }
                            //Console.Write(Powerfetch[i, j] + " " + Powerfetch[e, f] + "     ");
                            if (Powerfetch[i, j] == Powerfetch[e, f])
                            {
                                Console.Write(Powerfetch[i, j] + " " + Powerfetch[e, f] + "     ");
                                using (StreamWriter sw = File.AppendText(path))
                                {
                                    sw.WriteLine(Powerfetch[i, j] + " " + Powerfetch[e, f]);
                                }
                            }
                            //Console.Write(Powerfetch[i, j] + " " + Powerfetch[e, f] + "     ");
                        }
                        //Console.WriteLine();
                        //Console.Write(Powerfetch[i, j] + " " + Powerfetch[e, j] + "     ");
                    }
                    //Console.WriteLine();
                }
                //Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}   
