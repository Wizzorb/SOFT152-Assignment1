using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Neighbourhood
    {
        private string neighName;
        private int propNum;
        private Property[] propName;

        public Neighbourhood(string theName, string thePropNum, Property[] thePropName)
        {
            neighName = theName;
            setPropNum(thePropNum);
            propName = thePropName;
        }

        //Get Methods
        public string getName()
        {
            return neighName;
        }

        public int getPropNum()
        {
            return propNum;
        }

        public Property[] getpropName()
        {
            return propName;
        }

        //Set Methods
        public void setNeighName(string NN)
        {
            neighName = NN;
        }

        public void setPropNum(string PN)
        {
            propNum = Convert.ToInt32(PN);
        }

        public void setPropName(Property[] PName)
        {
            propName = PName;
        }
    }
}
