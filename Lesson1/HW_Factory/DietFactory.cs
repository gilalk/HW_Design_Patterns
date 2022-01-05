using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Factory
{
    public static class DietFactory
    {
        public static IDietBase GetMyDiet(int age, double weight, double height)
        {
            double BMI = weight / Math.Pow(height, 2);
            if(age > 30 && BMI >= 25 && BMI < 30)
            {
                return new PaleoDiet();
            }
            else if(age > 40 && BMI >= 30 && BMI < 35)
            {
                return new AttkinsDiet();
            }
            else if(age > 50 && BMI >= 35)
            {
                return new VegetarianDiet();
            }
            return new NoNeedDiet();
        }
    }
}
