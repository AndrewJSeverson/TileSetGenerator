﻿namespace TileSetGenerator.TuringMachine
{
    partial class StartingString
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listAlphabet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCharToString = new System.Windows.Forms.Button();
            this.txtStartingString = new System.Windows.Forms.TextBox();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listAlphabet
            // 
            this.listAlphabet.FormattingEnabled = true;
            this.listAlphabet.Location = new System.Drawing.Point(30, 43);
            this.listAlphabet.Name = "listAlphabet";
            this.listAlphabet.Size = new System.Drawing.Size(39, 134);
            this.listAlphabet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alphabet:";
            // 
            // btnAddCharToString
            // 
            this.btnAddCharToString.Location = new System.Drawing.Point(75, 90);
            this.btnAddCharToString.Name = "btnAddCharToString";
            this.btnAddCharToString.Size = new System.Drawing.Size(126, 23);
            this.btnAddCharToString.TabIndex = 6;
            this.btnAddCharToString.Text = "Add Selected to String";
            this.btnAddCharToString.UseVisualStyleBackColor = true;
            this.btnAddCharToString.Click += new System.EventHandler(this.btnAddCharToString_Click);
            // 
            // txtStartingString
            // 
            this.txtStartingString.Location = new System.Drawing.Point(207, 93);
            this.txtStartingString.Name = "txtStartingString";
            this.txtStartingString.ReadOnly = true;
            this.txtStartingString.Size = new System.Drawing.Size(138, 20);
            this.txtStartingString.TabIndex = 7;
            this.txtStartingString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(226, 119);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveLast.TabIndex = 8;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "*NOTE - all other locations will be filled with the empty character";
            // 
            // StartingString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.txtStartingString);
            this.Controls.Add(this.btnAddCharToString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAlphabet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "StartingString";
            this.Text = "StartingString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listAlphabet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCharToString;
        private System.Windows.Forms.TextBox txtStartingString;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Label label3;
    }
}