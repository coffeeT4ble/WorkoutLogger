namespace APP
{
    partial class WorkoutMenu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search0 = new System.Windows.Forms.Label();
            this.search1 = new System.Windows.Forms.Label();
            this.search2 = new System.Windows.Forms.Label();
            this.search3 = new System.Windows.Forms.Label();
            this.search4 = new System.Windows.Forms.Label();
            this.listOfExercises = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search0
            // 
            this.search0.AutoSize = true;
            this.search0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search0.Location = new System.Drawing.Point(253, 151);
            this.search0.Name = "search0";
            this.search0.Size = new System.Drawing.Size(67, 23);
            this.search0.TabIndex = 1;
            this.search0.Text = "search0";
            this.search0.Click += new System.EventHandler(this.search0_Click);
            // 
            // search1
            // 
            this.search1.AutoSize = true;
            this.search1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1.Location = new System.Drawing.Point(253, 188);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(64, 23);
            this.search1.TabIndex = 2;
            this.search1.Text = "search1";
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // search2
            // 
            this.search2.AutoSize = true;
            this.search2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search2.Location = new System.Drawing.Point(253, 225);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(67, 23);
            this.search2.TabIndex = 3;
            this.search2.Text = "search2";
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // search3
            // 
            this.search3.AutoSize = true;
            this.search3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search3.Location = new System.Drawing.Point(253, 258);
            this.search3.Name = "search3";
            this.search3.Size = new System.Drawing.Size(67, 23);
            this.search3.TabIndex = 4;
            this.search3.Text = "search3";
            this.search3.Click += new System.EventHandler(this.search3_Click);
            // 
            // search4
            // 
            this.search4.AutoSize = true;
            this.search4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search4.Location = new System.Drawing.Point(253, 296);
            this.search4.Name = "search4";
            this.search4.Size = new System.Drawing.Size(67, 23);
            this.search4.TabIndex = 5;
            this.search4.Text = "search4";
            this.search4.Click += new System.EventHandler(this.search4_Click);
            // 
            // listOfExercises
            // 
            this.listOfExercises.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfExercises.Location = new System.Drawing.Point(888, 240);
            this.listOfExercises.Name = "listOfExercises";
            this.listOfExercises.Size = new System.Drawing.Size(174, 88);
            this.listOfExercises.TabIndex = 6;
            this.listOfExercises.Text = "List Of Exercises";
            this.listOfExercises.UseVisualStyleBackColor = true;
            this.listOfExercises.Click += new System.EventHandler(this.listOfExercises_Click);
            // 
            // WorkoutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 630);
            this.Controls.Add(this.listOfExercises);
            this.Controls.Add(this.search4);
            this.Controls.Add(this.search3);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.search0);
            this.Controls.Add(this.textBox1);
            this.Name = "WorkoutMenu";
            this.Text = "WorkoutMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label search0;
        private System.Windows.Forms.Label search1;
        private System.Windows.Forms.Label search2;
        private System.Windows.Forms.Label search3;
        private System.Windows.Forms.Label search4;
        private System.Windows.Forms.Button listOfExercises;
    }
}