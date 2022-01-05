using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Factory
{
    class VegetarianDiet : IDietBase
    {
        public string Menu { get; set; } = "Die, just die..";

        public string GetDiet()
        {
            return Menu;
        }
    }
}
