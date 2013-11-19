namespace TileSetGenerator.TuringMachine
{
    partial class TuringMachineSetup
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
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlphabetSetup = new System.Windows.Forms.Label();
            this.lblStartStringSetup = new System.Windows.Forms.Label();
            this.lblStateSetup = new System.Windows.Forms.Label();
            this.btnOpenAlphabetSetup = new System.Windows.Forms.Button();
            this.btnOpenStartStringSetup = new System.Windows.Forms.Button();
            this.btnOpenStatesSetup = new System.Windows.Forms.Button();
            this.btnCreateTuringMachineSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 166);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(90, 23);
            this.btnBackToMenu.TabIndex = 0;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please go through the following stages to complete the tile set:";
            // 
            // lblAlphabetSetup
            // 
            this.lblAlphabetSetup.AutoSize = true;
            this.lblAlphabetSetup.BackColor = System.Drawing.Color.Red;
            this.lblAlphabetSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphabetSetup.Location = new System.Drawing.Point(126, 49);
            this.lblAlphabetSetup.Name = "lblAlphabetSetup";
            this.lblAlphabetSetup.Size = new System.Drawing.Size(129, 17);
            this.lblAlphabetSetup.TabIndex = 2;
            this.lblAlphabetSetup.Text = "Alphabet Setup: ";
            // 
            // lblStartStringSetup
            // 
            this.lblStartStringSetup.AutoSize = true;
            this.lblStartStringSetup.BackColor = System.Drawing.Color.Red;
            this.lblStartStringSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartStringSetup.Location = new System.Drawing.Point(85, 79);
            this.lblStartStringSetup.Name = "lblStartStringSetup";
            this.lblStartStringSetup.Size = new System.Drawing.Size(170, 17);
            this.lblStartStringSetup.TabIndex = 3;
            this.lblStartStringSetup.Text = "Starting String Setup: ";
            // 
            // lblStateSetup
            // 
            this.lblStateSetup.AutoSize = true;
            this.lblStateSetup.BackColor = System.Drawing.Color.Red;
            this.lblStateSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateSetup.Location = new System.Drawing.Point(144, 113);
            this.lblStateSetup.Name = "lblStateSetup";
            this.lblStateSetup.Size = new System.Drawing.Size(111, 17);
            this.lblStateSetup.TabIndex = 4;
            this.lblStateSetup.Text = "States Setup: ";
            // 
            // btnOpenAlphabetSetup
            // 
            this.btnOpenAlphabetSetup.Location = new System.Drawing.Point(261, 49);
            this.btnOpenAlphabetSetup.Name = "btnOpenAlphabetSetup";
            this.btnOpenAlphabetSetup.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAlphabetSetup.TabIndex = 5;
            this.btnOpenAlphabetSetup.Text = "Setup";
            this.btnOpenAlphabetSetup.UseVisualStyleBackColor = true;
            this.btnOpenAlphabetSetup.Click += new System.EventHandler(this.btnOpenAlphabetSetup_Click);
            // 
            // btnOpenStartStringSetup
            // 
            this.btnOpenStartStringSetup.Location = new System.Drawing.Point(261, 79);
            this.btnOpenStartStringSetup.Name = "btnOpenStartStringSetup";
            this.btnOpenStartStringSetup.Size = new System.Drawing.Size(75, 23);
            this.btnOpenStartStringSetup.TabIndex = 6;
            this.btnOpenStartStringSetup.Text = "Setup";
            this.btnOpenStartStringSetup.UseVisualStyleBackColor = true;
            this.btnOpenStartStringSetup.Click += new System.EventHandler(this.btnOpenStartStringSetup_Click);
            // 
            // btnOpenStatesSetup
            // 
            this.btnOpenStatesSetup.Location = new System.Drawing.Point(261, 113);
            this.btnOpenStatesSetup.Name = "btnOpenStatesSetup";
            this.btnOpenStatesSetup.Size = new System.Drawing.Size(75, 23);
            this.btnOpenStatesSetup.TabIndex = 7;
            this.btnOpenStatesSetup.Text = "Setup";
            this.btnOpenStatesSetup.UseVisualStyleBackColor = true;
            this.btnOpenStatesSetup.Click += new System.EventHandler(this.btnOpenStatesSetup_Click);
            // 
            // btnCreateTuringMachineSet
            // 
            this.btnCreateTuringMachineSet.Location = new System.Drawing.Point(360, 169);
            this.btnCreateTuringMachineSet.Name = "btnCreateTuringMachineSet";
            this.btnCreateTuringMachineSet.Size = new System.Drawing.Size(98, 23);
            this.btnCreateTuringMachineSet.TabIndex = 8;
            this.btnCreateTuringMachineSet.Text = "Create Tile Set";
            this.btnCreateTuringMachineSet.UseVisualStyleBackColor = true;
            this.btnCreateTuringMachineSet.Click += new System.EventHandler(this.btnCreateTuringMachineSet_Click);
            // 
            // TuringMachineSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 204);
            this.Controls.Add(this.btnCreateTuringMachineSet);
            this.Controls.Add(this.btnOpenStatesSetup);
            this.Controls.Add(this.btnOpenStartStringSetup);
            this.Controls.Add(this.btnOpenAlphabetSetup);
            this.Controls.Add(this.lblStateSetup);
            this.Controls.Add(this.lblStartStringSetup);
            this.Controls.Add(this.lblAlphabetSetup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToMenu);
            this.Name = "TuringMachineSetup";
            this.Text = "Turing Alphabet Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlphabetSetup;
        private System.Windows.Forms.Label lblStartStringSetup;
        private System.Windows.Forms.Label lblStateSetup;
        private System.Windows.Forms.Button btnOpenAlphabetSetup;
        private System.Windows.Forms.Button btnOpenStartStringSetup;
        private System.Windows.Forms.Button btnOpenStatesSetup;
        private System.Windows.Forms.Button btnCreateTuringMachineSet;
    }
}