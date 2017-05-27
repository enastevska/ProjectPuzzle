namespace Puzzle
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
            this.btnAddImage = new System.Windows.Forms.Button();
            this.gbSolvePuzzle = new System.Windows.Forms.GroupBox();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.gbPuzzle = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddImage.BackgroundImage = global::Puzzle.Properties.Resources.expences_button_png_hi__1_;
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(28, 12);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(188, 33);
            this.btnAddImage.TabIndex = 0;
            this.btnAddImage.Text = "Choose an image";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // gbSolvePuzzle
            // 
            this.gbSolvePuzzle.Location = new System.Drawing.Point(28, 61);
            this.gbSolvePuzzle.Name = "gbSolvePuzzle";
            this.gbSolvePuzzle.Size = new System.Drawing.Size(444, 444);
            this.gbSolvePuzzle.TabIndex = 1;
            this.gbSolvePuzzle.TabStop = false;
            this.gbSolvePuzzle.Text = "Solve puzzle";
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackgroundImage = global::Puzzle.Properties.Resources.blue_2_tone_gradient_bg;
            this.btnLevel1.Enabled = false;
            this.btnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLevel1.Location = new System.Drawing.Point(490, 61);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(136, 30);
            this.btnLevel1.TabIndex = 2;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackgroundImage = global::Puzzle.Properties.Resources.blue_2_tone_gradient_bg;
            this.btnLevel2.Enabled = false;
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLevel2.Location = new System.Drawing.Point(490, 106);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(136, 30);
            this.btnLevel2.TabIndex = 3;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackgroundImage = global::Puzzle.Properties.Resources.blue_2_tone_gradient_bg;
            this.btnLevel3.Enabled = false;
            this.btnLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLevel3.Location = new System.Drawing.Point(490, 153);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(136, 30);
            this.btnLevel3.TabIndex = 4;
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = true;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // gbPuzzle
            // 
            this.gbPuzzle.Location = new System.Drawing.Point(647, 61);
            this.gbPuzzle.Name = "gbPuzzle";
            this.gbPuzzle.Size = new System.Drawing.Size(357, 444);
            this.gbPuzzle.TabIndex = 5;
            this.gbPuzzle.TabStop = false;
            this.gbPuzzle.Text = "Final result";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::Puzzle.Properties.Resources.expences_button_png_hi__1_;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(490, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Start a new game";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::Puzzle.Properties.Resources.large;
            this.ClientSize = new System.Drawing.Size(1030, 517);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbPuzzle);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.gbSolvePuzzle);
            this.Controls.Add(this.btnAddImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.GroupBox gbSolvePuzzle;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.GroupBox gbPuzzle;
        private System.Windows.Forms.Button btnReset;
    }
}

