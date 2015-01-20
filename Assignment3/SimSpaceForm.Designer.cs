namespace Assignment3
{
    partial class SimSpaceForm
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
            this.components = new System.ComponentModel.Container();
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFacilityBarTitle = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblPollution = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Enabled = true;
            this.tmrGameTime.Interval = 1000;
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(926, 119);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 17);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month: ";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(926, 150);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(58, 17);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Money: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(923, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "MY SIM SPACE";
            // 
            // lblFacilityBarTitle
            // 
            this.lblFacilityBarTitle.AutoSize = true;
            this.lblFacilityBarTitle.Location = new System.Drawing.Point(8, 814);
            this.lblFacilityBarTitle.Name = "lblFacilityBarTitle";
            this.lblFacilityBarTitle.Size = new System.Drawing.Size(243, 17);
            this.lblFacilityBarTitle.TabIndex = 3;
            this.lblFacilityBarTitle.Text = "Drag and drop a facility onto the grid:";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(926, 182);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(83, 17);
            this.lblPopulation.TabIndex = 4;
            this.lblPopulation.Text = "Population: ";
            // 
            // lblPollution
            // 
            this.lblPollution.AutoSize = true;
            this.lblPollution.Location = new System.Drawing.Point(926, 216);
            this.lblPollution.Name = "lblPollution";
            this.lblPollution.Size = new System.Drawing.Size(70, 17);
            this.lblPollution.TabIndex = 5;
            this.lblPollution.Text = "Pollution: ";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(926, 249);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(55, 17);
            this.lblPower.TabIndex = 6;
            this.lblPower.Text = "Power: ";
            // 
            // SimSpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 892);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblPollution);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblFacilityBarTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblMonth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SimSpaceForm";
            this.Text = "SimSpaceForm";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SimSpaceForm_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SimSpaceForm_Paint);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SimSpaceForm_DragDrop);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SimSpaceForm_MouseDown);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SimSpaceForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrGameTime;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFacilityBarTitle;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblPollution;
        private System.Windows.Forms.Label lblPower;
    }
}

