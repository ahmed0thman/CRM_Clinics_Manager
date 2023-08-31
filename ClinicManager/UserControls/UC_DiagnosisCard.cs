using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.BL;
using System.Security.AccessControl;

namespace ClinicManager.UserControls
{
    public partial class UC_DiagnosisCard : UserControl
    {
        public Diagnosis diagnosisInCard { get; set; }
        public delegate void clickDiagnosisCard(Diagnosis diagnosis);
        public static event clickDiagnosisCard diagnosisCardCliced;

        public UC_DiagnosisCard(Diagnosis diagnosisInCard)
        {
            InitializeComponent();
            this.diagnosisInCard = diagnosisInCard;
        }

        private void GunaShadowPanel1_Click(object sender, EventArgs e) => FireDiagnosisCardcliced();

        private void lblDiagnosisDate_Click(object sender, EventArgs e) => FireDiagnosisCardcliced();

        private void lblDiagnosisID_Click(object sender, EventArgs e) => FireDiagnosisCardcliced();

        private void pictureBox1_Click(object sender, EventArgs e) => FireDiagnosisCardcliced();

        private void FireDiagnosisCardcliced() => diagnosisCardCliced.Invoke(diagnosisInCard);
    }
}
