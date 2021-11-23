using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppЗадача5._5
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите N ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[,] A = new int[n, n];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((i + j) % 2 == 0)
					{
						A[i, j] = 1;
					}
					else A[i, j] = 0;
				}
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(A[i, j]);
				}
				Console.WriteLine();

				
			}
			Console.ReadKey();

		}
        

    }
    
}


