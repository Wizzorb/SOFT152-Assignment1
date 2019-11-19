using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Neighbourhood
    {
        private string neighName;
        private int propNum;

        public Neighbourhood(string theName, string thePropNum)
        {
            neighName = theName;
            setPropNum(thePropNum);
        }

        //Get Methods
        public string getName()
        {
            return neighName;
        } public int getPropNum()
        {
            return propNum;
        }

        //Set Methods
        public void setNeighName(string NN)
        {
            neighName = NN;
        } public void setPropNum(string PN)
        {
            propNum = Convert.ToInt32(PN);
        }
    }
}
