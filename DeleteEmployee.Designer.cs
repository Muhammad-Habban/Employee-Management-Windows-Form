namespace EmployeeManagementApplication
{
    partial class DeleteEmployee
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
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.employeeId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(448, 42);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(291, 20);
            this.employeeIdTextBox.TabIndex = 26;
            // 
            // employeeId
            // 
            this.employeeId.AutoSize = true;
            this.employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeId.Location = new System.Drawing.Point(28, 42);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(100, 20);
            this.employeeId.TabIndex = 25;
            this.employeeId.Text = "Employee ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Delete Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.employeeId);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.Label employeeId;
        private System.Windows.Forms.Button button1;
    }
}