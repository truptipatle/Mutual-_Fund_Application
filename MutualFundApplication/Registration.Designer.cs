
namespace MutualFundApplication
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.Reg_Btn = new System.Windows.Forms.Button();
            this.GoToLogin_Lbl = new System.Windows.Forms.Label();
            this.alert_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(699, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Registration";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(269, 101);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(238, 28);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(269, 165);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(238, 28);
            this.textBox_Username.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(269, 231);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(238, 28);
            this.textBox_Password.TabIndex = 3;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(269, 298);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(238, 28);
            this.textBox_Age.TabIndex = 4;
            // 
            // Reg_Btn
            // 
            this.Reg_Btn.BackColor = System.Drawing.Color.White;
            this.Reg_Btn.Location = new System.Drawing.Point(269, 355);
            this.Reg_Btn.Name = "Reg_Btn";
            this.Reg_Btn.Size = new System.Drawing.Size(238, 38);
            this.Reg_Btn.TabIndex = 5;
            this.Reg_Btn.Text = "Register";
            this.Reg_Btn.UseVisualStyleBackColor = false;
            this.Reg_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoToLogin_Lbl
            // 
            this.GoToLogin_Lbl.AutoSize = true;
            this.GoToLogin_Lbl.Location = new System.Drawing.Point(6, 54);
            this.GoToLogin_Lbl.Name = "GoToLogin_Lbl";
            this.GoToLogin_Lbl.Size = new System.Drawing.Size(111, 24);
            this.GoToLogin_Lbl.TabIndex = 6;
            this.GoToLogin_Lbl.Text = "User Login";
            this.GoToLogin_Lbl.Click += new System.EventHandler(this.GoToLogin_Lbl_Click);
            // 
            // alert_lbl
            // 
            this.alert_lbl.Location = new System.Drawing.Point(132, 408);
            this.alert_lbl.Name = "alert_lbl";
            this.alert_lbl.Size = new System.Drawing.Size(375, 32);
            this.alert_lbl.TabIndex = 7;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 449);
            this.Controls.Add(this.alert_lbl);
            this.Controls.Add(this.GoToLogin_Lbl);
            this.Controls.Add(this.Reg_Btn);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.Button Reg_Btn;
        private System.Windows.Forms.Label GoToLogin_Lbl;
        private System.Windows.Forms.Label alert_lbl;
    }
}