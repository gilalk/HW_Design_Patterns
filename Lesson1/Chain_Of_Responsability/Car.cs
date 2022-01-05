using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability
{
    public abstract class Car
    {
        protected Car next;
        public bool CarIsOK { get; set; }

        public void SetNext(Car next)
        {
            this.next = next;
        }

        public abstract void HandleRequest();
    }
}
