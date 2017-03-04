namespace WinFormsTrivia
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
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDifficulty = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(114, 6);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(121, 21);
            this.comboCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Difficulty";
            // 
            // comboDifficulty
            // 
            this.comboDifficulty.FormattingEnabled = true;
            this.comboDifficulty.Location = new System.Drawing.Point(114, 37);
            this.comboDifficulty.Name = "comboDifficulty";
            this.comboDifficulty.Size = new System.Drawing.Size(121, 21);
            this.comboDifficulty.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(241, 6);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(74, 52);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate Questions";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(596, 199);
            this.listBox1.TabIndex = 5;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select a question to answer (Double-Click)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Points:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(366, 9);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(13, 13);
            this.labelPoints.TabIndex = 9;
            this.labelPoints.Text = "[]";
            this.labelPoints.Click += new System.EventHandler(this.labelPoints_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 274);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboDifficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDifficulty;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPoints;
    }
}

