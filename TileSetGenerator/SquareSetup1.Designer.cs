namespace TileSetGenerator
{
    partial class SquareSetup1
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
            this.btnGenerateSquareSet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nL = new System.Windows.Forms.CheckBox();
            this.logN = new System.Windows.Forms.CheckBox();
            this.nComb = new System.Windows.Forms.CheckBox();
            this.nSquared = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.WutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateSquareSet
            // 
            this.btnGenerateSquareSet.Location = new System.Drawing.Point(340, 70);
            this.btnGenerateSquareSet.Name = "btnGenerateSquareSet";
            this.btnGenerateSquareSet.Size = new System.Drawing.Size(198, 47);
            this.btnGenerateSquareSet.TabIndex = 3;
            this.btnGenerateSquareSet.Text = "Generate Tile Set";
            this.btnGenerateSquareSet.UseVisualStyleBackColor = true;
            this.btnGenerateSquareSet.Click += new System.EventHandler(this.btnGenerateSquareSet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nL);
            this.groupBox1.Controls.Add(this.logN);
            this.groupBox1.Controls.Add(this.nComb);
            this.groupBox1.Controls.Add(this.nSquared);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sizeInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 52);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // nL
            // 
            this.nL.AutoSize = true;
            this.nL.Location = new System.Drawing.Point(173, 21);
            this.nL.Name = "nL";
            this.nL.Size = new System.Drawing.Size(57, 17);
            this.nL.TabIndex = 13;
            this.nL.Text = "O(N) L";
            this.nL.UseVisualStyleBackColor = true;
            // 
            // logN
            // 
            this.logN.AutoSize = true;
            this.logN.Location = new System.Drawing.Point(236, 20);
            this.logN.Name = "logN";
            this.logN.Size = new System.Drawing.Size(134, 17);
            this.logN.TabIndex = 11;
            this.logN.Text = "O(logN) Binary Counter";
            this.logN.UseVisualStyleBackColor = true;
            // 
            // nComb
            // 
            this.nComb.AutoSize = true;
            this.nComb.Location = new System.Drawing.Point(89, 21);
            this.nComb.Name = "nComb";
            this.nComb.Size = new System.Drawing.Size(78, 17);
            this.nComb.TabIndex = 10;
            this.nComb.Text = "O(N) Comb";
            this.nComb.UseVisualStyleBackColor = true;
            // 
            // nSquared
            // 
            this.nSquared.AutoSize = true;
            this.nSquared.Location = new System.Drawing.Point(23, 21);
            this.nSquared.Name = "nSquared";
            this.nSquared.Size = new System.Drawing.Size(60, 17);
            this.nSquared.TabIndex = 9;
            this.nSquared.Text = "O(N^2)";
            this.nSquared.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size:";
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(420, 19);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(100, 20);
            this.sizeInput.TabIndex = 7;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 94);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(90, 23);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // WutButton
            // 
            this.WutButton.Location = new System.Drawing.Point(185, 82);
            this.WutButton.Name = "WutButton";
            this.WutButton.Size = new System.Drawing.Size(75, 23);
            this.WutButton.TabIndex = 9;
            this.WutButton.Text = "WUT";
            this.WutButton.UseVisualStyleBackColor = true;
            this.WutButton.Click += new System.EventHandler(this.WutButton_Click);
            // 
            // SquareSetup1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 125);
            this.Controls.Add(this.WutButton);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateSquareSet);
            this.Name = "SquareSetup1";
            this.Text = "Square Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateSquareSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.CheckBox nL;
        private System.Windows.Forms.CheckBox logN;
        private System.Windows.Forms.CheckBox nComb;
        private System.Windows.Forms.CheckBox nSquared;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button WutButton;

    }
}