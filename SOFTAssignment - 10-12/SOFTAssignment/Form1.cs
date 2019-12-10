using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData("miniAirBnB.txt");
        }

        //private WriteFile[] StArray;

        public void LoadData(string readerFile)
        {
            StreamReader SReader = new StreamReader(readerFile);

            int inputNum;
            int nextCharNum;
            char inputAsChar;
            string inputString;
            string dName;
            int dNeighNum;
            string nName;
            int nPropertyNum;

            Districts[] tempDistricts;
            Neighbourhood[] tempNeigh;
            Property[] tempProp;

            //Districts d = new Districts(gsdg, sdgds, sdgds);

            try
            {
                while (!SReader.EndOfStream)
                {
                    dName = SReader.ReadLine();
                    dNeighNum = Convert.ToInt32(SReader.ReadLine());
                    for (int i = 0; dNeighNum < i; i++)
                    {
                         
                    }
                }

            }
            catch(FileNotFoundException notFound)
            {
                MessageBox.Show("ERROR Opening file (when writing data out)" + "- File could not be found.\n" + notFound.Message);
                //return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR Opening File (when writing data out)" + "- Operation failed.\n" + e.Message);
                //return false;
            }

           /*while (!SReader.EndOfStream)
            {
                try
                {
                    // Data needs to be formatted and assigned to the correct array of classes (which contains the classes of District (2 lines), Neighbourhood (2 lines) and Property (11 lines))
                    // 
                    
                    
                    //inputString dataOut = new StreamWriter(StArray);
                    return true;
                }
            }*/
        }
    }
}