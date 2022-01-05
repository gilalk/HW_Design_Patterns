using System;

namespace HW_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDietBase myDiet = DietFactory.GetMyDiet(34, 78, 1.67);
            Console.WriteLine(myDiet.GetDiet());

            IDietBase myDiet1 = DietFactory.GetMyDiet(42, 75, 1.7);
            Console.WriteLine(myDiet1.GetDiet());

            IDietBase myDiet2 = DietFactory.GetMyDiet(54, 67, 1.46);
            Console.WriteLine(myDiet2.GetDiet());

            IDietBase myDiet3 = DietFactory.GetMyDiet(20, 67, 1.46);
            Console.WriteLine(myDiet3.GetDiet());

            IDietBase myDiet4 = DietFactory.GetMyDiet(32, 95, 1.54);
            Console.WriteLine(myDiet4.GetDiet());

        }
    }
}
