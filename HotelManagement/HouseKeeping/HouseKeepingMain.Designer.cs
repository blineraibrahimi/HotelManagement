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
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.createNewbtn = new System.Windows.Forms.Button();
            this.HouseKeepingDataGridView = new System.Windows.Forms.DataGridView();
            this.houseKeepingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HouseKeepingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(588, 362);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(129, 25);
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(447, 362);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(129, 25);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // createNewbtn
            // 
            this.createNewbtn.Location = new System.Drawing.Point(588, 63);
            this.createNewbtn.Margin = new System.Windows.Forms.Padding(2);
            this.createNewbtn.Name = "createNewbtn";
            this.createNewbtn.Size = new System.Drawing.Size(129, 25);
            this.createNewbtn.TabIndex = 7;
            this.createNewbtn.Text = "Create New";
            this.createNewbtn.UseVisualStyleBackColor = true;
            this.createNewbtn.Click += new System.EventHandler(this.createNewbtn_Click);
            // 
            // HouseKeepingDataGridView
            // 
            this.HouseKeepingDataGridView.AutoGenerateColumns = false;
            this.HouseKeepingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HouseKeepingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.housekeepingDateDataGridViewTextBoxColumn,
            this.housekeepingStatusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.HouseKeepingDataGridView.DataSource = this.houseKeepingBindingSource;
            this.HouseKeepingDataGridView.Location = new System.Drawing.Point(47, 146);
            this.HouseKeepingDataGridView.Name = "HouseKeepingDataGridView";
            this.HouseKeepingDataGridView.Size = new System.Drawing.Size(644, 150);
            this.HouseKeepingDataGridView.TabIndex = 10;
            this.HouseKeepingDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HouseKeepingDataGridView_RowHeaderMouseClick);
            // 
            // houseKeepingBindingSource
            // 
            this.houseKeepingBindingSource.DataSource = typeof(HotelManagement.BO.HouseKeeping);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            // 
            // housekeepingDateDataGridViewTextBoxColumn
            // 
            this.housekeepingDateDataGridViewTextBoxColumn.DataPropertyName = "HousekeepingDate";
            this.housekeepingDateDataGridViewTextBoxColumn.HeaderText = "HousekeepingDate";
            this.housekeepingDateDataGridViewTextBoxColumn.Name = "housekeepingDateDataGridViewTextBoxColumn";
            // 
            // housekeepingStatusDataGridViewTextBoxColumn
            // 
            this.housekeepingStatusDataGridViewTextBoxColumn.DataPropertyName = "HousekeepingStatus";
            this.housekeepingStatusDataGridViewTextBoxColumn.HeaderText = "HousekeepingStatus";
            this.housekeepingStatusDataGridViewTextBoxColumn.Name = "housekeepingStatusDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // HouseKeepingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HouseKeepingDataGridView);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.createNewbtn);
            this.Name = "HouseKeepingMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HouseKeeping";
            this.Load += new System.EventHandler(this.HouseKeepingMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HouseKeepingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button createNewbtn;
        private System.Windows.Forms.DataGridView HouseKeepingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeepingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeepingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource houseKeepingBindingSource;
    }
}