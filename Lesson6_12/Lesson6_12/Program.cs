﻿using System;

namespace Lesson6_12
{
    class Program
    {
        static double Rec(ref double[] array, int k)
        {
            if (k == 0)
                return array[0];
            if (k == 1)
                return array[1];
            if (k == 2)
                return array[2];
            if (array[k] != 0)
                return array[k];
            array[k] = Rec(ref array, k - 1) * 0.7 - Rec(ref array, k - 2) * 0.2 + Rec(ref array, k - 3) * k;
            return array[k];
        }

        static void Main(string[] args)
        {
            double[] nums = new double[3];
            nums[0] = int.Parse(Console.ReadLine());
            nums[1] = int.Parse(Console.ReadLine());
            nums[2] = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Array.Resize(ref nums, n * 2);

            Rec(ref nums, n * 2 - 2);

            bool isDown = true, isUp = true;

            for (int i = 0; i < n * 2 - 2; i += 2)
            {
                if (nums[i + 2] - nums[i] < 0)
                    isUp = false;
                if (nums[i + 2] - nums[i] > 0)
                    isDown = false;
            }

            Console.WriteLine((isDown || isUp) ? "Монотонно" : "Нет монотонности");
        }
    }
}
