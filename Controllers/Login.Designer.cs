namespace School_Election_System.Controllers
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_bttn = new System.Windows.Forms.Button();
            this.no_acc_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.voters_id_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_bttn
            // 
            this.login_bttn.BackColor = System.Drawing.Color.White;
            this.login_bttn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bttn.Location = new System.Drawing.Point(180, 548);
            this.login_bttn.Name = "login_bttn";
            this.login_bttn.Size = new System.Drawing.Size(215, 71);
            this.login_bttn.TabIndex = 13;
            this.login_bttn.Text = "LOGIN";
            this.login_bttn.UseVisualStyleBackColor = false;
            this.login_bttn.Click += new System.EventHandler(this.login_bttn_Click);
            // 
            // no_acc_label
            // 
            this.no_acc_label.AutoSize = true;
            this.no_acc_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_acc_label.ForeColor = System.Drawing.Color.White;
            this.no_acc_label.Location = new System.Drawing.Point(53, 484);
            this.no_acc_label.Name = "no_acc_label";
            this.no_acc_label.Size = new System.Drawing.Size(405, 21);
            this.no_acc_label.TabIndex = 12;
            this.no_acc_label.Text = "Don\'t have an account yet? Click here";
            this.no_acc_label.Click += new System.EventHandler(this.no_acc_label_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textBox.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(57, 403);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(431, 59);
            this.password_textBox.TabIndex = 11;
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.id_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_textBox.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textBox.Location = new System.Drawing.Point(57, 283);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(431, 59);
            this.id_textBox.TabIndex = 10;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.Color.White;
            this.pass_label.Location = new System.Drawing.Point(53, 366);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(95, 22);
            this.pass_label.TabIndex = 9;
            this.pass_label.Text = "Password";
            // 
            // voters_id_label
            // 
            this.voters_id_label.AutoSize = true;
            this.voters_id_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_id_label.ForeColor = System.Drawing.Color.White;
            this.voters_id_label.Location = new System.Drawing.Point(53, 245);
            this.voters_id_label.Name = "voters_id_label";
            this.voters_id_label.Size = new System.Drawing.Size(97, 22);
            this.voters_id_label.TabIndex = 8;
            this.voters_id_label.Text = "Voter\'s ID";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(96, 109);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(358, 78);
            this.welcome_label.TabIndex = 7;
            this.welcome_label.Text = "WELCOME";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.login_bttn);
            this.Controls.Add(this.no_acc_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.voters_id_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(553, 741);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_bttn;
        private System.Windows.Forms.Label no_acc_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label voters_id_label;
        private System.Windows.Forms.Label welcome_label;
    }
}
