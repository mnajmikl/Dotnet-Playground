namespace ExternalProcess
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpMain = new GroupBox();
            txtArguments = new TextBox();
            lblArguments = new Label();
            txtExecutable = new TextBox();
            lblProcess = new Label();
            grpButtons = new GroupBox();
            lblExtProc = new Label();
            btnKillProcess = new Button();
            btnRunProcess = new Button();
            grpMain.SuspendLayout();
            grpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // grpMain
            // 
            grpMain.Controls.Add(txtArguments);
            grpMain.Controls.Add(lblArguments);
            grpMain.Controls.Add(txtExecutable);
            grpMain.Controls.Add(lblProcess);
            grpMain.Location = new Point(12, 12);
            grpMain.Name = "grpMain";
            grpMain.Size = new Size(454, 133);
            grpMain.TabIndex = 0;
            grpMain.TabStop = false;
            grpMain.Text = "External Process Options";
            // 
            // txtArguments
            // 
            txtArguments.Location = new Point(121, 83);
            txtArguments.Name = "txtArguments";
            txtArguments.Size = new Size(327, 23);
            txtArguments.TabIndex = 3;
            // 
            // lblArguments
            // 
            lblArguments.AutoSize = true;
            lblArguments.Location = new Point(6, 86);
            lblArguments.Name = "lblArguments";
            lblArguments.Size = new Size(109, 15);
            lblArguments.TabIndex = 2;
            lblArguments.Text = "Process Arguments";
            // 
            // txtExecutable
            // 
            txtExecutable.Location = new Point(121, 39);
            txtExecutable.Name = "txtExecutable";
            txtExecutable.Size = new Size(327, 23);
            txtExecutable.TabIndex = 1;
            txtExecutable.TextChanged += txtExecutable_TextChanged;
            // 
            // lblProcess
            // 
            lblProcess.AutoSize = true;
            lblProcess.Location = new Point(6, 42);
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new Size(107, 15);
            lblProcess.TabIndex = 0;
            lblProcess.Text = "Process Executable";
            // 
            // grpButtons
            // 
            grpButtons.Controls.Add(lblExtProc);
            grpButtons.Controls.Add(btnKillProcess);
            grpButtons.Controls.Add(btnRunProcess);
            grpButtons.Location = new Point(52, 151);
            grpButtons.Name = "grpButtons";
            grpButtons.Size = new Size(369, 81);
            grpButtons.TabIndex = 1;
            grpButtons.TabStop = false;
            // 
            // lblExtProc
            // 
            lblExtProc.AutoSize = true;
            lblExtProc.Location = new Point(25, 54);
            lblExtProc.Name = "lblExtProc";
            lblExtProc.Size = new Size(66, 15);
            lblExtProc.TabIndex = 2;
            lblExtProc.Text = "No process";
            // 
            // btnKillProcess
            // 
            btnKillProcess.Enabled = false;
            btnKillProcess.Location = new Point(194, 17);
            btnKillProcess.Name = "btnKillProcess";
            btnKillProcess.Size = new Size(144, 25);
            btnKillProcess.TabIndex = 1;
            btnKillProcess.Text = "Kill Process";
            btnKillProcess.UseVisualStyleBackColor = true;
            btnKillProcess.Click += btnKillProcess_Click;
            // 
            // btnRunProcess
            // 
            btnRunProcess.Enabled = false;
            btnRunProcess.Location = new Point(25, 17);
            btnRunProcess.Name = "btnRunProcess";
            btnRunProcess.Size = new Size(149, 25);
            btnRunProcess.TabIndex = 0;
            btnRunProcess.Text = "Run";
            btnRunProcess.UseVisualStyleBackColor = true;
            btnRunProcess.Click += btnRunProcess_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 238);
            Controls.Add(grpButtons);
            Controls.Add(grpMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "External Process Example";
            grpMain.ResumeLayout(false);
            grpMain.PerformLayout();
            grpButtons.ResumeLayout(false);
            grpButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMain;
        private TextBox txtArguments;
        private Label lblArguments;
        private TextBox txtExecutable;
        private Label lblProcess;
        private GroupBox grpButtons;
        private Button btnKillProcess;
        private Button btnRunProcess;
        private Label lblExtProc;
    }
}