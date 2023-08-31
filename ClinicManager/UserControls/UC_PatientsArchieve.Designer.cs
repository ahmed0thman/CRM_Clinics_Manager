namespace ClinicManager.UserControls
{
    partial class UC_PatientsArchieve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI.Animation.Animation animation5 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation6 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation4 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PatientsArchieve));
            this.panelPatientArchive = new System.Windows.Forms.Panel();
            this.panelPatientInfo = new Guna.UI.WinForms.GunaShadowPanel();
            this.panelPatientsCards = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtPatientSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnPanelDashboard = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel6 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblPhone = new Guna.UI.WinForms.GunaLabel();
            this.lblAddress = new Guna.UI.WinForms.GunaLabel();
            this.lblGovernment = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNationalId = new Guna.UI.WinForms.GunaLabel();
            this.lblDtBirth = new Guna.UI.WinForms.GunaLabel();
            this.panelReservation = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnSaveReservation = new Guna.UI.WinForms.GunaButton();
            this.dtReservation = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.dgvPatientsTreatments = new Guna.UI.WinForms.GunaDataGridView();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSufferFrom = new Guna.UI.WinForms.GunaTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHistoricalDisease = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnPanelReservation = new Guna.UI.WinForms.GunaButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox6 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnShowPanelInfo = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.trans = new Guna.UI.WinForms.GunaTransition(this.components);
            this.trans2 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.trans3 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelPatientArchive.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel6.SuspendLayout();
            this.panelReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPatientArchive
            // 
            this.panelPatientArchive.Controls.Add(this.panelPatientInfo);
            this.panelPatientArchive.Controls.Add(this.panelPatientsCards);
            this.panelPatientArchive.Controls.Add(this.gunaShadowPanel1);
            this.panelPatientArchive.Controls.Add(this.gunaShadowPanel6);
            this.trans3.SetDecoration(this.panelPatientArchive, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.panelPatientArchive, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.panelPatientArchive, Guna.UI.Animation.DecorationType.None);
            this.panelPatientArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatientArchive.Location = new System.Drawing.Point(0, 0);
            this.panelPatientArchive.Name = "panelPatientArchive";
            this.panelPatientArchive.Size = new System.Drawing.Size(1566, 800);
            this.panelPatientArchive.TabIndex = 0;
            // 
            // panelPatientInfo
            // 
            this.panelPatientInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelPatientInfo.BaseColor = System.Drawing.Color.White;
            this.trans3.SetDecoration(this.panelPatientInfo, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.panelPatientInfo, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.panelPatientInfo, Guna.UI.Animation.DecorationType.None);
            this.panelPatientInfo.Location = new System.Drawing.Point(507, 76);
            this.panelPatientInfo.Name = "panelPatientInfo";
            this.panelPatientInfo.ShadowColor = System.Drawing.Color.Black;
            this.panelPatientInfo.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelPatientInfo.Size = new System.Drawing.Size(1035, 699);
            this.panelPatientInfo.TabIndex = 61;
            // 
            // panelPatientsCards
            // 
            this.panelPatientsCards.AutoScroll = true;
            this.trans2.SetDecoration(this.panelPatientsCards, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.panelPatientsCards, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.panelPatientsCards, Guna.UI.Animation.DecorationType.None);
            this.panelPatientsCards.Location = new System.Drawing.Point(7, 80);
            this.panelPatientsCards.Name = "panelPatientsCards";
            this.panelPatientsCards.Size = new System.Drawing.Size(491, 699);
            this.panelPatientsCards.TabIndex = 62;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.txtPatientSearch);
            this.gunaShadowPanel1.Controls.Add(this.btnPanelDashboard);
            this.trans3.SetDecoration(this.gunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.gunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(7, 20);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 8;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 2;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(470, 40);
            this.gunaShadowPanel1.TabIndex = 58;
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtPatientSearch.BaseColor = System.Drawing.Color.Transparent;
            this.txtPatientSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtPatientSearch.BorderSize = 0;
            this.txtPatientSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans3.SetDecoration(this.txtPatientSearch, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.txtPatientSearch, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.txtPatientSearch, Guna.UI.Animation.DecorationType.None);
            this.txtPatientSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPatientSearch.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txtPatientSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.txtPatientSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPatientSearch.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientSearch.Location = new System.Drawing.Point(62, 0);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.PasswordChar = '\0';
            this.txtPatientSearch.Radius = 8;
            this.txtPatientSearch.SelectedText = "";
            this.txtPatientSearch.Size = new System.Drawing.Size(408, 40);
            this.txtPatientSearch.TabIndex = 62;
            this.txtPatientSearch.TextOffsetX = 5;
            this.toolTip1.SetToolTip(this.txtPatientSearch, "Serach With ID or Phone");
            this.txtPatientSearch.TextChanged += new System.EventHandler(this.txtPatientSearch_TextChanged);
            // 
            // btnPanelDashboard
            // 
            this.btnPanelDashboard.AnimationHoverSpeed = 0.07F;
            this.btnPanelDashboard.AnimationSpeed = 0.03F;
            this.btnPanelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPanelDashboard.BaseColor = System.Drawing.Color.Transparent;
            this.btnPanelDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPanelDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans3.SetDecoration(this.btnPanelDashboard, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.btnPanelDashboard, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.btnPanelDashboard, Guna.UI.Animation.DecorationType.None);
            this.btnPanelDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPanelDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPanelDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnPanelDashboard.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPanelDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelDashboard.Image")));
            this.btnPanelDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPanelDashboard.ImageSize = new System.Drawing.Size(26, 26);
            this.btnPanelDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnPanelDashboard.Name = "btnPanelDashboard";
            this.btnPanelDashboard.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnPanelDashboard.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPanelDashboard.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPanelDashboard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPanelDashboard.OnHoverImage")));
            this.btnPanelDashboard.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPanelDashboard.OnPressedDepth = 0;
            this.btnPanelDashboard.Radius = 10;
            this.btnPanelDashboard.Size = new System.Drawing.Size(55, 40);
            this.btnPanelDashboard.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btnPanelDashboard, "Serach With ID or Phone");
            // 
            // gunaShadowPanel6
            // 
            this.gunaShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel6.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel6.Controls.Add(this.lblPhone);
            this.gunaShadowPanel6.Controls.Add(this.lblAddress);
            this.gunaShadowPanel6.Controls.Add(this.lblGovernment);
            this.gunaShadowPanel6.Controls.Add(this.panel1);
            this.gunaShadowPanel6.Controls.Add(this.lblNationalId);
            this.gunaShadowPanel6.Controls.Add(this.lblDtBirth);
            this.gunaShadowPanel6.Controls.Add(this.panelReservation);
            this.gunaShadowPanel6.Controls.Add(this.dgvPatientsTreatments);
            this.gunaShadowPanel6.Controls.Add(this.lblSufferFrom);
            this.gunaShadowPanel6.Controls.Add(this.label12);
            this.gunaShadowPanel6.Controls.Add(this.lblHistoricalDisease);
            this.gunaShadowPanel6.Controls.Add(this.label11);
            this.gunaShadowPanel6.Controls.Add(this.gunaLabel6);
            this.gunaShadowPanel6.Controls.Add(this.gunaLabel7);
            this.gunaShadowPanel6.Controls.Add(this.gunaLabel8);
            this.gunaShadowPanel6.Controls.Add(this.gunaLabel3);
            this.gunaShadowPanel6.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel6.Controls.Add(this.btnPanelReservation);
            this.gunaShadowPanel6.Controls.Add(this.lblAge);
            this.gunaShadowPanel6.Controls.Add(this.lblName);
            this.gunaShadowPanel6.Controls.Add(this.gunaCirclePictureBox6);
            this.gunaShadowPanel6.Controls.Add(this.gunaButton1);
            this.gunaShadowPanel6.Controls.Add(this.btnShowPanelInfo);
            this.gunaShadowPanel6.Controls.Add(this.label8);
            this.trans3.SetDecoration(this.gunaShadowPanel6, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaShadowPanel6, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.gunaShadowPanel6, Guna.UI.Animation.DecorationType.None);
            this.gunaShadowPanel6.Location = new System.Drawing.Point(509, 18);
            this.gunaShadowPanel6.Name = "gunaShadowPanel6";
            this.gunaShadowPanel6.Radius = 10;
            this.gunaShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel6.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel6.Size = new System.Drawing.Size(1035, 764);
            this.gunaShadowPanel6.TabIndex = 60;
            // 
            // lblPhone
            // 
            this.trans2.SetDecoration(this.lblPhone, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.lblPhone, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.lblPhone, Guna.UI.Animation.DecorationType.None);
            this.lblPhone.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(216, 92);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(150, 26);
            this.lblPhone.TabIndex = 77;
            // 
            // lblAddress
            // 
            this.trans2.SetDecoration(this.lblAddress, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.lblAddress, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.lblAddress, Guna.UI.Animation.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(216, 135);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 26);
            this.lblAddress.TabIndex = 76;
            // 
            // lblGovernment
            // 
            this.trans2.SetDecoration(this.lblGovernment, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.lblGovernment, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.lblGovernment, Guna.UI.Animation.DecorationType.None);
            this.lblGovernment.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGovernment.Location = new System.Drawing.Point(216, 265);
            this.lblGovernment.Name = "lblGovernment";
            this.lblGovernment.Size = new System.Drawing.Size(150, 26);
            this.lblGovernment.TabIndex = 75;
            // 
            // panel1
            // 
            this.trans3.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(-24, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 5);
            this.panel1.TabIndex = 59;
            // 
            // lblNationalId
            // 
            this.trans2.SetDecoration(this.lblNationalId, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.lblNationalId, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.lblNationalId, Guna.UI.Animation.DecorationType.None);
            this.lblNationalId.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalId.Location = new System.Drawing.Point(216, 180);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(150, 26);
            this.lblNationalId.TabIndex = 74;
            // 
            // lblDtBirth
            // 
            this.trans2.SetDecoration(this.lblDtBirth, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.lblDtBirth, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.lblDtBirth, Guna.UI.Animation.DecorationType.None);
            this.lblDtBirth.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtBirth.Location = new System.Drawing.Point(216, 224);
            this.lblDtBirth.Name = "lblDtBirth";
            this.lblDtBirth.Size = new System.Drawing.Size(150, 26);
            this.lblDtBirth.TabIndex = 73;
            // 
            // panelReservation
            // 
            this.panelReservation.BackColor = System.Drawing.Color.Transparent;
            this.panelReservation.BaseColor = System.Drawing.Color.White;
            this.panelReservation.Controls.Add(this.btnSaveReservation);
            this.panelReservation.Controls.Add(this.dtReservation);
            this.panelReservation.Controls.Add(this.gunaLabel13);
            this.trans3.SetDecoration(this.panelReservation, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.panelReservation, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.panelReservation, Guna.UI.Animation.DecorationType.None);
            this.panelReservation.Location = new System.Drawing.Point(367, 328);
            this.panelReservation.Name = "panelReservation";
            this.panelReservation.Radius = 10;
            this.panelReservation.ShadowColor = System.Drawing.Color.Black;
            this.panelReservation.ShadowShift = 3;
            this.panelReservation.Size = new System.Drawing.Size(646, 137);
            this.panelReservation.TabIndex = 67;
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveReservation.AnimationHoverSpeed = 0.07F;
            this.btnSaveReservation.AnimationSpeed = 0.03F;
            this.btnSaveReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveReservation.BaseColor = System.Drawing.Color.Transparent;
            this.btnSaveReservation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSaveReservation.BorderSize = 1;
            this.btnSaveReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans3.SetDecoration(this.btnSaveReservation, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.btnSaveReservation, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.btnSaveReservation, Guna.UI.Animation.DecorationType.None);
            this.btnSaveReservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveReservation.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveReservation.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnSaveReservation.Image = null;
            this.btnSaveReservation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveReservation.Location = new System.Drawing.Point(506, 82);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSaveReservation.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSaveReservation.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSaveReservation.OnHoverImage = null;
            this.btnSaveReservation.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSaveReservation.OnPressedDepth = 5;
            this.btnSaveReservation.Radius = 10;
            this.btnSaveReservation.Size = new System.Drawing.Size(115, 38);
            this.btnSaveReservation.TabIndex = 69;
            this.btnSaveReservation.Text = "Save";
            this.btnSaveReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveReservation.Click += new System.EventHandler(this.btnSaveReservation_Click);
            // 
            // dtReservation
            // 
            this.dtReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtReservation.BackColor = System.Drawing.Color.Transparent;
            this.dtReservation.BaseColor = System.Drawing.Color.White;
            this.dtReservation.BorderColor = System.Drawing.Color.Silver;
            this.dtReservation.BorderSize = 1;
            this.dtReservation.CustomFormat = null;
            this.trans3.SetDecoration(this.dtReservation, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.dtReservation, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.dtReservation, Guna.UI.Animation.DecorationType.None);
            this.dtReservation.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtReservation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.dtReservation.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReservation.ForeColor = System.Drawing.Color.Black;
            this.dtReservation.Location = new System.Drawing.Point(222, 19);
            this.dtReservation.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtReservation.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtReservation.Name = "dtReservation";
            this.dtReservation.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtReservation.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.dtReservation.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.dtReservation.OnPressedColor = System.Drawing.Color.Black;
            this.dtReservation.Radius = 10;
            this.dtReservation.Size = new System.Drawing.Size(400, 48);
            this.dtReservation.TabIndex = 67;
            this.dtReservation.Text = "Wednesday, 5 August, 2020";
            this.dtReservation.Value = new System.DateTime(2020, 8, 5, 2, 11, 3, 895);
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel13.AutoSize = true;
            this.trans2.SetDecoration(this.gunaLabel13, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaLabel13, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.gunaLabel13, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel13.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.Location = new System.Drawing.Point(33, 28);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(156, 28);
            this.gunaLabel13.TabIndex = 65;
            this.gunaLabel13.Text = "Rservation Date";
            // 
            // dgvPatientsTreatments
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvPatientsTreatments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatientsTreatments.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvPatientsTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientsTreatments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvPatientsTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientsTreatments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatientsTreatments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientsTreatments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPatientsTreatments.ColumnHeadersHeight = 27;
            this.dgvPatientsTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTreatment});
            this.trans3.SetDecoration(this.dgvPatientsTreatments, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.dgvPatientsTreatments, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.dgvPatientsTreatments, Guna.UI.Animation.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientsTreatments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPatientsTreatments.EnableHeadersVisualStyles = false;
            this.dgvPatientsTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvPatientsTreatments.Location = new System.Drawing.Point(640, 397);
            this.dgvPatientsTreatments.Name = "dgvPatientsTreatments";
            this.dgvPatientsTreatments.RowHeadersVisible = false;
            this.dgvPatientsTreatments.RowHeadersWidth = 51;
            this.dgvPatientsTreatments.RowTemplate.Height = 26;
            this.dgvPatientsTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientsTreatments.Size = new System.Drawing.Size(345, 304);
            this.dgvPatientsTreatments.TabIndex = 72;
            this.dgvPatientsTreatments.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Cyan;
            this.dgvPatientsTreatments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvPatientsTreatments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPatientsTreatments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPatientsTreatments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPatientsTreatments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPatientsTreatments.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvPatientsTreatments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvPatientsTreatments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dgvPatientsTreatments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatientsTreatments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPatientsTreatments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPatientsTreatments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPatientsTreatments.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvPatientsTreatments.ThemeStyle.ReadOnly = false;
            this.dgvPatientsTreatments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dgvPatientsTreatments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatientsTreatments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPatientsTreatments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPatientsTreatments.ThemeStyle.RowsStyle.Height = 26;
            this.dgvPatientsTreatments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dgvPatientsTreatments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // colTreatment
            // 
            this.colTreatment.DataPropertyName = "treatment";
            this.colTreatment.FillWeight = 200F;
            this.colTreatment.HeaderText = "Treatment Token";
            this.colTreatment.MinimumWidth = 6;
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            this.colTreatment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTreatment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblSufferFrom
            // 
            this.lblSufferFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblSufferFrom.BaseColor = System.Drawing.Color.White;
            this.lblSufferFrom.BorderColor = System.Drawing.Color.Silver;
            this.lblSufferFrom.BorderSize = 1;
            this.lblSufferFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans3.SetDecoration(this.lblSufferFrom, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.lblSufferFrom, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.lblSufferFrom, Guna.UI.Animation.DecorationType.None);
            this.lblSufferFrom.FocusedBaseColor = System.Drawing.Color.White;
            this.lblSufferFrom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.lblSufferFrom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSufferFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSufferFrom.Location = new System.Drawing.Point(35, 568);
            this.lblSufferFrom.Multiline = true;
            this.lblSufferFrom.Name = "lblSufferFrom";
            this.lblSufferFrom.PasswordChar = '\0';
            this.lblSufferFrom.Radius = 10;
            this.lblSufferFrom.ReadOnly = true;
            this.lblSufferFrom.SelectedText = "";
            this.lblSufferFrom.Size = new System.Drawing.Size(583, 120);
            this.lblSufferFrom.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.trans.SetDecoration(this.label12, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.label12, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.label12, Guna.UI.Animation.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 530);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(142, 25);
            this.label12.TabIndex = 70;
            this.label12.Text = "Suffer From";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHistoricalDisease
            // 
            this.lblHistoricalDisease.BackColor = System.Drawing.Color.Transparent;
            this.lblHistoricalDisease.BaseColor = System.Drawing.Color.White;
            this.lblHistoricalDisease.BorderColor = System.Drawing.Color.Silver;
            this.lblHistoricalDisease.BorderSize = 1;
            this.lblHistoricalDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans3.SetDecoration(this.lblHistoricalDisease, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.lblHistoricalDisease, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.lblHistoricalDisease, Guna.UI.Animation.DecorationType.None);
            this.lblHistoricalDisease.FocusedBaseColor = System.Drawing.Color.White;
            this.lblHistoricalDisease.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.lblHistoricalDisease.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHistoricalDisease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHistoricalDisease.Location = new System.Drawing.Point(37, 381);
            this.lblHistoricalDisease.Multiline = true;
            this.lblHistoricalDisease.Name = "lblHistoricalDisease";
            this.lblHistoricalDisease.PasswordChar = '\0';
            this.lblHistoricalDisease.Radius = 10;
            this.lblHistoricalDisease.ReadOnly = true;
            this.lblHistoricalDisease.SelectedText = "";
            this.lblHistoricalDisease.Size = new System.Drawing.Size(583, 118);
            this.lblHistoricalDisease.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.trans.SetDecoration(this.label11, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.label11, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.label11, Guna.UI.Animation.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 341);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(205, 25);
            this.label11.TabIndex = 68;
            this.label11.Text = "Historical Disease";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.trans2.SetDecoration(this.gunaLabel6, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaLabel6, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.gunaLabel6, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(59, 265);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(125, 26);
            this.gunaLabel6.TabIndex = 42;
            this.gunaLabel6.Text = "Government";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.trans2.SetDecoration(this.gunaLabel7, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaLabel7, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.gunaLabel7, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(59, 224);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(131, 26);
            this.gunaLabel7.TabIndex = 41;
            this.gunaLabel7.Text = "Date of Birth";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.trans2.SetDecoration(this.gunaLabel8, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaLabel8, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.gunaLabel8, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel8.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(59, 180);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(116, 26);
            this.gunaLabel8.TabIndex = 40;
            this.gunaLabel8.Text = "National ID";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.trans2.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(59, 135);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(87, 26);
            this.gunaLabel3.TabIndex = 39;
            this.gunaLabel3.Text = "Address";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.trans2.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(59, 92);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(71, 26);
            this.gunaLabel2.TabIndex = 38;
            this.gunaLabel2.Text = "Phone";
            // 
            // btnPanelReservation
            // 
            this.btnPanelReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanelReservation.AnimationHoverSpeed = 0.07F;
            this.btnPanelReservation.AnimationSpeed = 0.03F;
            this.btnPanelReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPanelReservation.BaseColor = System.Drawing.Color.Transparent;
            this.btnPanelReservation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPanelReservation.BorderSize = 1;
            this.btnPanelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans3.SetDecoration(this.btnPanelReservation, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.btnPanelReservation, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.btnPanelReservation, Guna.UI.Animation.DecorationType.None);
            this.btnPanelReservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPanelReservation.FocusedColor = System.Drawing.Color.Empty;
            this.btnPanelReservation.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnPanelReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelReservation.Image")));
            this.btnPanelReservation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPanelReservation.Location = new System.Drawing.Point(766, 272);
            this.btnPanelReservation.Name = "btnPanelReservation";
            this.btnPanelReservation.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnPanelReservation.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPanelReservation.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPanelReservation.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPanelReservation.OnHoverImage")));
            this.btnPanelReservation.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnPanelReservation.OnPressedDepth = 5;
            this.btnPanelReservation.Radius = 10;
            this.btnPanelReservation.Size = new System.Drawing.Size(161, 38);
            this.btnPanelReservation.TabIndex = 36;
            this.btnPanelReservation.Text = "Resrvation";
            this.btnPanelReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPanelReservation.Click += new System.EventHandler(this.btnPanelReservation_Click);
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.trans.SetDecoration(this.lblAge, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.lblAge, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.lblAge, Guna.UI.Animation.DecorationType.None);
            this.lblAge.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblAge.Location = new System.Drawing.Point(658, 222);
            this.lblAge.Name = "lblAge";
            this.lblAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAge.Size = new System.Drawing.Size(358, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.trans.SetDecoration(this.lblName, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.lblName, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.lblName, Guna.UI.Animation.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblName.Location = new System.Drawing.Point(658, 184);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(358, 38);
            this.lblName.TabIndex = 3;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaCirclePictureBox6
            // 
            this.gunaCirclePictureBox6.BaseColor = System.Drawing.Color.White;
            this.trans.SetDecoration(this.gunaCirclePictureBox6, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.gunaCirclePictureBox6, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.gunaCirclePictureBox6, Guna.UI.Animation.DecorationType.None);
            this.gunaCirclePictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox6.Image")));
            this.gunaCirclePictureBox6.Location = new System.Drawing.Point(786, 77);
            this.gunaCirclePictureBox6.Name = "gunaCirclePictureBox6";
            this.gunaCirclePictureBox6.Size = new System.Drawing.Size(114, 100);
            this.gunaCirclePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox6.TabIndex = 5;
            this.gunaCirclePictureBox6.TabStop = false;
            this.gunaCirclePictureBox6.UseTransfarantBackground = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.gunaButton1.BorderSize = 1;
            this.trans3.SetDecoration(this.gunaButton1, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.gunaButton1, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.gunaButton1, Guna.UI.Animation.DecorationType.None);
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(27, 27);
            this.gunaButton1.Location = new System.Drawing.Point(978, 7);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton1.OnHoverImage")));
            this.gunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.gunaButton1.OnPressedDepth = 5;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(46, 40);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnShowPanelInfo
            // 
            this.btnShowPanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPanelInfo.AnimationHoverSpeed = 0.07F;
            this.btnShowPanelInfo.AnimationSpeed = 0.03F;
            this.btnShowPanelInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPanelInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowPanelInfo.BaseColor = System.Drawing.Color.Transparent;
            this.btnShowPanelInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.btnShowPanelInfo.BorderSize = 1;
            this.trans3.SetDecoration(this.btnShowPanelInfo, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.btnShowPanelInfo, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this.btnShowPanelInfo, Guna.UI.Animation.DecorationType.None);
            this.btnShowPanelInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowPanelInfo.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowPanelInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPanelInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowPanelInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPanelInfo.Image")));
            this.btnShowPanelInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowPanelInfo.ImageSize = new System.Drawing.Size(27, 27);
            this.btnShowPanelInfo.Location = new System.Drawing.Point(926, 8);
            this.btnShowPanelInfo.Name = "btnShowPanelInfo";
            this.btnShowPanelInfo.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnShowPanelInfo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnShowPanelInfo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowPanelInfo.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowPanelInfo.OnHoverImage")));
            this.btnShowPanelInfo.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnShowPanelInfo.OnPressedDepth = 5;
            this.btnShowPanelInfo.Radius = 10;
            this.btnShowPanelInfo.Size = new System.Drawing.Size(46, 40);
            this.btnShowPanelInfo.TabIndex = 3;
            this.btnShowPanelInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowPanelInfo.Click += new System.EventHandler(this.btnShowPanelInfo_Click);
            // 
            // label8
            // 
            this.trans.SetDecoration(this.label8, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this.label8, Guna.UI.Animation.DecorationType.None);
            this.trans3.SetDecoration(this.label8, Guna.UI.Animation.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 7);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(167, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Patient Profile";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trans
            // 
            this.trans.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.trans.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.trans.DefaultAnimation = animation5;
            this.trans.Interval = 6;
            this.trans.TimeStep = 0.04F;
            // 
            // trans2
            // 
            this.trans2.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.trans2.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.trans2.DefaultAnimation = animation6;
            this.trans2.Interval = 6;
            this.trans2.TimeStep = 0.04F;
            // 
            // trans3
            // 
            this.trans3.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.trans3.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.trans3.DefaultAnimation = animation4;
            this.trans3.Interval = 6;
            this.trans3.TimeStep = 0.04F;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // UC_PatientsArchieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelPatientArchive);
            this.trans3.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.trans.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.trans2.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Name = "UC_PatientsArchieve";
            this.Size = new System.Drawing.Size(1566, 800);
            this.Load += new System.EventHandler(this.UC_PatientsArchieve_Load);
            this.panelPatientArchive.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel6.ResumeLayout(false);
            this.gunaShadowPanel6.PerformLayout();
            this.panelReservation.ResumeLayout(false);
            this.panelReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPatientArchive;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnPanelReservation;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox6;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton btnShowPanelInfo;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaTextBox txtPatientSearch;
        private Guna.UI.WinForms.GunaButton btnPanelDashboard;
        private Guna.UI.WinForms.GunaShadowPanel panelReservation;
        private Guna.UI.WinForms.GunaTransition trans;
        private Guna.UI.WinForms.GunaDateTimePicker dtReservation;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaButton btnSaveReservation;
        private Guna.UI.WinForms.GunaTransition trans2;
        private Guna.UI.WinForms.GunaShadowPanel panelPatientInfo;
        private Guna.UI.WinForms.GunaTransition trans3;
        private Guna.UI.WinForms.GunaDataGridView dgvPatientsTreatments;
        private Guna.UI.WinForms.GunaTextBox lblSufferFrom;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaTextBox lblHistoricalDisease;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaLabel lblPhone;
        private Guna.UI.WinForms.GunaLabel lblAddress;
        private Guna.UI.WinForms.GunaLabel lblGovernment;
        private Guna.UI.WinForms.GunaLabel lblNationalId;
        private Guna.UI.WinForms.GunaLabel lblDtBirth;
        private System.Windows.Forms.FlowLayoutPanel panelPatientsCards;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
    }
}
