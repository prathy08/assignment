﻿namespace _4UC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;
            int empwages = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                emphrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwages = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage :" + empwages);
        }
    

}
    }
