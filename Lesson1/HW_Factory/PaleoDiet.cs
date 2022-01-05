using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Factory
{
    class PaleoDiet : IDietBase
    {
        public string Menu { get; set; } = "Eat JUST Meat";

        public string GetDiet()
        {
            return Menu;
        }
    }
}
