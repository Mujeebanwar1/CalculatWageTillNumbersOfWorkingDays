namespace CalculatWageTillNumbersOfWorkingDays
{
    class TillNumbersOfWorkingDays
    
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        static void Main(string[] args)
        {
            int empHur = 0, totalEmpHur = 0, totalWorkingDays = 0;


            while (totalEmpHur <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHur = 4;
                        break;
                    case IS_FULL_TIME:
                        empHur = 8;
                        break;

                }
                totalEmpHur += empHur;
                Console.WriteLine("Days :" + totalWorkingDays + "Emp Hur :" + empHur);

            }
            int totalEmpWage = totalEmpHur + EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            
        }

          

        

    }
}