using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project.Business
{
    public class Booking
    {
        private int bookingID;
        private Room room;
        private Period checkIn;
        private Period checkOut;

        public Booking(String id, Room r, Period checkIn, Period checkOut ) 
        {
            this.bookingID = id;
            this.room = r;  
            this.checkIn = checkIn; 
            this.checkOut = checkOut;   
        
            //System.DateTime.Compare()
        }

        
    }
}
