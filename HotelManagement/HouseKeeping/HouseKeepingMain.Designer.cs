namespace HotelManagement
{
    partial class HouseKeepingMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseKeepingMain));
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.createNewbtn = new System.Windows.Forms.Button();
            this.HouseKeepingDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseKeepingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HouseKeepingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            resources.ApplyResources(this.deletebtn, "deletebtn");
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            resources.ApplyResources(this.updatebtn, "updatebtn");
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // createNewbtn
            // 
            resources.ApplyResources(this.createNewbtn, "createNewbtn");
            this.createNewbtn.Name = "createNewbtn";
            this.createNewbtn.UseVisualStyleBackColor = true;
            this.createNewbtn.Click += new System.EventHandler(this.createNewbtn_Click);
            // 
            // HouseKeepingDataGridView
            // 
            this.HouseKeepingDataGridView.AutoGenerateColumns = false;
            this.HouseKeepingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HouseKeepingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.EmployeeName,
            this.EmployeeLastName,
            this.RoomName,
            this.housekeepingDateDataGridViewTextBoxColumn,
            this.housekeepingStatusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.HouseKeepingDataGridView.DataSource = this.houseKeepingBindingSource;
            resources.ApplyResources(this.HouseKeepingDataGridView, "HouseKeepingDataGridView");
            this.HouseKeepingDataGridView.Name = "HouseKeepingDataGridView";
            this.HouseKeepingDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HouseKeepingDataGridView_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            resources.ApplyResources(this.EmployeeName, "EmployeeName");
            this.EmployeeName.Name = "EmployeeName";
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.DataPropertyName = "EmployeeLastName";
            resources.ApplyResources(this.EmployeeLastName, "EmployeeLastName");
            this.EmployeeLastName.Name = "EmployeeLastName";
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            resources.ApplyResources(this.RoomName, "RoomName");
            this.RoomName.Name = "RoomName";
            // 
            // housekeepingDateDataGridViewTextBoxColumn
            // 
            this.housekeepingDateDataGridViewTextBoxColumn.DataPropertyName = "HousekeepingDate";
            resources.ApplyResources(this.housekeepingDateDataGridViewTextBoxColumn, "housekeepingDateDataGridViewTextBoxColumn");
            this.housekeepingDateDataGridViewTextBoxColumn.Name = "housekeepingDateDataGridViewTextBoxColumn";
            // 
            // housekeepingStatusDataGridViewTextBoxColumn
            // 
            this.housekeepingStatusDataGridViewTextBoxColumn.DataPropertyName = "HousekeepingStatus";
            resources.ApplyResources(this.housekeepingStatusDataGridViewTextBoxColumn, "housekeepingStatusDataGridViewTextBoxColumn");
            this.housekeepingStatusDataGridViewTextBoxColumn.Name = "housekeepingStatusDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // houseKeepingBindingSource
            // 
            this.houseKeepingBindingSource.DataSource = typeof(HotelManagement.BO.HouseKeeping);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HouseKeepingMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.HouseKeepingDataGridView);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.createNewbtn);
            this.Name = "HouseKeepingMain";
            this.Load += new System.EventHandler(this.HouseKeepingMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HouseKeepingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button createNewbtn;
        private System.Windows.Forms.DataGridView HouseKeepingDataGridView;
        private System.Windows.Forms.BindingSource houseKeepingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeepingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeepingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}