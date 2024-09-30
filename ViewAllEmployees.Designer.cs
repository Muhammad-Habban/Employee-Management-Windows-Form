namespace EmployeeManagementApplication
{
    partial class ViewAllEmployees
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
            this.dataGridViewAllEmps = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllEmps
            // 
            this.dataGridViewAllEmps.AccessibleDescription = "dataGridViewAllEmps";
            this.dataGridViewAllEmps.AccessibleName = "dataGridViewAllEmps";
            this.dataGridViewAllEmps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAllEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllEmps.Location = new System.Drawing.Point(22, 12);
            this.dataGridViewAllEmps.Name = "dataGridViewAllEmps";
            this.dataGridViewAllEmps.Size = new System.Drawing.Size(617, 349);
            this.dataGridViewAllEmps.TabIndex = 0;
            // 
            // ViewAllEmployees
            // 
            this.ClientSize = new System.Drawing.Size(666, 386);
            this.Controls.Add(this.dataGridViewAllEmps);
            this.Name = "ViewAllEmployees";
            this.Text = "View All Employees";
            this.Load += new System.EventHandler(this.ViewAllEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllEmps;
    }
}