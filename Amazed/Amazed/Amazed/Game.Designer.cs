namespace Amazed
{
    partial class Game
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMoveSouth = new System.Windows.Forms.Button();
            this.btnMoveNorth = new System.Windows.Forms.Button();
            this.btnMoveWest = new System.Windows.Forms.Button();
            this.btnMoveEast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(16, 15);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1089, 602);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMoveSouth
            // 
            this.btnMoveSouth.Location = new System.Drawing.Point(512, 618);
            this.btnMoveSouth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveSouth.Name = "btnMoveSouth";
            this.btnMoveSouth.Size = new System.Drawing.Size(100, 25);
            this.btnMoveSouth.TabIndex = 3;
            this.btnMoveSouth.Text = "Move South";
            this.btnMoveSouth.UseVisualStyleBackColor = true;
            this.btnMoveSouth.Click += new System.EventHandler(this.btnMoveSouth_Click);
            // 
            // btnMoveNorth
            // 
            this.btnMoveNorth.Location = new System.Drawing.Point(512, 528);
            this.btnMoveNorth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveNorth.Name = "btnMoveNorth";
            this.btnMoveNorth.Size = new System.Drawing.Size(100, 25);
            this.btnMoveNorth.TabIndex = 4;
            this.btnMoveNorth.Text = "Move North";
            this.btnMoveNorth.UseVisualStyleBackColor = true;
            this.btnMoveNorth.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMoveWest
            // 
            this.btnMoveWest.Location = new System.Drawing.Point(412, 572);
            this.btnMoveWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveWest.Name = "btnMoveWest";
            this.btnMoveWest.Size = new System.Drawing.Size(100, 25);
            this.btnMoveWest.TabIndex = 5;
            this.btnMoveWest.Text = "Move West";
            this.btnMoveWest.UseVisualStyleBackColor = true;
            this.btnMoveWest.Click += new System.EventHandler(this.btnMoveWest_Click);
            // 
            // btnMoveEast
            // 
            this.btnMoveEast.Location = new System.Drawing.Point(613, 572);
            this.btnMoveEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveEast.Name = "btnMoveEast";
            this.btnMoveEast.Size = new System.Drawing.Size(100, 25);
            this.btnMoveEast.TabIndex = 6;
            this.btnMoveEast.Text = "Move East";
            this.btnMoveEast.UseVisualStyleBackColor = true;
            this.btnMoveEast.Click += new System.EventHandler(this.btnMoveEast_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1121, 665);
            this.Controls.Add(this.btnMoveEast);
            this.Controls.Add(this.btnMoveWest);
            this.Controls.Add(this.btnMoveNorth);
            this.Controls.Add(this.btnMoveSouth);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game";
            this.Text = "Amazed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnMoveSouth;
        private System.Windows.Forms.Button btnMoveNorth;
        private System.Windows.Forms.Button btnMoveWest;
        private System.Windows.Forms.Button btnMoveEast;
    }
}