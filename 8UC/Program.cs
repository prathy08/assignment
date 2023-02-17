namespace _8UC
{
    internal class Program
    {

        public static int computeempwages(string company, int empRatePerHour,int numofworkingdays,int maxhourspermonth)
            {
                const int IS_PART_TIME = 1;
                const int IS_FULL_TIME = 2;
               
                int emphrs = 0;
                int totalemphrs = 0;
                int totalworkingdays = 0;
                while (totalemphrs <= maxhourspermonth && totalworkingdays < numofworkingdays)
                {
                    totalworkingdays++;
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
                    totalemphrs += emphrs;


                    Console.WriteLine("Days:" + totalworkingdays + "Emphrs:" + emphrs);

                }
                int totalempwages = totalemphrs * empRatePerHour;
                Console.WriteLine("Total Emp Wage for company :" + company +" is:"+totalempwages);
                return totalempwages;
            }
            static void Main(string[] args)
            {
                computeempwages("Dmart" ,20,2,10);
            computeempwages("Reliance", 10, 4, 20);
            }
        }
    }



    
