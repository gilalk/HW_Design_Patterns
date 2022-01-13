using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Builder
{
    public abstract class VacationBuilder
    {
        protected Vacation Vacation;
        public VacationBuilder()
        {
            Vacation = new Vacation();
        }

        public abstract void BuyFlightTicketBuilder();
        public abstract void GetRoomInHotelBuilder();
        public abstract void GetRideBuilder();

        public void CreateVacation()
        {
            BuyFlightTicketBuilder();
            GetRoomInHotelBuilder();
            GetRideBuilder();
        }

        public Vacation GetVacation()
        {
            return Vacation;
        }
    }

    public class VacationFluentBuilder
    {
        public VacationFluent vacationFluent = new VacationFluent();
        public VacationFluent Build() => vacationFluent;

        public VacationFluentBuilder BusinessFlight()
        {
            if (vacationFluent.OtherClassFlight)
            {
                vacationFluent.OtherClassFlight = false;
            }
            vacationFluent.BusinessFlight = true;
            return this;
        }

        public VacationFluentBuilder OtherFlight()
        {
            if (vacationFluent.BusinessFlight)
            {
                vacationFluent.BusinessFlight = false;
            }
            vacationFluent.OtherClassFlight = true;
            return this;
        }

        public VacationFluentBuilder PenthouseInHotel()
        {
            if (vacationFluent.roomInHotel)
            {
                vacationFluent.roomInHotel = false;
            }
            vacationFluent.penthouseInHotel = true;
            return this;
        }

        public VacationFluentBuilder RoomInHotel()
        {
            if (vacationFluent.penthouseInHotel)
            {
                vacationFluent.penthouseInHotel = false;
            }
            vacationFluent.roomInHotel = true;
            return this;
        }

        public VacationFluentBuilder GetRide()
        {
            if (vacationFluent.buss)
            {
                vacationFluent.buss = false;
            }
            vacationFluent.ride = true;
            return this;
        }

        public VacationFluentBuilder TakeBuss()
        {
            if (vacationFluent.ride)
            {
                vacationFluent.ride = false;
            }
            vacationFluent.buss = true;
            return this;
        }
    }
}
