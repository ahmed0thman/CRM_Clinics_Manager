using System;
using System.Windows.Forms;
using System.IO;
using Clinic.BL;
using static ClinicManager.Program;
using System.Drawing;

namespace ClinicManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Replace("'", "").Trim();
            string password = txtPassword.Text.Replace("'", "").Trim();
            person = new PersonRepository().RetriveOnePerson(username, password);
            if (person == null)
            {
                MessageBox.Show("Wrong username or password, please try again!..");
                return;
            }

            if (person.personType == PersonType.Doctor)
            {
                ShowMainWindowForDoctor();
                return;
            }

            ShowMainWindowForSecritary();
        }

        private void ShowMainWindowForDoctor()
        {
            this.Hide();
            new Form1().Show();
        }

        private void ShowMainWindowForSecritary()
        {
            this.Hide();
            Form1 Main = new Form1();
            Main.btnControl.Visible = false;
            Main.btnDoctor.Visible = false;
            Main.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string directoryName = "ClinicLogo";
            string[] fileName = null;
            if (Directory.Exists(directoryName))
                fileName = Directory.GetFiles(directoryName);
            if (!Directory.Exists(directoryName) || fileName.Length == 0)
            {
                if (!Directory.Exists(directoryName))
                    Directory.CreateDirectory(directoryName);

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Select clinic logo";
                fileDialog.ShowDialog();
                string path = fileDialog.FileName;
                string[] str = fileDialog.FileName.Split('.');
                string fileExtention = str[str.Length - 1];
                if (File.Exists(path))
                    File.Copy(path, directoryName + "\\Logo." + fileExtention);
                fileName = Directory.GetFiles(directoryName);
            }

            if (fileName.Length == 0)
            {
                Application.Exit();
                return;
            }
            
            picClinicLogo.Image = Image.FromFile($"{fileName[0]}");
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}
