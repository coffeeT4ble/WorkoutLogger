namespace APP
{
    partial class ExerciseSetting
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
            this.reps_counter = new System.Windows.Forms.NumericUpDown();
            this.sets_counter = new System.Windows.Forms.NumericUpDown();
            this.sets_label = new System.Windows.Forms.Label();
            this.reps_label = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.weight_counter = new System.Windows.Forms.NumericUpDown();
            this.weight_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reps_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sets_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_counter)).BeginInit();
            this.SuspendLayout();
            // 
            // reps_counter
            // 
            this.reps_counter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reps_counter.Location = new System.Drawing.Point(257, 142);
            this.reps_counter.Name = "reps_counter";
            this.reps_counter.Size = new System.Drawing.Size(160, 37);
            this.reps_counter.TabIndex = 0;
            // 
            // sets_counter
            // 
            this.sets_counter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sets_counter.Location = new System.Drawing.Point(257, 82);
            this.sets_counter.Name = "sets_counter";
            this.sets_counter.Size = new System.Drawing.Size(160, 37);
            this.sets_counter.TabIndex = 1;
            // 
            // sets_label
            // 
            this.sets_label.AutoSize = true;
            this.sets_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sets_label.Location = new System.Drawing.Point(137, 86);
            this.sets_label.Name = "sets_label";
            this.sets_label.Size = new System.Drawing.Size(67, 33);
            this.sets_label.TabIndex = 2;
            this.sets_label.Text = "Sets";
            // 
            // reps_label
            // 
            this.reps_label.AutoSize = true;
            this.reps_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reps_label.Location = new System.Drawing.Point(137, 146);
            this.reps_label.Name = "reps_label";
            this.reps_label.Size = new System.Drawing.Size(68, 33);
            this.reps_label.TabIndex = 3;
            this.reps_label.Text = "Reps";
            // 
            // confirm_button
            // 
            this.confirm_button.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.Location = new System.Drawing.Point(460, 47);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(99, 113);
            this.confirm_button.TabIndex = 4;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // weight_counter
            // 
            this.weight_counter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_counter.Location = new System.Drawing.Point(257, 28);
            this.weight_counter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weight_counter.Name = "weight_counter";
            this.weight_counter.Size = new System.Drawing.Size(160, 37);
            this.weight_counter.TabIndex = 5;
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_label.Location = new System.Drawing.Point(137, 32);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(97, 33);
            this.weight_label.TabIndex = 6;
            this.weight_label.Text = "Weight";
            // 
            // ExerciseSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 262);
            this.ControlBox = false;
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.weight_counter);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.reps_label);
            this.Controls.Add(this.sets_label);
            this.Controls.Add(this.sets_counter);
            this.Controls.Add(this.reps_counter);
            this.Name = "ExerciseSetting";
            this.Text = "ExerciseSetting";
            ((System.ComponentModel.ISupportInitialize)(this.reps_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sets_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown reps_counter;
        private System.Windows.Forms.NumericUpDown sets_counter;
        private System.Windows.Forms.Label sets_label;
        private System.Windows.Forms.Label reps_label;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.NumericUpDown weight_counter;
        private System.Windows.Forms.Label weight_label;
    }
}