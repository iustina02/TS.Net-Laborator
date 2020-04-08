namespace Client.Pages
{
    public partial class AddProp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewPropName = new System.Windows.Forms.Label();
            this.NewPropNameTextBox = new System.Windows.Forms.TextBox();
            this.NewPropDetailTextBox = new System.Windows.Forms.TextBox();
            this.NewPropDetail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPropName
            // 
            this.NewPropName.AutoSize = true;
            this.NewPropName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPropName.Location = new System.Drawing.Point(2, 11);
            this.NewPropName.Name = "NewPropName";
            this.NewPropName.Size = new System.Drawing.Size(128, 20);
            this.NewPropName.TabIndex = 23;
            this.NewPropName.Text = "New Prop Name";
            // 
            // NewPropNameTextBox
            // 
            this.NewPropNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPropNameTextBox.Location = new System.Drawing.Point(3, 34);
            this.NewPropNameTextBox.Name = "NewPropNameTextBox";
            this.NewPropNameTextBox.Size = new System.Drawing.Size(194, 25);
            this.NewPropNameTextBox.TabIndex = 24;
            // 
            // NewPropDetailTextBox
            // 
            this.NewPropDetailTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPropDetailTextBox.Location = new System.Drawing.Point(3, 85);
            this.NewPropDetailTextBox.Name = "NewPropDetailTextBox";
            this.NewPropDetailTextBox.Size = new System.Drawing.Size(194, 25);
            this.NewPropDetailTextBox.TabIndex = 25;
            this.NewPropDetailTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NewPropDetail
            // 
            this.NewPropDetail.AutoSize = true;
            this.NewPropDetail.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPropDetail.Location = new System.Drawing.Point(3, 62);
            this.NewPropDetail.Name = "NewPropDetail";
            this.NewPropDetail.Size = new System.Drawing.Size(51, 20);
            this.NewPropDetail.TabIndex = 26;
            this.NewPropDetail.Text = "Detail";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewPropDetail);
            this.Controls.Add(this.NewPropName);
            this.Controls.Add(this.NewPropDetailTextBox);
            this.Controls.Add(this.NewPropNameTextBox);
            this.Name = "AddProp";
            this.Size = new System.Drawing.Size(201, 172);
            this.Load += new System.EventHandler(this.AddProp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPropName;
        private System.Windows.Forms.TextBox NewPropNameTextBox;
        private System.Windows.Forms.TextBox NewPropDetailTextBox;
        private System.Windows.Forms.Label NewPropDetail;
        private System.Windows.Forms.Button button1;
    }
}
