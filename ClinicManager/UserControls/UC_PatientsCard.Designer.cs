namespace ClinicManager.UserControls
{
    partial class UC_PatientsCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PatientsCard));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.lblPatientID);
            this.gunaShadowPanel1.Controls.Add(this.lblPatientName);
            this.gunaShadowPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(395, 95);
            this.gunaShadowPanel1.TabIndex = 10;
            this.gunaShadowPanel1.Click += new System.EventHandler(this.gunaShadowPanel1_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientID.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(93, 47);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatientID.Size = new System.Drawing.Size(276, 31);
            this.lblPatientID.TabIndex = 2;
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPatientID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientName.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(93, 8);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatientName.Size = new System.Drawing.Size(276, 39);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Ahmed Hesham Othman";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPatientName.Click += new System.EventHandler(this.lblPatientName_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(8, 8);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(70, 70);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            // 
            // UC_PatientsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "UC_PatientsCard";
            this.Size = new System.Drawing.Size(395, 95);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPatientName;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label lblPatientID;
        public Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}
