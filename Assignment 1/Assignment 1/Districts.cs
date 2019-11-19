using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Districts
    {
        private string disName;
        private int disHoods;
        private string hoodNames;

        public Districts(string theName, string theHoods, string hoodName)
        {
            disName = theName;
            setHoodsNum(theHoods);
            hoodNames = hoodName;
        }


        //Get Methods
        public string getName()
        {
            return disName;
        }
        public int numHoods()
        {
            return disHoods;
        }
        public string GetHoods()
        {
            return hoodNames;
        }

        //Set Methods
        public void setName(string N)
        {
            disName = N;
        }
        public void setHoodsNum(string HN)
        {
            disHoods = Convert.ToInt32(HN);
        }
        public void setHoodsName(string H)
        {
            hoodNames = H;
        }
    }
}
