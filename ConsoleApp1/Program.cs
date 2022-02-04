using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимальная сумма двух чисел кратная 3
            Random rand = new Random();
            int[] arr = new int[20];
            int mod_1 = 0;
            int mod_2 = 0;
            int mod_3_1 = 0;
            int mod_3_2 = 0;
            Console.WriteLine("---------------------------------------------------------------------");
            for (int i = 0;arr.Length>i;i++)
            {
                arr[i] = rand.Next(1,100);
                switch (arr[i] % 3)
                {
                    case 0:
                        Console.WriteLine(arr[i] + " - кратно 3");
                        if (mod_3_1 > mod_3_2)
                        {
                            if (arr[i] > mod_3_2){mod_3_2 = arr[i];}
                        }
                        else 
                        {
                            if (arr[i] > mod_3_1){mod_3_1 = arr[i];}
                        }
                        break;
                    case 1:
                        Console.WriteLine(arr[i] + " - остаток 1");
                        if (arr[i] > mod_1) { mod_1 = arr[i]; }
                        break;
                    case 2:
                        Console.WriteLine(arr[i] + " - остаток 2");
                        if (arr[i] > mod_2) { mod_2 = arr[i]; }
                        break;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Сумма кратная 3: " + mod_1 + " + " + mod_2 + " = " + (mod_1 + mod_2));
            Console.WriteLine("Сумма кратная 3: " + mod_3_1 + " + " + mod_3_2 + " = " + (mod_3_1 + mod_3_2));
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
