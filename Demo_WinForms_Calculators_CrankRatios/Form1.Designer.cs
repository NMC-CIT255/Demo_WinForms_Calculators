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
            this.grpBox_ChainringSet = new System.Windows.Forms.GroupBox();
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
            this.grpBox_Cassett = new System.Windows.Forms.GroupBox();
            this.cmbBox_Sprocket12 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket11 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket10 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket9 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket8 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket7 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket6 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket5 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket4 = new System.Windows.Forms.ComboBox();
            this.cmbBox_NumberOfSprockets = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket3 = new System.Windows.Forms.ComboBox();
            this.lbl_NumberOfSprockets = new System.Windows.Forms.Label();
            this.cmbBox_Sprocket2 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sprocket1 = new System.Windows.Forms.ComboBox();
            this.lbl_Sprocket12 = new System.Windows.Forms.Label();
            this.lbl_Sprocket11 = new System.Windows.Forms.Label();
            this.lbl_Sprocket10 = new System.Windows.Forms.Label();
            this.lbl_Sprocket9 = new System.Windows.Forms.Label();
            this.lbl_Sprocket8 = new System.Windows.Forms.Label();
            this.lbl_Sprocket7 = new System.Windows.Forms.Label();
            this.lbl_Sprocket6 = new System.Windows.Forms.Label();
            this.lbl_Sprocket5 = new System.Windows.Forms.Label();
            this.lbl_Sprocket4 = new System.Windows.Forms.Label();
            this.lbl_Sprocket3 = new System.Windows.Forms.Label();
            this.lbl_Sprocket2 = new System.Windows.Forms.Label();
            this.lbl_Sprocket1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpBox_Tires = new System.Windows.Forms.GroupBox();
            this.lbl_TireSize = new System.Windows.Forms.Label();
            this.tab_Setup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBox_ChainringSet.SuspendLayout();
            this.grpBox_NumberOfChainrings.SuspendLayout();
            this.grpBox_Cassett.SuspendLayout();
            this.grpBox_Tires.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.grpBox_Tires);
            this.tabPage1.Controls.Add(this.grpBox_ChainringSet);
            this.tabPage1.Controls.Add(this.grpBox_Cassett);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bike Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBox_ChainringSet
            // 
            this.grpBox_ChainringSet.Controls.Add(this.lbl_Chainring3);
            this.grpBox_ChainringSet.Controls.Add(this.cmbBox_Chainring3);
            this.grpBox_ChainringSet.Controls.Add(this.lbl_Chainring2);
            this.grpBox_ChainringSet.Controls.Add(this.cmbBox_Chainring2);
            this.grpBox_ChainringSet.Controls.Add(this.lbl_Chainring1);
            this.grpBox_ChainringSet.Controls.Add(this.cmbBox_Chainring1);
            this.grpBox_ChainringSet.Controls.Add(this.grpBox_NumberOfChainrings);
            this.grpBox_ChainringSet.Location = new System.Drawing.Point(11, 191);
            this.grpBox_ChainringSet.Name = "grpBox_ChainringSet";
            this.grpBox_ChainringSet.Size = new System.Drawing.Size(200, 212);
            this.grpBox_ChainringSet.TabIndex = 13;
            this.grpBox_ChainringSet.TabStop = false;
            this.grpBox_ChainringSet.Text = "Chainring Set";
            // 
            // lbl_Chainring3
            // 
            this.lbl_Chainring3.AutoSize = true;
            this.lbl_Chainring3.Location = new System.Drawing.Point(11, 166);
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
            this.cmbBox_Chainring3.Location = new System.Drawing.Point(104, 163);
            this.cmbBox_Chainring3.Name = "cmbBox_Chainring3";
            this.cmbBox_Chainring3.Size = new System.Drawing.Size(77, 24);
            this.cmbBox_Chainring3.TabIndex = 8;
            this.cmbBox_Chainring3.ValueMember = "Value";
            // 
            // lbl_Chainring2
            // 
            this.lbl_Chainring2.AutoSize = true;
            this.lbl_Chainring2.Location = new System.Drawing.Point(11, 136);
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
            this.cmbBox_Chainring2.Location = new System.Drawing.Point(104, 133);
            this.cmbBox_Chainring2.Name = "cmbBox_Chainring2";
            this.cmbBox_Chainring2.Size = new System.Drawing.Size(77, 24);
            this.cmbBox_Chainring2.TabIndex = 6;
            // 
            // lbl_Chainring1
            // 
            this.lbl_Chainring1.AutoSize = true;
            this.lbl_Chainring1.Location = new System.Drawing.Point(11, 105);
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
            this.cmbBox_Chainring1.Location = new System.Drawing.Point(104, 102);
            this.cmbBox_Chainring1.Name = "cmbBox_Chainring1";
            this.cmbBox_Chainring1.Size = new System.Drawing.Size(77, 24);
            this.cmbBox_Chainring1.TabIndex = 4;
            // 
            // grpBox_NumberOfChainrings
            // 
            this.grpBox_NumberOfChainrings.Controls.Add(this.radBtn_Chainring2);
            this.grpBox_NumberOfChainrings.Controls.Add(this.radBtn_Chainring3);
            this.grpBox_NumberOfChainrings.Controls.Add(this.radBtn_Chainring1);
            this.grpBox_NumberOfChainrings.Location = new System.Drawing.Point(14, 29);
            this.grpBox_NumberOfChainrings.Name = "grpBox_NumberOfChainrings";
            this.grpBox_NumberOfChainrings.Size = new System.Drawing.Size(167, 52);
            this.grpBox_NumberOfChainrings.TabIndex = 3;
            this.grpBox_NumberOfChainrings.TabStop = false;
            this.grpBox_NumberOfChainrings.Text = "Number of Chainrings";
            // 
            // radBtn_Chainring2
            // 
            this.radBtn_Chainring2.AutoSize = true;
            this.radBtn_Chainring2.Location = new System.Drawing.Point(62, 21);
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
            this.radBtn_Chainring3.Location = new System.Drawing.Point(111, 21);
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
            this.radBtn_Chainring1.Location = new System.Drawing.Point(15, 21);
            this.radBtn_Chainring1.Name = "radBtn_Chainring1";
            this.radBtn_Chainring1.Size = new System.Drawing.Size(37, 21);
            this.radBtn_Chainring1.TabIndex = 0;
            this.radBtn_Chainring1.TabStop = true;
            this.radBtn_Chainring1.Text = "1";
            this.radBtn_Chainring1.UseVisualStyleBackColor = true;
            this.radBtn_Chainring1.CheckedChanged += new System.EventHandler(this.radBtn_Chainring_CheckedChanged);
            // 
            // grpBox_Cassett
            // 
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket12);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket11);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket10);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket9);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket8);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket7);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket6);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket5);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket4);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_NumberOfSprockets);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket3);
            this.grpBox_Cassett.Controls.Add(this.lbl_NumberOfSprockets);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket2);
            this.grpBox_Cassett.Controls.Add(this.cmbBox_Sprocket1);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket12);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket11);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket10);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket9);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket8);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket7);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket6);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket5);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket4);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket3);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket2);
            this.grpBox_Cassett.Controls.Add(this.lbl_Sprocket1);
            this.grpBox_Cassett.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Cassett.Location = new System.Drawing.Point(378, 10);
            this.grpBox_Cassett.Name = "grpBox_Cassett";
            this.grpBox_Cassett.Size = new System.Drawing.Size(231, 397);
            this.grpBox_Cassett.TabIndex = 10;
            this.grpBox_Cassett.TabStop = false;
            this.grpBox_Cassett.Text = "Cassette";
            // 
            // cmbBox_Sprocket12
            // 
            this.cmbBox_Sprocket12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket12.FormattingEnabled = true;
            this.cmbBox_Sprocket12.Location = new System.Drawing.Point(131, 362);
            this.cmbBox_Sprocket12.Name = "cmbBox_Sprocket12";
            this.cmbBox_Sprocket12.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket12.TabIndex = 23;
            // 
            // cmbBox_Sprocket11
            // 
            this.cmbBox_Sprocket11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket11.FormattingEnabled = true;
            this.cmbBox_Sprocket11.Location = new System.Drawing.Point(131, 332);
            this.cmbBox_Sprocket11.Name = "cmbBox_Sprocket11";
            this.cmbBox_Sprocket11.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket11.TabIndex = 22;
            // 
            // cmbBox_Sprocket10
            // 
            this.cmbBox_Sprocket10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket10.FormattingEnabled = true;
            this.cmbBox_Sprocket10.Location = new System.Drawing.Point(131, 305);
            this.cmbBox_Sprocket10.Name = "cmbBox_Sprocket10";
            this.cmbBox_Sprocket10.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket10.TabIndex = 21;
            // 
            // cmbBox_Sprocket9
            // 
            this.cmbBox_Sprocket9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket9.FormattingEnabled = true;
            this.cmbBox_Sprocket9.Location = new System.Drawing.Point(131, 278);
            this.cmbBox_Sprocket9.Name = "cmbBox_Sprocket9";
            this.cmbBox_Sprocket9.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket9.TabIndex = 20;
            // 
            // cmbBox_Sprocket8
            // 
            this.cmbBox_Sprocket8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket8.FormattingEnabled = true;
            this.cmbBox_Sprocket8.Location = new System.Drawing.Point(131, 251);
            this.cmbBox_Sprocket8.Name = "cmbBox_Sprocket8";
            this.cmbBox_Sprocket8.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket8.TabIndex = 19;
            // 
            // cmbBox_Sprocket7
            // 
            this.cmbBox_Sprocket7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket7.FormattingEnabled = true;
            this.cmbBox_Sprocket7.Location = new System.Drawing.Point(131, 223);
            this.cmbBox_Sprocket7.Name = "cmbBox_Sprocket7";
            this.cmbBox_Sprocket7.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket7.TabIndex = 18;
            // 
            // cmbBox_Sprocket6
            // 
            this.cmbBox_Sprocket6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket6.FormattingEnabled = true;
            this.cmbBox_Sprocket6.Location = new System.Drawing.Point(131, 195);
            this.cmbBox_Sprocket6.Name = "cmbBox_Sprocket6";
            this.cmbBox_Sprocket6.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket6.TabIndex = 17;
            // 
            // cmbBox_Sprocket5
            // 
            this.cmbBox_Sprocket5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket5.FormattingEnabled = true;
            this.cmbBox_Sprocket5.Location = new System.Drawing.Point(131, 167);
            this.cmbBox_Sprocket5.Name = "cmbBox_Sprocket5";
            this.cmbBox_Sprocket5.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket5.TabIndex = 16;
            // 
            // cmbBox_Sprocket4
            // 
            this.cmbBox_Sprocket4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket4.FormattingEnabled = true;
            this.cmbBox_Sprocket4.Location = new System.Drawing.Point(131, 139);
            this.cmbBox_Sprocket4.Name = "cmbBox_Sprocket4";
            this.cmbBox_Sprocket4.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket4.TabIndex = 15;
            // 
            // cmbBox_NumberOfSprockets
            // 
            this.cmbBox_NumberOfSprockets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_NumberOfSprockets.FormattingEnabled = true;
            this.cmbBox_NumberOfSprockets.Location = new System.Drawing.Point(166, 18);
            this.cmbBox_NumberOfSprockets.Name = "cmbBox_NumberOfSprockets";
            this.cmbBox_NumberOfSprockets.Size = new System.Drawing.Size(57, 24);
            this.cmbBox_NumberOfSprockets.TabIndex = 12;
            this.cmbBox_NumberOfSprockets.SelectedIndexChanged += new System.EventHandler(this.cmbBox_NumberOfSprockets_SelectedIndexChanged);
            // 
            // cmbBox_Sprocket3
            // 
            this.cmbBox_Sprocket3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket3.FormattingEnabled = true;
            this.cmbBox_Sprocket3.Location = new System.Drawing.Point(131, 111);
            this.cmbBox_Sprocket3.Name = "cmbBox_Sprocket3";
            this.cmbBox_Sprocket3.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket3.TabIndex = 14;
            // 
            // lbl_NumberOfSprockets
            // 
            this.lbl_NumberOfSprockets.AutoSize = true;
            this.lbl_NumberOfSprockets.Location = new System.Drawing.Point(15, 18);
            this.lbl_NumberOfSprockets.Name = "lbl_NumberOfSprockets";
            this.lbl_NumberOfSprockets.Size = new System.Drawing.Size(144, 17);
            this.lbl_NumberOfSprockets.TabIndex = 11;
            this.lbl_NumberOfSprockets.Text = "Number Of Sprockets";
            // 
            // cmbBox_Sprocket2
            // 
            this.cmbBox_Sprocket2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket2.FormattingEnabled = true;
            this.cmbBox_Sprocket2.Location = new System.Drawing.Point(131, 83);
            this.cmbBox_Sprocket2.Name = "cmbBox_Sprocket2";
            this.cmbBox_Sprocket2.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket2.TabIndex = 13;
            // 
            // cmbBox_Sprocket1
            // 
            this.cmbBox_Sprocket1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sprocket1.FormattingEnabled = true;
            this.cmbBox_Sprocket1.Location = new System.Drawing.Point(131, 56);
            this.cmbBox_Sprocket1.Name = "cmbBox_Sprocket1";
            this.cmbBox_Sprocket1.Size = new System.Drawing.Size(89, 24);
            this.cmbBox_Sprocket1.TabIndex = 12;
            // 
            // lbl_Sprocket12
            // 
            this.lbl_Sprocket12.AutoSize = true;
            this.lbl_Sprocket12.Location = new System.Drawing.Point(32, 364);
            this.lbl_Sprocket12.Name = "lbl_Sprocket12";
            this.lbl_Sprocket12.Size = new System.Drawing.Size(84, 17);
            this.lbl_Sprocket12.TabIndex = 11;
            this.lbl_Sprocket12.Text = "Sprocket 12";
            // 
            // lbl_Sprocket11
            // 
            this.lbl_Sprocket11.AutoSize = true;
            this.lbl_Sprocket11.Location = new System.Drawing.Point(32, 336);
            this.lbl_Sprocket11.Name = "lbl_Sprocket11";
            this.lbl_Sprocket11.Size = new System.Drawing.Size(84, 17);
            this.lbl_Sprocket11.TabIndex = 10;
            this.lbl_Sprocket11.Text = "Sprocket 11";
            // 
            // lbl_Sprocket10
            // 
            this.lbl_Sprocket10.AutoSize = true;
            this.lbl_Sprocket10.Location = new System.Drawing.Point(32, 308);
            this.lbl_Sprocket10.Name = "lbl_Sprocket10";
            this.lbl_Sprocket10.Size = new System.Drawing.Size(84, 17);
            this.lbl_Sprocket10.TabIndex = 9;
            this.lbl_Sprocket10.Text = "Sprocket 10";
            // 
            // lbl_Sprocket9
            // 
            this.lbl_Sprocket9.AutoSize = true;
            this.lbl_Sprocket9.Location = new System.Drawing.Point(32, 280);
            this.lbl_Sprocket9.Name = "lbl_Sprocket9";
            this.lbl_Sprocket9.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket9.TabIndex = 8;
            this.lbl_Sprocket9.Text = "Sprocket 9";
            // 
            // lbl_Sprocket8
            // 
            this.lbl_Sprocket8.AutoSize = true;
            this.lbl_Sprocket8.Location = new System.Drawing.Point(32, 252);
            this.lbl_Sprocket8.Name = "lbl_Sprocket8";
            this.lbl_Sprocket8.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket8.TabIndex = 7;
            this.lbl_Sprocket8.Text = "Sprocket 8";
            // 
            // lbl_Sprocket7
            // 
            this.lbl_Sprocket7.AutoSize = true;
            this.lbl_Sprocket7.Location = new System.Drawing.Point(32, 224);
            this.lbl_Sprocket7.Name = "lbl_Sprocket7";
            this.lbl_Sprocket7.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket7.TabIndex = 6;
            this.lbl_Sprocket7.Text = "Sprocket 7";
            // 
            // lbl_Sprocket6
            // 
            this.lbl_Sprocket6.AutoSize = true;
            this.lbl_Sprocket6.Location = new System.Drawing.Point(32, 196);
            this.lbl_Sprocket6.Name = "lbl_Sprocket6";
            this.lbl_Sprocket6.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket6.TabIndex = 5;
            this.lbl_Sprocket6.Text = "Sprocket 6";
            // 
            // lbl_Sprocket5
            // 
            this.lbl_Sprocket5.AutoSize = true;
            this.lbl_Sprocket5.Location = new System.Drawing.Point(32, 168);
            this.lbl_Sprocket5.Name = "lbl_Sprocket5";
            this.lbl_Sprocket5.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket5.TabIndex = 4;
            this.lbl_Sprocket5.Text = "Sprocket 5";
            // 
            // lbl_Sprocket4
            // 
            this.lbl_Sprocket4.AutoSize = true;
            this.lbl_Sprocket4.Location = new System.Drawing.Point(32, 140);
            this.lbl_Sprocket4.Name = "lbl_Sprocket4";
            this.lbl_Sprocket4.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket4.TabIndex = 3;
            this.lbl_Sprocket4.Text = "Sprocket 4";
            // 
            // lbl_Sprocket3
            // 
            this.lbl_Sprocket3.AutoSize = true;
            this.lbl_Sprocket3.Location = new System.Drawing.Point(32, 112);
            this.lbl_Sprocket3.Name = "lbl_Sprocket3";
            this.lbl_Sprocket3.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket3.TabIndex = 2;
            this.lbl_Sprocket3.Text = "Sprocket 3";
            // 
            // lbl_Sprocket2
            // 
            this.lbl_Sprocket2.AutoSize = true;
            this.lbl_Sprocket2.Location = new System.Drawing.Point(32, 84);
            this.lbl_Sprocket2.Name = "lbl_Sprocket2";
            this.lbl_Sprocket2.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket2.TabIndex = 1;
            this.lbl_Sprocket2.Text = "Sprocket 2";
            // 
            // lbl_Sprocket1
            // 
            this.lbl_Sprocket1.AutoSize = true;
            this.lbl_Sprocket1.Location = new System.Drawing.Point(32, 56);
            this.lbl_Sprocket1.Name = "lbl_Sprocket1";
            this.lbl_Sprocket1.Size = new System.Drawing.Size(76, 17);
            this.lbl_Sprocket1.TabIndex = 0;
            this.lbl_Sprocket1.Text = "Sprocket 1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpBox_Tires
            // 
            this.grpBox_Tires.Controls.Add(this.lbl_TireSize);
            this.grpBox_Tires.Location = new System.Drawing.Point(11, 28);
            this.grpBox_Tires.Name = "grpBox_Tires";
            this.grpBox_Tires.Size = new System.Drawing.Size(200, 100);
            this.grpBox_Tires.TabIndex = 14;
            this.grpBox_Tires.TabStop = false;
            this.grpBox_Tires.Text = "Tires";
            // 
            // lbl_TireSize
            // 
            this.lbl_TireSize.AutoSize = true;
            this.lbl_TireSize.Location = new System.Drawing.Point(7, 22);
            this.lbl_TireSize.Name = "lbl_TireSize";
            this.lbl_TireSize.Size = new System.Drawing.Size(64, 17);
            this.lbl_TireSize.TabIndex = 0;
            this.lbl_TireSize.Text = "Tire Size";
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
            this.grpBox_ChainringSet.ResumeLayout(false);
            this.grpBox_ChainringSet.PerformLayout();
            this.grpBox_NumberOfChainrings.ResumeLayout(false);
            this.grpBox_NumberOfChainrings.PerformLayout();
            this.grpBox_Cassett.ResumeLayout(false);
            this.grpBox_Cassett.PerformLayout();
            this.grpBox_Tires.ResumeLayout(false);
            this.grpBox_Tires.PerformLayout();
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
        private GroupBox grpBox_Cassett;
        private ComboBox cmbBox_NumberOfSprockets;
        private Label lbl_NumberOfSprockets;
        private GroupBox grpBox_ChainringSet;
        private ComboBox cmbBox_Sprocket12;
        private ComboBox cmbBox_Sprocket11;
        private ComboBox cmbBox_Sprocket10;
        private ComboBox cmbBox_Sprocket9;
        private ComboBox cmbBox_Sprocket8;
        private ComboBox cmbBox_Sprocket7;
        private ComboBox cmbBox_Sprocket6;
        private ComboBox cmbBox_Sprocket5;
        private ComboBox cmbBox_Sprocket4;
        private ComboBox cmbBox_Sprocket3;
        private ComboBox cmbBox_Sprocket2;
        private ComboBox cmbBox_Sprocket1;
        private Label lbl_Sprocket12;
        private Label lbl_Sprocket11;
        private Label lbl_Sprocket10;
        private Label lbl_Sprocket9;
        private Label lbl_Sprocket8;
        private Label lbl_Sprocket7;
        private Label lbl_Sprocket6;
        private Label lbl_Sprocket5;
        private Label lbl_Sprocket4;
        private Label lbl_Sprocket3;
        private Label lbl_Sprocket2;
        private Label lbl_Sprocket1;
        private GroupBox grpBox_Tires;
        private Label lbl_TireSize;
    }
}

