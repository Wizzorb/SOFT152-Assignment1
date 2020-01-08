using System;
using System.Windows.Forms;

namespace SOFTAssignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvPropertyList = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLoadDataFile = new System.Windows.Forms.TextBox();
            this.cmdLoadDataFile = new System.Windows.Forms.Button();
            this.cboActionButtonSelector = new System.Windows.Forms.ComboBox();
            this.cboPropertyNeighbourhood = new System.Windows.Forms.ComboBox();
            this.cboPropertyDistrict = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minNightsBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HNameTxt = new System.Windows.Forms.Label();
            this.HIDTxt = new System.Windows.Forms.Label();
            this.PNameTxt = new System.Windows.Forms.Label();
            this.PIDtxt = new System.Windows.Forms.Label();
            this.availDaysBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.roomTypeBox = new System.Windows.Forms.TextBox();
            this.HNameBox = new System.Windows.Forms.TextBox();
            this.LatBox = new System.Windows.Forms.TextBox();
            this.LongBox = new System.Windows.Forms.TextBox();
            this.HPNumberBox = new System.Windows.Forms.TextBox();
            this.PIDBox = new System.Windows.Forms.TextBox();
            this.PNameBox = new System.Windows.Forms.TextBox();
            this.HIDBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboNeighActionButton = new System.Windows.Forms.ComboBox();
            this.NeighBtn = new System.Windows.Forms.Button();
            this.TXTNeighDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNeighEdit = new System.Windows.Forms.TextBox();
            this.cboNeighbourhoods = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DistrictBtn = new System.Windows.Forms.Button();
            this.TXTDistrictEdit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboDistrictActionButton = new System.Windows.Forms.ComboBox();
            this.cboDistricts = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OFDLoadDataFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPropertyList
            // 
            this.tvPropertyList.Location = new System.Drawing.Point(6, 33);
            this.tvPropertyList.Name = "tvPropertyList";
            this.tvPropertyList.Size = new System.Drawing.Size(355, 240);
            this.tvPropertyList.TabIndex = 0;
            this.tvPropertyList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 304);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLoadDataFile);
            this.tabPage1.Controls.Add(this.cmdLoadDataFile);
            this.tabPage1.Controls.Add(this.cboActionButtonSelector);
            this.tabPage1.Controls.Add(this.cboPropertyNeighbourhood);
            this.tabPage1.Controls.Add(this.cboPropertyDistrict);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmdUpdate);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.minNightsBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.HNameTxt);
            this.tabPage1.Controls.Add(this.HIDTxt);
            this.tabPage1.Controls.Add(this.PNameTxt);
            this.tabPage1.Controls.Add(this.PIDtxt);
            this.tabPage1.Controls.Add(this.availDaysBox);
            this.tabPage1.Controls.Add(this.priceBox);
            this.tabPage1.Controls.Add(this.roomTypeBox);
            this.tabPage1.Controls.Add(this.HNameBox);
            this.tabPage1.Controls.Add(this.LatBox);
            this.tabPage1.Controls.Add(this.LongBox);
            this.tabPage1.Controls.Add(this.HPNumberBox);
            this.tabPage1.Controls.Add(this.PIDBox);
            this.tabPage1.Controls.Add(this.PNameBox);
            this.tabPage1.Controls.Add(this.HIDBox);
            this.tabPage1.Controls.Add(this.tvPropertyList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLoadDataFile
            // 
            this.txtLoadDataFile.Location = new System.Drawing.Point(6, 7);
            this.txtLoadDataFile.Name = "txtLoadDataFile";
            this.txtLoadDataFile.Size = new System.Drawing.Size(210, 20);
            this.txtLoadDataFile.TabIndex = 34;
            // 
            // cmdLoadDataFile
            // 
            this.cmdLoadDataFile.Location = new System.Drawing.Point(222, 6);
            this.cmdLoadDataFile.Name = "cmdLoadDataFile";
            this.cmdLoadDataFile.Size = new System.Drawing.Size(139, 23);
            this.cmdLoadDataFile.TabIndex = 33;
            this.cmdLoadDataFile.Text = "Load Data File";
            this.cmdLoadDataFile.UseVisualStyleBackColor = true;
            this.cmdLoadDataFile.Click += new System.EventHandler(this.cmdLoadDataFile_Click);
            // 
            // cboActionButtonSelector
            // 
            this.cboActionButtonSelector.FormattingEnabled = true;
            this.cboActionButtonSelector.Location = new System.Drawing.Point(367, 234);
            this.cboActionButtonSelector.Name = "cboActionButtonSelector";
            this.cboActionButtonSelector.Size = new System.Drawing.Size(127, 21);
            this.cboActionButtonSelector.TabIndex = 32;
            this.cboActionButtonSelector.SelectedIndexChanged += new System.EventHandler(this.cboActionButtonSelector_SelectedIndexChanged);
            // 
            // cboPropertyNeighbourhood
            // 
            this.cboPropertyNeighbourhood.FormattingEnabled = true;
            this.cboPropertyNeighbourhood.Location = new System.Drawing.Point(644, 6);
            this.cboPropertyNeighbourhood.Name = "cboPropertyNeighbourhood";
            this.cboPropertyNeighbourhood.Size = new System.Drawing.Size(118, 21);
            this.cboPropertyNeighbourhood.TabIndex = 31;
            // 
            // cboPropertyDistrict
            // 
            this.cboPropertyDistrict.FormattingEnabled = true;
            this.cboPropertyDistrict.Location = new System.Drawing.Point(412, 6);
            this.cboPropertyDistrict.Name = "cboPropertyDistrict";
            this.cboPropertyDistrict.Size = new System.Drawing.Size(140, 21);
            this.cboPropertyDistrict.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Neighbourhood";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "District";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cmdUpdate.Location = new System.Drawing.Point(500, 234);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(262, 38);
            this.cmdUpdate.TabIndex = 23;
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Minimum Nights";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Available Days";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Price (Per Day)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Room Type";
            // 
            // minNightsBox
            // 
            this.minNightsBox.Location = new System.Drawing.Point(454, 186);
            this.minNightsBox.Name = "minNightsBox";
            this.minNightsBox.Size = new System.Drawing.Size(37, 20);
            this.minNightsBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Latitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Host Property Number";
            // 
            // HNameTxt
            // 
            this.HNameTxt.AutoSize = true;
            this.HNameTxt.Location = new System.Drawing.Point(384, 59);
            this.HNameTxt.Name = "HNameTxt";
            this.HNameTxt.Size = new System.Drawing.Size(60, 13);
            this.HNameTxt.TabIndex = 14;
            this.HNameTxt.Text = "Host Name";
            // 
            // HIDTxt
            // 
            this.HIDTxt.AutoSize = true;
            this.HIDTxt.Location = new System.Drawing.Point(570, 85);
            this.HIDTxt.Name = "HIDTxt";
            this.HIDTxt.Size = new System.Drawing.Size(43, 13);
            this.HIDTxt.TabIndex = 13;
            this.HIDTxt.Text = "Host ID";
            // 
            // PNameTxt
            // 
            this.PNameTxt.AutoSize = true;
            this.PNameTxt.Location = new System.Drawing.Point(367, 36);
            this.PNameTxt.Name = "PNameTxt";
            this.PNameTxt.Size = new System.Drawing.Size(77, 13);
            this.PNameTxt.TabIndex = 12;
            this.PNameTxt.Text = "Property Name";
            // 
            // PIDtxt
            // 
            this.PIDtxt.AutoSize = true;
            this.PIDtxt.Location = new System.Drawing.Point(367, 85);
            this.PIDtxt.Name = "PIDtxt";
            this.PIDtxt.Size = new System.Drawing.Size(60, 13);
            this.PIDtxt.TabIndex = 11;
            this.PIDtxt.Text = "Property ID";
            // 
            // availDaysBox
            // 
            this.availDaysBox.Location = new System.Drawing.Point(580, 186);
            this.availDaysBox.Name = "availDaysBox";
            this.availDaysBox.Size = new System.Drawing.Size(37, 20);
            this.availDaysBox.TabIndex = 10;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(707, 186);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(55, 20);
            this.priceBox.TabIndex = 9;
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.Location = new System.Drawing.Point(435, 160);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(327, 20);
            this.roomTypeBox.TabIndex = 8;
            // 
            // HNameBox
            // 
            this.HNameBox.Location = new System.Drawing.Point(450, 56);
            this.HNameBox.Name = "HNameBox";
            this.HNameBox.Size = new System.Drawing.Size(312, 20);
            this.HNameBox.TabIndex = 7;
            // 
            // LatBox
            // 
            this.LatBox.Location = new System.Drawing.Point(414, 134);
            this.LatBox.Name = "LatBox";
            this.LatBox.Size = new System.Drawing.Size(138, 20);
            this.LatBox.TabIndex = 6;
            // 
            // LongBox
            // 
            this.LongBox.Location = new System.Drawing.Point(618, 134);
            this.LongBox.Name = "LongBox";
            this.LongBox.Size = new System.Drawing.Size(144, 20);
            this.LongBox.TabIndex = 5;
            // 
            // HPNumberBox
            // 
            this.HPNumberBox.Location = new System.Drawing.Point(484, 108);
            this.HPNumberBox.Name = "HPNumberBox";
            this.HPNumberBox.Size = new System.Drawing.Size(278, 20);
            this.HPNumberBox.TabIndex = 4;
            // 
            // PIDBox
            // 
            this.PIDBox.Location = new System.Drawing.Point(433, 82);
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(131, 20);
            this.PIDBox.TabIndex = 3;
            // 
            // PNameBox
            // 
            this.PNameBox.Location = new System.Drawing.Point(450, 33);
            this.PNameBox.Name = "PNameBox";
            this.PNameBox.Size = new System.Drawing.Size(312, 20);
            this.PNameBox.TabIndex = 2;
            // 
            // HIDBox
            // 
            this.HIDBox.Location = new System.Drawing.Point(619, 82);
            this.HIDBox.Name = "HIDBox";
            this.HIDBox.Size = new System.Drawing.Size(143, 20);
            this.HIDBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboNeighActionButton);
            this.tabPage2.Controls.Add(this.NeighBtn);
            this.tabPage2.Controls.Add(this.TXTNeighDisplay);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TXTNeighEdit);
            this.tabPage2.Controls.Add(this.cboNeighbourhoods);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Neighbourhoods";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboNeighActionButton
            // 
            this.cboNeighActionButton.FormattingEnabled = true;
            this.cboNeighActionButton.Location = new System.Drawing.Point(6, 183);
            this.cboNeighActionButton.Name = "cboNeighActionButton";
            this.cboNeighActionButton.Size = new System.Drawing.Size(263, 21);
            this.cboNeighActionButton.TabIndex = 6;
            this.cboNeighActionButton.SelectedIndexChanged += new System.EventHandler(this.cboNeighActionButton_SelectedIndexChanged);
            // 
            // NeighBtn
            // 
            this.NeighBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeighBtn.Location = new System.Drawing.Point(3, 210);
            this.NeighBtn.Name = "NeighBtn";
            this.NeighBtn.Size = new System.Drawing.Size(266, 65);
            this.NeighBtn.TabIndex = 5;
            this.NeighBtn.Text = "EDIT";
            this.NeighBtn.UseVisualStyleBackColor = true;
            this.NeighBtn.Click += new System.EventHandler(this.NeighBtn_Click);
            // 
            // TXTNeighDisplay
            // 
            this.TXTNeighDisplay.Location = new System.Drawing.Point(275, 6);
            this.TXTNeighDisplay.Multiline = true;
            this.TXTNeighDisplay.Name = "TXTNeighDisplay";
            this.TXTNeighDisplay.Size = new System.Drawing.Size(487, 266);
            this.TXTNeighDisplay.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edit Neighbourhood Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Neighbourhood";
            // 
            // TXTNeighEdit
            // 
            this.TXTNeighEdit.Location = new System.Drawing.Point(9, 46);
            this.TXTNeighEdit.Name = "TXTNeighEdit";
            this.TXTNeighEdit.Size = new System.Drawing.Size(260, 20);
            this.TXTNeighEdit.TabIndex = 1;
            // 
            // cboNeighbourhoods
            // 
            this.cboNeighbourhoods.FormattingEnabled = true;
            this.cboNeighbourhoods.Location = new System.Drawing.Point(92, 6);
            this.cboNeighbourhoods.Name = "cboNeighbourhoods";
            this.cboNeighbourhoods.Size = new System.Drawing.Size(121, 21);
            this.cboNeighbourhoods.TabIndex = 0;
            this.cboNeighbourhoods.SelectedIndexChanged += new System.EventHandler(this.cboNeighbourhoods_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.DistrictBtn);
            this.tabPage3.Controls.Add(this.TXTDistrictEdit);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cboDistrictActionButton);
            this.tabPage3.Controls.Add(this.cboDistricts);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Districts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Edit District Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "District";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(490, 269);
            this.textBox2.TabIndex = 6;
            // 
            // DistrictBtn
            // 
            this.DistrictBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistrictBtn.Location = new System.Drawing.Point(3, 208);
            this.DistrictBtn.Name = "DistrictBtn";
            this.DistrictBtn.Size = new System.Drawing.Size(266, 67);
            this.DistrictBtn.TabIndex = 5;
            this.DistrictBtn.Text = "EDIT";
            this.DistrictBtn.UseVisualStyleBackColor = true;
            // 
            // TXTDistrictEdit
            // 
            this.TXTDistrictEdit.Location = new System.Drawing.Point(3, 46);
            this.TXTDistrictEdit.Name = "TXTDistrictEdit";
            this.TXTDistrictEdit.Size = new System.Drawing.Size(266, 20);
            this.TXTDistrictEdit.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 3;
            // 
            // cboDistrictActionButton
            // 
            this.cboDistrictActionButton.FormattingEnabled = true;
            this.cboDistrictActionButton.Location = new System.Drawing.Point(3, 181);
            this.cboDistrictActionButton.Name = "cboDistrictActionButton";
            this.cboDistrictActionButton.Size = new System.Drawing.Size(266, 21);
            this.cboDistrictActionButton.TabIndex = 2;
            this.cboDistrictActionButton.SelectedIndexChanged += new System.EventHandler(this.cboDistrictActionButton_SelectedIndexChanged);
            // 
            // cboDistricts
            // 
            this.cboDistricts.FormattingEnabled = true;
            this.cboDistricts.Location = new System.Drawing.Point(92, 6);
            this.cboDistricts.Name = "cboDistricts";
            this.cboDistricts.Size = new System.Drawing.Size(121, 21);
            this.cboDistricts.TabIndex = 1;
            this.cboDistricts.SelectedIndexChanged += new System.EventHandler(this.cboDistricts_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 324);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Airbnb Property Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TreeView tvPropertyList;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox HIDBox;
        private Label PIDtxt;
        private TextBox availDaysBox;
        private TextBox priceBox;
        private TextBox roomTypeBox;
        private TextBox HNameBox;
        private TextBox LatBox;
        private TextBox LongBox;
        private TextBox HPNumberBox;
        private TextBox PIDBox;
        private TextBox PNameBox;
        private Label PNameTxt;
        private Label HIDTxt;
        private Label HNameTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox minNightsBox;
        private Label label9;
        private Label label10;
        private Button cmdUpdate;
        private Label label11;
        private ComboBox cboActionButtonSelector;
        private ComboBox cboPropertyNeighbourhood;
        private ComboBox cboPropertyDistrict;
        private Label label2;
        private Label label1;
        private Button cmdLoadDataFile;
        private TextBox txtLoadDataFile;
        private OpenFileDialog OFDLoadDataFile;
        private Label label4;
        private Label label3;
        private TextBox TXTNeighEdit;
        private ComboBox cboNeighbourhoods;
        private Button NeighBtn;
        private TextBox TXTNeighDisplay;
        private ComboBox cboNeighActionButton;
        private TabPage tabPage3;
        private Label label15;
        private Label label14;
        private TextBox textBox2;
        private Button DistrictBtn;
        private TextBox TXTDistrictEdit;
        private Label label13;
        private ComboBox cboDistrictActionButton;
        private ComboBox cboDistricts;
        private Label label12;
    }
}

