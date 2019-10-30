namespace CRM
{
    partial class addCustomerForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.postalCodeTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.streetAddressTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.countryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Postal Code:";
            // 
            // postalCodeTextbox
            // 
            this.postalCodeTextbox.Location = new System.Drawing.Point(121, 199);
            this.postalCodeTextbox.Name = "postalCodeTextbox";
            this.postalCodeTextbox.Size = new System.Drawing.Size(203, 20);
            this.postalCodeTextbox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Full Name";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(121, 64);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(203, 20);
            this.NameTextbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Street Address:";
            // 
            // streetAddressTextbox
            // 
            this.streetAddressTextbox.Location = new System.Drawing.Point(121, 109);
            this.streetAddressTextbox.Name = "streetAddressTextbox";
            this.streetAddressTextbox.Size = new System.Drawing.Size(203, 20);
            this.streetAddressTextbox.TabIndex = 15;
            this.streetAddressTextbox.TextChanged += new System.EventHandler(this.streetAddressTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Phone Number:";
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(121, 319);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(203, 20);
            this.phoneNumberTextbox.TabIndex = 24;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(274, 365);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(177, 365);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "City:";
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(121, 155);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(203, 20);
            this.cityTextbox.TabIndex = 32;
            // 
            // countryDataGridView
            // 
            this.countryDataGridView.AllowUserToAddRows = false;
            this.countryDataGridView.AllowUserToDeleteRows = false;
            this.countryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.countryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGridView.ColumnHeadersVisible = false;
            this.countryDataGridView.Location = new System.Drawing.Point(121, 239);
            this.countryDataGridView.MultiSelect = false;
            this.countryDataGridView.Name = "countryDataGridView";
            this.countryDataGridView.ReadOnly = true;
            this.countryDataGridView.RowHeadersVisible = false;
            this.countryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.countryDataGridView.Size = new System.Drawing.Size(203, 61);
            this.countryDataGridView.TabIndex = 34;
            // 
            // addCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 404);
            this.Controls.Add(this.countryDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.postalCodeTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.streetAddressTextbox);
            this.Name = "addCustomerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.addCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox postalCodeTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox streetAddressTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.DataGridView countryDataGridView;
    }
}