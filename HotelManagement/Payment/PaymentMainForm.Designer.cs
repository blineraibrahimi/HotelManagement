namespace HotelManagement.Payment
{
    partial class PaymentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMainForm));
            this.paymentDVG = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentDVG
            // 
            this.paymentDVG.AutoGenerateColumns = false;
            this.paymentDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.BookingID,
            this.amountDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.paymentDetailsDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.paymentDVG.DataSource = this.paymentsBindingSource;
            this.paymentDVG.Location = new System.Drawing.Point(12, 26);
            this.paymentDVG.Name = "paymentDVG";
            this.paymentDVG.RowHeadersWidth = 51;
            this.paymentDVG.RowTemplate.Height = 24;
            this.paymentDVG.Size = new System.Drawing.Size(948, 322);
            this.paymentDVG.TabIndex = 0;
            this.paymentDVG.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.paymentDVG_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // BookingID
            // 
            this.BookingID.DataPropertyName = "BookingID";
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.MinimumWidth = 6;
            this.BookingID.Name = "BookingID";
            this.BookingID.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment Type";
            this.paymentTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDetailsDataGridViewTextBoxColumn
            // 
            this.paymentDetailsDataGridViewTextBoxColumn.DataPropertyName = "PaymentDetails";
            this.paymentDetailsDataGridViewTextBoxColumn.HeaderText = "Payment Details";
            this.paymentDetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDetailsDataGridViewTextBoxColumn.Name = "paymentDetailsDataGridViewTextBoxColumn";
            this.paymentDetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.Width = 125;
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
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataSource = typeof(HotelManagement.BO.Payments);
            // 
            // deletebtn
            // 
            this.deletebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deletebtn.Location = new System.Drawing.Point(555, 366);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(172, 31);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updatebtn.Location = new System.Drawing.Point(747, 366);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(172, 31);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // PaymentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 418);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.paymentDVG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.PaymentMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentDVG;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}