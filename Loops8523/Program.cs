using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops8523
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 20; i=i+2)
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i <= 30; i +=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 30; i >= 2 ; i -=2)
            {
                Console.WriteLine(i);
            }

            int j;
            for (j = 0;  j<= 5; j++)
            {

            }
            Console.WriteLine(j); // 6  
            Console.WriteLine();

            for (int i = 1; i <= 5; i ++)
            {
                for (int k = 1; k <=i ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 5; i >= 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int sayi = 1;
            while (sayi <=10)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            int number = 10; // imitial value
            do
            {
                Console.WriteLine(number);
                number--; // increment
            } while (number >=1); //condition

            string[] students = new string[3]
            {
                "Çağıl", "Leo" , "Angel"
            };
            foreach (string student in students)
            {
                // students = "Yağız";
                Console.WriteLine(student);
            }
            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                //students[i] = "Yağız";
                Console.WriteLine(students[i]);
            }
            Console.WriteLine();
            int sayi1 = 0;
            while (sayi1 <students.Length)
            {
                Console.WriteLine(students[sayi1]);
                sayi1++;
            }
            Console.WriteLine();
            int sayi2 = 0;
            do
            {
                Console.WriteLine(students[sayi2]);
                sayi2++;

            } while (sayi2 <students.Length);
            Console.ReadLine();
        }
    }
}
