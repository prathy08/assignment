namespace _6UC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                const int IS_PART_TIME = 1;
                const int IS_FULL_TIME = 2;
                const int EMP_RATE_PER_HOUR = 20;
                const int NUM_WORKING_DAYS = 20;
                
                int emphrs = 0;
            int empwages = 0;
                int totalempwages = 0;
            for (int day = 0; day < NUM_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwages = emphrs * EMP_RATE_PER_HOUR;
                totalempwages += empwages;
                Console.WriteLine("Emp wage :" + empwages);
            }
            Console.WriteLine("Ttotal emp wage :" + totalempwages);
            


        }
    }


}