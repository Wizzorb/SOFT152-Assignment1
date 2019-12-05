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

            Districts[] tempDistricts;
            Neighbourhood[] tempNeigh;
            Property[] tempProp;

            //Districts d = new Districts(gsdg, sdgds, sdgds);

            //while (!SReader.EndOfStream)
            //{
                //try
                //{
                //    inputString
                //    dataOut = new StreamWriter(StArray);
                //    return true;
                //}
                //catch(FileNotFoundException notFound)
                //{
                //    MessageBox.Show("ERROR Opening file (when writing data out)" + "- File could not be found.\n" + notFound.Message);
                //    return false;
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show("ERROR Opening File (when writing data out)" + "- Operation failed.\n" + e.Message);
                //    return false;
                //}
            }
        }
    }
}
