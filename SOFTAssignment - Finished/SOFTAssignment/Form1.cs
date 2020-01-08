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

        //Setting up the objects to be read into

        public Form1()
        {
            InitializeComponent();
            cboActionButtonSelector.Items.Add("Select an Action");
            cboActionButtonSelector.Items.Add("Update Property");
            cboActionButtonSelector.Items.Add("Add New Property");
            cboActionButtonSelector.Items.Add("Delete this Property");
            cboActionButtonSelector.SelectedIndex = 0;

            cboNeighActionButton.Items.Add("Edit Neighbourhood Name");
            cboNeighActionButton.Items.Add("Delete Neighbourhood");
            cboNeighActionButton.SelectedIndex = 0;

            cboDistrictActionButton.Items.Add("Edit District Name");
            cboDistrictActionButton.Items.Add("Delete District");
            cboDistrictActionButton.SelectedIndex = 0;
            LoadData("maxiAirBnB.txt");

            //Setting up the buttons and default data on the form

        }

        #region Populate Data

        Districts[] LoadData(string readerFile)
        {
            Districts[] readInDistrict = new Districts[0];
            StreamReader SReader = new StreamReader(readerFile);                    //This is setting up the data file to be read in and send to the objects

            string dName;
            int dNeighNum;
            string nName;
            int nPropertyNum;

            int count = 0;
            while (!SReader.EndOfStream)
            {
                //District data
                dName = SReader.ReadLine();
                cboPropertyDistrict.Items.Add(dName);
                cboDistricts.Items.Add(dName);

                dNeighNum = Convert.ToInt32(SReader.ReadLine());
                tempNeigh = new Neighbourhood[dNeighNum];

                for (int i = 0; i < dNeighNum; i++)
                {
                    //Neighbourhood data
                    nName = SReader.ReadLine();
                    cboPropertyNeighbourhood.Items.Add(nName);
                    cboNeighbourhoods.Items.Add(nName);
                    nPropertyNum = Convert.ToInt32(SReader.ReadLine());

                    tempProp = new Property[nPropertyNum];
                    for (int q = 0; q < nPropertyNum; q++)
                    {
                        //Property data
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

                Array.Resize(ref readInDistrict, readInDistrict.Length + 1);
                readInDistrict[count] = new Districts(dName, dNeighNum.ToString(), tempNeigh);
                tempDistricts = readInDistrict;
                count += 1;
                //Resizing and adding to the readInDistrict to keep track of how many Districts there are
            }

            populateDistrictNodes(tempDistricts); //This is for the method to populate the treeview nodes
            return tempDistricts;
        }

        private void populateDistrictNodes(Districts[] districtArray)
        {
            int i;
            tvPropertyList.Nodes.Clear();
            tvPropertyList.BeginUpdate(); // Prepare the TreeView for data entry

            for (i = 0; i < districtArray.Length; i++)
            {
                tvPropertyList.Nodes.Add(districtArray[i].getDisName(), districtArray[i].getDisName());
                tvPropertyList.Nodes[tvPropertyList.Nodes.Count - 1].Tag = districtArray[i]; // Fill districts into TreeView and set association for child nodes
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

                for (int ii = 0; ii < NumberOfProperties; ii++)
                {
                    parentNode.Nodes[i].Nodes.Add(districtArray.getNeighList()[i].getpropName()[ii].getPName().ToString());
                    parentNode.Nodes[i].Nodes[parentNode.Nodes[i].Nodes.Count - 1].Tag = districtArray.getNeighList()[i].getpropName()[ii];
                }

            }
        }

        /*
        public void displayDistrict(Districts selectedDistrict)
        {
            PNameBox.Text = selectedDistrict.getDisName().ToString();
        }

        public void displayNeighbourhood(Neighbourhood selectedNeighbourhood)
        {
            PNameBox.Text = selectedNeighbourhood.getneigName();
            cboPropertyDistrict.SelectedItem = tvPropertyList.SelectedNode.Parent.Parent.Text;
        }
        */

        public void displayProperty(Property selectedProperties)                                    //Display the property data
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

        public void displayNeigh(Neighbourhood selectedNeighbourhood)
        {

        }

        public void editProperty(Property selectedProperties)                                       //Edit the property data
        {
            selectedProperties.setPID(PIDBox.Text);
            selectedProperties.setPN(PNameBox.Text);
            selectedProperties.setHID(HIDBox.Text);
            selectedProperties.setHN(HNameBox.Text);
            selectedProperties.setHPN(Convert.ToInt32(HPNumberBox.Text));
            selectedProperties.setLat(LatBox.Text);
            selectedProperties.setLongi(LongBox.Text);
            selectedProperties.setRT(roomTypeBox.Text);
            selectedProperties.setP(priceBox.Text);
            selectedProperties.setminN(Convert.ToInt32(minNightsBox.Text));
            selectedProperties.setavailableD(Convert.ToInt32(availDaysBox.Text));
        }

        #endregion

        #region Form Interaction

        private void Form1_Load(object sender, EventArgs e)
        {
            // LoadData("maxiAirBnB.txt");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)      //This clears all the boxes so that they're empty if you click on a district from a property
        {
            PIDBox.Clear();
            PNameBox.Clear();
            HIDBox.Clear();
            HNameBox.Clear();
            HPNumberBox.Clear();
            LatBox.Clear();
            LongBox.Clear();
            roomTypeBox.Clear();
            priceBox.Clear();
            minNightsBox.Clear();
            availDaysBox.Clear();
            cboPropertyDistrict.SelectedIndex = -1;
            cboPropertyNeighbourhood.SelectedIndex = -1;

            if (tvPropertyList.SelectedNode.Level == 0)
            {
                //displayDistrict((Districts)tvPropertyList.SelectedNode.Tag);
            }
            else if (tvPropertyList.SelectedNode.Level == 1)
            {
                
            }
            else
            {
                displayProperty((Property)tvPropertyList.SelectedNode.Tag);         //Sends to the method for displaying property info
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)                    //Method for pressing the update button
        {
            string ActionToDo = cboActionButtonSelector.SelectedItem.ToString();

            if(tvPropertyList.SelectedNode is null && cboActionButtonSelector.SelectedItem.ToString() != "Add a Property")
            {
                MessageBox.Show("You need to select a Property to continue", "Missing Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tvPropertyList.SelectedNode.Level != 2)
                {
                    MessageBox.Show("You need to select a Property to continue", "Missing Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Created separate check for the correct node level of the TreeView for modularity
                }
                else
                {
                    Property tempProp = new Property();
                    tempProp = (Property)tvPropertyList.SelectedNode.Tag;

                    if (ActionToDo == "Select an Action")                           //Decided to make a combo box instead of multiple buttons for simplicity
                    {
                        MessageBox.Show("You need to select an Action to continue", "No Action Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboActionButtonSelector.SelectedIndex = 0;
                        cmdUpdate.Text = "";
                    }
                    if (ActionToDo == "Update Property")
                    {
                        editProperty((Property)tvPropertyList.SelectedNode.Tag);
                        cboActionButtonSelector.SelectedIndex = 0;
                        cmdUpdate.Text = "";
                    }
                    if (ActionToDo == "Add New Property")
                    {

                        string pID = PIDBox.Text;
                        string pName = PNameBox.Text;
                        string pHID = HIDBox.Text;
                        string pHName = HNameBox.Text;
                        int pHNum = int.Parse(HPNumberBox.Text);
                        string pLat = LatBox.Text;
                        string pLong = LongBox.Text;
                        string pRoomType = roomTypeBox.Text;
                        string pPrice = priceBox.Text;
                        int pMinNights = int.Parse(minNightsBox.Text);
                        int pAvailDays = int.Parse(availDaysBox.Text);
                        tempProp = new Property(pID, pName, pHID, pHName, pHNum, pLat, pLong, pRoomType, pPrice, pMinNights, pAvailDays);
                        //tvPropertyList.SelectedNode.Nodes.Add(tempProp);
                        //tvPropertyList.SelectedNode.Nodes.Add(pName);
                        //tvPropertyList.Nodes.Clear();
                        //populateDistrictNodes(tempDistricts);
                        cboActionButtonSelector.SelectedIndex = 0;
                        cmdUpdate.Text = "";
                    }
                    if (ActionToDo == "Delete this Property")
                    {
                        tvPropertyList.Nodes.Remove(tvPropertyList.SelectedNode);
                        cboActionButtonSelector.SelectedIndex = 0;
                        cmdUpdate.Text = "";
                    }
                }
            }
        }

        private void NeighBtn_Click(object sender, EventArgs e)                                 //Attempt at affecting the data, couldn't get it to delete or edit to the treeview as well
        {
            if (NeighBtn.Text == "DELETE")
            {
                
            }
            else
            {

            }
        }

        private void cboActionButtonSelector_SelectedIndexChanged(object sender, EventArgs e)   //Sends to the different combo box option method 
        {
            string ActionToDo = cboActionButtonSelector.SelectedItem.ToString();
            if (ActionToDo == "Select an Action")
            {
                // Do Nothing
            }
            else
            {
                cmdUpdate.Text = ActionToDo;
            }
        }

        private void cboNeighbourhoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXTNeighEdit.Text = cboNeighbourhoods.SelectedItem.ToString();
        }

        private void cboNeighActionButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNeighActionButton.SelectedItem.ToString() == "Delete Neighbourhood")
            {
                NeighBtn.Text = "DELETE";
            }
            else
            {
                NeighBtn.Text = "EDIT";
            }
        }

        private void cboDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXTDistrictEdit.Text = cboDistricts.SelectedItem.ToString();
        }

        private void cboDistrictActionButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrictActionButton.SelectedItem.ToString() == "Delete District")
            {
                DistrictBtn.Text = "DELETE";
            }
            else
            {
                DistrictBtn.Text = "EDIT";
            }
        }

        #endregion

        private void cmdLoadDataFile_Click(object sender, EventArgs e)
        {
            cboPropertyDistrict.Items.Clear();
            cboPropertyNeighbourhood.Items.Clear();
            cboDistricts.Items.Clear();
            cboNeighbourhoods.Items.Clear();
            OFDLoadDataFile.ShowDialog();
            tempDistricts = LoadData(OFDLoadDataFile.FileName);
            txtLoadDataFile.Text = OFDLoadDataFile.FileName.ToString(); // Load the data file
            Array.Clear(tempDistricts, 0, tempDistricts.Length); // Clear arrays for use again
        }
    }
}