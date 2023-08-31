namespace ClinicManager.UserControls
{
    partial class UC_DashBoard
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
            this.timrAnimation = new System.Windows.Forms.Timer(this.components);
            this.panelParent = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // timrAnimation
            // 
            this.timrAnimation.Enabled = true;
            this.timrAnimation.Interval = 25;
            // 
            // panelParent
            // 
            this.panelParent.AutoScroll = true;
            this.panelParent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelParent.Location = new System.Drawing.Point(457, 3);
            this.panelParent.Name = "panelParent";
            this.panelParent.Padding = new System.Windows.Forms.Padding(5);
            this.panelParent.Size = new System.Drawing.Size(467, 794);
            this.panelParent.TabIndex = 0;
            // 
            // UC_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelParent);
            this.Name = "UC_DashBoard";
            this.Size = new System.Drawing.Size(1380, 800);
            this.Load += new System.EventHandler(this.UC_DashBoard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timrAnimation;
        private System.Windows.Forms.FlowLayoutPanel panelParent;
    }
}
