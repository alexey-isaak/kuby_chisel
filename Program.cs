using System;
 
namespace kuby_chisel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число N: ");
            int chisloN = int.Parse(Console.ReadLine());
            int i = 1;
            while ( i < chisloN )
            {
                double kub = Math.Pow(i, 3);
                Console.WriteLine("Число " + i + " куб числа " + i + "  " + kub);
                i = i + 1;
            }
        }
    }
}
