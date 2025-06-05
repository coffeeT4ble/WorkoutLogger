namespace APP
{
    partial class Calendar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sunday = new System.Windows.Forms.Label();
            this.monday = new System.Windows.Forms.Label();
            this.tuesday = new System.Windows.Forms.Label();
            this.wednesday = new System.Windows.Forms.Label();
            this.thursday = new System.Windows.Forms.Label();
            this.friday = new System.Windows.Forms.Label();
            this.saturday = new System.Windows.Forms.Label();
            this.month_label = new System.Windows.Forms.Label();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1256, 734);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday.Location = new System.Drawing.Point(69, 98);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(63, 23);
            this.sunday.TabIndex = 1;
            this.sunday.Text = "Sunday";
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monday.Location = new System.Drawing.Point(257, 98);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(67, 23);
            this.monday.TabIndex = 2;
            this.monday.Text = "Monday";
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesday.Location = new System.Drawing.Point(433, 98);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(70, 23);
            this.tuesday.TabIndex = 3;
            this.tuesday.Text = "Tuesday";
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday.Location = new System.Drawing.Point(591, 98);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(93, 23);
            this.wednesday.TabIndex = 4;
            this.wednesday.Text = "Wednesday";
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday.Location = new System.Drawing.Point(767, 98);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(78, 23);
            this.thursday.TabIndex = 5;
            this.thursday.Text = "Thursday";
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday.Location = new System.Drawing.Point(948, 98);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(59, 23);
            this.friday.TabIndex = 6;
            this.friday.Text = "Friday";
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday.Location = new System.Drawing.Point(1130, 98);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(78, 23);
            this.saturday.TabIndex = 7;
            this.saturday.Text = "Saturday";
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_label.Location = new System.Drawing.Point(12, 9);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(97, 38);
            this.month_label.TabIndex = 8;
            this.month_label.Text = "Month";
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(1086, 12);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(75, 23);
            this.previous_button.TabIndex = 9;
            this.previous_button.Text = "Previous";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(1167, 12);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 10;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 899);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.month_label);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.friday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.sunday);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label sunday;
        private System.Windows.Forms.Label monday;
        private System.Windows.Forms.Label tuesday;
        private System.Windows.Forms.Label wednesday;
        private System.Windows.Forms.Label thursday;
        private System.Windows.Forms.Label friday;
        private System.Windows.Forms.Label saturday;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
    }
}