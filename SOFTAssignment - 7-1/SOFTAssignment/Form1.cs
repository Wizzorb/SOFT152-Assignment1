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

        #region Populate Data

        public void LoadData(string readerFile)
        {
            StreamReader SReader = new StreamReader(readerFile);

            string dName;
            int dNeighNum;
            string nName;
            int nPropertyNum;

            int count = 0;
            while (!SReader.EndOfStream)
            {
                dName = SReader.ReadLine();
                cboPropertyDistrict.Items.Add(dName);
                dNeighNum = Convert.ToInt32(SReader.ReadLine());
                tempNeigh = new Neighbourhood[dNeighNum];

                for (int i = 0; i < dNeighNum; i++)
                {
                    nName = SReader.ReadLine();
                    cboPropertyNeighbourhood.Items.Add(nName);
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
                NumberOfProperties = districtArray.getNeighList()[i].getPropNum() - 1; // Get number of Properties for each neighbourhood

                parentNode.Nodes.Add(districtArray.getNeighList()[i].getneigName().ToString());
                parentNode.Nodes[parentNode.Nodes.Count - 1].Tag = districtArray.getNeighList()[i].getneigName(); // Fill Neighbourhoods into TreeView and set association for child nodes

                // lbxDiag.Items.Add("DIAG: Neighbourhood " + districtArray.getNeighList()[i].getneigName().ToString() + " has " + NumberOfProperties + " properties.");

                for (int ii = 0; ii < NumberOfProperties; ii++)
                {
                    /*lbxDiag.Items.Add("DIAG: Neighbourhood: " + districtArray.getNeighList()[i].getneigName().ToString() 
                        + " - " + districtArray.getNeighList()[i].getpropName()[ii].getPName().ToString());*/

                    parentNode.Nodes[i].Nodes.Add(districtArray.getNeighList()[i].getpropName()[ii].getPName().ToString());
                    parentNode.Nodes[i].Nodes[parentNode.Nodes[i].Nodes.Count - 1].Tag = districtArray.getNeighList()[i].getpropName()[ii];
                }

            }
        }

        public void displayDetails(Property selectedProperties)
        {
            PIDBox.Text = selectedProperties.getPID().ToString();
            PNameBox.Text = selectedProperties.getPName().ToString();
            HIDBox.Text = selectedProperties.getHID().ToString();
            HNameBox.Text = selectedProperties.getHName().ToString();
            HPNumberBox.Text = selectedProperties.getHPNum().ToString();
            LatBox.Text = selectedProperties.getLat().ToString();
            LongBox.Text = selectedProperties.getLong().ToString();
            roomTypeBox.Text = selectedProperties.getRType().ToString();
            priceBox.Text = selectedProperties.getPrice().ToString();
            minNightsBox.Text = selectedProperties.getMinNights().ToString();
            availDaysBox.Text = selectedProperties.getAvailDays().ToString();
            cboPropertyDistrict.SelectedItem = tvPropertyList.SelectedNode.Parent.Parent.Text;
            cboPropertyNeighbourhood.SelectedItem = tvPropertyList.SelectedNode.Parent.Text;
        }

        #endregion

        #region Form Interaction

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData("miniAirBnB.txt");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvPropertyList.SelectedNode.Level != 2)
            {
                // Do Nothing
            }
            else
            {

                lbxDiag.Items.Add(tvPropertyList.SelectedNode.Tag.ToString());
                displayDetails((Property)tvPropertyList.SelectedNode.Tag);
            }
            //MessageBox.Show(tvPropertyList.SelectedNode.Tag.ToString());
            //displayDetails(tvPropertyList.SelectedNode);
            /*This is where you need to get the selected item within the TreeView and then pass the selected property object to the displayDetails method
             * By doing this you pass the property object to the method that will populate the form fields with the property data.
             * Check the selectedItem or Itemvalue type methods of the TreeView box on your form, if you're unsure how to do this, check stackoverflow et al.
             * If you're not sure on the search results feel free to ask :) 
            */
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

    }
}