using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Factory
{
    class AttkinsDiet : IDietBase
    {
        public string Menu { get; set; } = "Don't eat just suffer";

        public string GetDiet()
        {
            return Menu;
        }
    }
}
