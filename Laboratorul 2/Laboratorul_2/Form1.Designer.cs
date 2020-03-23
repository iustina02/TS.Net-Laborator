namespace Laboratorul_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.unu = new System.Windows.Forms.Button();
            this.doi = new System.Windows.Forms.Button();
            this.trei = new System.Windows.Forms.Button();
            this.patru = new System.Windows.Forms.Button();
            this.cinci = new System.Windows.Forms.Button();
            this.sase = new System.Windows.Forms.Button();
            this.sapte = new System.Windows.Forms.Button();
            this.opt = new System.Windows.Forms.Button();
            this.noua = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.punct = new System.Windows.Forms.Button();
            this.left_para = new System.Windows.Forms.Button();
            this.right_para = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // textBox1
            // 
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(21, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(240, 279);
            this.plus.Margin = new System.Windows.Forms.Padding(2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(56, 44);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(240, 208);
            this.minus.Margin = new System.Windows.Forms.Padding(2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(56, 44);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(240, 137);
            this.multiply.Margin = new System.Windows.Forms.Padding(2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(56, 44);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button2_Click);
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(240, 72);
            this.devide.Margin = new System.Windows.Forms.Padding(2);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(56, 44);
            this.devide.TabIndex = 5;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.button3_Click);
            // 
            // unu
            // 
            this.unu.Location = new System.Drawing.Point(21, 137);
            this.unu.Margin = new System.Windows.Forms.Padding(2);
            this.unu.Name = "unu";
            this.unu.Size = new System.Drawing.Size(56, 44);
            this.unu.TabIndex = 6;
            this.unu.Text = "1";
            this.unu.UseVisualStyleBackColor = true;
            this.unu.Click += new System.EventHandler(this.unu_Click);
            // 
            // doi
            // 
            this.doi.Location = new System.Drawing.Point(92, 137);
            this.doi.Margin = new System.Windows.Forms.Padding(2);
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(56, 44);
            this.doi.TabIndex = 7;
            this.doi.Text = "2";
            this.doi.UseVisualStyleBackColor = true;
            this.doi.Click += new System.EventHandler(this.doi_Click);
            // 
            // trei
            // 
            this.trei.Location = new System.Drawing.Point(164, 137);
            this.trei.Margin = new System.Windows.Forms.Padding(2);
            this.trei.Name = "trei";
            this.trei.Size = new System.Drawing.Size(56, 44);
            this.trei.TabIndex = 8;
            this.trei.Text = "3";
            this.trei.UseVisualStyleBackColor = true;
            this.trei.Click += new System.EventHandler(this.trei_Click);
            // 
            // patru
            // 
            this.patru.Location = new System.Drawing.Point(21, 208);
            this.patru.Margin = new System.Windows.Forms.Padding(2);
            this.patru.Name = "patru";
            this.patru.Size = new System.Drawing.Size(56, 44);
            this.patru.TabIndex = 9;
            this.patru.Text = "4";
            this.patru.UseVisualStyleBackColor = true;
            this.patru.Click += new System.EventHandler(this.patru_Click);
            // 
            // cinci
            // 
            this.cinci.Location = new System.Drawing.Point(92, 208);
            this.cinci.Margin = new System.Windows.Forms.Padding(2);
            this.cinci.Name = "cinci";
            this.cinci.Size = new System.Drawing.Size(56, 44);
            this.cinci.TabIndex = 10;
            this.cinci.Text = "5";
            this.cinci.UseVisualStyleBackColor = true;
            this.cinci.Click += new System.EventHandler(this.cinci_Click);
            // 
            // sase
            // 
            this.sase.Location = new System.Drawing.Point(164, 208);
            this.sase.Margin = new System.Windows.Forms.Padding(2);
            this.sase.Name = "sase";
            this.sase.Size = new System.Drawing.Size(56, 44);
            this.sase.TabIndex = 11;
            this.sase.Text = "6";
            this.sase.UseVisualStyleBackColor = true;
            this.sase.Click += new System.EventHandler(this.sase_Click);
            // 
            // sapte
            // 
            this.sapte.Location = new System.Drawing.Point(21, 279);
            this.sapte.Margin = new System.Windows.Forms.Padding(2);
            this.sapte.Name = "sapte";
            this.sapte.Size = new System.Drawing.Size(56, 44);
            this.sapte.TabIndex = 12;
            this.sapte.Text = "7";
            this.sapte.UseVisualStyleBackColor = true;
            this.sapte.Click += new System.EventHandler(this.sapte_Click);
            // 
            // opt
            // 
            this.opt.Location = new System.Drawing.Point(92, 279);
            this.opt.Margin = new System.Windows.Forms.Padding(2);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(56, 44);
            this.opt.TabIndex = 13;
            this.opt.Text = "8";
            this.opt.UseVisualStyleBackColor = true;
            this.opt.Click += new System.EventHandler(this.opt_Click);
            // 
            // noua
            // 
            this.noua.Location = new System.Drawing.Point(164, 279);
            this.noua.Margin = new System.Windows.Forms.Padding(2);
            this.noua.Name = "noua";
            this.noua.Size = new System.Drawing.Size(56, 44);
            this.noua.TabIndex = 14;
            this.noua.Text = "9";
            this.noua.UseVisualStyleBackColor = true;
            this.noua.Click += new System.EventHandler(this.button12_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(240, 340);
            this.result.Margin = new System.Windows.Forms.Padding(2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(56, 44);
            this.result.TabIndex = 15;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(92, 340);
            this.zero.Margin = new System.Windows.Forms.Padding(2);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(56, 44);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(21, 340);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(56, 44);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // punct
            // 
            this.punct.Location = new System.Drawing.Point(164, 340);
            this.punct.Margin = new System.Windows.Forms.Padding(2);
            this.punct.Name = "punct";
            this.punct.Size = new System.Drawing.Size(56, 44);
            this.punct.TabIndex = 18;
            this.punct.Text = ".";
            this.punct.UseVisualStyleBackColor = true;
            this.punct.Click += new System.EventHandler(this.punct_Click);
            // 
            // left_para
            // 
            this.left_para.Location = new System.Drawing.Point(21, 72);
            this.left_para.Margin = new System.Windows.Forms.Padding(2);
            this.left_para.Name = "left_para";
            this.left_para.Size = new System.Drawing.Size(56, 44);
            this.left_para.TabIndex = 19;
            this.left_para.Text = "(";
            this.left_para.UseVisualStyleBackColor = true;
            // 
            // right_para
            // 
            this.right_para.Location = new System.Drawing.Point(92, 72);
            this.right_para.Margin = new System.Windows.Forms.Padding(2);
            this.right_para.Name = "right_para";
            this.right_para.Size = new System.Drawing.Size(56, 44);
            this.right_para.TabIndex = 20;
            this.right_para.Text = ")";
            this.right_para.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "0";
            // 
            // deleteone
            // 
            this.deleteone.Location = new System.Drawing.Point(164, 72);
            this.deleteone.Margin = new System.Windows.Forms.Padding(2);
            this.deleteone.Name = "deleteone";
            this.deleteone.Size = new System.Drawing.Size(56, 44);
            this.deleteone.TabIndex = 22;
            this.deleteone.Text = "<=";
            this.deleteone.UseVisualStyleBackColor = true;
            this.deleteone.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 398);
            this.Controls.Add(this.deleteone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.right_para);
            this.Controls.Add(this.left_para);
            this.Controls.Add(this.punct);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.result);
            this.Controls.Add(this.noua);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.sapte);
            this.Controls.Add(this.sase);
            this.Controls.Add(this.cinci);
            this.Controls.Add(this.patru);
            this.Controls.Add(this.trei);
            this.Controls.Add(this.doi);
            this.Controls.Add(this.unu);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button unu;
        private System.Windows.Forms.Button doi;
        private System.Windows.Forms.Button trei;
        private System.Windows.Forms.Button patru;
        private System.Windows.Forms.Button cinci;
        private System.Windows.Forms.Button sase;
        private System.Windows.Forms.Button sapte;
        private System.Windows.Forms.Button opt;
        private System.Windows.Forms.Button noua;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button punct;
        private System.Windows.Forms.Button left_para;
        private System.Windows.Forms.Button right_para;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteone;
        private System.Windows.Forms.TextBox textBox1;
    }
}

