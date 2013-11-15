namespace TileSetGenerator.TuringMachine
{
    partial class States
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
            this.txtAddNewState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewState = new System.Windows.Forms.Button();
            this.lstStates = new System.Windows.Forms.ListBox();
            this.lstAlphabet = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAlphabet = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.btnRemoveState = new System.Windows.Forms.Button();
            this.transitionTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddNewState
            // 
            this.txtAddNewState.Location = new System.Drawing.Point(84, 12);
            this.txtAddNewState.Name = "txtAddNewState";
            this.txtAddNewState.Size = new System.Drawing.Size(37, 20);
            this.txtAddNewState.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "State Name: ";
            // 
            // btnAddNewState
            // 
            this.btnAddNewState.Location = new System.Drawing.Point(137, 9);
            this.btnAddNewState.Name = "btnAddNewState";
            this.btnAddNewState.Size = new System.Drawing.Size(94, 23);
            this.btnAddNewState.TabIndex = 8;
            this.btnAddNewState.Text = "Add New State";
            this.btnAddNewState.UseVisualStyleBackColor = true;
            this.btnAddNewState.Click += new System.EventHandler(this.btnAddNewState_Click);
            // 
            // lstStates
            // 
            this.lstStates.FormattingEnabled = true;
            this.lstStates.Location = new System.Drawing.Point(13, 47);
            this.lstStates.Name = "lstStates";
            this.lstStates.Size = new System.Drawing.Size(65, 225);
            this.lstStates.TabIndex = 9;
            // 
            // lstAlphabet
            // 
            this.lstAlphabet.FormattingEnabled = true;
            this.lstAlphabet.Location = new System.Drawing.Point(166, 47);
            this.lstAlphabet.Name = "lstAlphabet";
            this.lstAlphabet.Size = new System.Drawing.Size(65, 225);
            this.lstAlphabet.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Write to: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Move: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Next State: ";
            // 
            // cboAlphabet
            // 
            this.cboAlphabet.FormattingEnabled = true;
            this.cboAlphabet.Location = new System.Drawing.Point(84, 307);
            this.cboAlphabet.Name = "cboAlphabet";
            this.cboAlphabet.Size = new System.Drawing.Size(121, 21);
            this.cboAlphabet.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioRight);
            this.panel1.Controls.Add(this.radioLeft);
            this.panel1.Location = new System.Drawing.Point(84, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 36);
            this.panel1.TabIndex = 15;
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(3, 9);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(43, 17);
            this.radioLeft.TabIndex = 16;
            this.radioLeft.TabStop = true;
            this.radioLeft.Text = "Left";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(53, 9);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(50, 17);
            this.radioRight.TabIndex = 17;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Right";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(84, 373);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 21);
            this.cboState.TabIndex = 16;
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.Location = new System.Drawing.Point(18, 400);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(187, 23);
            this.btnUpdateState.TabIndex = 17;
            this.btnUpdateState.Text = "Update";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            this.btnUpdateState.Click += new System.EventHandler(this.btnUpdateState_Click);
            // 
            // btnRemoveState
            // 
            this.btnRemoveState.Location = new System.Drawing.Point(13, 278);
            this.btnRemoveState.Name = "btnRemoveState";
            this.btnRemoveState.Size = new System.Drawing.Size(218, 23);
            this.btnRemoveState.TabIndex = 18;
            this.btnRemoveState.Text = "Remove Selected State";
            this.btnRemoveState.UseVisualStyleBackColor = true;
            this.btnRemoveState.Click += new System.EventHandler(this.btnRemoveState_Click);
            // 
            // transitionTable
            // 
            this.transitionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transitionTable.Location = new System.Drawing.Point(275, 47);
            this.transitionTable.Name = "transitionTable";
            this.transitionTable.ReadOnly = true;
            this.transitionTable.Size = new System.Drawing.Size(532, 405);
            this.transitionTable.TabIndex = 19;
            // 
            // States
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 483);
            this.Controls.Add(this.transitionTable);
            this.Controls.Add(this.btnRemoveState);
            this.Controls.Add(this.btnUpdateState);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboAlphabet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAlphabet);
            this.Controls.Add(this.lstStates);
            this.Controls.Add(this.btnAddNewState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddNewState);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "States";
            this.Text = "States";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddNewState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewState;
        private System.Windows.Forms.ListBox lstStates;
        private System.Windows.Forms.ListBox lstAlphabet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAlphabet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Button btnUpdateState;
        private System.Windows.Forms.Button btnRemoveState;
        private System.Windows.Forms.DataGridView transitionTable;
    }
}