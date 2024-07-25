
namespace MutualFundApplication
{
    partial class LoginForm
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
            this.textBox_UsernameL = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PasswordL = new System.Windows.Forms.TextBox();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBox_UsernameL
            // 
            this.textBox_UsernameL.Location = new System.Drawing.Point(217, 127);
            this.textBox_UsernameL.Name = "textBox_UsernameL";
            this.textBox_UsernameL.Size = new System.Drawing.Size(194, 28);
            this.textBox_UsernameL.TabIndex = 1;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.White;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(84, 270);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(139, 48);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOGIN FORM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_PasswordL
            // 
            this.textBox_PasswordL.Location = new System.Drawing.Point(217, 198);
            this.textBox_PasswordL.Name = "textBox_PasswordL";
            this.textBox_PasswordL.PasswordChar = '*';
            this.textBox_PasswordL.Size = new System.Drawing.Size(194, 28);
            this.textBox_PasswordL.TabIndex = 2;
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.BackColor = System.Drawing.Color.White;
            this.Btn_Reg.Location = new System.Drawing.Point(272, 270);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(139, 48);
            this.Btn_Reg.TabIndex = 8;
            this.Btn_Reg.Text = "Registration";
            this.Btn_Reg.UseVisualStyleBackColor = false;
            this.Btn_Reg.Click += new System.EventHandler(this.Btn_Reg_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 411);
            this.Controls.Add(this.Btn_Reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.textBox_PasswordL);
            this.Controls.Add(this.textBox_UsernameL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UsernameL;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PasswordL;
        private System.Windows.Forms.Button Btn_Reg;
    }
}