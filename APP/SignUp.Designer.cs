namespace APP
{
    partial class SignUp
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
            this.username_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_text_box = new System.Windows.Forms.TextBox();
            this.email_text_box = new System.Windows.Forms.TextBox();
            this.password_text_box = new System.Windows.Forms.TextBox();
            this.signup_window_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(114, 73);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(105, 26);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username:";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(155, 117);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(64, 26);
            this.email_label.TabIndex = 1;
            this.email_label.Text = "Email:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(119, 157);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(100, 26);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password:";
            // 
            // username_text_box
            // 
            this.username_text_box.Location = new System.Drawing.Point(225, 79);
            this.username_text_box.Name = "username_text_box";
            this.username_text_box.Size = new System.Drawing.Size(192, 20);
            this.username_text_box.TabIndex = 3;
            this.username_text_box.TextChanged += new System.EventHandler(this.username_text_box_TextChanged);
            // 
            // email_text_box
            // 
            this.email_text_box.Location = new System.Drawing.Point(225, 123);
            this.email_text_box.Name = "email_text_box";
            this.email_text_box.Size = new System.Drawing.Size(192, 20);
            this.email_text_box.TabIndex = 4;
            this.email_text_box.TextChanged += new System.EventHandler(this.email_text_box_TextChanged);
            // 
            // password_text_box
            // 
            this.password_text_box.Location = new System.Drawing.Point(225, 163);
            this.password_text_box.Name = "password_text_box";
            this.password_text_box.Size = new System.Drawing.Size(192, 20);
            this.password_text_box.TabIndex = 5;
            this.password_text_box.TextChanged += new System.EventHandler(this.password_text_box_TextChanged);
            // 
            // signup_window_button
            // 
            this.signup_window_button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_window_button.Location = new System.Drawing.Point(261, 211);
            this.signup_window_button.Name = "signup_window_button";
            this.signup_window_button.Size = new System.Drawing.Size(94, 43);
            this.signup_window_button.TabIndex = 6;
            this.signup_window_button.Text = "Sign Up";
            this.signup_window_button.UseVisualStyleBackColor = true;
            this.signup_window_button.Click += new System.EventHandler(this.signup_window_button_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 300);
            this.Controls.Add(this.signup_window_button);
            this.Controls.Add(this.password_text_box);
            this.Controls.Add(this.email_text_box);
            this.Controls.Add(this.username_text_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.username_label);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_text_box;
        private System.Windows.Forms.TextBox email_text_box;
        private System.Windows.Forms.TextBox password_text_box;
        private System.Windows.Forms.Button signup_window_button;
    }
}