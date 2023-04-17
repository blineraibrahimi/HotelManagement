namespace HotelManagement.Bookings
{
    partial class RegisterBooking
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
            this.bookRegisterbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRangeOfDays = new System.Windows.Forms.TextBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.bookingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bookRegisterbtn
            // 
            this.bookRegisterbtn.Location = new System.Drawing.Point(170, 506);
            this.bookRegisterbtn.Name = "bookRegisterbtn";
            this.bookRegisterbtn.Size = new System.Drawing.Size(172, 31);
            this.bookRegisterbtn.TabIndex = 70;
            this.bookRegisterbtn.Text = "Register";
            this.bookRegisterbtn.UseVisualStyleBackColor = true;
            this.bookRegisterbtn.Click += new System.EventHandler(this.bookRegisterbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(162, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 32);
            this.label9.TabIndex = 69;
            this.label9.Text = "Book a room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(202, 464);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(242, 22);
            this.txtDescription.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Days of stay";
            // 
            // txtRangeOfDays
            // 
            this.txtRangeOfDays.Location = new System.Drawing.Point(202, 333);
            this.txtRangeOfDays.Name = "txtRangeOfDays";
            this.txtRangeOfDays.Size = new System.Drawing.Size(242, 22);
            this.txtRangeOfDays.TabIndex = 65;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DisplayMember = "ID";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(202, 143);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(241, 24);
            this.cmbRoom.TabIndex = 80;
            this.cmbRoom.ValueMember = "ID";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(202, 93);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(241, 24);
            this.cmbEmployee.TabIndex = 79;
            // 
            // bookingDatePicker
            // 
            this.bookingDatePicker.Location = new System.Drawing.Point(202, 189);
            this.bookingDatePicker.Name = "bookingDatePicker";
            this.bookingDatePicker.Size = new System.Drawing.Size(241, 22);
            this.bookingDatePicker.TabIndex = 78;
            this.bookingDatePicker.Value = new System.DateTime(2023, 4, 17, 17, 39, 6, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "Booking date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Room ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "Employee Name";
            // 
            // checkInDatePicker
            // 
            this.checkInDatePicker.Location = new System.Drawing.Point(201, 236);
            this.checkInDatePicker.Name = "checkInDatePicker";
            this.checkInDatePicker.Size = new System.Drawing.Size(241, 22);
            this.checkInDatePicker.TabIndex = 82;
            this.checkInDatePicker.Value = new System.DateTime(2023, 4, 17, 17, 39, 6, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Checkin date";
            // 
            // checkOutDatePicker
            // 
            this.checkOutDatePicker.Location = new System.Drawing.Point(201, 288);
            this.checkOutDatePicker.Name = "checkOutDatePicker";
            this.checkOutDatePicker.Size = new System.Drawing.Size(241, 22);
            this.checkOutDatePicker.TabIndex = 84;
            this.checkOutDatePicker.Value = new System.DateTime(2023, 4, 17, 17, 39, 6, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Checkout date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Total cost";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(201, 376);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(242, 22);
            this.txtTotalCost.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(202, 421);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(242, 22);
            this.txtStatus.TabIndex = 87;
            // 
            // RegisterBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.checkOutDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkInDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.bookingDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bookRegisterbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRangeOfDays);
            this.Name = "RegisterBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Booking";
            this.Load += new System.EventHandler(this.RegisterBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookRegisterbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRangeOfDays;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.DateTimePicker bookingDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker checkInDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker checkOutDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
    }
}