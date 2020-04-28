namespace Project_iPole_01
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextMemberID = new System.Windows.Forms.Label();
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(988, 392);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(95, 32);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(737, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 106);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to iPole";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Location = new System.Drawing.Point(752, 285);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(73, 17);
            this.TextPassword.TabIndex = 6;
            this.TextPassword.Text = "Password:";
            this.TextPassword.Click += new System.EventHandler(this.TextPassword_Click);
            // 
            // TextMemberID
            // 
            this.TextMemberID.AutoSize = true;
            this.TextMemberID.Location = new System.Drawing.Point(752, 237);
            this.TextMemberID.Name = "TextMemberID";
            this.TextMemberID.Size = new System.Drawing.Size(80, 17);
            this.TextMemberID.TabIndex = 7;
            this.TextMemberID.Text = "Member ID:";
            this.TextMemberID.Click += new System.EventHandler(this.TextMemberID_Click);
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.Location = new System.Drawing.Point(892, 234);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(401, 22);
            this.textBoxMemberID.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(892, 282);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(401, 22);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 731);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxMemberID);
            this.Controls.Add(this.TextMemberID);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.Label TextMemberID;
        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

