using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
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
        public Property (string thePID, string thePName, string theHID, string theHName, string theHPNum, string theLat, string theLong, string theRoomType, string thePrice, string theMinNights, string theAvailDays)
        {
            propID = thePID;
            propName = thePName;
            hostID = theHID;
            hostName = theHName;
            hostPropNum = theHPNum;
            Lat = theLat;
            Long = theLong;
            roomType = theRoomType;
            Price = thePrice;
            minNights = theMinNights;
            availableDays = theAvailDays;
        }

        //Get Methods
        public string getPID()
        {
            return propID;
        } public string getPName()
        {
            return propName;
        } public string getHID()
        {
            return hostID;
        } public string getHName()
        {
            return hostName;
        } public int getHPNum()
        {
            return hostPropNum;
        } public double getLat()
        {
            return Lat;
        } public double getLong()
        {
            return Lat;
        } public string getRType()
        {
            return roomType;
        } public double getPrice()
        {
            return Price;
        } public int getMinNights()
        {
            return minNights;
        } public int getAvailDays()
        {
            return availableDays;
        }

        //Set Methods
        public void setPID(string PID)
        {
            propID = PID;
        }
    }
}
