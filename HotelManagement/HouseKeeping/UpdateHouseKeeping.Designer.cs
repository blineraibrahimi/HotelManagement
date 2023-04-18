namespace HotelManagement.HouseKeeping
{
    partial class UpdateHouseKeeping
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
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.houseKeepingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.empUpdatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRoom
            // 
            this.cmbRoom.DisplayMember = "ID";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(203, 142);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(241, 24);
            this.cmbRoom.TabIndex = 86;
            this.cmbRoom.ValueMember = "ID";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(203, 92);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(241, 24);
            this.cmbEmployee.TabIndex = 85;
            // 
            // houseKeepingDatePicker
            // 
            this.houseKeepingDatePicker.Location = new System.Drawing.Point(203, 188);
            this.houseKeepingDatePicker.Name = "houseKeepingDatePicker";
            this.houseKeepingDatePicker.Size = new System.Drawing.Size(241, 22);
            this.houseKeepingDatePicker.TabIndex = 84;
            this.houseKeepingDatePicker.Value = new System.DateTime(2023, 4, 17, 17, 39, 6, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 32);
            this.label9.TabIndex = 82;
            this.label9.Text = "Update Housekeeping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(203, 279);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(241, 22);
            this.txtDescription.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Room Status";
            // 
            // txtRoomStatus
            // 
            this.txtRoomStatus.Location = new System.Drawing.Point(203, 236);
            this.txtRoomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomStatus.Name = "txtRoomStatus";
            this.txtRoomStatus.Size = new System.Drawing.Size(241, 22);
            this.txtRoomStatus.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Room ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Employee Name";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(66, 340);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(172, 31);
            this.cancelbtn.TabIndex = 88;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // empUpdatebtn
            // 
            this.empUpdatebtn.Location = new System.Drawing.Point(272, 340);
            this.empUpdatebtn.Name = "empUpdatebtn";
            this.empUpdatebtn.Size = new System.Drawing.Size(172, 31);
            this.empUpdatebtn.TabIndex = 87;
            this.empUpdatebtn.Text = "Update";
            this.empUpdatebtn.UseVisualStyleBackColor = true;
            this.empUpdatebtn.Click += new System.EventHandler(this.empUpdatebtn_Click);
            // 
            // UpdateHouseKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 401);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.empUpdatebtn);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.houseKeepingDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoomStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateHouseKeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update HouseKeeping";
            this.Load += new System.EventHandler(this.UpdateHouseKeeping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.DateTimePicker houseKeepingDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button empUpdatebtn;
    }
}