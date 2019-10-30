namespace CRM
{
    partial class mainForm
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
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.totalCreatedAppointmentsButton = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.appointmentClearSearchButton = new System.Windows.Forms.Button();
            this.searchAppointmentButton = new System.Windows.Forms.Button();
            this.searchAppointmentTextbox = new System.Windows.Forms.TextBox();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.updateAppointmentButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerClearSearchButton = new System.Windows.Forms.Button();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.searchCustomerTextbox = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.appointmentTypeReportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultantSchedulesReportButton = new System.Windows.Forms.Button();
            this.CustomersAddedReportButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.totalCreatedAppointmentsButton.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(8, 52);
            this.appointmentDataGridView.MultiSelect = false;
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.RowHeadersVisible = false;
            this.appointmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDataGridView.Size = new System.Drawing.Size(562, 309);
            this.appointmentDataGridView.TabIndex = 0;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upcoming Appointments";
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Location = new System.Drawing.Point(49, 9);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(91, 17);
            this.weekRadioButton.TabIndex = 2;
            this.weekRadioButton.Text = "Current Week";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.CheckedChanged += new System.EventHandler(this.weekRadioButton_CheckedChanged);
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(161, 9);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(92, 17);
            this.monthRadioButton.TabIndex = 3;
            this.monthRadioButton.Text = "Current Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allRadioButton);
            this.groupBox1.Controls.Add(this.monthRadioButton);
            this.groupBox1.Controls.Add(this.weekRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(83, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 35);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(277, 9);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(103, 17);
            this.allRadioButton.TabIndex = 4;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All Appointments";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // totalCreatedAppointmentsButton
            // 
            this.totalCreatedAppointmentsButton.Controls.Add(this.groupBox5);
            this.totalCreatedAppointmentsButton.Controls.Add(this.deleteAppointmentButton);
            this.totalCreatedAppointmentsButton.Controls.Add(this.updateAppointmentButton);
            this.totalCreatedAppointmentsButton.Controls.Add(this.addAppointmentButton);
            this.totalCreatedAppointmentsButton.Controls.Add(this.groupBox1);
            this.totalCreatedAppointmentsButton.Controls.Add(this.label1);
            this.totalCreatedAppointmentsButton.Controls.Add(this.appointmentDataGridView);
            this.totalCreatedAppointmentsButton.Location = new System.Drawing.Point(698, 12);
            this.totalCreatedAppointmentsButton.Name = "totalCreatedAppointmentsButton";
            this.totalCreatedAppointmentsButton.Size = new System.Drawing.Size(678, 465);
            this.totalCreatedAppointmentsButton.TabIndex = 5;
            this.totalCreatedAppointmentsButton.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.appointmentClearSearchButton);
            this.groupBox5.Controls.Add(this.searchAppointmentButton);
            this.groupBox5.Controls.Add(this.searchAppointmentTextbox);
            this.groupBox5.Location = new System.Drawing.Point(100, 367);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 46);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // appointmentClearSearchButton
            // 
            this.appointmentClearSearchButton.Location = new System.Drawing.Point(295, 12);
            this.appointmentClearSearchButton.Name = "appointmentClearSearchButton";
            this.appointmentClearSearchButton.Size = new System.Drawing.Size(75, 23);
            this.appointmentClearSearchButton.TabIndex = 15;
            this.appointmentClearSearchButton.Text = "Clear";
            this.appointmentClearSearchButton.UseVisualStyleBackColor = true;
            this.appointmentClearSearchButton.Click += new System.EventHandler(this.appointmentClearSearchButton_Click);
            // 
            // searchAppointmentButton
            // 
            this.searchAppointmentButton.Location = new System.Drawing.Point(214, 12);
            this.searchAppointmentButton.Name = "searchAppointmentButton";
            this.searchAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.searchAppointmentButton.TabIndex = 13;
            this.searchAppointmentButton.Text = "Search";
            this.searchAppointmentButton.UseVisualStyleBackColor = true;
            this.searchAppointmentButton.Click += new System.EventHandler(this.searchAppointmentButton_Click);
            // 
            // searchAppointmentTextbox
            // 
            this.searchAppointmentTextbox.Location = new System.Drawing.Point(6, 15);
            this.searchAppointmentTextbox.Name = "searchAppointmentTextbox";
            this.searchAppointmentTextbox.Size = new System.Drawing.Size(202, 20);
            this.searchAppointmentTextbox.TabIndex = 12;
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(576, 178);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(91, 23);
            this.deleteAppointmentButton.TabIndex = 8;
            this.deleteAppointmentButton.Text = "Delete";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.deleteAppointmentButton_Click);
            // 
            // updateAppointmentButton
            // 
            this.updateAppointmentButton.Location = new System.Drawing.Point(576, 120);
            this.updateAppointmentButton.Name = "updateAppointmentButton";
            this.updateAppointmentButton.Size = new System.Drawing.Size(91, 23);
            this.updateAppointmentButton.TabIndex = 7;
            this.updateAppointmentButton.Text = "Update";
            this.updateAppointmentButton.UseVisualStyleBackColor = true;
            this.updateAppointmentButton.Click += new System.EventHandler(this.updateAppointmentButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(576, 52);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(91, 23);
            this.addAppointmentButton.TabIndex = 6;
            this.addAppointmentButton.Text = "Add ";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(8, 52);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(562, 309);
            this.customerDataGridView.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customers";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(576, 178);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(91, 23);
            this.deleteCustomerButton.TabIndex = 11;
            this.deleteCustomerButton.Text = "Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(576, 120);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(91, 23);
            this.updateCustomerButton.TabIndex = 10;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(576, 52);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(91, 23);
            this.addCustomerButton.TabIndex = 9;
            this.addCustomerButton.Text = "Add ";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.deleteCustomerButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.updateCustomerButton);
            this.groupBox3.Controls.Add(this.customerDataGridView);
            this.groupBox3.Controls.Add(this.addCustomerButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 420);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerClearSearchButton);
            this.groupBox2.Controls.Add(this.searchCustomerButton);
            this.groupBox2.Controls.Add(this.searchCustomerTextbox);
            this.groupBox2.Location = new System.Drawing.Point(100, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 46);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // customerClearSearchButton
            // 
            this.customerClearSearchButton.Location = new System.Drawing.Point(296, 12);
            this.customerClearSearchButton.Name = "customerClearSearchButton";
            this.customerClearSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerClearSearchButton.TabIndex = 14;
            this.customerClearSearchButton.Text = "Clear";
            this.customerClearSearchButton.UseVisualStyleBackColor = true;
            this.customerClearSearchButton.Click += new System.EventHandler(this.customerClearSearchButton_Click);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.Location = new System.Drawing.Point(214, 12);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.searchCustomerButton.TabIndex = 13;
            this.searchCustomerButton.Text = "Search";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.searchCustomerButton_Click);
            // 
            // searchCustomerTextbox
            // 
            this.searchCustomerTextbox.Location = new System.Drawing.Point(6, 15);
            this.searchCustomerTextbox.Name = "searchCustomerTextbox";
            this.searchCustomerTextbox.Size = new System.Drawing.Size(202, 20);
            this.searchCustomerTextbox.TabIndex = 12;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1285, 483);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // appointmentTypeReportButton
            // 
            this.appointmentTypeReportButton.Location = new System.Drawing.Point(89, 10);
            this.appointmentTypeReportButton.Name = "appointmentTypeReportButton";
            this.appointmentTypeReportButton.Size = new System.Drawing.Size(161, 23);
            this.appointmentTypeReportButton.TabIndex = 14;
            this.appointmentTypeReportButton.Text = "Appointment Types By Month";
            this.appointmentTypeReportButton.UseVisualStyleBackColor = true;
            this.appointmentTypeReportButton.Click += new System.EventHandler(this.appointmentTypeReportButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reports:";
            // 
            // ConsultantSchedulesReportButton
            // 
            this.ConsultantSchedulesReportButton.Location = new System.Drawing.Point(256, 10);
            this.ConsultantSchedulesReportButton.Name = "ConsultantSchedulesReportButton";
            this.ConsultantSchedulesReportButton.Size = new System.Drawing.Size(161, 23);
            this.ConsultantSchedulesReportButton.TabIndex = 16;
            this.ConsultantSchedulesReportButton.Text = "Consultant Schedules";
            this.ConsultantSchedulesReportButton.UseVisualStyleBackColor = true;
            this.ConsultantSchedulesReportButton.Click += new System.EventHandler(this.ConsultantSchedulesReportButton_Click);
            // 
            // CustomersAddedReportButton
            // 
            this.CustomersAddedReportButton.Location = new System.Drawing.Point(423, 10);
            this.CustomersAddedReportButton.Name = "CustomersAddedReportButton";
            this.CustomersAddedReportButton.Size = new System.Drawing.Size(161, 23);
            this.CustomersAddedReportButton.TabIndex = 17;
            this.CustomersAddedReportButton.Text = "Total Created Appointments ";
            this.CustomersAddedReportButton.UseVisualStyleBackColor = true;
            this.CustomersAddedReportButton.Click += new System.EventHandler(this.CustomersAddedReportButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CustomersAddedReportButton);
            this.groupBox4.Controls.Add(this.ConsultantSchedulesReportButton);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.appointmentTypeReportButton);
            this.groupBox4.Location = new System.Drawing.Point(20, 438);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(599, 39);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 512);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.totalCreatedAppointmentsButton);
            this.Name = "mainForm";
            this.Text = "AgendaCRM";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.totalCreatedAppointmentsButton.ResumeLayout(false);
            this.totalCreatedAppointmentsButton.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox totalCreatedAppointmentsButton;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Button updateAppointmentButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button appointmentTypeReportButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConsultantSchedulesReportButton;
        private System.Windows.Forms.Button CustomersAddedReportButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button searchAppointmentButton;
        private System.Windows.Forms.TextBox searchAppointmentTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.TextBox searchCustomerTextbox;
        private System.Windows.Forms.Button appointmentClearSearchButton;
        private System.Windows.Forms.Button customerClearSearchButton;
    }
}

