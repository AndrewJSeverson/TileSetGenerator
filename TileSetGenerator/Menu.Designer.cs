namespace TileSetGenerator
{
    partial class Menu
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
            this.btnTuring = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTuring
            // 
            this.btnTuring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnTuring.Location = new System.Drawing.Point(12, 12);
            this.btnTuring.Name = "btnTuring";
            this.btnTuring.Size = new System.Drawing.Size(113, 114);
            this.btnTuring.TabIndex = 1;
            this.btnTuring.Text = "Turing Machine";
            this.btnTuring.UseVisualStyleBackColor = true;
            this.btnTuring.Click += new System.EventHandler(this.btnTuring_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSquare.Location = new System.Drawing.Point(131, 12);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(113, 114);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnTriangle.Location = new System.Drawing.Point(250, 12);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(113, 114);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 138);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnTuring);
            this.Name = "Menu";
            this.Text = "Tileset Helper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTuring;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnTriangle;
    }
}

