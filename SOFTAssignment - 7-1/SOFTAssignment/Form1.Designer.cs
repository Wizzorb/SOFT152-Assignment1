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
            this.tvPropertyList = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboPropertyNeighbourhood = new System.Windows.Forms.ComboBox();
            this.cboPropertyDistrict = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbxDiag = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPropertyList
            // 
            this.tvPropertyList.Location = new System.Drawing.Point(6, 6);
            this.tvPropertyList.Name = "tvPropertyList";
            this.tvPropertyList.Size = new System.Drawing.Size(355, 267);
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
            this.tabPage1.Controls.Add(this.cboPropertyNeighbourhood);
            this.tabPage1.Controls.Add(this.cboPropertyDistrict);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.updateBtn);
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
            // cboPropertyNeighbourhood
            // 
            this.cboPropertyNeighbourhood.FormattingEnabled = true;
            this.cboPropertyNeighbourhood.Location = new System.Drawing.Point(644, 185);
            this.cboPropertyNeighbourhood.Name = "cboPropertyNeighbourhood";
            this.cboPropertyNeighbourhood.Size = new System.Drawing.Size(118, 21);
            this.cboPropertyNeighbourhood.TabIndex = 27;
            // 
            // cboPropertyDistrict
            // 
            this.cboPropertyDistrict.FormattingEnabled = true;
            this.cboPropertyDistrict.Location = new System.Drawing.Point(412, 185);
            this.cboPropertyDistrict.Name = "cboPropertyDistrict";
            this.cboPropertyDistrict.Size = new System.Drawing.Size(140, 21);
            this.cboPropertyDistrict.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Neighbourhood";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "District";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.updateBtn.Location = new System.Drawing.Point(370, 212);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(392, 60);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Minimum Nights";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Available Days";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Price (Per Day)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Room Type";
            // 
            // minNightsBox
            // 
            this.minNightsBox.Location = new System.Drawing.Point(454, 159);
            this.minNightsBox.Name = "minNightsBox";
            this.minNightsBox.Size = new System.Drawing.Size(37, 20);
            this.minNightsBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Latitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Host Property Number";
            // 
            // HNameTxt
            // 
            this.HNameTxt.AutoSize = true;
            this.HNameTxt.Location = new System.Drawing.Point(384, 32);
            this.HNameTxt.Name = "HNameTxt";
            this.HNameTxt.Size = new System.Drawing.Size(60, 13);
            this.HNameTxt.TabIndex = 14;
            this.HNameTxt.Text = "Host Name";
            // 
            // HIDTxt
            // 
            this.HIDTxt.AutoSize = true;
            this.HIDTxt.Location = new System.Drawing.Point(570, 58);
            this.HIDTxt.Name = "HIDTxt";
            this.HIDTxt.Size = new System.Drawing.Size(43, 13);
            this.HIDTxt.TabIndex = 13;
            this.HIDTxt.Text = "Host ID";
            // 
            // PNameTxt
            // 
            this.PNameTxt.AutoSize = true;
            this.PNameTxt.Location = new System.Drawing.Point(367, 9);
            this.PNameTxt.Name = "PNameTxt";
            this.PNameTxt.Size = new System.Drawing.Size(77, 13);
            this.PNameTxt.TabIndex = 12;
            this.PNameTxt.Text = "Property Name";
            // 
            // PIDtxt
            // 
            this.PIDtxt.AutoSize = true;
            this.PIDtxt.Location = new System.Drawing.Point(367, 58);
            this.PIDtxt.Name = "PIDtxt";
            this.PIDtxt.Size = new System.Drawing.Size(60, 13);
            this.PIDtxt.TabIndex = 11;
            this.PIDtxt.Text = "Property ID";
            // 
            // availDaysBox
            // 
            this.availDaysBox.Location = new System.Drawing.Point(580, 159);
            this.availDaysBox.Name = "availDaysBox";
            this.availDaysBox.Size = new System.Drawing.Size(37, 20);
            this.availDaysBox.TabIndex = 10;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(707, 159);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(55, 20);
            this.priceBox.TabIndex = 9;
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.Location = new System.Drawing.Point(435, 133);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(327, 20);
            this.roomTypeBox.TabIndex = 8;
            // 
            // HNameBox
            // 
            this.HNameBox.Location = new System.Drawing.Point(450, 29);
            this.HNameBox.Name = "HNameBox";
            this.HNameBox.Size = new System.Drawing.Size(312, 20);
            this.HNameBox.TabIndex = 7;
            // 
            // LatBox
            // 
            this.LatBox.Location = new System.Drawing.Point(414, 107);
            this.LatBox.Name = "LatBox";
            this.LatBox.Size = new System.Drawing.Size(138, 20);
            this.LatBox.TabIndex = 6;
            // 
            // LongBox
            // 
            this.LongBox.Location = new System.Drawing.Point(618, 107);
            this.LongBox.Name = "LongBox";
            this.LongBox.Size = new System.Drawing.Size(144, 20);
            this.LongBox.TabIndex = 5;
            // 
            // HPNumberBox
            // 
            this.HPNumberBox.Location = new System.Drawing.Point(484, 81);
            this.HPNumberBox.Name = "HPNumberBox";
            this.HPNumberBox.Size = new System.Drawing.Size(278, 20);
            this.HPNumberBox.TabIndex = 4;
            // 
            // PIDBox
            // 
            this.PIDBox.Location = new System.Drawing.Point(433, 55);
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(131, 20);
            this.PIDBox.TabIndex = 3;
            // 
            // PNameBox
            // 
            this.PNameBox.Location = new System.Drawing.Point(450, 6);
            this.PNameBox.Name = "PNameBox";
            this.PNameBox.Size = new System.Drawing.Size(312, 20);
            this.PNameBox.TabIndex = 2;
            // 
            // HIDBox
            // 
            this.HIDBox.Location = new System.Drawing.Point(619, 55);
            this.HIDBox.Name = "HIDBox";
            this.HIDBox.Size = new System.Drawing.Size(143, 20);
            this.HIDBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Diagnostics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbxDiag
            // 
            this.lbxDiag.FormattingEnabled = true;
            this.lbxDiag.Location = new System.Drawing.Point(794, 12);
            this.lbxDiag.Name = "lbxDiag";
            this.lbxDiag.Size = new System.Drawing.Size(275, 303);
            this.lbxDiag.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 324);
            this.Controls.Add(this.lbxDiag);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private Button updateBtn;
        private Label label11;
        private TabPage tabPage3;
        private ListBox lbxDiag;
        private ComboBox cboPropertyNeighbourhood;
        private ComboBox cboPropertyDistrict;
        private Label label2;
        private Label label1;
    }
}

