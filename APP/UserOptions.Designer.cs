namespace APP
{
    partial class UserOptions
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
            this.welcome = new System.Windows.Forms.Label();
            this.StartWorkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(36, 35);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(116, 33);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome";
            // 
            // StartWorkout
            // 
            this.StartWorkout.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartWorkout.Location = new System.Drawing.Point(72, 147);
            this.StartWorkout.Name = "StartWorkout";
            this.StartWorkout.Size = new System.Drawing.Size(160, 48);
            this.StartWorkout.TabIndex = 1;
            this.StartWorkout.Text = "Start Workout";
            this.StartWorkout.UseVisualStyleBackColor = true;
            this.StartWorkout.Click += new System.EventHandler(this.StartWorkout_Click);
            // 
            // UserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 652);
            this.Controls.Add(this.StartWorkout);
            this.Controls.Add(this.welcome);
            this.Name = "UserOptions";
            this.Text = "UserOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button StartWorkout;
    }
}