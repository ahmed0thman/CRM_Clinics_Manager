namespace ClinicManager.UserControls
{
    partial class UC_Medical
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
            this.radTreatment = new System.Windows.Forms.RadioButton();
            this.radRay = new System.Windows.Forms.RadioButton();
            this.radAnalysis = new System.Windows.Forms.RadioButton();
            this.btnChoseFile = new Guna.UI.WinForms.GunaButton();
            this.txtFilePath = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddItemFromFile = new Guna.UI.WinForms.GunaButton();
            this.dgvItems = new Guna.UI.WinForms.GunaDataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteItem = new Guna.UI.WinForms.GunaButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddItemManiwally = new Guna.UI.WinForms.GunaButton();
            this.Item = new Guna.UI.WinForms.GunaLabel();
            this.txtItem = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTreatment
            // 
            this.radTreatment.AutoSize = true;
            this.radTreatment.Checked = true;
            this.radTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTreatment.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.radTreatment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.radTreatment.Location = new System.Drawing.Point(54, 22);
            this.radTreatment.Name = "radTreatment";
            this.radTreatment.Size = new System.Drawing.Size(126, 32);
            this.radTreatment.TabIndex = 24;
            this.radTreatment.TabStop = true;
            this.radTreatment.Text = "Treatment";
            this.radTreatment.UseVisualStyleBackColor = true;
            this.radTreatment.CheckedChanged += new System.EventHandler(this.radTreatment_CheckedChanged);
            // 
            // radRay
            // 
            this.radRay.AutoSize = true;
            this.radRay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radRay.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.radRay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.radRay.Location = new System.Drawing.Point(235, 22);
            this.radRay.Name = "radRay";
            this.radRay.Size = new System.Drawing.Size(64, 32);
            this.radRay.TabIndex = 25;
            this.radRay.Text = "Ray";
            this.radRay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRay.UseVisualStyleBackColor = true;
            this.radRay.CheckedChanged += new System.EventHandler(this.radRay_CheckedChanged);
            // 
            // radAnalysis
            // 
            this.radAnalysis.AutoSize = true;
            this.radAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radAnalysis.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.radAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.radAnalysis.Location = new System.Drawing.Point(371, 22);
            this.radAnalysis.Name = "radAnalysis";
            this.radAnalysis.Size = new System.Drawing.Size(105, 32);
            this.radAnalysis.TabIndex = 26;
            this.radAnalysis.Text = "Analysis";
            this.radAnalysis.UseVisualStyleBackColor = true;
            this.radAnalysis.CheckedChanged += new System.EventHandler(this.radAnalysis_CheckedChanged);
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.AnimationHoverSpeed = 0.07F;
            this.btnChoseFile.AnimationSpeed = 0.03F;
            this.btnChoseFile.BackColor = System.Drawing.Color.Transparent;
            this.btnChoseFile.BaseColor = System.Drawing.Color.White;
            this.btnChoseFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnChoseFile.BorderSize = 1;
            this.btnChoseFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChoseFile.FocusedColor = System.Drawing.Color.Empty;
            this.btnChoseFile.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnChoseFile.Image = null;
            this.btnChoseFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChoseFile.Location = new System.Drawing.Point(33, 37);
            this.btnChoseFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnChoseFile.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnChoseFile.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChoseFile.OnHoverImage = null;
            this.btnChoseFile.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnChoseFile.Radius = 20;
            this.btnChoseFile.Size = new System.Drawing.Size(228, 55);
            this.btnChoseFile.TabIndex = 28;
            this.btnChoseFile.Text = "Choose File";
            this.btnChoseFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.Transparent;
            this.txtFilePath.BaseColor = System.Drawing.Color.White;
            this.txtFilePath.BorderColor = System.Drawing.Color.Silver;
            this.txtFilePath.BorderSize = 1;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilePath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtFilePath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilePath.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(295, 42);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.Radius = 10;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(381, 45);
            this.txtFilePath.TabIndex = 29;
            // 
            // btnAddItemFromFile
            // 
            this.btnAddItemFromFile.AnimationHoverSpeed = 0.07F;
            this.btnAddItemFromFile.AnimationSpeed = 0.03F;
            this.btnAddItemFromFile.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItemFromFile.BaseColor = System.Drawing.Color.White;
            this.btnAddItemFromFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemFromFile.BorderSize = 1;
            this.btnAddItemFromFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItemFromFile.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItemFromFile.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemFromFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemFromFile.Image = null;
            this.btnAddItemFromFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItemFromFile.Location = new System.Drawing.Point(715, 37);
            this.btnAddItemFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItemFromFile.Name = "btnAddItemFromFile";
            this.btnAddItemFromFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemFromFile.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemFromFile.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItemFromFile.OnHoverImage = null;
            this.btnAddItemFromFile.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemFromFile.Radius = 20;
            this.btnAddItemFromFile.Size = new System.Drawing.Size(126, 55);
            this.btnAddItemFromFile.TabIndex = 30;
            this.btnAddItemFromFile.Text = "Add";
            this.btnAddItemFromFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItemFromFile.Click += new System.EventHandler(this.btnAddItemFromFile_Click);
            // 
            // dgvItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeight = 40;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItems.Location = new System.Drawing.Point(975, 0);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 40;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(625, 509);
            this.dgvItems.TabIndex = 31;
            this.dgvItems.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvItems.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dgvItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvItems.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvItems.ThemeStyle.ReadOnly = true;
            this.dgvItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvItems.ThemeStyle.RowsStyle.Height = 40;
            this.dgvItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colID
            // 
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "Item ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteItem.AnimationHoverSpeed = 0.07F;
            this.btnDeleteItem.AnimationSpeed = 0.03F;
            this.btnDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.BaseColor = System.Drawing.Color.White;
            this.btnDeleteItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteItem.BorderSize = 1;
            this.btnDeleteItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteItem.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteItem.Image = null;
            this.btnDeleteItem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteItem.Location = new System.Drawing.Point(1170, 529);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteItem.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.OnHoverImage = null;
            this.btnDeleteItem.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnDeleteItem.Radius = 20;
            this.btnDeleteItem.Size = new System.Drawing.Size(271, 55);
            this.btnDeleteItem.TabIndex = 32;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddItemManiwally);
            this.groupBox1.Controls.Add(this.Item);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Location = new System.Drawing.Point(54, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 128);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adding manually";
            // 
            // btnAddItemManiwally
            // 
            this.btnAddItemManiwally.AnimationHoverSpeed = 0.07F;
            this.btnAddItemManiwally.AnimationSpeed = 0.03F;
            this.btnAddItemManiwally.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItemManiwally.BaseColor = System.Drawing.Color.White;
            this.btnAddItemManiwally.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemManiwally.BorderSize = 1;
            this.btnAddItemManiwally.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItemManiwally.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItemManiwally.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemManiwally.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemManiwally.Image = null;
            this.btnAddItemManiwally.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItemManiwally.Location = new System.Drawing.Point(719, 37);
            this.btnAddItemManiwally.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItemManiwally.Name = "btnAddItemManiwally";
            this.btnAddItemManiwally.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemManiwally.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemManiwally.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItemManiwally.OnHoverImage = null;
            this.btnAddItemManiwally.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnAddItemManiwally.Radius = 20;
            this.btnAddItemManiwally.Size = new System.Drawing.Size(126, 55);
            this.btnAddItemManiwally.TabIndex = 30;
            this.btnAddItemManiwally.Text = "Add";
            this.btnAddItemManiwally.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItemManiwally.Click += new System.EventHandler(this.btnAddItemManiwally_Click);
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Font = new System.Drawing.Font("Malgun Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.Item.Location = new System.Drawing.Point(29, 41);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(87, 45);
            this.Item.TabIndex = 28;
            this.Item.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.Transparent;
            this.txtItem.BaseColor = System.Drawing.Color.White;
            this.txtItem.BorderColor = System.Drawing.Color.Silver;
            this.txtItem.BorderSize = 1;
            this.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.txtItem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(138, 42);
            this.txtItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtItem.Name = "txtItem";
            this.txtItem.PasswordChar = '\0';
            this.txtItem.Radius = 10;
            this.txtItem.SelectedText = "";
            this.txtItem.Size = new System.Drawing.Size(559, 45);
            this.txtItem.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChoseFile);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.btnAddItemFromFile);
            this.groupBox2.Location = new System.Drawing.Point(54, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 128);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adding from file";
            // 
            // UC_Medical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.radAnalysis);
            this.Controls.Add(this.radRay);
            this.Controls.Add(this.radTreatment);
            this.Name = "UC_Medical";
            this.Size = new System.Drawing.Size(1600, 694);
            this.Load += new System.EventHandler(this.UC_Medical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radTreatment;
        private System.Windows.Forms.RadioButton radRay;
        private System.Windows.Forms.RadioButton radAnalysis;
        private Guna.UI.WinForms.GunaButton btnChoseFile;
        private Guna.UI.WinForms.GunaTextBox txtFilePath;
        private Guna.UI.WinForms.GunaButton btnAddItemFromFile;
        private Guna.UI.WinForms.GunaDataGridView dgvItems;
        private Guna.UI.WinForms.GunaButton btnDeleteItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton btnAddItemManiwally;
        private Guna.UI.WinForms.GunaLabel Item;
        private Guna.UI.WinForms.GunaTextBox txtItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
    }
}
