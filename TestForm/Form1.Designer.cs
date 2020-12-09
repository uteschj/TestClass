namespace TestForm
{
    partial class Form1
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
            this.ThreadedTestButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.TaskTestButton = new System.Windows.Forms.Button();
            this.CreateFilesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThreadedTestButton
            // 
            this.ThreadedTestButton.Location = new System.Drawing.Point(265, 138);
            this.ThreadedTestButton.Name = "ThreadedTestButton";
            this.ThreadedTestButton.Size = new System.Drawing.Size(154, 23);
            this.ThreadedTestButton.TabIndex = 1;
            this.ThreadedTestButton.Text = "Start Parallel Threaded Test";
            this.ThreadedTestButton.UseVisualStyleBackColor = true;
            this.ThreadedTestButton.Click += new System.EventHandler(this.ThreadedTestButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(71, 138);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(145, 23);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Start Single Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // TaskTestButton
            // 
            this.TaskTestButton.Location = new System.Drawing.Point(440, 138);
            this.TaskTestButton.Name = "TaskTestButton";
            this.TaskTestButton.Size = new System.Drawing.Size(145, 23);
            this.TaskTestButton.TabIndex = 3;
            this.TaskTestButton.Text = "Start Parallel Task Test";
            this.TaskTestButton.UseVisualStyleBackColor = true;
            this.TaskTestButton.Click += new System.EventHandler(this.TaskTestButton_Click);
            // 
            // CreateFilesButton
            // 
            this.CreateFilesButton.Location = new System.Drawing.Point(68, 12);
            this.CreateFilesButton.Name = "CreateFilesButton";
            this.CreateFilesButton.Size = new System.Drawing.Size(145, 23);
            this.CreateFilesButton.TabIndex = 4;
            this.CreateFilesButton.Text = "Create Test Files";
            this.CreateFilesButton.UseVisualStyleBackColor = true;
            this.CreateFilesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reads trs1.h10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reads trs1.h10 && trs2.h10 \r\nin separate threads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reads trs1.h10 && trs2.h10 \r\nin separate tasks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Creates 10mm record files (trs1.h10, trs2.h10)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 224);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateFilesButton);
            this.Controls.Add(this.TaskTestButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.ThreadedTestButton);
            this.Name = "Form1";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ThreadedTestButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button TaskTestButton;
        private System.Windows.Forms.Button CreateFilesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

