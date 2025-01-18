using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
        {
            static void Main(string[] args)
            {
                int[] numbers = { 1, 2, 4, 5, 6 };
                int n = 6;

                int missingNumber = FindMissingNumber(numbers, n);
                Console.WriteLine($"عدد گمشده: {missingNumber}");
            }

            static int FindMissingNumber(int[] arr, int n)
            {
                int totalSum = (n * (n + 1)) / 2;
                int arraySum = 0;

                foreach (int num in arr)
                {
                    arraySum += num;
                }

                return totalSum - arraySum;
            }
        }
    }
