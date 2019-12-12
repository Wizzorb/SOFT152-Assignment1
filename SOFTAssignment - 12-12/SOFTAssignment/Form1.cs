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
     
        }

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

            Districts[] tempDistricts = new Districts[0];
            Neighbourhood[] tempNeigh = new Neighbourhood[0];
            Property[] tempProp = new Property[0];

            //try
            //{
                int count = 0;
                while (!SReader.EndOfStream)
                {
                    dName = SReader.ReadLine();
                    dNeighNum = Convert.ToInt32(SReader.ReadLine()); // Changing this number allows more data to be "read" and displayed in listBox1, beause the for loop is using this value to continue.
                tempNeigh = new Neighbourhood[dNeighNum];
                //string lbItemText = dName + " (" + dNeighNum.ToString() + ")"; // Make the data more readable for the End User
                //listBox1.Items.Add(lbItemText);
                //// This is where you have the code that fills the tempDistrict array with districts
                ////tempDistricts = new Districts(dName, dNeighNum);

                for (int i = 0; i < dNeighNum; i++)
                    {
                        nName = SReader.ReadLine();
                        nPropertyNum = Convert.ToInt32(SReader.ReadLine());
                    //string lbItemText2 = nName + " (" + nPropertyNum.ToString() + ")";
                    //listBox2.Items.Add(lbItemText2);
                    tempProp = new Property[nPropertyNum];
                    for (int q = 0; q < nPropertyNum; q++)
                        {
                            
                            string pID = SReader.ReadLine();
                            string pName = SReader.ReadLine();
                            string pHID = SReader.ReadLine();
                            string pHName = SReader.ReadLine();
                            int pHNum = Convert.ToInt32(SReader.ReadLine());
                            string pLat = SReader.ReadLine();
                            string pLong = SReader.ReadLine();
                            string pRoomType = SReader.ReadLine();
                            string pPrice = SReader.ReadLine();
                            int pMinNights = Convert.ToInt32(SReader.ReadLine());
                            int pAvailDays = Convert.ToInt32(SReader.ReadLine());
                            //listBox3.Items.Add(pID);
                            //listBox3.Items.Add(pName);
                            //listBox3.Items.Add(pHID);
                            //listBox3.Items.Add(pHName);
                            //listBox3.Items.Add(pHNum);
                            //listBox3.Items.Add(pLat);
                            //listBox3.Items.Add(pLong);
                            //listBox3.Items.Add(pRoomType);
                            //listBox3.Items.Add(pPrice);
                            //listBox3.Items.Add(pMinNights);
                            //listBox3.Items.Add(pAvailDays);
                            tempProp[q] = new Property(pID, pName, pHID, pHName, pHNum, pLat, pLong, pRoomType, pPrice, pMinNights, pAvailDays);
                        }
                        tempNeigh[i] = new Neighbourhood(nName, nPropertyNum.ToString(), tempProp);
                    }

                //expand dist array called tempDistricts

                Array.Resize(ref tempDistricts, tempDistricts.Length + 1);
                tempDistricts[count] = new Districts(dName, dNeighNum.ToString(), tempNeigh);
                count += 1;
                }
            }
            //catch(FileNotFoundException notFound)
            //{
            //    MessageBox.Show("ERROR Opening file (when writing data out)" + "- File could not be found.\n" + notFound.Message);
            //    //return false;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("ERROR Opening File (when writing data out)" + "- Operation failed.\n" + e.Message);
            //    //return false;
            //}
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData("miniAirBnB.txt");
        }
    }
}