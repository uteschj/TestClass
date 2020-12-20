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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.CreateFilesButton.Location = new System.Drawing.Point(71, 60);
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
            this.label4.Location = new System.Drawing.Point(235, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Creates 10mm record files (trs1.h10, trs2.h10)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 356);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "My System Specs\n\nCPU: i7-4930K @ 3.40GHz\nRAM: 32 GB\nHardware Raid 1 across two SS" +
    "Ds ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Approx Time: 0:42";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Approx Time: 1:31";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Approx Time: 1:26";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "1.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "2.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 464);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

