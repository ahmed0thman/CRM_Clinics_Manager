namespace ClinicManager.UserControls
{
    partial class UC_DiagnosisCard
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DiagnosisCard));
            this.GunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblDiagnosisDate = new System.Windows.Forms.Label();
            this.lblDiagnosisID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardOptionAnim = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.GunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaShadowPanel1
            // 
            this.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.GunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.GunaShadowPanel1.Controls.Add(this.lblDiagnosisDate);
            this.GunaShadowPanel1.Controls.Add(this.lblDiagnosisID);
            this.GunaShadowPanel1.Controls.Add(this.pictureBox1);
            this.cardOptionAnim.SetDecoration(this.GunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.GunaShadowPanel1.Location = new System.Drawing.Point(2, 4);
            this.GunaShadowPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.GunaShadowPanel1.Name = "GunaShadowPanel1";
            this.GunaShadowPanel1.Radius = 10;
            this.GunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GunaShadowPanel1.ShadowShift = 3;
            this.GunaShadowPanel1.Size = new System.Drawing.Size(418, 92);
            this.GunaShadowPanel1.TabIndex = 1;
            this.GunaShadowPanel1.Click += new System.EventHandler(this.GunaShadowPanel1_Click);
            // 
            // lblDiagnosisDate
            // 
            this.lblDiagnosisDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDiagnosisDate.BackColor = System.Drawing.Color.Transparent;
            this.cardOptionAnim.SetDecoration(this.lblDiagnosisDate, Guna.UI.Animation.DecorationType.None);
            this.lblDiagnosisDate.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosisDate.Location = new System.Drawing.Point(106, 44);
            this.lblDiagnosisDate.Name = "lblDiagnosisDate";
            this.lblDiagnosisDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiagnosisDate.Size = new System.Drawing.Size(136, 25);
            this.lblDiagnosisDate.TabIndex = 49;
            this.lblDiagnosisDate.Text = "01/01/2020";
            this.lblDiagnosisDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiagnosisDate.Click += new System.EventHandler(this.lblDiagnosisDate_Click);
            // 
            // lblDiagnosisID
            // 
            this.lblDiagnosisID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDiagnosisID.BackColor = System.Drawing.Color.Transparent;
            this.cardOptionAnim.SetDecoration(this.lblDiagnosisID, Guna.UI.Animation.DecorationType.None);
            this.lblDiagnosisID.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosisID.Location = new System.Drawing.Point(106, 14);
            this.lblDiagnosisID.Name = "lblDiagnosisID";
            this.lblDiagnosisID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiagnosisID.Size = new System.Drawing.Size(106, 25);
            this.lblDiagnosisID.TabIndex = 48;
            this.lblDiagnosisID.Text = "Diagnosis";
            this.lblDiagnosisID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiagnosisID.Click += new System.EventHandler(this.lblDiagnosisID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cardOptionAnim.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cardOptionAnim
            // 
            this.cardOptionAnim.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.cardOptionAnim.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.cardOptionAnim.DefaultAnimation = animation2;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // UC_DiagnosisCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GunaShadowPanel1);
            this.cardOptionAnim.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_DiagnosisCard";
            this.Size = new System.Drawing.Size(425, 102);
            this.GunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel GunaShadowPanel1;
        private Guna.UI.WinForms.GunaTransition cardOptionAnim;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Label lblDiagnosisDate;
        private System.Windows.Forms.Label lblDiagnosisID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
