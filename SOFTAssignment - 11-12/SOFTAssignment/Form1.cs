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
            string PropInfo;

            Districts[] tempDistricts;
            Neighbourhood[] tempNeigh;
            Property[] tempProp;

            //Districts d = new Districts(gsdg, sdgds, sdgds);

            try
            {
                while (!SReader.EndOfStream)
                {
                    dName = SReader.ReadLine();
                    dNeighNum = Convert.ToInt32(SReader.ReadLine()); // Changing this number allows more data to be "read" and displayed in listBox1, beause the for loop is using this value to continue.

                    string lbItemText = dName + " (" + dNeighNum.ToString() + ")"; // Make the data more readable for the End User
                    listBox1.Items.Add(lbItemText);
                    // This is where you have the code that fills the tempDistrict array with districts
                    tempDistricts = new Districts[]
                    {
                        
                    };

                    for (int i = 0; dNeighNum > i; i++)
                    {
                        nName = SReader.ReadLine();
                        nPropertyNum = Convert.ToInt32(SReader.ReadLine());
                        listBox2.Items.Add(nName);
                        listBox2.Items.Add(nPropertyNum);
                        for (int q = 0; q < nPropertyNum; q++)
                        {
                            for (int w = 0; w < 11; w++)
                            {
                                PropInfo = SReader.ReadLine();
                                listBox3.Items.Add(PropInfo);
                            }
                        }
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}