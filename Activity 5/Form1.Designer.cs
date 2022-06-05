namespace Activity_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.inputFilePath = new System.Windows.Forms.TextBox();
            this.fileData = new System.Windows.Forms.RichTextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstWordBox = new System.Windows.Forms.TextBox();
            this.lastWordBox = new System.Windows.Forms.TextBox();
            this.longestWordBox = new System.Windows.Forms.TextBox();
            this.mostVowelsBox = new System.Windows.Forms.TextBox();
            this.outputFilePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input File Name: ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.inputFilePath, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.fileData, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(118, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.28829F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71171F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(527, 222);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // inputFilePath
            // 
            this.inputFilePath.Location = new System.Drawing.Point(3, 199);
            this.inputFilePath.Name = "inputFilePath";
            this.inputFilePath.Size = new System.Drawing.Size(521, 20);
            this.inputFilePath.TabIndex = 0;
            // 
            // fileData
            // 
            this.fileData.Location = new System.Drawing.Point(3, 3);
            this.fileData.Name = "fileData";
            this.fileData.Size = new System.Drawing.Size(521, 190);
            this.fileData.TabIndex = 1;
            this.fileData.Text = "";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(3, 3);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(264, 28);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select File";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel4.Controls.Add(this.selectBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(105, 438);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(534, 34);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(273, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(258, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Exit";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.83969F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.16031F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.firstWordBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lastWordBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.longestWordBox, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.mostVowelsBox, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(105, 273);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(534, 141);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Word: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Word:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Longest Word:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Most Vowels";
            // 
            // firstWordBox
            // 
            this.firstWordBox.Location = new System.Drawing.Point(87, 3);
            this.firstWordBox.Name = "firstWordBox";
            this.firstWordBox.Size = new System.Drawing.Size(435, 20);
            this.firstWordBox.TabIndex = 4;
            // 
            // lastWordBox
            // 
            this.lastWordBox.Location = new System.Drawing.Point(87, 38);
            this.lastWordBox.Name = "lastWordBox";
            this.lastWordBox.Size = new System.Drawing.Size(435, 20);
            this.lastWordBox.TabIndex = 5;
            // 
            // longestWordBox
            // 
            this.longestWordBox.Location = new System.Drawing.Point(87, 73);
            this.longestWordBox.Name = "longestWordBox";
            this.longestWordBox.Size = new System.Drawing.Size(435, 20);
            this.longestWordBox.TabIndex = 6;
            // 
            // mostVowelsBox
            // 
            this.mostVowelsBox.Location = new System.Drawing.Point(87, 108);
            this.mostVowelsBox.Name = "mostVowelsBox";
            this.mostVowelsBox.Size = new System.Drawing.Size(435, 20);
            this.mostVowelsBox.TabIndex = 7;
            // 
            // outputFilePath
            // 
            this.outputFilePath.Location = new System.Drawing.Point(118, 243);
            this.outputFilePath.Name = "outputFilePath";
            this.outputFilePath.Size = new System.Drawing.Size(524, 20);
            this.outputFilePath.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Output File Name: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(728, 541);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputFilePath);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(744, 580);
            this.MinimumSize = new System.Drawing.Size(744, 580);
            this.Name = "Form1";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox inputFilePath;
        private System.Windows.Forms.RichTextBox fileData;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstWordBox;
        private System.Windows.Forms.TextBox lastWordBox;
        private System.Windows.Forms.TextBox longestWordBox;
        private System.Windows.Forms.TextBox mostVowelsBox;
        private System.Windows.Forms.TextBox outputFilePath;
        private System.Windows.Forms.Label label7;
    }
}

