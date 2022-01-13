using System;

namespace HW_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VacationBuilder lowCostVacation = new LowCostVacation();

            lowCostVacation.CreateVacation();
            Vacation vacation = lowCostVacation.GetVacation();

            Console.WriteLine("Vacation is builded: \n" + vacation);

            VacationFluentBuilder vacationFluentBuilder = new VacationFluentBuilder();
            VacationFluent myVacation = vacationFluentBuilder.OtherFlight()
                                                             .PenthouseInHotel()
                                                             .BusinessFlight()
                                                             .GetRide()
                                                             .Build();


        }
    }
}
