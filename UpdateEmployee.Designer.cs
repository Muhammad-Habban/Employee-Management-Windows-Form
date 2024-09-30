namespace EmployeeManagementApplication
{
    partial class UpdateEmployee
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
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.departmentName = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.employeeId = new System.Windows.Forms.Label();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(465, 252);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.departmentNameTextBox.TabIndex = 22;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(465, 213);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(291, 20);
            this.positionTextBox.TabIndex = 21;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(465, 176);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(291, 20);
            this.salaryTextBox.TabIndex = 20;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(465, 138);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.lastNameTextBox.TabIndex = 19;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(465, 99);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.firstNameTextBox.TabIndex = 18;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(45, 176);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(53, 20);
            this.salary.TabIndex = 17;
            this.salary.Text = "Salary";
            // 
            // departmentName
            // 
            this.departmentName.AutoSize = true;
            this.departmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentName.Location = new System.Drawing.Point(45, 252);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(140, 20);
            this.departmentName.TabIndex = 16;
            this.departmentName.Text = "Department Name";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(45, 213);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(65, 20);
            this.position.TabIndex = 15;
            this.position.Text = "Position";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(45, 138);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(86, 20);
            this.lastName.TabIndex = 14;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(45, 99);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(86, 20);
            this.firstName.TabIndex = 13;
            this.firstName.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeeId
            // 
            this.employeeId.AutoSize = true;
            this.employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeId.Location = new System.Drawing.Point(45, 59);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(100, 20);
            this.employeeId.TabIndex = 23;
            this.employeeId.Text = "Employee ID";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(465, 59);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(291, 20);
            this.employeeIdTextBox.TabIndex = 24;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.employeeId);
            this.Controls.Add(this.departmentNameTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.position);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.button1);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label departmentName;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label employeeId;
        private System.Windows.Forms.TextBox employeeIdTextBox;
    }
}