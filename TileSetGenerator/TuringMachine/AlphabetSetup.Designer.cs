namespace TileSetGenerator.TuringMachine
{
    partial class AlphabetSetup
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listAlphabet = new System.Windows.Forms.ListBox();
            this.btnRemoveChar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewChar = new System.Windows.Forms.TextBox();
            this.btnAddChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listAlphabet
            // 
            this.listAlphabet.FormattingEnabled = true;
            this.listAlphabet.Location = new System.Drawing.Point(206, 12);
            this.listAlphabet.Name = "listAlphabet";
            this.listAlphabet.Size = new System.Drawing.Size(45, 212);
            this.listAlphabet.TabIndex = 2;
            // 
            // btnRemoveChar
            // 
            this.btnRemoveChar.Location = new System.Drawing.Point(165, 230);
            this.btnRemoveChar.Name = "btnRemoveChar";
            this.btnRemoveChar.Size = new System.Drawing.Size(124, 23);
            this.btnRemoveChar.TabIndex = 3;
            this.btnRemoveChar.Text = "Remove Selected";
            this.btnRemoveChar.UseVisualStyleBackColor = true;
            this.btnRemoveChar.Click += new System.EventHandler(this.btnRemoveChar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Character: ";
            // 
            // txtNewChar
            // 
            this.txtNewChar.Location = new System.Drawing.Point(102, 9);
            this.txtNewChar.Name = "txtNewChar";
            this.txtNewChar.Size = new System.Drawing.Size(41, 20);
            this.txtNewChar.TabIndex = 5;
            this.txtNewChar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewChar_KeyUp);
            // 
            // btnAddChar
            // 
            this.btnAddChar.Location = new System.Drawing.Point(98, 35);
            this.btnAddChar.Name = "btnAddChar";
            this.btnAddChar.Size = new System.Drawing.Size(102, 23);
            this.btnAddChar.TabIndex = 6;
            this.btnAddChar.Text = "Add to Alphabet";
            this.btnAddChar.UseVisualStyleBackColor = true;
            this.btnAddChar.Click += new System.EventHandler(this.btnAddChar_Click);
            // 
            // AlphabetSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 292);
            this.Controls.Add(this.btnAddChar);
            this.Controls.Add(this.txtNewChar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveChar);
            this.Controls.Add(this.listAlphabet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "AlphabetSetup";
            this.Text = "AlphabetSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listAlphabet;
        private System.Windows.Forms.Button btnRemoveChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewChar;
        private System.Windows.Forms.Button btnAddChar;
    }
}