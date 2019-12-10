using System;
using System.Collections.Generic;
using System.Text;

namespace SOFTAssignment
{
    class Property
    {
        private string propID;
        private string propName;
        private string hostID;
        private string hostName;
        private int hostPropNum;
        private double Lat;
        private double Long;
        private string roomType;
        private double Price;
        private int minNights;
        private int availableDays;
        public Property(string thePID, string thePName, string theHID, string theHName, string theHPNum, double theLat, double theLong, string theRoomType, double thePrice, string theMinNights, string theAvailDays)
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
        public double getLat()
        {
            return Lat;
        }
        public double getLong()
        {
            return Lat;
        }
        public string getRType()
        {
            return roomType;
        }
        public double getPrice()
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
        public void setHPN(string HPN)
        {
            hostPropNum = Convert.ToInt32(HPN);
        }
        public void setLat(double L)
        {
            Lat = L;
        }
        public void setLongi(double Longi)
        {
            Long = Longi;
        }
        public void setRT(string RT)
        {
            roomType = RT;
        }
        public void setP(double P)
        {
            Price = P;
        }
        public void setminN(string minN)
        {
            minNights = Convert.ToInt32(minN);
        }
        public void setavailableD(string availableD)
        {
            availableDays = Convert.ToInt32(availableD);
        }
    }
}