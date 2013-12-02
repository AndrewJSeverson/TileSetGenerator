namespace TileSetGenerator
{
    partial class TriangleSetup1
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
            this.txtTriangleHeight = new System.Windows.Forms.TextBox();
            this.btnGenerateTiangleSet = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provide the height for the triangle and a tile set will be created for it: ";
            // 
            // txtTriangleHeight
            // 
            this.txtTriangleHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriangleHeight.Location = new System.Drawing.Point(368, 60);
            this.txtTriangleHeight.Name = "txtTriangleHeight";
            this.txtTriangleHeight.Size = new System.Drawing.Size(100, 20);
            this.txtTriangleHeight.TabIndex = 1;
            // 
            // btnGenerateTiangleSet
            // 
            this.btnGenerateTiangleSet.Location = new System.Drawing.Point(270, 102);
            this.btnGenerateTiangleSet.Name = "btnGenerateTiangleSet";
            this.btnGenerateTiangleSet.Size = new System.Drawing.Size(198, 47);
            this.btnGenerateTiangleSet.TabIndex = 2;
            this.btnGenerateTiangleSet.Text = "Generate Tile Set";
            this.btnGenerateTiangleSet.UseVisualStyleBackColor = true;
            this.btnGenerateTiangleSet.Click += new System.EventHandler(this.btnGenerateTiangleSet_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 126);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(90, 23);
            this.btnBackToMenu.TabIndex = 9;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // TriangleSetup1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 161);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnGenerateTiangleSet);
            this.Controls.Add(this.txtTriangleHeight);
            this.Controls.Add(this.label1);
            this.Name = "TriangleSetup1";
            this.Text = "Triangle Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTriangleHeight;
        private System.Windows.Forms.Button btnGenerateTiangleSet;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}