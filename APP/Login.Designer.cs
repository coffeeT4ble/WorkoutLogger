namespace APP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.email_text_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.email_label = new System.Windows.Forms.Label();
            this.pwd_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.SignUp_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_text_box
            // 
            this.email_text_box.Location = new System.Drawing.Point(211, 110);
            this.email_text_box.Name = "email_text_box";
            this.email_text_box.Size = new System.Drawing.Size(186, 20);
            this.email_text_box.TabIndex = 0;
            this.email_text_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(151, 107);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(54, 23);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "Email:";
            this.email_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwd_label
            // 
            this.pwd_label.AutoSize = true;
            this.pwd_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_label.Location = new System.Drawing.Point(124, 139);
            this.pwd_label.Name = "pwd_label";
            this.pwd_label.Size = new System.Drawing.Size(81, 23);
            this.pwd_label.TabIndex = 3;
            this.pwd_label.Text = "Password:";
            this.pwd_label.Click += new System.EventHandler(this.pwd_label_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(211, 204);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(55, 34);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_Button.Location = new System.Drawing.Point(335, 204);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(62, 34);
            this.SignUp_Button.TabIndex = 6;
            this.SignUp_Button.Text = "SignUp";
            this.SignUp_Button.UseVisualStyleBackColor = true;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            // 
            // SignUp_Label
            // 
            this.SignUp_Label.AutoSize = true;
            this.SignUp_Label.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_Label.Location = new System.Drawing.Point(294, 183);
            this.SignUp_Label.Name = "SignUp_Label";
            this.SignUp_Label.Size = new System.Drawing.Size(143, 18);
            this.SignUp_Label.TabIndex = 7;
            this.SignUp_Label.Text = "Dont have an account?";
            this.SignUp_Label.Click += new System.EventHandler(this.SignUp_Label_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 282);
            this.Controls.Add(this.SignUp_Label);
            this.Controls.Add(this.SignUp_Button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pwd_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email_text_box);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_text_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label pwd_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Label SignUp_Label;
    }
}

