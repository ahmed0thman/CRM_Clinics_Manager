namespace ClinicManager.UserControls
{
    partial class UC_QueueCard
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
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panelQueue = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.panelQueue);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(4, 2);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 14;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowShift = 3;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(448, 758);
            this.gunaShadowPanel2.TabIndex = 2;
            // 
            // panelQueue
            // 
            this.panelQueue.AutoScroll = true;
            this.panelQueue.Location = new System.Drawing.Point(3, 33);
            this.panelQueue.Name = "panelQueue";
            this.panelQueue.Padding = new System.Windows.Forms.Padding(3);
            this.panelQueue.Size = new System.Drawing.Size(442, 698);
            this.panelQueue.TabIndex = 3;
            // 
            // UC_QueueCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel2);
            this.Name = "UC_QueueCard";
            this.Size = new System.Drawing.Size(455, 763);
            this.Load += new System.EventHandler(this.UC_QueueCard_Load);
            this.gunaShadowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.FlowLayoutPanel panelQueue;
    }
}
