using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Builder
{
    class LowCostVacation : VacationBuilder
    {
        public override void BuyFlightTicketBuilder()
        {
            Vacation.SetFlight("Hope you will arrive to your target safe and sound!");
        }

        public override void GetRideBuilder()
        {
            Vacation.SetRide("You can start walking - this is low-cost man!");
        }

        public override void GetRoomInHotelBuilder()
        {
            Vacation.SetRoomInHotel("You can sleep by the mouse or near the cat");
        }
    }
}
