using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Builder
{
    public class Vacation
    {
        private string flight;
        private string roomInHotel;
        private string ride;

        public void SetFlight(string flight)
        {
            this.flight = flight;
        }

        public void SetRoomInHotel(string roomInHotel)
        {
            this.roomInHotel = roomInHotel;
        }

        public void SetRide(string ride)
        {
            this.ride = ride;
        }

        public override string ToString()
        {
            return $"{flight}\n{roomInHotel}\n{ride}";
        }
    }

    public class VacationFluent
    {
        public bool BusinessFlight;
        public bool OtherClassFlight;
        public bool roomInHotel;
        public bool penthouseInHotel;
        public bool ride;
        public bool buss;
    }
}
