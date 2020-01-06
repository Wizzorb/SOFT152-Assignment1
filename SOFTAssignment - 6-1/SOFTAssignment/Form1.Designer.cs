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
            this.lbxDiag = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tvPropertyList
            // 
            this.tvPropertyList.Location = new System.Drawing.Point(12, 12);
            this.tvPropertyList.Name = "tvPropertyList";
            this.tvPropertyList.Size = new System.Drawing.Size(417, 426);
            this.tvPropertyList.TabIndex = 0;
            this.tvPropertyList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lbxDiag
            // 
            this.lbxDiag.FormattingEnabled = true;
            this.lbxDiag.Location = new System.Drawing.Point(443, 330);
            this.lbxDiag.Name = "lbxDiag";
            this.lbxDiag.Size = new System.Drawing.Size(345, 108);
            this.lbxDiag.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxDiag);
            this.Controls.Add(this.tvPropertyList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TreeView tvPropertyList;
        private ListBox lbxDiag;
    }
}

