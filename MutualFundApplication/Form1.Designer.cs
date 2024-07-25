
namespace MutualFundApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
       /// <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Insert_Btn = new System.Windows.Forms.Button();
            this.textBox_folio = new System.Windows.Forms.TextBox();
            this.textBox_Scheme = new System.Windows.Forms.TextBox();
            this.textBox_Unit = new System.Windows.Forms.TextBox();
            this.textBox_NAV = new System.Windows.Forms.TextBox();
            this.Modify_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Amount_Lbl = new System.Windows.Forms.Label();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalAmount_Lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DTP_Lbl = new System.Windows.Forms.Label();
            this.Btn_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Net Assest Value";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Units";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Scheme Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Folio Number";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1202, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "MUTUAL FUND APPLICATION";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 525);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount";
            // 
            // Insert_Btn
            // 
            this.Insert_Btn.BackColor = System.Drawing.Color.White;
            this.Insert_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_Btn.Location = new System.Drawing.Point(461, 506);
            this.Insert_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Insert_Btn.Name = "Insert_Btn";
            this.Insert_Btn.Size = new System.Drawing.Size(130, 41);
            this.Insert_Btn.TabIndex = 7;
            this.Insert_Btn.Text = "&Insert";
            this.Insert_Btn.UseVisualStyleBackColor = false;
            this.Insert_Btn.Click += new System.EventHandler(this.Insert_Btn_Click);
            // 
            // textBox_folio
            // 
            this.textBox_folio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_folio.Location = new System.Drawing.Point(214, 136);
            this.textBox_folio.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_folio.Name = "textBox_folio";
            this.textBox_folio.Size = new System.Drawing.Size(153, 27);
            this.textBox_folio.TabIndex = 1;
            this.textBox_folio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_folio_KeyPress);
            // 
            // textBox_Scheme
            // 
            this.textBox_Scheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Scheme.Location = new System.Drawing.Point(214, 209);
            this.textBox_Scheme.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Scheme.Name = "textBox_Scheme";
            this.textBox_Scheme.Size = new System.Drawing.Size(153, 27);
            this.textBox_Scheme.TabIndex = 2;
            this.textBox_Scheme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Scheme_KeyPress);
            // 
            // textBox_Unit
            // 
            this.textBox_Unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Unit.Location = new System.Drawing.Point(214, 444);
            this.textBox_Unit.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Unit.Name = "textBox_Unit";
            this.textBox_Unit.Size = new System.Drawing.Size(153, 27);
            this.textBox_Unit.TabIndex = 5;
            this.textBox_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Unit_KeyPress);
            // 
            // textBox_NAV
            // 
            this.textBox_NAV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_NAV.Location = new System.Drawing.Point(214, 285);
            this.textBox_NAV.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NAV.Name = "textBox_NAV";
            this.textBox_NAV.Size = new System.Drawing.Size(153, 27);
            this.textBox_NAV.TabIndex = 3;
            this.textBox_NAV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NAV_KeyPress);
            // 
            // Modify_Btn
            // 
            this.Modify_Btn.BackColor = System.Drawing.Color.White;
            this.Modify_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_Btn.Location = new System.Drawing.Point(616, 506);
            this.Modify_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Modify_Btn.Name = "Modify_Btn";
            this.Modify_Btn.Size = new System.Drawing.Size(126, 41);
            this.Modify_Btn.TabIndex = 8;
            this.Modify_Btn.Text = "&Modify";
            this.Modify_Btn.UseVisualStyleBackColor = false;
            this.Modify_Btn.Click += new System.EventHandler(this.Modify_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.BackColor = System.Drawing.Color.White;
            this.Delete_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.Location = new System.Drawing.Point(764, 507);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(126, 41);
            this.Delete_Btn.TabIndex = 9;
            this.Delete_Btn.Text = "&Delete";
            this.Delete_Btn.UseVisualStyleBackColor = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 311);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 365);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 27);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.UseWaitCursor = true;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Amount_Lbl
            // 
            this.Amount_Lbl.Location = new System.Drawing.Point(214, 519);
            this.Amount_Lbl.Name = "Amount_Lbl";
            this.Amount_Lbl.Size = new System.Drawing.Size(153, 26);
            this.Amount_Lbl.TabIndex = 11;
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.BackColor = System.Drawing.Color.White;
            this.Clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Btn.Location = new System.Drawing.Point(913, 507);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(126, 43);
            this.Clear_Btn.TabIndex = 12;
            this.Clear_Btn.Text = "&Clear";
            this.Clear_Btn.UseVisualStyleBackColor = false;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(909, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Amount ";
            // 
            // TotalAmount_Lbl
            // 
            this.TotalAmount_Lbl.Location = new System.Drawing.Point(1041, 471);
            this.TotalAmount_Lbl.Name = "TotalAmount_Lbl";
            this.TotalAmount_Lbl.Size = new System.Drawing.Size(136, 31);
            this.TotalAmount_Lbl.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 679);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1202, 60);
            this.label9.TabIndex = 16;
            this.label9.Text = "2024 developed by @truptipatle.. All rights reserved.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTP_Lbl
            // 
            this.DTP_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Lbl.ForeColor = System.Drawing.Color.Red;
            this.DTP_Lbl.Location = new System.Drawing.Point(59, 406);
            this.DTP_Lbl.Name = "DTP_Lbl";
            this.DTP_Lbl.Size = new System.Drawing.Size(308, 26);
            this.DTP_Lbl.TabIndex = 17;
            this.DTP_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.Color.White;
            this.Btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logout.Location = new System.Drawing.Point(1057, 505);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(133, 45);
            this.Btn_Logout.TabIndex = 18;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseVisualStyleBackColor = false;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 739);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.DTP_Lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalAmount_Lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.Amount_Lbl);
            this.Controls.Add(this.textBox_NAV);
            this.Controls.Add(this.textBox_Unit);
            this.Controls.Add(this.textBox_Scheme);
            this.Controls.Add(this.textBox_folio);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insert_Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Modify_Btn);
            this.Controls.Add(this.Delete_Btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutual Fund Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_folio;
        private System.Windows.Forms.TextBox textBox_Scheme;
        private System.Windows.Forms.TextBox textBox_Unit;
        private System.Windows.Forms.TextBox textBox_NAV;
        private System.Windows.Forms.Button Insert_Btn;
        private System.Windows.Forms.Button Modify_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Amount_Lbl;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalAmount_Lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DTP_Lbl;
        private System.Windows.Forms.Button Btn_Logout;
    }
}

