using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Factory
{
    class NoNeedDiet : IDietBase
    {
        public string Menu { get; set; } = "Eat whatever you wanna eat!";

        public string GetDiet()
        {
            return Menu;
        }
    }
}
