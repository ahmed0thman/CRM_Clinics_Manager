namespace ClinicManager.UserControls
{
    partial class UC_PatientSec
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
            this.btnSavePatientInfo = new Guna.UI.WinForms.GunaButton();
            this.dgvTreatmentToken = new Guna.UI.WinForms.GunaDataGridView();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSufferFrom = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHistoricalDisease = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtGovernment = new Guna.UI.WinForms.GunaTextBox();
            this.dtBirth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txtAge = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtNationalID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentToken)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSavePatientInfo
            // 
            this.btnSavePatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePatientInfo.AnimationHoverSpeed = 0.07F;
            this.btnSavePatientInfo.AnimationSpeed = 0.03F;
            this.btnSavePatientInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePatientInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSavePatientInfo.BaseColor = System.Drawing.Color.Transparent;
            this.btnSavePatientInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSavePatientInfo.BorderSize = 1;
            this.btnSavePatientInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePatientInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSavePatientInfo.FocusedColor = System.Drawing.Color.Empty;
            this.btnSavePatientInfo.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSavePatientInfo.Image = null;
            this.btnSavePatientInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSavePatientInfo.Location = new System.Drawing.Point(767, 645);
            this.btnSavePatientInfo.Name = "btnSavePatientInfo";
            this.btnSavePatientInfo.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSavePatientInfo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSavePatientInfo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSavePatientInfo.OnHoverImage = null;
            this.btnSavePatientInfo.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSavePatientInfo.OnPressedDepth = 5;
            this.btnSavePatientInfo.Radius = 10;
            this.btnSavePatientInfo.Size = new System.Drawing.Size(101, 38);
            this.btnSavePatientInfo.TabIndex = 112;
            this.btnSavePatientInfo.Text = "Save";
            this.btnSavePatientInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSavePatientInfo.Click += new System.EventHandler(this.btnSavePatientInfo_Click);
            // 
            // dgvTreatmentToken
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvTreatmentToken.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTreatmentToken.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvTreatmentToken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreatmentToken.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvTreatmentToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTreatmentToken.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTreatmentToken.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTreatmentToken.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTreatmentToken.ColumnHeadersHeight = 27;
            this.dgvTreatmentToken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTreatment});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatmentToken.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTreatmentToken.EnableHeadersVisualStyles = false;
            this.dgvTreatmentToken.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvTreatmentToken.Location = new System.Drawing.Point(566, 337);
            this.dgvTreatmentToken.Name = "dgvTreatmentToken";
            this.dgvTreatmentToken.RowHeadersVisible = false;
            this.dgvTreatmentToken.RowHeadersWidth = 51;
            this.dgvTreatmentToken.RowTemplate.Height = 26;
            this.dgvTreatmentToken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatmentToken.Size = new System.Drawing.Size(310, 295);
            this.dgvTreatmentToken.TabIndex = 111;
            this.dgvTreatmentToken.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Cyan;
            this.dgvTreatmentToken.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvTreatmentToken.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTreatmentToken.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTreatmentToken.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTreatmentToken.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTreatmentToken.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvTreatmentToken.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvTreatmentToken.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dgvTreatmentToken.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTreatmentToken.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTreatmentToken.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTreatmentToken.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTreatmentToken.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvTreatmentToken.ThemeStyle.ReadOnly = false;
            this.dgvTreatmentToken.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dgvTreatmentToken.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTreatmentToken.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTreatmentToken.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTreatmentToken.ThemeStyle.RowsStyle.Height = 26;
            this.dgvTreatmentToken.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dgvTreatmentToken.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTreatmentToken.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreatmentToken_CellEndEdit);
            this.dgvTreatmentToken.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTreatmentToken_DataError);
            this.dgvTreatmentToken.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTreatmentToken_EditingControlShowing);
            this.dgvTreatmentToken.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTreatmentToken_KeyDown);
            // 
            // colTreatment
            // 
            this.colTreatment.DataPropertyName = "treatment";
            this.colTreatment.FillWeight = 200F;
            this.colTreatment.HeaderText = "Treatment Token";
            this.colTreatment.MinimumWidth = 6;
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTreatment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSufferFrom
            // 
            this.txtSufferFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtSufferFrom.BaseColor = System.Drawing.Color.White;
            this.txtSufferFrom.BorderColor = System.Drawing.Color.Silver;
            this.txtSufferFrom.BorderSize = 1;
            this.txtSufferFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSufferFrom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSufferFrom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.txtSufferFrom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSufferFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSufferFrom.Location = new System.Drawing.Point(37, 512);
            this.txtSufferFrom.Multiline = true;
            this.txtSufferFrom.Name = "txtSufferFrom";
            this.txtSufferFrom.PasswordChar = '\0';
            this.txtSufferFrom.Radius = 10;
            this.txtSufferFrom.SelectedText = "";
            this.txtSufferFrom.Size = new System.Drawing.Size(510, 120);
            this.txtSufferFrom.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 474);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 109;
            this.label2.Text = "Suffer From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHistoricalDisease
            // 
            this.txtHistoricalDisease.BackColor = System.Drawing.Color.Transparent;
            this.txtHistoricalDisease.BaseColor = System.Drawing.Color.White;
            this.txtHistoricalDisease.BorderColor = System.Drawing.Color.Silver;
            this.txtHistoricalDisease.BorderSize = 1;
            this.txtHistoricalDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHistoricalDisease.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHistoricalDisease.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.txtHistoricalDisease.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHistoricalDisease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHistoricalDisease.Location = new System.Drawing.Point(38, 329);
            this.txtHistoricalDisease.Multiline = true;
            this.txtHistoricalDisease.Name = "txtHistoricalDisease";
            this.txtHistoricalDisease.PasswordChar = '\0';
            this.txtHistoricalDisease.Radius = 10;
            this.txtHistoricalDisease.SelectedText = "";
            this.txtHistoricalDisease.Size = new System.Drawing.Size(510, 118);
            this.txtHistoricalDisease.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 289);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 107;
            this.label3.Text = "Historical Disease";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(469, 158);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(126, 28);
            this.gunaLabel1.TabIndex = 106;
            this.gunaLabel1.Text = "Government";
            // 
            // txtGovernment
            // 
            this.txtGovernment.BackColor = System.Drawing.Color.Transparent;
            this.txtGovernment.BaseColor = System.Drawing.Color.White;
            this.txtGovernment.BorderColor = System.Drawing.Color.Silver;
            this.txtGovernment.BorderSize = 1;
            this.txtGovernment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGovernment.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGovernment.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtGovernment.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGovernment.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGovernment.Location = new System.Drawing.Point(601, 152);
            this.txtGovernment.Name = "txtGovernment";
            this.txtGovernment.PasswordChar = '\0';
            this.txtGovernment.Radius = 10;
            this.txtGovernment.SelectedText = "";
            this.txtGovernment.Size = new System.Drawing.Size(275, 45);
            this.txtGovernment.TabIndex = 105;
            // 
            // dtBirth
            // 
            this.dtBirth.BackColor = System.Drawing.Color.Transparent;
            this.dtBirth.BaseColor = System.Drawing.Color.White;
            this.dtBirth.BorderColor = System.Drawing.Color.Silver;
            this.dtBirth.BorderSize = 1;
            this.dtBirth.CustomFormat = null;
            this.dtBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtBirth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.dtBirth.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirth.ForeColor = System.Drawing.Color.Black;
            this.dtBirth.Location = new System.Drawing.Point(601, 84);
            this.dtBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtBirth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.dtBirth.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.dtBirth.OnPressedColor = System.Drawing.Color.Black;
            this.dtBirth.Radius = 10;
            this.dtBirth.Size = new System.Drawing.Size(275, 48);
            this.dtBirth.TabIndex = 104;
            this.dtBirth.Text = "Wednesday, August 5, 2020";
            this.dtBirth.Value = new System.DateTime(2020, 8, 5, 2, 11, 3, 895);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(469, 94);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(104, 28);
            this.gunaLabel4.TabIndex = 103;
            this.gunaLabel4.Text = "Birth Date";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(469, 21);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(48, 28);
            this.gunaLabel10.TabIndex = 100;
            this.gunaLabel10.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Transparent;
            this.txtAge.BaseColor = System.Drawing.Color.White;
            this.txtAge.BorderColor = System.Drawing.Color.Silver;
            this.txtAge.BorderSize = 1;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtAge.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAge.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(601, 15);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.Radius = 10;
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(275, 45);
            this.txtAge.TabIndex = 99;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(30, 218);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(114, 28);
            this.gunaLabel11.TabIndex = 98;
            this.gunaLabel11.Text = "National ID";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderSize = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(159, 17);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 10;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(275, 45);
            this.txtName.TabIndex = 97;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalID.BaseColor = System.Drawing.Color.White;
            this.txtNationalID.BorderColor = System.Drawing.Color.Silver;
            this.txtNationalID.BorderSize = 1;
            this.txtNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNationalID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtNationalID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNationalID.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalID.Location = new System.Drawing.Point(159, 213);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.PasswordChar = '\0';
            this.txtNationalID.Radius = 10;
            this.txtNationalID.SelectedText = "";
            this.txtNationalID.Size = new System.Drawing.Size(275, 45);
            this.txtNationalID.TabIndex = 96;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.Location = new System.Drawing.Point(30, 153);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(85, 28);
            this.gunaLabel12.TabIndex = 95;
            this.gunaLabel12.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.BorderSize = 1;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(159, 148);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Radius = 10;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(275, 45);
            this.txtAddress.TabIndex = 94;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel14.Location = new System.Drawing.Point(30, 87);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(70, 28);
            this.gunaLabel14.TabIndex = 93;
            this.gunaLabel14.Text = "Phone";
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel15.Location = new System.Drawing.Point(30, 21);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(66, 28);
            this.gunaLabel15.TabIndex = 92;
            this.gunaLabel15.Text = "Name";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(159, 81);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 10;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(275, 45);
            this.txtPhone.TabIndex = 91;
            // 
            // UC_PatientSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSavePatientInfo);
            this.Controls.Add(this.dgvTreatmentToken);
            this.Controls.Add(this.txtSufferFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHistoricalDisease);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtGovernment);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNationalID);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.gunaLabel14);
            this.Controls.Add(this.gunaLabel15);
            this.Controls.Add(this.txtPhone);
            this.Name = "UC_PatientSec";
            this.Size = new System.Drawing.Size(906, 699);
            this.Load += new System.EventHandler(this.UC_PatientSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentToken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSavePatientInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        public Guna.UI.WinForms.GunaTextBox txtGovernment;
        public Guna.UI.WinForms.GunaDateTimePicker dtBirth;
        public Guna.UI.WinForms.GunaTextBox txtAge;
        public Guna.UI.WinForms.GunaTextBox txtName;
        public Guna.UI.WinForms.GunaTextBox txtNationalID;
        public Guna.UI.WinForms.GunaTextBox txtAddress;
        public Guna.UI.WinForms.GunaTextBox txtPhone;
        public Guna.UI.WinForms.GunaDataGridView dgvTreatmentToken;
        public Guna.UI.WinForms.GunaTextBox txtSufferFrom;
        public Guna.UI.WinForms.GunaTextBox txtHistoricalDisease;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
    }
}
