namespace Laboratorul_1_3
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.startAsyncButton = new System.Windows.Forms.Button();
            this.cancelAsyncButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.first_start_time = new System.Windows.Forms.Label();
            this.second_start_time = new System.Windows.Forms.Label();
            this.first_end_time = new System.Windows.Forms.Label();
            this.second_end_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(118, 22);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(26, 13);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "First";
            // 
            // startAsyncButton
            // 
            this.startAsyncButton.Location = new System.Drawing.Point(121, 98);
            this.startAsyncButton.Name = "startAsyncButton";
            this.startAsyncButton.Size = new System.Drawing.Size(92, 23);
            this.startAsyncButton.TabIndex = 1;
            this.startAsyncButton.Text = "Start";
            this.startAsyncButton.UseVisualStyleBackColor = true;
            this.startAsyncButton.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // cancelAsyncButton
            // 
            this.cancelAsyncButton.Location = new System.Drawing.Point(121, 127);
            this.cancelAsyncButton.Name = "cancelAsyncButton";
            this.cancelAsyncButton.Size = new System.Drawing.Size(92, 23);
            this.cancelAsyncButton.TabIndex = 2;
            this.cancelAsyncButton.Text = "Cancel";
            this.cancelAsyncButton.UseVisualStyleBackColor = true;
            this.cancelAsyncButton.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // resultLabel2
            // 
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Location = new System.Drawing.Point(118, 60);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Size = new System.Drawing.Size(44, 13);
            this.resultLabel2.TabIndex = 3;
            this.resultLabel2.Text = "Second";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // first_start_time
            // 
            this.first_start_time.AutoSize = true;
            this.first_start_time.Location = new System.Drawing.Point(12, 22);
            this.first_start_time.Name = "first_start_time";
            this.first_start_time.Size = new System.Drawing.Size(51, 13);
            this.first_start_time.TabIndex = 4;
            this.first_start_time.Text = "Start time";
            // 
            // second_start_time
            // 
            this.second_start_time.AutoSize = true;
            this.second_start_time.Location = new System.Drawing.Point(12, 60);
            this.second_start_time.Name = "second_start_time";
            this.second_start_time.Size = new System.Drawing.Size(51, 13);
            this.second_start_time.TabIndex = 5;
            this.second_start_time.Text = "Start time";
            // 
            // first_end_time
            // 
            this.first_end_time.AutoSize = true;
            this.first_end_time.Location = new System.Drawing.Point(225, 22);
            this.first_end_time.Name = "first_end_time";
            this.first_end_time.Size = new System.Drawing.Size(51, 13);
            this.first_end_time.TabIndex = 6;
            this.first_end_time.Text = "End_time";
            // 
            // second_end_time
            // 
            this.second_end_time.AutoSize = true;
            this.second_end_time.Location = new System.Drawing.Point(225, 60);
            this.second_end_time.Name = "second_end_time";
            this.second_end_time.Size = new System.Drawing.Size(51, 13);
            this.second_end_time.TabIndex = 7;
            this.second_end_time.Text = "End_time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 200);
            this.Controls.Add(this.second_end_time);
            this.Controls.Add(this.first_end_time);
            this.Controls.Add(this.second_start_time);
            this.Controls.Add(this.first_start_time);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.cancelAsyncButton);
            this.Controls.Add(this.startAsyncButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button startAsyncButton;
        private System.Windows.Forms.Button cancelAsyncButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label resultLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label first_start_time;
        private System.Windows.Forms.Label second_start_time;
        private System.Windows.Forms.Label first_end_time;
        private System.Windows.Forms.Label second_end_time;
    }
}

