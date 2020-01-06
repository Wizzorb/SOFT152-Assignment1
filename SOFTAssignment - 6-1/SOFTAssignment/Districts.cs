using System;
using System.Collections.Generic;
using System.Text;

namespace SOFTAssignment
{
    class Districts
    {
        private string disName;
        private int disHoods;
        private Neighbourhood[] disNeighNames;

        public Districts(string theName, string theHoods, Neighbourhood[] theDisNeighNames)
        {
            disName = theName;
            setHoodsNum(theHoods);
            disNeighNames = theDisNeighNames;
        }

        public override string ToString()
        {
            return disName;
        }

        //Get Methods
        public string getDisName()
        {
            return disName;
        }
        public int numHoods()
        {
            return disHoods;
        }
        public Neighbourhood[] getNeighList()
        {
            return disNeighNames;
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
        public void setHoodsName(Neighbourhood[] NN)
        {
            disNeighNames = NN;
        }
    }
}
