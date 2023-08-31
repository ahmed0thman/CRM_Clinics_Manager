using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Clinic.BL;

namespace ClinicManager.UserControls
{
    public partial class UC_Medical : UserControl
    {
        public UC_Medical()
        {
            InitializeComponent();
        }

        private void UC_Medical_Load(object sender, EventArgs e)
        {
            GetTreatments();
        }

        private void GetTreatments()
        {
            DataTable tblTreatmants = new TreatmentRepository().RetriveAllTreatments();
            dgvItems.DataSource = tblTreatmants;
        }

        private void GetRays()
        {
            DataTable tblRays = new RayRepository().RetriveAllRays();
            dgvItems.DataSource = tblRays;
        }

        private void GetAnalysis()
        {
            DataTable tblAnalysis = new AnalysisRepository().RetriveAllAnalysis();
            dgvItems.DataSource = tblAnalysis;
        }

        private void btnAddItemManiwally_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            if (radTreatment.Checked)
            {
                AddTreatment(item);
                GetTreatments();
                WidgetCleaner.ClearControls(groupBox1, groupBox2);
                return;
            }

            if (radRay.Checked)
            {
                AddRay(item);
                GetRays();
                WidgetCleaner.ClearControls(groupBox1, groupBox2);
                return;
            }

            AddAnalysis(item);
            GetAnalysis();
            WidgetCleaner.ClearControls(groupBox1, groupBox2);
        }

        private void AddAnalysis(string item)
        {
            Analysis analysis = new Analysis
            {
                analysisName = item
            };

            new AnalysisRepository().AddAnalysis(analysis);
        }

        private void AddRay(string item)
        {
            Ray ray = new Ray
            {
                rayName = item
            };

            new RayRepository().AddRay(ray);
        }

        private void AddTreatment(string item)
        {
            Treatment treatment = new Treatment
            {
                TreatmentName = item
            };

            new TreatmentRepository().AddTreatment(treatment);
        }

        private void radRay_CheckedChanged(object sender, EventArgs e)
        {
            if (radRay.Checked)
                GetRays();
        }

        private void radAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            if (radAnalysis.Checked)
                GetAnalysis();
        }

        private void radTreatment_CheckedChanged(object sender, EventArgs e)
        {
            if (radTreatment.Checked)
                GetTreatments();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string itemID = dgvItems.CurrentRow.Cells["colID"].Value.ToString();
            if (radTreatment.Checked)
            {
                DeleteTreatment(itemID);
                GetTreatments();
                WidgetCleaner.ClearControls(groupBox1, groupBox2);
                return;
            }

            if (radRay.Checked)
            {
                DeleteRay(itemID);
                GetRays();
                WidgetCleaner.ClearControls(groupBox1, groupBox2);
                return;
            }

            DeleteAnalysis(itemID);
            GetAnalysis();
            WidgetCleaner.ClearControls(groupBox1, groupBox2);
        }

        private void DeleteAnalysis(string itemID) => new AnalysisRepository().DeleteAnalysis(itemID);

        private void DeleteRay(string itemID) => new RayRepository().DeleteRay(itemID);

        private void DeleteTreatment(string itemID) => new TreatmentRepository().DeleteTreatment(itemID);

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Text files (*.txt)|*.txt";
                openFile.ShowDialog();
                txtFilePath.Text = openFile.FileName;
            }
        }

        private void btnAddItemFromFile_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Trim() == "") return;

            StreamReader streamReader = new StreamReader(txtFilePath.Text);
            string line = null;
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.Length > 100)
                {
                    MessageBox.Show($"Item ({line}) is so big.\nplease type the right name and try again!..");
                    continue;
                }

                if (radAnalysis.Checked)
                {
                    AddAnalysis(line);
                    GetAnalysis();
                }
                else if (radRay.Checked)
                {
                    AddRay(line);
                    GetRays();
                }
                else
                {
                    AddTreatment(line);
                    GetTreatments();
                }
            }

            WidgetCleaner.ClearControls(groupBox1, groupBox2);
        }
    }
}
