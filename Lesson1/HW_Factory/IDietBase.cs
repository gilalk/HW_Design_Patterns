using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Factory
{
    public interface IDietBase
    {
        public string Menu { get; set; }

        public string GetDiet();
    }
}
