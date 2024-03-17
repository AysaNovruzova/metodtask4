using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod
{
    internal class Program
    {
        static void Main(string[] args)

        {
             string[] arr2 = { "5", "7", "9", "11" };

            string[] arr3 = { "Anar", "Eli", "Yusif", "Arif" };

            ElementA(arr3, 'A');

            string[] array1 = { "salam", "sa]ol", "he", "yox", "yaxsi" };
            string[] array2 = { "he", " sa]ol", "pis", };
            numbers(array1, array2);

            ProduckNumbers(arr2);
        }

        public static void numbers(string[] arr1, string[] arr2)
        {
            Console.WriteLine("ortaq elemenetler");
            for (int i = 0; i < arr1.Length; i++) 
            {
                for (int j = 0; j < arr2.Length; j++) 
                {
                    if (arr1[i] == arr2[j]) 
                    {
                        Console.WriteLine(" birinci elementi ekrana yaz");
                        break;
                    }

                }
            }

        }







     
    static void ProduckNumbers(string[] arr)
    {
        int produck = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            int num = int.Parse(arr[i]);
            produck *= num;
        }

        Console.WriteLine("siradaki elementlerin hasilini tap: " + produck);
    }











      


    public static void ElementA(string[] arr, char herf)
    {
        Console.WriteLine($"'{"A"}' herfi ilə başlayan elemeentler:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i][0] == herf || arr[i][0] == char.ToLower(herf))
                {
                Console.WriteLine(arr[i]);
            }
        }
    }




        void Main()
        {
            int n = 10; 
            List<int> fibonacciSeriyasi = FibonacciSeriyasi(n);

            Console.WriteLine($"{n} ədədə qədər Fibonacci seriyası:");
            foreach (int fib in fibonacciSeriyasi)
            {
                Console.Write($"{fib} ");
            }
        }

        List<int> FibonacciSeriyasi(int n)
        {
            List<int> fibonacci = new List<int>();

            int a = 0;
            int b = 1;
            fibonacci.Add(a);
            fibonacci.Add(b);

            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                fibonacci.Add(c);
                a = b;
                b = c;
            }

            return fibonacci;
        }















        static void Metod1 (string[] args)
    {
        int[] arr = { 5, 7, 9, 11, 13, 17, 23 };

        int max = Max(arr);

        Console.WriteLine($"Siradaki max numbers : {max}");
    }

    public static int Max(params int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }











    public static void Polindrom(int n)
    {
        int newN = n;
        int qaliq = 0;
        int m = 0;
        while (n > 0)
        {
            qaliq = n % 10;
            m = m * 10 + qaliq;
            n /= 10;
        }
        if (newN == m) ;
        {
            Console.WriteLine("polindromdur");
        }



    }




}
    }
