namespace CRM
{
    partial class reminderForm
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
            this.reminderDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reminderDataGridView
            // 
            this.reminderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reminderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reminderDataGridView.Location = new System.Drawing.Point(0, 1);
            this.reminderDataGridView.Name = "reminderDataGridView";
            this.reminderDataGridView.ReadOnly = true;
            this.reminderDataGridView.RowHeadersVisible = false;
            this.reminderDataGridView.Size = new System.Drawing.Size(541, 264);
            this.reminderDataGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(433, 271);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(97, 26);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // reminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 303);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reminderDataGridView);
            this.Name = "reminderForm";
            this.Text = "Reminder ";
            this.Load += new System.EventHandler(this.reminderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reminderDataGridView;
        private System.Windows.Forms.Button closeButton;
    }
}