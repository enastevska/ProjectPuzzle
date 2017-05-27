namespace Puzzle
{
    partial class ResetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnYES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to start a new game?";
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnNO.BackgroundImage = global::Puzzle.Properties.Resources.blue_2_tone_gradient_bg;
            this.btnNO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNO.Location = new System.Drawing.Point(24, 136);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(112, 40);
            this.btnNO.TabIndex = 1;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnYES.BackgroundImage = global::Puzzle.Properties.Resources.blue_2_tone_gradient_bg;
            this.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYES.Location = new System.Drawing.Point(214, 136);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(112, 40);
            this.btnYES.TabIndex = 2;
            this.btnYES.Text = "YES";
            this.btnYES.UseVisualStyleBackColor = false;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // ResetForm
            // 
            this.AcceptButton = this.btnYES;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Puzzle.Properties.Resources.large;
            this.CancelButton = this.btnNO;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnYES;
    }
}