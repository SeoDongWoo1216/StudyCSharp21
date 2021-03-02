﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_02_02_CallbackTestApp
{
    delegate int Compare(int a, int b); // a, b 비교 대리자.
    class Program
    {
        // 오름차순 a가 b보다 크면 1리턴, 같으면 0리턴, a < b 이면 -1 리턴
        static int AscendCompare(int a, int b)
        {
            if(a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        // 내림차순 비교, a < b 이면 1리턴, 같으면 0, a > b이면 -1 리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;       // b와 a 순서 바꿀 것
            else if (a == b) return 0;
            else return -1;
        }

    static void BubbleSort(int[] DataSet, Compare comparer)
    {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - (i+1); j++)
                {
                    // 비교하여 값 위치 변경 Swap과 비슷
                    if(comparer(DataSet[j], DataSet[j+1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
    }

    static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };

            Console.WriteLine("Sorting....");
            BubbleSort(array, new Compare(AscendCompare));  // 오름차순 정렬
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}

