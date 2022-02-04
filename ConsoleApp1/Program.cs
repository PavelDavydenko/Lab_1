using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимальная сумма двух чисел кратная 3
            Random rand = new Random();
            Console.Write("Введите количество чисел: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int curentDigit = 0;
            int mod_1 = 0;
            int mod_2 = 0;
            int mod_3_1 = 0;
            int mod_3_2 = 0;
            Console.WriteLine("---------------------------------------------------------------------");
            for (int i = 0;i<count;i++)
            {
                curentDigit = rand.Next(1,100);
                switch (curentDigit % 3)
                {
                    case 0:
                        Console.WriteLine(curentDigit + " - кратно 3");
                        if (mod_3_1 > mod_3_2)
                        {
                            if (curentDigit > mod_3_2) {mod_3_2 = curentDigit;}
                        }
                        else 
                        {
                            if (curentDigit > mod_3_1) {mod_3_1 = curentDigit;}
                        }
                        break;
                    case 1:
                        Console.WriteLine(curentDigit + " - остаток 1");
                        if (curentDigit > mod_1) { mod_1 = curentDigit; }
                        break;
                    case 2:
                        Console.WriteLine(curentDigit + " - остаток 2");
                        if (curentDigit > mod_2) { mod_2 = curentDigit; }
                        break;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Максимальная сумма кратная 3 (из двух чисел некратных 3): " + mod_1 + " + " + mod_2 + " = " + (mod_1 + mod_2));
            Console.WriteLine("Максимальная сумма кратная 3 (из двух чисел кратных 3): " + mod_3_1 + " + " + mod_3_2 + " = " + (mod_3_1 + mod_3_2));
            Console.WriteLine("---------------------------------------------------------------------");
            if (mod_1 + mod_2 > mod_3_1 + mod_3_2)
            { 
                Console.WriteLine("Максимальная сумма кратная 3: " + mod_1 + " + " + mod_2 + " = " + (mod_1 + mod_2)); 
            }
            else 
            { 
                Console.WriteLine("Максимальная сумма кратная 3: " + mod_3_1 + " + " + mod_3_2 + " = " + (mod_3_1 + mod_3_2)); 
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

    }
}
