namespace Hotel_Management
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.position_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fgt_pw_lbl = new System.Windows.Forms.Label();
            this.sgup_lbl = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.remind_tb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 101);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remind_tb);
            this.panel2.Controls.Add(this.sgup_lbl);
            this.panel2.Controls.Add(this.Login_btn);
            this.panel2.Controls.Add(this.fgt_pw_lbl);
            this.panel2.Controls.Add(this.pass_tb);
            this.panel2.Controls.Add(this.login_tb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.position_cb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(96, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 188);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Revue", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "You are: ";
            // 
            // position_cb
            // 
            this.position_cb.FormattingEnabled = true;
            this.position_cb.Items.AddRange(new object[] {
            "Boss",
            "Manager",
            "Receptionist",
            "Guest"});
            this.position_cb.Location = new System.Drawing.Point(127, 38);
            this.position_cb.Name = "position_cb";
            this.position_cb.Size = new System.Drawing.Size(445, 24);
            this.position_cb.TabIndex = 1;
            this.position_cb.SelectedIndexChanged += new System.EventHandler(this.position_cb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password: ";
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(127, 70);
            this.login_tb.Multiline = true;
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(445, 22);
            this.login_tb.TabIndex = 4;
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(127, 98);
            this.pass_tb.Multiline = true;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(445, 22);
            this.pass_tb.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 318);
            this.panel3.TabIndex = 1;
            // 
            // fgt_pw_lbl
            // 
            this.fgt_pw_lbl.AutoSize = true;
            this.fgt_pw_lbl.Location = new System.Drawing.Point(128, 134);
            this.fgt_pw_lbl.Name = "fgt_pw_lbl";
            this.fgt_pw_lbl.Size = new System.Drawing.Size(115, 16);
            this.fgt_pw_lbl.TabIndex = 2;
            this.fgt_pw_lbl.Text = "Forgot password?";
            // 
            // sgup_lbl
            // 
            this.sgup_lbl.AutoSize = true;
            this.sgup_lbl.Location = new System.Drawing.Point(249, 134);
            this.sgup_lbl.Name = "sgup_lbl";
            this.sgup_lbl.Size = new System.Drawing.Size(52, 16);
            this.sgup_lbl.TabIndex = 3;
            this.sgup_lbl.Text = "Sign up";
            this.sgup_lbl.Visible = false;
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(461, 126);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(111, 33);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "OK";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // remind_tb
            // 
            this.remind_tb.AutoSize = true;
            this.remind_tb.ForeColor = System.Drawing.Color.Red;
            this.remind_tb.Location = new System.Drawing.Point(128, 19);
            this.remind_tb.Name = "remind_tb";
            this.remind_tb.Size = new System.Drawing.Size(235, 16);
            this.remind_tb.TabIndex = 6;
            this.remind_tb.Text = "Login name or password is not correct!";
            this.remind_tb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox position_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label sgup_lbl;
        private System.Windows.Forms.Label fgt_pw_lbl;
        private System.Windows.Forms.Label remind_tb;
    }
}

