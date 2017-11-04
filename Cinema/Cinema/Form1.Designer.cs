namespace Cinema
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cinemasCombo = new System.Windows.Forms.ComboBox();
            this.cinemaHallCombo = new System.Windows.Forms.ComboBox();
            this.moviesCombo = new System.Windows.Forms.ComboBox();
            this._3dCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.screeningsCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.screeningsCombo);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this._3dCheckBox);
            this.groupBox1.Controls.Add(this.moviesCombo);
            this.groupBox1.Controls.Add(this.cinemaHallCombo);
            this.groupBox1.Controls.Add(this.cinemasCombo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cinema hall";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movies";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add cinema hall";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cinemasCombo
            // 
            this.cinemasCombo.FormattingEnabled = true;
            this.cinemasCombo.Location = new System.Drawing.Point(16, 61);
            this.cinemasCombo.Name = "cinemasCombo";
            this.cinemasCombo.Size = new System.Drawing.Size(213, 29);
            this.cinemasCombo.TabIndex = 5;
            // 
            // cinemaHallCombo
            // 
            this.cinemaHallCombo.FormattingEnabled = true;
            this.cinemaHallCombo.Location = new System.Drawing.Point(16, 118);
            this.cinemaHallCombo.Name = "cinemaHallCombo";
            this.cinemaHallCombo.Size = new System.Drawing.Size(213, 29);
            this.cinemaHallCombo.TabIndex = 6;
            // 
            // moviesCombo
            // 
            this.moviesCombo.FormattingEnabled = true;
            this.moviesCombo.Location = new System.Drawing.Point(16, 173);
            this.moviesCombo.Name = "moviesCombo";
            this.moviesCombo.Size = new System.Drawing.Size(213, 29);
            this.moviesCombo.TabIndex = 7;
            // 
            // _3dCheckBox
            // 
            this._3dCheckBox.AutoSize = true;
            this._3dCheckBox.Location = new System.Drawing.Point(16, 265);
            this._3dCheckBox.Name = "_3dCheckBox";
            this._3dCheckBox.Size = new System.Drawing.Size(94, 25);
            this._3dCheckBox.TabIndex = 8;
            this._3dCheckBox.Text = "3D Film";
            this._3dCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add cinema";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add film";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 31);
            this.button4.TabIndex = 11;
            this.button4.Text = "Connecting";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 31);
            this.button5.TabIndex = 12;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(245, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 507);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hall";
            // 
            // screeningsCombo
            // 
            this.screeningsCombo.FormattingEnabled = true;
            this.screeningsCombo.Location = new System.Drawing.Point(16, 233);
            this.screeningsCombo.Name = "screeningsCombo";
            this.screeningsCombo.Size = new System.Drawing.Size(213, 29);
            this.screeningsCombo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Screenings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(850, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Cinema manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox _3dCheckBox;
        private System.Windows.Forms.ComboBox moviesCombo;
        private System.Windows.Forms.ComboBox cinemaHallCombo;
        private System.Windows.Forms.ComboBox cinemasCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox screeningsCombo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

