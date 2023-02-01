namespace WindowsFormsApplication1
{
    partial class Dbmodhist
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gridcontrol1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnDelete_Panel1 = new System.Windows.Forms.Button();
            this.BtnUpdate_Panel1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnReference = new System.Windows.Forms.Button();
            this.BtnCreate_Panel1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBox_PJTNM = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MaskedTextBox_PJTCD = new System.Windows.Forms.MaskedTextBox();
            this.ComboBox_CUSTCD = new System.Windows.Forms.ComboBox();
            this.ComboBox_EMPCD = new System.Windows.Forms.ComboBox();
            this.BtnReset_Panel1 = new System.Windows.Forms.Button();
            this.BtnReset_Panel2 = new System.Windows.Forms.Button();
            this.BtnUpdate_Panel2 = new System.Windows.Forms.Button();
            this.BtnDelete_Panel2 = new System.Windows.Forms.Button();
            this.BtnCreate_Panel2 = new System.Windows.Forms.Button();
            this.TextBox_CONGATE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_CONSUBNET = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox_CONPORT = new System.Windows.Forms.TextBox();
            this.TextBox_CONIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_CONWINPASS = new System.Windows.Forms.TextBox();
            this.TextBox_CONCAT = new System.Windows.Forms.TextBox();
            this.Gridcontrol2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_CONCOMNM = new System.Windows.Forms.TextBox();
            this.TextBox_PJTCD = new System.Windows.Forms.TextBox();
            this.TextBox_CONWINID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_CONSEQ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gridcontrol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridcontrol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // Gridcontrol1
            // 
            this.Gridcontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Gridcontrol1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.Gridcontrol1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.Gridcontrol1.Location = new System.Drawing.Point(3, 84);
            this.Gridcontrol1.MainView = this.gridView1;
            this.Gridcontrol1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gridcontrol1.Name = "Gridcontrol1";
            this.Gridcontrol1.Size = new System.Drawing.Size(1023, 367);
            this.Gridcontrol1.TabIndex = 4;
            this.Gridcontrol1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.Gridcontrol1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // BtnDelete_Panel1
            // 
            this.BtnDelete_Panel1.Enabled = false;
            this.BtnDelete_Panel1.Location = new System.Drawing.Point(1034, 8);
            this.BtnDelete_Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete_Panel1.Name = "BtnDelete_Panel1";
            this.BtnDelete_Panel1.Size = new System.Drawing.Size(101, 69);
            this.BtnDelete_Panel1.TabIndex = 43;
            this.BtnDelete_Panel1.Text = "삭제";
            this.BtnDelete_Panel1.UseVisualStyleBackColor = true;
            this.BtnDelete_Panel1.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate_Panel1
            // 
            this.BtnUpdate_Panel1.Enabled = false;
            this.BtnUpdate_Panel1.Location = new System.Drawing.Point(927, 8);
            this.BtnUpdate_Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate_Panel1.Name = "BtnUpdate_Panel1";
            this.BtnUpdate_Panel1.Size = new System.Drawing.Size(101, 69);
            this.BtnUpdate_Panel1.TabIndex = 41;
            this.BtnUpdate_Panel1.Text = "수정";
            this.BtnUpdate_Panel1.UseVisualStyleBackColor = true;
            this.BtnUpdate_Panel1.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(209, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 50;
            this.label14.Text = "EMPCD";
            // 
            // BtnReference
            // 
            this.BtnReference.Location = new System.Drawing.Point(605, 8);
            this.BtnReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReference.Name = "BtnReference";
            this.BtnReference.Size = new System.Drawing.Size(101, 69);
            this.BtnReference.TabIndex = 40;
            this.BtnReference.Text = "조회";
            this.BtnReference.UseVisualStyleBackColor = true;
            this.BtnReference.Click += new System.EventHandler(this.BtnReference_Click);
            // 
            // BtnCreate_Panel1
            // 
            this.BtnCreate_Panel1.Enabled = false;
            this.BtnCreate_Panel1.Location = new System.Drawing.Point(819, 8);
            this.BtnCreate_Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate_Panel1.Name = "BtnCreate_Panel1";
            this.BtnCreate_Panel1.Size = new System.Drawing.Size(101, 69);
            this.BtnCreate_Panel1.TabIndex = 42;
            this.BtnCreate_Panel1.Text = "추가";
            this.BtnCreate_Panel1.UseVisualStyleBackColor = true;
            this.BtnCreate_Panel1.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 49;
            this.label12.Text = "PJTCD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "PJTNM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 51;
            this.label15.Text = "CUSTCD";
            // 
            // TextBox_PJTNM
            // 
            this.TextBox_PJTNM.Location = new System.Drawing.Point(73, 45);
            this.TextBox_PJTNM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_PJTNM.MaxLength = 100;
            this.TextBox_PJTNM.Name = "TextBox_PJTNM";
            this.TextBox_PJTNM.Size = new System.Drawing.Size(129, 25);
            this.TextBox_PJTNM.TabIndex = 48;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MaskedTextBox_PJTCD);
            this.splitContainer1.Panel1.Controls.Add(this.ComboBox_CUSTCD);
            this.splitContainer1.Panel1.Controls.Add(this.ComboBox_EMPCD);
            this.splitContainer1.Panel1.Controls.Add(this.BtnReset_Panel1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnReference);
            this.splitContainer1.Panel1.Controls.Add(this.Gridcontrol1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnCreate_Panel1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnDelete_Panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_PJTNM);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.BtnUpdate_Panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnReset_Panel2);
            this.splitContainer1.Panel2.Controls.Add(this.BtnUpdate_Panel2);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete_Panel2);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCreate_Panel2);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONGATE);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONSUBNET);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONPORT);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONIP);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONWINPASS);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONCAT);
            this.splitContainer1.Panel2.Controls.Add(this.Gridcontrol2);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONSEQ);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONCOMNM);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_PJTCD);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_CONWINID);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 911);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 54;
            // 
            // MaskedTextBox_PJTCD
            // 
            this.MaskedTextBox_PJTCD.Location = new System.Drawing.Point(73, 10);
            this.MaskedTextBox_PJTCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaskedTextBox_PJTCD.Mask = "00000000";
            this.MaskedTextBox_PJTCD.Name = "MaskedTextBox_PJTCD";
            this.MaskedTextBox_PJTCD.ResetOnSpace = false;
            this.MaskedTextBox_PJTCD.Size = new System.Drawing.Size(129, 25);
            this.MaskedTextBox_PJTCD.TabIndex = 57;
            this.MaskedTextBox_PJTCD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox_PJTCD_MaskInputRejected);
            this.MaskedTextBox_PJTCD.Click += new System.EventHandler(this.MaskedTextBox_PJTCD_Click);
            this.MaskedTextBox_PJTCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedTextBox_PJTCD_KeyPress);
            // 
            // ComboBox_CUSTCD
            // 
            this.ComboBox_CUSTCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CUSTCD.FormattingEnabled = true;
            this.ComboBox_CUSTCD.Location = new System.Drawing.Point(278, 45);
            this.ComboBox_CUSTCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_CUSTCD.Name = "ComboBox_CUSTCD";
            this.ComboBox_CUSTCD.Size = new System.Drawing.Size(129, 23);
            this.ComboBox_CUSTCD.TabIndex = 56;
            // 
            // ComboBox_EMPCD
            // 
            this.ComboBox_EMPCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_EMPCD.FormattingEnabled = true;
            this.ComboBox_EMPCD.Location = new System.Drawing.Point(278, 10);
            this.ComboBox_EMPCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_EMPCD.Name = "ComboBox_EMPCD";
            this.ComboBox_EMPCD.Size = new System.Drawing.Size(129, 23);
            this.ComboBox_EMPCD.TabIndex = 55;
            // 
            // BtnReset_Panel1
            // 
            this.BtnReset_Panel1.Enabled = false;
            this.BtnReset_Panel1.Location = new System.Drawing.Point(712, 8);
            this.BtnReset_Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReset_Panel1.Name = "BtnReset_Panel1";
            this.BtnReset_Panel1.Size = new System.Drawing.Size(101, 69);
            this.BtnReset_Panel1.TabIndex = 54;
            this.BtnReset_Panel1.Text = "초기화";
            this.BtnReset_Panel1.UseVisualStyleBackColor = true;
            this.BtnReset_Panel1.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnReset_Panel2
            // 
            this.BtnReset_Panel2.Enabled = false;
            this.BtnReset_Panel2.Location = new System.Drawing.Point(919, 12);
            this.BtnReset_Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReset_Panel2.Name = "BtnReset_Panel2";
            this.BtnReset_Panel2.Size = new System.Drawing.Size(50, 59);
            this.BtnReset_Panel2.TabIndex = 79;
            this.BtnReset_Panel2.Text = "초기화";
            this.BtnReset_Panel2.UseVisualStyleBackColor = true;
            this.BtnReset_Panel2.Click += new System.EventHandler(this.BtnReset_Panel2_Click);
            // 
            // BtnUpdate_Panel2
            // 
            this.BtnUpdate_Panel2.Enabled = false;
            this.BtnUpdate_Panel2.Location = new System.Drawing.Point(1033, 12);
            this.BtnUpdate_Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate_Panel2.Name = "BtnUpdate_Panel2";
            this.BtnUpdate_Panel2.Size = new System.Drawing.Size(50, 59);
            this.BtnUpdate_Panel2.TabIndex = 56;
            this.BtnUpdate_Panel2.Text = "수정";
            this.BtnUpdate_Panel2.UseVisualStyleBackColor = true;
            this.BtnUpdate_Panel2.Click += new System.EventHandler(this.BtnUpdate_Panel2_Click);
            // 
            // BtnDelete_Panel2
            // 
            this.BtnDelete_Panel2.Enabled = false;
            this.BtnDelete_Panel2.Location = new System.Drawing.Point(1090, 12);
            this.BtnDelete_Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete_Panel2.Name = "BtnDelete_Panel2";
            this.BtnDelete_Panel2.Size = new System.Drawing.Size(50, 59);
            this.BtnDelete_Panel2.TabIndex = 58;
            this.BtnDelete_Panel2.Text = "삭제";
            this.BtnDelete_Panel2.UseVisualStyleBackColor = true;
            this.BtnDelete_Panel2.Click += new System.EventHandler(this.BtnDelete_Panel2_Click);
            // 
            // BtnCreate_Panel2
            // 
            this.BtnCreate_Panel2.Enabled = false;
            this.BtnCreate_Panel2.Location = new System.Drawing.Point(976, 12);
            this.BtnCreate_Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate_Panel2.Name = "BtnCreate_Panel2";
            this.BtnCreate_Panel2.Size = new System.Drawing.Size(50, 59);
            this.BtnCreate_Panel2.TabIndex = 57;
            this.BtnCreate_Panel2.Text = "추가";
            this.BtnCreate_Panel2.UseVisualStyleBackColor = true;
            this.BtnCreate_Panel2.Click += new System.EventHandler(this.BtnCreate_Panel2_Click);
            // 
            // TextBox_CONGATE
            // 
            this.TextBox_CONGATE.Location = new System.Drawing.Point(823, 12);
            this.TextBox_CONGATE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONGATE.MaxLength = 15;
            this.TextBox_CONGATE.Name = "TextBox_CONGATE";
            this.TextBox_CONGATE.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONGATE.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "CONGATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 76;
            this.label7.Text = "CONPORT";
            // 
            // TextBox_CONSUBNET
            // 
            this.TextBox_CONSUBNET.Location = new System.Drawing.Point(654, 45);
            this.TextBox_CONSUBNET.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONSUBNET.MaxLength = 15;
            this.TextBox_CONSUBNET.Name = "TextBox_CONSUBNET";
            this.TextBox_CONSUBNET.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONSUBNET.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "CONIP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 77;
            this.label9.Text = "CONWINPASS";
            // 
            // TextBox_CONPORT
            // 
            this.TextBox_CONPORT.Location = new System.Drawing.Point(823, 45);
            this.TextBox_CONPORT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONPORT.MaxLength = 5;
            this.TextBox_CONPORT.Name = "TextBox_CONPORT";
            this.TextBox_CONPORT.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONPORT.TabIndex = 71;
            // 
            // TextBox_CONIP
            // 
            this.TextBox_CONIP.Location = new System.Drawing.Point(654, 12);
            this.TextBox_CONIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONIP.MaxLength = 15;
            this.TextBox_CONIP.Name = "TextBox_CONIP";
            this.TextBox_CONIP.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONIP.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 78;
            this.label10.Text = "CONSUBNET";
            // 
            // TextBox_CONWINPASS
            // 
            this.TextBox_CONWINPASS.Location = new System.Drawing.Point(464, 45);
            this.TextBox_CONWINPASS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONWINPASS.MaxLength = 50;
            this.TextBox_CONWINPASS.Name = "TextBox_CONWINPASS";
            this.TextBox_CONWINPASS.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONWINPASS.TabIndex = 72;
            // 
            // TextBox_CONCAT
            // 
            this.TextBox_CONCAT.Location = new System.Drawing.Point(269, 12);
            this.TextBox_CONCAT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONCAT.MaxLength = 20;
            this.TextBox_CONCAT.Name = "TextBox_CONCAT";
            this.TextBox_CONCAT.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONCAT.TabIndex = 60;
            // 
            // Gridcontrol2
            // 
            this.Gridcontrol2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Gridcontrol2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gridcontrol2.Location = new System.Drawing.Point(3, 84);
            this.Gridcontrol2.MainView = this.gridView2;
            this.Gridcontrol2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gridcontrol2.Name = "Gridcontrol2";
            this.Gridcontrol2.Size = new System.Drawing.Size(1023, 369);
            this.Gridcontrol2.TabIndex = 54;
            this.Gridcontrol2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.Gridcontrol2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "CONCAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "CONCOMNM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "PJTCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "CONWINID";
            // 
            // TextBox_CONCOMNM
            // 
            this.TextBox_CONCOMNM.Location = new System.Drawing.Point(269, 45);
            this.TextBox_CONCOMNM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONCOMNM.MaxLength = 50;
            this.TextBox_CONCOMNM.Name = "TextBox_CONCOMNM";
            this.TextBox_CONCOMNM.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONCOMNM.TabIndex = 61;
            // 
            // TextBox_PJTCD
            // 
            this.TextBox_PJTCD.Location = new System.Drawing.Point(80, 10);
            this.TextBox_PJTCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_PJTCD.Name = "TextBox_PJTCD";
            this.TextBox_PJTCD.ReadOnly = true;
            this.TextBox_PJTCD.Size = new System.Drawing.Size(89, 25);
            this.TextBox_PJTCD.TabIndex = 59;
            // 
            // TextBox_CONWINID
            // 
            this.TextBox_CONWINID.Location = new System.Drawing.Point(464, 12);
            this.TextBox_CONWINID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONWINID.MaxLength = 50;
            this.TextBox_CONWINID.Name = "TextBox_CONWINID";
            this.TextBox_CONWINID.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONWINID.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "CONSEQ";
            // 
            // TextBox_CONSEQ
            // 
            this.TextBox_CONSEQ.Location = new System.Drawing.Point(80, 45);
            this.TextBox_CONSEQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CONSEQ.Name = "TextBox_CONSEQ";
            this.TextBox_CONSEQ.ReadOnly = true;
            this.TextBox_CONSEQ.Size = new System.Drawing.Size(89, 25);
            this.TextBox_CONSEQ.TabIndex = 63;
            // 
            // Dbmodhist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 911);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1168, 948);
            this.Name = "Dbmodhist";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dbmodhist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridcontrol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridcontrol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl Gridcontrol1;
        private System.Windows.Forms.Button BtnDelete_Panel1;
        private System.Windows.Forms.Button BtnUpdate_Panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnReference;
        private System.Windows.Forms.Button BtnCreate_Panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TextBox_CONCAT;
        private DevExpress.XtraGrid.GridControl Gridcontrol2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button BtnUpdate_Panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCreate_Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDelete_Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_CONCOMNM;
        private System.Windows.Forms.TextBox TextBox_PJTCD;
        private System.Windows.Forms.TextBox TextBox_CONWINID;
        private System.Windows.Forms.TextBox TextBox_CONGATE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox_CONSUBNET;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox_CONPORT;
        private System.Windows.Forms.TextBox TextBox_CONIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_CONWINPASS;
        private System.Windows.Forms.Button BtnReset_Panel1;
        private System.Windows.Forms.Button BtnReset_Panel2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.TextBox TextBox_PJTNM;
        public System.Windows.Forms.ComboBox ComboBox_EMPCD;
        public System.Windows.Forms.ComboBox ComboBox_CUSTCD;
        public System.Windows.Forms.MaskedTextBox MaskedTextBox_PJTCD;
        private System.Windows.Forms.TextBox TextBox_CONSEQ;
        private System.Windows.Forms.Label label2;
    }
}

