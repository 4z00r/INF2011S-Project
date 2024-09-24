using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project.Business
{
    public class Period
    {

        private DateTime checkIn, checkOut;

        public enum Season
        {
            peakSeason,
            midSeason,
            offSeason
        }
        private Season season;

        public DateTime CheckIn {
            get { return checkIn; } set {  checkIn = value; }
        }

        public DateTime CheckOut {
            get { return checkOut; } set { checkOut = value; }
        }

        public Period(DateTime checkIn, DateTime checkOut)   
        {

            this.checkIn = checkIn;
            this.checkOut = checkOut;

            this.season
        }

        public bool Overlap(Period other)
        {

            if (DateTime.Compare(CheckOut, other.CheckIn) <= 0)
            {
                return false
            }
            if (DateTime.Compare(CheckIn, other.CheckOut) >= 0)
            {
                return false;
            }

            return true;

        }

        private Season DetermineSeason
        {
            // take preference of checkin Day
        }


        public static DateTime ToDateTime(int day, int month, int year)
        {
            return new DateTime(day, month, year);
        }

    }
}
