namespace ClinicManager.UserControls
{
    partial class UC_PatientCardDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PatientCardDoctor));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnPatientDone = new Guna.UI.WinForms.GunaButton();
            this.lblQueue = new System.Windows.Forms.Label();
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
            this.gunaShadowPanel1.Controls.Add(this.btnPatientDone);
            this.gunaShadowPanel1.Controls.Add(this.lblQueue);
            this.gunaShadowPanel1.Controls.Add(this.lblPatientName);
            this.gunaShadowPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(420, 95);
            this.gunaShadowPanel1.TabIndex = 9;
            this.gunaShadowPanel1.Click += new System.EventHandler(this.gunaShadowPanel1_Click);
            // 
            // btnPatientDone
            // 
            this.btnPatientDone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPatientDone.AnimationHoverSpeed = 0.07F;
            this.btnPatientDone.AnimationSpeed = 0.03F;
            this.btnPatientDone.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatientDone.BaseColor = System.Drawing.Color.Transparent;
            this.btnPatientDone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPatientDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientDone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatientDone.FocusedColor = System.Drawing.Color.Empty;
            this.btnPatientDone.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPatientDone.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientDone.Image")));
            this.btnPatientDone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPatientDone.ImageSize = new System.Drawing.Size(26, 26);
            this.btnPatientDone.Location = new System.Drawing.Point(357, 27);
            this.btnPatientDone.Name = "btnPatientDone";
            this.btnPatientDone.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnPatientDone.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPatientDone.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPatientDone.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPatientDone.OnHoverImage")));
            this.btnPatientDone.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPatientDone.OnPressedDepth = 5;
            this.btnPatientDone.Radius = 10;
            this.btnPatientDone.Size = new System.Drawing.Size(45, 45);
            this.btnPatientDone.TabIndex = 64;
            this.btnPatientDone.Click += new System.EventHandler(this.btnPatientDone_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.ForeColor = System.Drawing.Color.Black;
            this.lblQueue.Location = new System.Drawing.Point(93, 43);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(80, 35);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQueue.Click += new System.EventHandler(this.lblQueue_Click);
            // 
            // lblPatientName
            // 
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
            // UC_PatientCardDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "UC_PatientCardDoctor";
            this.Size = new System.Drawing.Size(420, 95);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblPatientName;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaButton btnPatientDone;
    }
}
