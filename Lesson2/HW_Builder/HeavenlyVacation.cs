using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Builder
{
    class HeavenlyVacation : VacationBuilder
    {
        public override void BuyFlightTicketBuilder()
        {
            Vacation.SetFlight("Do you want to get the massage couch?");
        }

        public override void GetRideBuilder()
        {
            Vacation.SetRide("Your limozine is outside..");
        }

        public override void GetRoomInHotelBuilder()
        {
            Vacation.SetRoomInHotel("You got the room with the seven servants and all-included");
        }
    }
}
