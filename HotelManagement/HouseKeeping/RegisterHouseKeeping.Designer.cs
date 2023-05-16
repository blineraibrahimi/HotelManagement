using System;

namespace HotelManagement.HouseKeeping
{
    partial class RegisterHouseKeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterHouseKeeping));
            this.hsRegisterbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.houseKeepingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHouseKeepingStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hsRegisterbtn
            // 
            this.hsRegisterbtn.Location = new System.Drawing.Point(159, 331);
            this.hsRegisterbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hsRegisterbtn.Name = "hsRegisterbtn";
            this.hsRegisterbtn.Size = new System.Drawing.Size(172, 31);
            this.hsRegisterbtn.TabIndex = 70;
            this.hsRegisterbtn.Text = "Register";
            this.hsRegisterbtn.UseVisualStyleBackColor = true;
            this.hsRegisterbtn.Click += new System.EventHandler(this.hsRegisterbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 32);
            this.label9.TabIndex = 69;
            this.label9.Text = "Register Housekeeping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(200, 276);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(241, 22);
            this.txtDescription.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Room Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Room ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Employee Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // houseKeepingDatePicker
            // 
            this.houseKeepingDatePicker.Location = new System.Drawing.Point(200, 185);
            this.houseKeepingDatePicker.Name = "houseKeepingDatePicker";
            this.houseKeepingDatePicker.Size = new System.Drawing.Size(241, 22);
            this.houseKeepingDatePicker.TabIndex = 72;
            this.houseKeepingDatePicker.Value = new System.DateTime(2023, 5, 14, 14, 38, 23, 949);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(200, 89);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(241, 24);
            this.cmbEmployee.TabIndex = 73;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.roomBindingSource;
            this.cmbRoom.DisplayMember = "ID";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(200, 139);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(241, 24);
            this.cmbRoom.TabIndex = 74;
            this.cmbRoom.ValueMember = "ID";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(HotelManagement.BO.Room);
            // 
            // cmbHouseKeepingStatus
            // 
            this.cmbHouseKeepingStatus.FormattingEnabled = true;
            this.cmbHouseKeepingStatus.Items.AddRange(new object[] {
            "Cleaned",
            "Occupied",
            "Vacant",
            "Do not disturb",
            "Inspected",
            "Out of Order",
            "Ready"});
            this.cmbHouseKeepingStatus.Location = new System.Drawing.Point(200, 230);
            this.cmbHouseKeepingStatus.Name = "cmbHouseKeepingStatus";
            this.cmbHouseKeepingStatus.Size = new System.Drawing.Size(241, 24);
            this.cmbHouseKeepingStatus.TabIndex = 90;
            // 
            // RegisterHouseKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 378);
            this.Controls.Add(this.cmbHouseKeepingStatus);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.houseKeepingDatePicker);
            this.Controls.Add(this.hsRegisterbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterHouseKeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register HouseKeeping";
            this.Load += new System.EventHandler(this.RegisterHouseKeeping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hsRegisterbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker houseKeepingDatePicker;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.ComboBox cmbHouseKeepingStatus;
    }
}