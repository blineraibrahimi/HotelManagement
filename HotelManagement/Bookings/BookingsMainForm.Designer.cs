namespace HotelManagement.Bookings
{
    partial class BookingsMainForm
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
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createNewbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.checkInDataGridViewTextBoxColumn,
            this.checkOutDataGridViewTextBoxColumn,
            this.rangeOfDaysDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.bookingDataGridView.DataSource = this.bookingsBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(12, 92);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.RowHeadersWidth = 51;
            this.bookingDataGridView.RowTemplate.Height = 24;
            this.bookingDataGridView.Size = new System.Drawing.Size(1179, 246);
            this.bookingDataGridView.TabIndex = 0;
            this.bookingDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookingDataGridView_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room no";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            this.checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn.HeaderText = "CheckIn Date";
            this.checkInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            this.checkInDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            this.checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn.HeaderText = "CheckOut Date";
            this.checkOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            this.checkOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // rangeOfDaysDataGridViewTextBoxColumn
            // 
            this.rangeOfDaysDataGridViewTextBoxColumn.DataPropertyName = "RangeOfDays";
            this.rangeOfDaysDataGridViewTextBoxColumn.HeaderText = "Range Of Days";
            this.rangeOfDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rangeOfDaysDataGridViewTextBoxColumn.Name = "rangeOfDaysDataGridViewTextBoxColumn";
            this.rangeOfDaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataSource = typeof(HotelManagement.BO.Bookings);
            // 
            // createNewbtn
            // 
            this.createNewbtn.Location = new System.Drawing.Point(962, 44);
            this.createNewbtn.Name = "createNewbtn";
            this.createNewbtn.Size = new System.Drawing.Size(172, 31);
            this.createNewbtn.TabIndex = 3;
            this.createNewbtn.Text = "Create New";
            this.createNewbtn.UseVisualStyleBackColor = true;
            this.createNewbtn.Click += new System.EventHandler(this.createNewbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(962, 366);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(172, 31);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(773, 366);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(172, 31);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // BookingsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 421);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.createNewbtn);
            this.Controls.Add(this.bookingDataGridView);
            this.Name = "BookingsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.BookingsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeOfDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private System.Windows.Forms.Button createNewbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
    }
}