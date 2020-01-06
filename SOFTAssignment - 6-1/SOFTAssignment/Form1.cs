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
        Districts[] tempDistricts = new Districts[0];
        Neighbourhood[] tempNeigh = new Neighbourhood[0];
        Property[] tempProp = new Property[0];

        public Form1()
        {
            InitializeComponent();
     
        }

        public void LoadData(string readerFile)
        {
            StreamReader SReader = new StreamReader(readerFile);

            string dName;
            int dNeighNum;
            string nName;
            int nPropertyNum;

            //try
            //{
                int count = 0;
                while (!SReader.EndOfStream)
                {
                    dName = SReader.ReadLine();
                    dNeighNum = Convert.ToInt32(SReader.ReadLine());
                    tempNeigh = new Neighbourhood[dNeighNum];

                for (int i = 0; i < dNeighNum; i++)
                    {
                        nName = SReader.ReadLine();
                        nPropertyNum = Convert.ToInt32(SReader.ReadLine());

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
                            tempProp[q] = new Property(pID, pName, pHID, pHName, pHNum, pLat, pLong, pRoomType, pPrice, pMinNights, pAvailDays);
                        }
                        tempNeigh[i] = new Neighbourhood(nName, nPropertyNum.ToString(), tempProp);
                    }
                
                Array.Resize(ref tempDistricts, tempDistricts.Length + 1);
                tempDistricts[count] = new Districts(dName, dNeighNum.ToString(), tempNeigh);
                count += 1;
                }

            populateDistrictNodes();

            }

        private void populateDistrictNodes()
        {
            int i;
            tvPropertyList.Nodes.Clear();
            tvPropertyList.BeginUpdate(); // Prepare the TreeView for data entry

            for (i = 0; i < tempDistricts.Count(); i++)
            {
                tvPropertyList.Nodes.Add(tempDistricts[i].getDisName(), tempDistricts[i].getDisName()); 
                tvPropertyList.Nodes[tvPropertyList.Nodes.Count - 1].Tag = tempDistricts[i]; // Fill districts into TreeView and set association for child nodes
            }
            for (i = 0; i < tvPropertyList.Nodes.Count; i++)
            {
                populateChildNodes(tvPropertyList.Nodes[i]); // Fill child nodes
            }

            tvPropertyList.EndUpdate();
            tvPropertyList.Refresh(); // Let the TreeView know data entry has been completed
        }

        private void populateChildNodes(TreeNode parentNode)
        {
            Districts districtArray = (Districts)parentNode.Tag;

            int i; int NumberOfProperties = 0;
            for (i = 0; i < districtArray.numHoods(); i++)
            {
                NumberOfProperties = districtArray.getNeighList()[i].getPropNum(); // Get number of Properties for each neighbourhood

                parentNode.Nodes.Add(districtArray.getNeighList()[i].getneigName().ToString());
                parentNode.Nodes[parentNode.Nodes.Count - 1].Tag = districtArray;// Fill Neighbourhoods into TreeView and set association for child nodes
                lbxDiag.Items.Add("DIAG: Neighbourhood " + districtArray.getNeighList()[i].getneigName().ToString() + " has " + NumberOfProperties + " properties.");
                populateProperties(tvPropertyList.Nodes[i], NumberOfProperties);
            }

            for (i = 0; i < tvPropertyList.Nodes.Count; i++)
            {
                // populateProperties(tvPropertyList.Nodes[i]);
            }
        }

        private void populateProperties(TreeNode parentNode, int NumberOfProperties)
        {
            Districts neighArray = (Districts)parentNode.Tag;

            for (int i = 0; i < NumberOfProperties; i++)
            {

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
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData("miniAirBnB.txt");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}