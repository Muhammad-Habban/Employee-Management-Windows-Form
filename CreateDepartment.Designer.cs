namespace EmployeeManagementApplication
{
    partial class CreateDepartment
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
            this.deptNameTextBox = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(465, 138);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(291, 20);
            this.budgetTextBox.TabIndex = 20;
            // 
            // deptNameTextBox
            // 
            this.deptNameTextBox.Location = new System.Drawing.Point(465, 98);
            this.deptNameTextBox.Name = "deptNameTextBox";
            this.deptNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.deptNameTextBox.TabIndex = 18;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(45, 138);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(61, 20);
            this.salary.TabIndex = 17;
            this.salary.Text = "Budget";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(45, 98);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(140, 20);
            this.firstName.TabIndex = 13;
            this.firstName.Text = "Department Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.deptNameTextBox);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.button1);
            this.Name = "CreateDepartment";
            this.Text = "CreateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox deptNameTextBox;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button button1;
    }
}