namespace EmployeeManagementApplication
{
    partial class UpdateDepartment
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
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.deptIdTextBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(460, 120);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(291, 20);
            this.budgetTextBox.TabIndex = 12;
            // 
            // deptIdTextBox
            // 
            this.deptIdTextBox.Location = new System.Drawing.Point(460, 81);
            this.deptIdTextBox.Name = "deptIdTextBox";
            this.deptIdTextBox.Size = new System.Drawing.Size(291, 20);
            this.deptIdTextBox.TabIndex = 11;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(40, 120);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(61, 20);
            this.lastName.TabIndex = 10;
            this.lastName.Text = "Budget";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(40, 81);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(115, 20);
            this.firstName.TabIndex = 9;
            this.firstName.Text = "Department ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.deptIdTextBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "UpdateDepartment";
            this.Text = "UpdateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox deptIdTextBox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button button1;
    }
}