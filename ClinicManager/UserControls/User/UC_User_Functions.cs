using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.BL;
using System.Windows.Forms;

namespace ClinicManager.UserControls
{
    public partial class UC_User
    {
        private void AddUser()
        {
            //state is equal to "Done" if the operation complete
            //elese it will equal to ex.message
            var state = new PersonRepository().AddPerson(GetPersonData());
            ShowAllDateInDgvPersons();
        }

        private void EditUser()
        {
            //state is equal to "Done" if the operation complete
            //elese it will equal to ex.message
            var state = new PersonRepository().SavePerson(GetPersonData());
            ShowAllDateInDgvPersons();
        }

        private void DeleteUser()
        {
            //state is equal to "Done" if the operation complete
            //elese it will equal to ex.message
            int personID = int.Parse(txtPersonId.Text);
            var state = new PersonRepository().DeletePerson(personID);
            ShowAllDateInDgvPersons();
        }

        private void ShowAllDateInDgvPersons()
        {
            var AllPersons = new PersonRepository().RetriveAllPersons();
            dgvPersons.DataSource = AllPersons;
        }

        private void DgvSelectionChanged()
        {
            if (dgvPersons.Rows.Count == 0) return;
            txtPersonId.Text = dgvPersons.CurrentRow.Cells["col_ID"].Value.ToString();
            txtPersonName.Text = dgvPersons.CurrentRow.Cells["col_Name"].Value.ToString();
            txtPersonPhone.Text = dgvPersons.CurrentRow.Cells["col_Phone"].Value.ToString();
            txtPersonUsername.Text = dgvPersons.CurrentRow.Cells["col_Username"].Value.ToString();
            txtPersonMail.Text = dgvPersons.CurrentRow.Cells["col_Email"].Value.ToString();
            txtPersonAddress.Text = dgvPersons.CurrentRow.Cells["col_Address"].Value.ToString();
            txtpersonPass.Text = dgvPersons.CurrentRow.Cells["col_Password"].Value.ToString();
            string type = dgvPersons.CurrentRow.Cells["col_Type"].Value.ToString();

            SelectPersonType(type);
        }

        private void SelectPersonType(string type)
        {
            
            if (type.Trim() == "Secritary")
                cmbType.SelectedIndex = 1;
            else
                cmbType.SelectedIndex = 0;
        }

        private Person GetPersonData()
        {
            Person p = new Person
            {
                personID = int.Parse(txtPersonId.Text.ToString()),
                personName = txtPersonName.Text,
                personPhone = txtPersonPhone.Text,
                personAddress = txtPersonAddress.Text,
                personEmail = txtPersonMail.Text,
                personPassword = txtpersonPass.Text,
                personUsername = txtPersonUsername.Text,
                personType = Person.GetPersonType(cmbType.Text)
            };

            return p;
        }
    }
}
