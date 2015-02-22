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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(16, 15);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1089, 562);
            this.textBox2.TabIndex = 2;
            // 
            // btnMoveSouth
            // 
            this.btnMoveSouth.Location = new System.Drawing.Point(536, 633);
            this.btnMoveSouth.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveSouth.Name = "btnMoveSouth";
            this.btnMoveSouth.Size = new System.Drawing.Size(56, 25);
            this.btnMoveSouth.TabIndex = 3;
            this.btnMoveSouth.Text = "South";
            this.btnMoveSouth.UseVisualStyleBackColor = true;
            this.btnMoveSouth.Click += new System.EventHandler(this.btnMoveSouth_Click);
            // 
            // btnMoveNorth
            // 
            this.btnMoveNorth.Location = new System.Drawing.Point(536, 585);
            this.btnMoveNorth.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveNorth.Name = "btnMoveNorth";
            this.btnMoveNorth.Size = new System.Drawing.Size(56, 25);
            this.btnMoveNorth.TabIndex = 4;
            this.btnMoveNorth.Text = "North";
            this.btnMoveNorth.UseVisualStyleBackColor = true;
            this.btnMoveNorth.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMoveWest
            // 
            this.btnMoveWest.Location = new System.Drawing.Point(481, 609);
            this.btnMoveWest.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveWest.Name = "btnMoveWest";
            this.btnMoveWest.Size = new System.Drawing.Size(56, 25);
            this.btnMoveWest.TabIndex = 5;
            this.btnMoveWest.Text = "West";
            this.btnMoveWest.UseVisualStyleBackColor = true;
            this.btnMoveWest.Click += new System.EventHandler(this.btnMoveWest_Click);
            // 
            // btnMoveEast
            // 
            this.btnMoveEast.Location = new System.Drawing.Point(591, 609);
            this.btnMoveEast.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveEast.Name = "btnMoveEast";
            this.btnMoveEast.Size = new System.Drawing.Size(56, 25);
            this.btnMoveEast.TabIndex = 6;
            this.btnMoveEast.Text = "East";
            this.btnMoveEast.UseVisualStyleBackColor = true;
            this.btnMoveEast.Click += new System.EventHandler(this.btnMoveEast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(539, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "k: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1121, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoveEast);
            this.Controls.Add(this.btnMoveWest);
            this.Controls.Add(this.btnMoveNorth);
            this.Controls.Add(this.btnMoveSouth);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.Label label1;
    }
}