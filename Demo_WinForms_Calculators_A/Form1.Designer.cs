namespace Demo_WinForms_Calculators
{
    partial class Frm_CalcA
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
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.lbl_NumberOfClownsPerCar = new System.Windows.Forms.Label();
            this.txtBox_ClownsPerCar = new System.Windows.Forms.TextBox();
            this.lbl_NumberOfCars = new System.Windows.Forms.Label();
            this.txtBox_Cars = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AppTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(678, 40);
            this.lbl_AppTitle.TabIndex = 0;
            this.lbl_AppTitle.Text = "Clown Calculator";
            this.lbl_AppTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_NumberOfClownsPerCar
            // 
            this.lbl_NumberOfClownsPerCar.AutoSize = true;
            this.lbl_NumberOfClownsPerCar.Location = new System.Drawing.Point(34, 92);
            this.lbl_NumberOfClownsPerCar.Name = "lbl_NumberOfClownsPerCar";
            this.lbl_NumberOfClownsPerCar.Size = new System.Drawing.Size(178, 17);
            this.lbl_NumberOfClownsPerCar.TabIndex = 1;
            this.lbl_NumberOfClownsPerCar.Text = "Number of Clowns Per Car:";
            // 
            // txtBox_ClownsPerCar
            // 
            this.txtBox_ClownsPerCar.Location = new System.Drawing.Point(237, 92);
            this.txtBox_ClownsPerCar.Name = "txtBox_ClownsPerCar";
            this.txtBox_ClownsPerCar.Size = new System.Drawing.Size(100, 22);
            this.txtBox_ClownsPerCar.TabIndex = 2;
            // 
            // lbl_NumberOfCars
            // 
            this.lbl_NumberOfCars.AutoSize = true;
            this.lbl_NumberOfCars.Location = new System.Drawing.Point(34, 127);
            this.lbl_NumberOfCars.Name = "lbl_NumberOfCars";
            this.lbl_NumberOfCars.Size = new System.Drawing.Size(111, 17);
            this.lbl_NumberOfCars.TabIndex = 3;
            this.lbl_NumberOfCars.Text = "Number of Cars:";
            // 
            // txtBox_Cars
            // 
            this.txtBox_Cars.Location = new System.Drawing.Point(237, 121);
            this.txtBox_Cars.Name = "txtBox_Cars";
            this.txtBox_Cars.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Cars.TabIndex = 4;
            // 
            // Frm_CalcA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(678, 411);
            this.Controls.Add(this.txtBox_Cars);
            this.Controls.Add(this.lbl_NumberOfCars);
            this.Controls.Add(this.txtBox_ClownsPerCar);
            this.Controls.Add(this.lbl_NumberOfClownsPerCar);
            this.Controls.Add(this.lbl_AppTitle);
            this.Name = "Frm_CalcA";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AppTitle;
        private System.Windows.Forms.Label lbl_NumberOfClownsPerCar;
        private System.Windows.Forms.TextBox txtBox_ClownsPerCar;
        private System.Windows.Forms.Label lbl_NumberOfCars;
        private System.Windows.Forms.TextBox txtBox_Cars;
    }
}

