namespace EmployeeManagementApplication
{
    partial class ViewAllDepartments
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
            this.dataGridViewAllDepts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDepts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllDepts
            // 
            this.dataGridViewAllDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllDepts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAllDepts.Name = "dataGridViewAllDepts";
            this.dataGridViewAllDepts.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewAllDepts.TabIndex = 0;
            // 
            // ViewAllDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAllDepts);
            this.Name = "ViewAllDepartments";
            this.Text = "ViewAllDepartments";
            this.Load += new System.EventHandler(this.ViewAllDepartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDepts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllDepts;
    }
}