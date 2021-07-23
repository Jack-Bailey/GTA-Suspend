
namespace GTA_Suspend
{
    partial class Form1
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
            this.durationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.closeRadioButton = new System.Windows.Forms.RadioButton();
            this.programToSuspend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(12, 31);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(108, 23);
            this.durationBox.TabIndex = 0;
            this.durationBox.TextChanged += new System.EventHandler(this.durationBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duration (Seconds)";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(12, 78);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(176, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // closeRadioButton
            // 
            this.closeRadioButton.AutoSize = true;
            this.closeRadioButton.Location = new System.Drawing.Point(14, 55);
            this.closeRadioButton.Name = "closeRadioButton";
            this.closeRadioButton.Size = new System.Drawing.Size(102, 19);
            this.closeRadioButton.TabIndex = 2;
            this.closeRadioButton.TabStop = true;
            this.closeRadioButton.Text = "Close after run";
            this.closeRadioButton.UseVisualStyleBackColor = true;
            this.closeRadioButton.CheckedChanged += new System.EventHandler(this.closeRadioButton_CheckedChanged);
            // 
            // programToSuspend
            // 
            this.programToSuspend.Location = new System.Drawing.Point(126, 31);
            this.programToSuspend.Name = "programToSuspend";
            this.programToSuspend.Size = new System.Drawing.Size(131, 23);
            this.programToSuspend.TabIndex = 1;
            this.programToSuspend.TextChanged += new System.EventHandler(this.programToSuspend_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Program (Default: gta5)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 104);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programToSuspend);
            this.Controls.Add(this.closeRadioButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "GTA Suspend";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.RadioButton closeRadioButton;
        private System.Windows.Forms.TextBox programToSuspend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

