using System;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string operand;
            float answer;

            Console.Write("Pilih Menu Calculator : ");
            Console.WriteLine();
            Console.Write("1. Penambahan ");
            Console.WriteLine();
            Console.Write("2. Pengurangan ");
            Console.WriteLine();
            Console.Write("3. Pembagian ");
            Console.WriteLine();
            Console.Write("4. Perkalian ");
            Console.WriteLine();
            Console.Write("Pilih Angka (1 - 4) : ");
            operand = Console.ReadLine();

            Console.Write("Inputkan Nilai a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan Nilai b : ");
            b = Convert.ToInt32(Console.ReadLine());

            if (operand == "-")
            {
                answer = a - b;
            }
            else if (operand == "1")
            {
                answer = a + b;
            }
            else if (operand == "2")
            {
                answer = a - b;
            }
            else if (operand == "3")
            {
                answer = a / b;
            }
            else if (operand == "4")
            {
                answer = a * b;
            }
            else
            {
                answer = 0;
            }

            Console.WriteLine(a.ToString() + " " + operand + " " + b.ToString() + " = " + answer.ToString());
            
            Console.ReadLine();

            Console.WriteLine("\n Tekan Terserah Untuk Keluar");
            Console.ReadKey();
        }
    }
}

        