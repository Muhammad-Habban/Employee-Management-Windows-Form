namespace EmployeeManagementApplication
{
    partial class DeleteDepartment
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
            this.button1 = new System.Windows.Forms.Button();
            this.deptIdTextBox = new System.Windows.Forms.TextBox();
            this.deptId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Delete Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deptIdTextBox
            // 
            this.deptIdTextBox.Location = new System.Drawing.Point(443, 29);
            this.deptIdTextBox.Name = "deptIdTextBox";
            this.deptIdTextBox.Size = new System.Drawing.Size(291, 20);
            this.deptIdTextBox.TabIndex = 29;
            // 
            // deptId
            // 
            this.deptId.AutoSize = true;
            this.deptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptId.Location = new System.Drawing.Point(23, 29);
            this.deptId.Name = "deptId";
            this.deptId.Size = new System.Drawing.Size(115, 20);
            this.deptId.TabIndex = 28;
            this.deptId.Text = "Department ID";
            // 
            // DeleteDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deptIdTextBox);
            this.Controls.Add(this.deptId);
            this.Name = "DeleteDepartment";
            this.Text = "DeleteDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deptIdTextBox;
        private System.Windows.Forms.Label deptId;
    }
}