namespace ClinicManager.UserControls
{
    partial class UC_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPersonName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtPersonPhone = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtPersonUsername = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtpersonPass = new Guna.UI.WinForms.GunaTextBox();
            this.dgvPersons = new Guna.UI.WinForms.GunaDataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditUser = new Guna.UI.WinForms.GunaButton();
            this.btnAddUser = new Guna.UI.WinForms.GunaButton();
            this.btnDeleteUser = new Guna.UI.WinForms.GunaButton();
            this.txtPersonMail = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtPersonAddress = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtPersonId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.cmbType = new Guna.UI.WinForms.GunaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPersonName
            // 
            this.txtPersonName.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonName.BaseColor = System.Drawing.Color.White;
            this.txtPersonName.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonName.BorderSize = 1;
            this.txtPersonName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPersonName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtPersonName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPersonName.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonName.Location = new System.Drawing.Point(201, 96);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.PasswordChar = '\0';
            this.txtPersonName.Radius = 10;
            this.txtPersonName.SelectedText = "";
            this.txtPersonName.Size = new System.Drawing.Size(291, 45);
            this.txtPersonName.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(50, 104);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(66, 28);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Name";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(50, 174);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 28);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Phone";
            // 
            // txtPersonPhone
            // 
            this.txtPersonPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonPhone.BaseColor = System.Drawing.Color.White;
            this.txtPersonPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonPhone.BorderSize = 1;
            this.txtPersonPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPersonPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtPersonPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPersonPhone.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonPhone.Location = new System.Drawing.Point(201, 166);
            this.txtPersonPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonPhone.Name = "txtPersonPhone";
            this.txtPersonPhone.PasswordChar = '\0';
            this.txtPersonPhone.Radius = 10;
            this.txtPersonPhone.SelectedText = "";
            this.txtPersonPhone.Size = new System.Drawing.Size(291, 45);
            this.txtPersonPhone.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(50, 243);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(107, 28);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "UserName";
            // 
            // txtPersonUsername
            // 
            this.txtPersonUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonUsername.BaseColor = System.Drawing.Color.White;
            this.txtPersonUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonUsername.BorderSize = 1;
            this.txtPersonUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPersonUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtPersonUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPersonUsername.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonUsername.Location = new System.Drawing.Point(201, 236);
            this.txtPersonUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonUsername.Name = "txtPersonUsername";
            this.txtPersonUsername.PasswordChar = '\0';
            this.txtPersonUsername.Radius = 10;
            this.txtPersonUsername.SelectedText = "";
            this.txtPersonUsername.Size = new System.Drawing.Size(291, 45);
            this.txtPersonUsername.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(50, 314);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(97, 28);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Password";
            // 
            // txtpersonPass
            // 
            this.txtpersonPass.BackColor = System.Drawing.Color.Transparent;
            this.txtpersonPass.BaseColor = System.Drawing.Color.White;
            this.txtpersonPass.BorderColor = System.Drawing.Color.Silver;
            this.txtpersonPass.BorderSize = 1;
            this.txtpersonPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpersonPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpersonPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtpersonPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpersonPass.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpersonPass.Location = new System.Drawing.Point(201, 306);
            this.txtpersonPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtpersonPass.Name = "txtpersonPass";
            this.txtpersonPass.PasswordChar = '\0';
            this.txtpersonPass.Radius = 10;
            this.txtpersonPass.SelectedText = "";
            this.txtpersonPass.Size = new System.Drawing.Size(291, 45);
            this.txtpersonPass.TabIndex = 8;
            // 
            // dgvPersons
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPersons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvPersons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPersons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersons.ColumnHeadersHeight = 40;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Name,
            this.col_Phone,
            this.col_Username,
            this.col_Email,
            this.col_Address,
            this.col_Password,
            this.col_Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersons.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersons.EnableHeadersVisualStyles = false;
            this.dgvPersons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersons.Location = new System.Drawing.Point(526, 13);
            this.dgvPersons.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersVisible = false;
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 40;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(1062, 663);
            this.dgvPersons.TabIndex = 13;
            this.dgvPersons.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvPersons.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPersons.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPersons.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPersons.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPersons.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPersons.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvPersons.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersons.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dgvPersons.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPersons.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPersons.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvPersons.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPersons.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPersons.ThemeStyle.ReadOnly = false;
            this.dgvPersons.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvPersons.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPersons.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPersons.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPersons.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPersons.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPersons.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPersons.SelectionChanged += new System.EventHandler(this.dgvPersons_SelectionChanged);
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "id";
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Name
            // 
            this.col_Name.DataPropertyName = "name";
            this.col_Name.HeaderText = "Name";
            this.col_Name.MinimumWidth = 6;
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            // 
            // col_Phone
            // 
            this.col_Phone.DataPropertyName = "phone";
            this.col_Phone.HeaderText = "Phone";
            this.col_Phone.MinimumWidth = 6;
            this.col_Phone.Name = "col_Phone";
            this.col_Phone.ReadOnly = true;
            // 
            // col_Username
            // 
            this.col_Username.DataPropertyName = "username";
            this.col_Username.HeaderText = "UserName";
            this.col_Username.MinimumWidth = 6;
            this.col_Username.Name = "col_Username";
            this.col_Username.ReadOnly = true;
            // 
            // col_Email
            // 
            this.col_Email.DataPropertyName = "e_mail";
            this.col_Email.HeaderText = "Email";
            this.col_Email.MinimumWidth = 6;
            this.col_Email.Name = "col_Email";
            this.col_Email.ReadOnly = true;
            // 
            // col_Address
            // 
            this.col_Address.DataPropertyName = "address";
            this.col_Address.HeaderText = "Address";
            this.col_Address.MinimumWidth = 6;
            this.col_Address.Name = "col_Address";
            this.col_Address.ReadOnly = true;
            // 
            // col_Password
            // 
            this.col_Password.DataPropertyName = "pass";
            this.col_Password.HeaderText = "password";
            this.col_Password.MinimumWidth = 6;
            this.col_Password.Name = "col_Password";
            this.col_Password.ReadOnly = true;
            this.col_Password.Visible = false;
            // 
            // col_Type
            // 
            this.col_Type.DataPropertyName = "type";
            this.col_Type.HeaderText = "Type";
            this.col_Type.MinimumWidth = 6;
            this.col_Type.Name = "col_Type";
            this.col_Type.ReadOnly = true;
            this.col_Type.Visible = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditUser.AnimationHoverSpeed = 0.07F;
            this.btnEditUser.AnimationSpeed = 0.03F;
            this.btnEditUser.BackColor = System.Drawing.Color.Transparent;
            this.btnEditUser.BaseColor = System.Drawing.Color.White;
            this.btnEditUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnEditUser.BorderSize = 1;
            this.btnEditUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditUser.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnEditUser.Image = null;
            this.btnEditUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditUser.Location = new System.Drawing.Point(192, 621);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnEditUser.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnEditUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditUser.OnHoverImage = null;
            this.btnEditUser.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnEditUser.Radius = 10;
            this.btnEditUser.Size = new System.Drawing.Size(126, 55);
            this.btnEditUser.TabIndex = 14;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddUser.AnimationHoverSpeed = 0.07F;
            this.btnAddUser.AnimationSpeed = 0.03F;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BaseColor = System.Drawing.Color.White;
            this.btnAddUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddUser.BorderSize = 1;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddUser.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddUser.Image = null;
            this.btnAddUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddUser.Location = new System.Drawing.Point(22, 621);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddUser.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddUser.OnHoverImage = null;
            this.btnAddUser.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddUser.Radius = 10;
            this.btnAddUser.Size = new System.Drawing.Size(126, 55);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteUser.AnimationHoverSpeed = 0.07F;
            this.btnDeleteUser.AnimationSpeed = 0.03F;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.BaseColor = System.Drawing.Color.White;
            this.btnDeleteUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteUser.BorderSize = 1;
            this.btnDeleteUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteUser.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteUser.Image = null;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteUser.Location = new System.Drawing.Point(367, 621);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteUser.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.OnHoverImage = null;
            this.btnDeleteUser.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteUser.Radius = 10;
            this.btnDeleteUser.Size = new System.Drawing.Size(126, 55);
            this.btnDeleteUser.TabIndex = 16;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtPersonMail
            // 
            this.txtPersonMail.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonMail.BaseColor = System.Drawing.Color.White;
            this.txtPersonMail.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonMail.BorderSize = 1;
            this.txtPersonMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonMail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPersonMail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtPersonMail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPersonMail.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonMail.Location = new System.Drawing.Point(201, 381);
            this.txtPersonMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonMail.Name = "txtPersonMail";
            this.txtPersonMail.PasswordChar = '\0';
            this.txtPersonMail.Radius = 10;
            this.txtPersonMail.SelectedText = "";
            this.txtPersonMail.Size = new System.Drawing.Size(291, 45);
            this.txtPersonMail.TabIndex = 19;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(50, 390);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(60, 28);
            this.gunaLabel5.TabIndex = 18;
            this.gunaLabel5.Text = "Email";
            // 
            // txtPersonAddress
            // 
            this.txtPersonAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonAddress.BaseColor = System.Drawing.Color.White;
            this.txtPersonAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonAddress.BorderSize = 1;
            this.txtPersonAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPersonAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtPersonAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPersonAddress.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonAddress.Location = new System.Drawing.Point(201, 458);
            this.txtPersonAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonAddress.Name = "txtPersonAddress";
            this.txtPersonAddress.PasswordChar = '\0';
            this.txtPersonAddress.Radius = 10;
            this.txtPersonAddress.SelectedText = "";
            this.txtPersonAddress.Size = new System.Drawing.Size(291, 45);
            this.txtPersonAddress.TabIndex = 21;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(50, 466);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(85, 28);
            this.gunaLabel7.TabIndex = 20;
            this.gunaLabel7.Text = "Address";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(50, 35);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(31, 28);
            this.gunaLabel8.TabIndex = 23;
            this.gunaLabel8.Text = "ID";
            // 
            // txtPersonId
            // 
            this.txtPersonId.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonId.BaseColor = System.Drawing.Color.White;
            this.txtPersonId.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonId.BorderSize = 1;
            this.txtPersonId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPersonId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtPersonId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPersonId.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonId.Location = new System.Drawing.Point(201, 28);
            this.txtPersonId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.PasswordChar = '\0';
            this.txtPersonId.Radius = 10;
            this.txtPersonId.SelectedText = "";
            this.txtPersonId.Size = new System.Drawing.Size(291, 45);
            this.txtPersonId.TabIndex = 22;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(50, 540);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(56, 28);
            this.gunaLabel6.TabIndex = 24;
            this.gunaLabel6.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BaseColor = System.Drawing.Color.White;
            this.cmbType.BorderColor = System.Drawing.Color.Silver;
            this.cmbType.BorderSize = 1;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbType.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Doctor",
            "Sec"});
            this.cmbType.Location = new System.Drawing.Point(201, 540);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbType.Radius = 10;
            this.cmbType.Size = new System.Drawing.Size(291, 41);
            this.cmbType.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.txtPersonName);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.txtPersonId);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.txtPersonAddress);
            this.panel1.Controls.Add(this.txtPersonPhone);
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.txtPersonMail);
            this.panel1.Controls.Add(this.txtPersonUsername);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.txtpersonPass);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.dgvPersons);
            this.panel1.Controls.Add(this.btnEditUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 694);
            this.panel1.TabIndex = 26;
            // 
            // UC_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_User";
            this.Size = new System.Drawing.Size(1600, 694);
            this.Load += new System.EventHandler(this.UC_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtPersonName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtPersonPhone;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtPersonUsername;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtpersonPass;
        private Guna.UI.WinForms.GunaDataGridView dgvPersons;
        private Guna.UI.WinForms.GunaButton btnEditUser;
        private Guna.UI.WinForms.GunaButton btnAddUser;
        private Guna.UI.WinForms.GunaButton btnDeleteUser;
        private Guna.UI.WinForms.GunaTextBox txtPersonMail;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtPersonAddress;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtPersonId;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaComboBox cmbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Type;
        private System.Windows.Forms.Panel panel1;
    }
}
