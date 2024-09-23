using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project.Business
{
    public class Booking
    {
        private String bookingID;
        private Room room;
        private Date checkIn;
        private Date checkOut;
        private int lengthOfStay;
        private List<Date> dates; 


        public Booking(String id, Room r, Date checkIn, Date checkOut ) 
        {
            this.bookingID = id;
            this.room = r;  
            this.checkIn = checkIn; 
            this.checkOut = checkOut;   
        }
        
    }
}
