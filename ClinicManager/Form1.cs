using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManager.UserControls;
using Guna.UI.WinForms;

namespace ClinicManager
{
    public partial class Form1 : Form
    {
        #region UserControls Objects Intialization
        UC_Control UC_Control = new UC_Control();
        UC_Doctor UC_Doctor = new UC_Doctor();
        UC_DataCenter UC_DataCenter = new UC_DataCenter();
        #endregion

        #region CurrentTab Navigator Handler
        GunaButton _CurrentTab = null;
        public GunaButton CurrentTab
        {
            get
            {
                return _CurrentTab;
            }
            set
            {
                if (_CurrentTab != null)
                {
                    _CurrentTab.BaseColor = Color.FromArgb(250, 249, 255);
                    _CurrentTab.ForeColor = Color.FromArgb(36, 180, 214);
                }
                _CurrentTab = value;
                _CurrentTab.BaseColor = Color.FromArgb(36, 180, 214);
                _CurrentTab.ForeColor = Color.FromArgb(250, 249, 255);

            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataCenter_Click(object sender, EventArgs e)
        {
            CurrentTab = (GunaButton)sender;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_DataCenter);
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            CurrentTab = (GunaButton)sender;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_Doctor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HandleSreenSize();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            CurrentTab = (GunaButton)sender;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_Control);
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            HandleSreenSize();
        }
        private void HandleSreenSize()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int x = (Screen.PrimaryScreen.WorkingArea.Width - panelContainer.Width) / 2;
                int y = ((panelParent.Height - panelContainer.Height) / 2);
                panelContainer.Location = new Point(x, y);
            }
            else if (this.WindowState == FormWindowState.Normal) panelContainer.Location = new Point(0, 90);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
