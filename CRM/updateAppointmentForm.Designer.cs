namespace CRM
{
    partial class updateAppointmentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.typeTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.typeTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.urlTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.locationTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.descriptionTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.titleTextbox);
            this.groupBox1.Controls.Add(this.customerDataGridView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.contactTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 534);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(111, 487);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.endDateTimePicker.TabIndex = 22;
            this.endDateTimePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(111, 446);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.startDateTimePicker.TabIndex = 21;
            this.startDateTimePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "End:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Type:";
            // 
            // typeTextbox
            // 
            this.typeTextbox.Location = new System.Drawing.Point(111, 412);
            this.typeTextbox.Name = "typeTextbox";
            this.typeTextbox.Size = new System.Drawing.Size(203, 20);
            this.typeTextbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "URL:";
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(111, 372);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(203, 20);
            this.urlTextbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Start:";
            // 
            // locationTextbox
            // 
            this.locationTextbox.Location = new System.Drawing.Point(111, 285);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(203, 20);
            this.locationTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(111, 180);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(203, 84);
            this.descriptionTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title:";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(111, 136);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(203, 20);
            this.titleTextbox.TabIndex = 5;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToResizeColumns = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(111, 29);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(203, 84);
            this.customerDataGridView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Customer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact:";
            // 
            // contactTextbox
            // 
            this.contactTextbox.Location = new System.Drawing.Point(111, 330);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(203, 20);
            this.contactTextbox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(286, 553);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(180, 553);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 583);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "updateAppointmentForm";
            this.Text = "Update Appointment";
            this.Load += new System.EventHandler(this.updateAppointmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}