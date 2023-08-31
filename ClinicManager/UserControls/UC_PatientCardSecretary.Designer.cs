namespace ClinicManager.UserControls
{
    partial class UC_PatientCardSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PatientCardSecretary));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panelSwitchReservations = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnSwitchReservations = new Guna.UI.WinForms.GunaButton();
            this.txtQueueSwitch = new Guna.UI.WinForms.GunaTextBox();
            this.btnHold = new Guna.UI.WinForms.GunaButton();
            this.btnPatientDone = new Guna.UI.WinForms.GunaButton();
            this.btnSwitchQueue = new Guna.UI.WinForms.GunaButton();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaShadowPanel1.SuspendLayout();
            this.panelSwitchReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.panelSwitchReservations);
            this.gunaShadowPanel1.Controls.Add(this.btnHold);
            this.gunaShadowPanel1.Controls.Add(this.btnPatientDone);
            this.gunaShadowPanel1.Controls.Add(this.btnSwitchQueue);
            this.gunaShadowPanel1.Controls.Add(this.lblQueue);
            this.gunaShadowPanel1.Controls.Add(this.lblPatientName);
            this.gunaShadowPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(2, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(406, 95);
            this.gunaShadowPanel1.TabIndex = 10;
            // 
            // panelSwitchReservations
            // 
            this.panelSwitchReservations.BackColor = System.Drawing.Color.Transparent;
            this.panelSwitchReservations.BaseColor = System.Drawing.Color.White;
            this.panelSwitchReservations.Controls.Add(this.btnSwitchReservations);
            this.panelSwitchReservations.Controls.Add(this.txtQueueSwitch);
            this.panelSwitchReservations.Location = new System.Drawing.Point(168, 43);
            this.panelSwitchReservations.Name = "panelSwitchReservations";
            this.panelSwitchReservations.Radius = 7;
            this.panelSwitchReservations.ShadowColor = System.Drawing.Color.Black;
            this.panelSwitchReservations.ShadowShift = 2;
            this.panelSwitchReservations.Size = new System.Drawing.Size(134, 42);
            this.panelSwitchReservations.TabIndex = 68;
            // 
            // btnSwitchReservations
            // 
            this.btnSwitchReservations.AnimationHoverSpeed = 0.07F;
            this.btnSwitchReservations.AnimationSpeed = 0.03F;
            this.btnSwitchReservations.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchReservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSwitchReservations.BaseColor = System.Drawing.Color.Transparent;
            this.btnSwitchReservations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSwitchReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchReservations.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSwitchReservations.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSwitchReservations.FocusedColor = System.Drawing.Color.Empty;
            this.btnSwitchReservations.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSwitchReservations.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchReservations.Image")));
            this.btnSwitchReservations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSwitchReservations.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSwitchReservations.Location = new System.Drawing.Point(0, 0);
            this.btnSwitchReservations.Name = "btnSwitchReservations";
            this.btnSwitchReservations.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSwitchReservations.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSwitchReservations.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSwitchReservations.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSwitchReservations.OnHoverImage")));
            this.btnSwitchReservations.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSwitchReservations.OnPressedDepth = 0;
            this.btnSwitchReservations.Size = new System.Drawing.Size(38, 42);
            this.btnSwitchReservations.TabIndex = 68;
            this.btnSwitchReservations.Click += new System.EventHandler(this.btnSwitchReservations_Click);
            // 
            // txtQueueSwitch
            // 
            this.txtQueueSwitch.BackColor = System.Drawing.Color.Transparent;
            this.txtQueueSwitch.BaseColor = System.Drawing.Color.Transparent;
            this.txtQueueSwitch.BorderColor = System.Drawing.Color.Silver;
            this.txtQueueSwitch.BorderSize = 0;
            this.txtQueueSwitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQueueSwitch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtQueueSwitch.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txtQueueSwitch.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtQueueSwitch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQueueSwitch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQueueSwitch.Location = new System.Drawing.Point(36, 0);
            this.txtQueueSwitch.Name = "txtQueueSwitch";
            this.txtQueueSwitch.PasswordChar = '\0';
            this.txtQueueSwitch.Radius = 10;
            this.txtQueueSwitch.SelectedText = "";
            this.txtQueueSwitch.Size = new System.Drawing.Size(98, 42);
            this.txtQueueSwitch.TabIndex = 67;
            // 
            // btnHold
            // 
            this.btnHold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHold.AnimationHoverSpeed = 0.07F;
            this.btnHold.AnimationSpeed = 0.03F;
            this.btnHold.BackColor = System.Drawing.Color.Transparent;
            this.btnHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHold.BaseColor = System.Drawing.Color.Transparent;
            this.btnHold.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHold.FocusedColor = System.Drawing.Color.Empty;
            this.btnHold.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnHold.Image = ((System.Drawing.Image)(resources.GetObject("btnHold.Image")));
            this.btnHold.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHold.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHold.Location = new System.Drawing.Point(349, 50);
            this.btnHold.Name = "btnHold";
            this.btnHold.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnHold.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnHold.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnHold.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnHold.OnHoverImage")));
            this.btnHold.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnHold.OnPressedDepth = 0;
            this.btnHold.Size = new System.Drawing.Size(35, 35);
            this.btnHold.TabIndex = 66;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
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
            this.btnPatientDone.Location = new System.Drawing.Point(349, 12);
            this.btnPatientDone.Name = "btnPatientDone";
            this.btnPatientDone.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnPatientDone.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPatientDone.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPatientDone.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPatientDone.OnHoverImage")));
            this.btnPatientDone.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPatientDone.OnPressedDepth = 5;
            this.btnPatientDone.Radius = 10;
            this.btnPatientDone.Size = new System.Drawing.Size(35, 35);
            this.btnPatientDone.TabIndex = 65;
            this.btnPatientDone.Click += new System.EventHandler(this.btnPatientDone_Click);
            // 
            // btnSwitchQueue
            // 
            this.btnSwitchQueue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSwitchQueue.AnimationHoverSpeed = 0.07F;
            this.btnSwitchQueue.AnimationSpeed = 0.03F;
            this.btnSwitchQueue.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSwitchQueue.BaseColor = System.Drawing.Color.Transparent;
            this.btnSwitchQueue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSwitchQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchQueue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSwitchQueue.FocusedColor = System.Drawing.Color.Empty;
            this.btnSwitchQueue.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSwitchQueue.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchQueue.Image")));
            this.btnSwitchQueue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSwitchQueue.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSwitchQueue.Location = new System.Drawing.Point(308, 50);
            this.btnSwitchQueue.Name = "btnSwitchQueue";
            this.btnSwitchQueue.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSwitchQueue.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSwitchQueue.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSwitchQueue.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSwitchQueue.OnHoverImage")));
            this.btnSwitchQueue.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSwitchQueue.OnPressedDepth = 0;
            this.btnSwitchQueue.Size = new System.Drawing.Size(35, 35);
            this.btnSwitchQueue.TabIndex = 62;
            this.btnSwitchQueue.Click += new System.EventHandler(this.btnSwitchQueue_Click);
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
            // 
            // lblPatientName
            // 
            this.lblPatientName.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(93, 8);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatientName.Size = new System.Drawing.Size(250, 39);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Ahmed Hesham Othman";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // UC_PatientCardSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "UC_PatientCardSecretary";
            this.Size = new System.Drawing.Size(413, 102);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.panelSwitchReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblPatientName;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaButton btnSwitchQueue;
        private Guna.UI.WinForms.GunaButton btnPatientDone;
        private Guna.UI.WinForms.GunaButton btnHold;
        private Guna.UI.WinForms.GunaTextBox txtQueueSwitch;
        private Guna.UI.WinForms.GunaShadowPanel panelSwitchReservations;
        private Guna.UI.WinForms.GunaButton btnSwitchReservations;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}
