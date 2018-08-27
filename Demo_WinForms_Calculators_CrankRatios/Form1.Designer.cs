using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo_WinForms_Calculators_CrankRatios
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
            this.tab_Setup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Chainring3 = new System.Windows.Forms.Label();
            this.cmbBox_Chainring3 = new System.Windows.Forms.ComboBox();
            this.lbl_Chainring2 = new System.Windows.Forms.Label();
            this.cmbBox_Chainring2 = new System.Windows.Forms.ComboBox();
            this.lbl_Chainring1 = new System.Windows.Forms.Label();
            this.cmbBox_Chainring1 = new System.Windows.Forms.ComboBox();
            this.grpBox_NumberOfChainrings = new System.Windows.Forms.GroupBox();
            this.radBtn_Chainring2 = new System.Windows.Forms.RadioButton();
            this.radBtn_Chainring3 = new System.Windows.Forms.RadioButton();
            this.radBtn_Chainring1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_Setup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBox_NumberOfChainrings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Setup
            // 
            this.tab_Setup.Controls.Add(this.tabPage1);
            this.tab_Setup.Controls.Add(this.tabPage2);
            this.tab_Setup.Location = new System.Drawing.Point(12, 3);
            this.tab_Setup.Name = "tab_Setup";
            this.tab_Setup.SelectedIndex = 0;
            this.tab_Setup.Size = new System.Drawing.Size(642, 449);
            this.tab_Setup.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_Chainring3);
            this.tabPage1.Controls.Add(this.cmbBox_Chainring3);
            this.tabPage1.Controls.Add(this.lbl_Chainring2);
            this.tabPage1.Controls.Add(this.cmbBox_Chainring2);
            this.tabPage1.Controls.Add(this.lbl_Chainring1);
            this.tabPage1.Controls.Add(this.cmbBox_Chainring1);
            this.tabPage1.Controls.Add(this.grpBox_NumberOfChainrings);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gearing Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_Chainring3
            // 
            this.lbl_Chainring3.AutoSize = true;
            this.lbl_Chainring3.Location = new System.Drawing.Point(214, 99);
            this.lbl_Chainring3.Name = "lbl_Chainring3";
            this.lbl_Chainring3.Size = new System.Drawing.Size(80, 17);
            this.lbl_Chainring3.TabIndex = 9;
            this.lbl_Chainring3.Text = "Chainring 3";
            // 
            // cmbBox_Chainring3
            // 
            this.cmbBox_Chainring3.DisplayMember = "Key";
            this.cmbBox_Chainring3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Chainring3.FormattingEnabled = true;
            this.cmbBox_Chainring3.Location = new System.Drawing.Point(307, 96);
            this.cmbBox_Chainring3.Name = "cmbBox_Chainring3";
            this.cmbBox_Chainring3.Size = new System.Drawing.Size(121, 24);
            this.cmbBox_Chainring3.TabIndex = 8;
            this.cmbBox_Chainring3.ValueMember = "Value";
            // 
            // lbl_Chainring2
            // 
            this.lbl_Chainring2.AutoSize = true;
            this.lbl_Chainring2.Location = new System.Drawing.Point(214, 69);
            this.lbl_Chainring2.Name = "lbl_Chainring2";
            this.lbl_Chainring2.Size = new System.Drawing.Size(80, 17);
            this.lbl_Chainring2.TabIndex = 7;
            this.lbl_Chainring2.Text = "Chainring 2";
            // 
            // cmbBox_Chainring2
            // 
            this.cmbBox_Chainring2.DisplayMember = "Key";
            this.cmbBox_Chainring2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Chainring2.FormattingEnabled = true;
            this.cmbBox_Chainring2.Location = new System.Drawing.Point(307, 66);
            this.cmbBox_Chainring2.Name = "cmbBox_Chainring2";
            this.cmbBox_Chainring2.Size = new System.Drawing.Size(121, 24);
            this.cmbBox_Chainring2.TabIndex = 6;
            // 
            // lbl_Chainring1
            // 
            this.lbl_Chainring1.AutoSize = true;
            this.lbl_Chainring1.Location = new System.Drawing.Point(214, 38);
            this.lbl_Chainring1.Name = "lbl_Chainring1";
            this.lbl_Chainring1.Size = new System.Drawing.Size(80, 17);
            this.lbl_Chainring1.TabIndex = 5;
            this.lbl_Chainring1.Text = "Chainring 1";
            // 
            // cmbBox_Chainring1
            // 
            this.cmbBox_Chainring1.DisplayMember = "Key";
            this.cmbBox_Chainring1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Chainring1.FormattingEnabled = true;
            this.cmbBox_Chainring1.Location = new System.Drawing.Point(307, 35);
            this.cmbBox_Chainring1.Name = "cmbBox_Chainring1";
            this.cmbBox_Chainring1.Size = new System.Drawing.Size(121, 24);
            this.cmbBox_Chainring1.TabIndex = 4;
            // 
            // grpBox_NumberOfChainrings
            // 
            this.grpBox_NumberOfChainrings.Controls.Add(this.radBtn_Chainring2);
            this.grpBox_NumberOfChainrings.Controls.Add(this.radBtn_Chainring3);
            this.grpBox_NumberOfChainrings.Controls.Add(this.radBtn_Chainring1);
            this.grpBox_NumberOfChainrings.Location = new System.Drawing.Point(6, 19);
            this.grpBox_NumberOfChainrings.Name = "grpBox_NumberOfChainrings";
            this.grpBox_NumberOfChainrings.Size = new System.Drawing.Size(167, 100);
            this.grpBox_NumberOfChainrings.TabIndex = 3;
            this.grpBox_NumberOfChainrings.TabStop = false;
            this.grpBox_NumberOfChainrings.Text = "Number of Chainrings";
            // 
            // radBtn_Chainring2
            // 
            this.radBtn_Chainring2.AutoSize = true;
            this.radBtn_Chainring2.Location = new System.Drawing.Point(15, 47);
            this.radBtn_Chainring2.Name = "radBtn_Chainring2";
            this.radBtn_Chainring2.Size = new System.Drawing.Size(37, 21);
            this.radBtn_Chainring2.TabIndex = 1;
            this.radBtn_Chainring2.TabStop = true;
            this.radBtn_Chainring2.Text = "2";
            this.radBtn_Chainring2.UseVisualStyleBackColor = true;
            this.radBtn_Chainring2.CheckedChanged += new System.EventHandler(this.radBtn_Chainring_CheckedChanged);
            // 
            // radBtn_Chainring3
            // 
            this.radBtn_Chainring3.AutoSize = true;
            this.radBtn_Chainring3.Location = new System.Drawing.Point(15, 75);
            this.radBtn_Chainring3.Name = "radBtn_Chainring3";
            this.radBtn_Chainring3.Size = new System.Drawing.Size(37, 21);
            this.radBtn_Chainring3.TabIndex = 2;
            this.radBtn_Chainring3.TabStop = true;
            this.radBtn_Chainring3.Text = "3";
            this.radBtn_Chainring3.UseVisualStyleBackColor = true;
            this.radBtn_Chainring3.CheckedChanged += new System.EventHandler(this.radBtn_Chainring_CheckedChanged);
            // 
            // radBtn_Chainring1
            // 
            this.radBtn_Chainring1.AutoSize = true;
            this.radBtn_Chainring1.Location = new System.Drawing.Point(15, 19);
            this.radBtn_Chainring1.Name = "radBtn_Chainring1";
            this.radBtn_Chainring1.Size = new System.Drawing.Size(37, 21);
            this.radBtn_Chainring1.TabIndex = 0;
            this.radBtn_Chainring1.TabStop = true;
            this.radBtn_Chainring1.Text = "1";
            this.radBtn_Chainring1.UseVisualStyleBackColor = true;
            this.radBtn_Chainring1.CheckedChanged += new System.EventHandler(this.radBtn_Chainring_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 464);
            this.Controls.Add(this.tab_Setup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_Setup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpBox_NumberOfChainrings.ResumeLayout(false);
            this.grpBox_NumberOfChainrings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Setup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpBox_NumberOfChainrings;
        private System.Windows.Forms.RadioButton radBtn_Chainring2;
        private System.Windows.Forms.RadioButton radBtn_Chainring3;
        private System.Windows.Forms.RadioButton radBtn_Chainring1;
        private System.Windows.Forms.ComboBox cmbBox_Chainring1;
        private System.Windows.Forms.Label lbl_Chainring1;
        private Label lbl_Chainring3;
        private ComboBox cmbBox_Chainring3;
        private Label lbl_Chainring2;
        private ComboBox cmbBox_Chainring2;
    }
}

