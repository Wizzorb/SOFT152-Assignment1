using System;
using System.Collections.Generic;
using System.Text;

namespace SOFTAssignment
{
    public class Property
    {
        private string propID;
        private string propName;
        private string hostID;
        private string hostName;
        private int hostPropNum;
        private string Lat;
        private string Long;
        private string roomType;
        private string Price;
        private int minNights;
        private int availableDays;
        public Property(string thePID, string thePName, string theHID, string theHName, int theHPNum, string theLat, string theLong, string theRoomType, string thePrice, int theMinNights, int theAvailDays)
        {
            propID = thePID;
            propName = thePName;
            hostID = theHID;
            hostName = theHName;
            setHPN(theHPNum);
            setLat(theLat);
            setLongi(theLong);
            roomType = theRoomType;
            Price = thePrice;
            setminN(theMinNights);
            setavailableD(theAvailDays);
        }

        //Get Methods
        public string getPID()
        {
            return propID;
        }
        public string getPName()
        {
            return propName;
        }
        public string getHID()
        {
            return hostID;
        }
        public string getHName()
        {
            return hostName;
        }
        public int getHPNum()
        {
            return hostPropNum;
        }
        public string getLat()
        {
            return Lat;
        }
        public string getLong()
        {
            return Lat;
        }
        public string getRType()
        {
            return roomType;
        }
        public string getPrice()
        {
            return Price;
        }
        public int getMinNights()
        {
            return minNights;
        }
        public int getAvailDays()
        {
            return availableDays;
        }

        //Set Methods
        public void setPID(string PID)
        {
            propID = PID;
        }
        public void setPN(string PN)
        {
            propName = PN;
        }
        public void setHID(string HID)
        {
            hostID = HID;
        }
        public void setHN(string HN)
        {
            hostName = HN;
        }
        public void setHPN(int HPN)
        {
            hostPropNum = Convert.ToInt32(HPN);
        }
        public void setLat(string L)
        {
            Lat = L;
        }
        public void setLongi(string Longi)
        {
            Long = Longi;
        }
        public void setRT(string RT)
        {
            roomType = RT;
        }
        public void setP(string P)
        {
            Price = P;
        }
        public void setminN(int minN)
        {
            minNights = Convert.ToInt32(minN);
        }
        public void setavailableD(int availableD)
        {
            availableDays = Convert.ToInt32(availableD);
        }
    }
}