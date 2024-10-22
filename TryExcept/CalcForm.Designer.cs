namespace TryExcept
{
    partial class TryExceptForm
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
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSummation = new System.Windows.Forms.RadioButton();
            this.rbDifference = new System.Windows.Forms.RadioButton();
            this.rbMultiplication = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbExponentiation = new System.Windows.Forms.RadioButton();
            this.lblCalc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1 :";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNumber1.Location = new System.Drawing.Point(88, 3);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(338, 32);
            this.tbNumber1.TabIndex = 0;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNumber2.Location = new System.Drawing.Point(88, 67);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(338, 32);
            this.tbNumber2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "İşlem :";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnswer.Location = new System.Drawing.Point(88, 197);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(338, 32);
            this.tbAnswer.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 61);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cevap :";
            // 
            // rbSummation
            // 
            this.rbSummation.AutoSize = true;
            this.rbSummation.Location = new System.Drawing.Point(12, 3);
            this.rbSummation.Name = "rbSummation";
            this.rbSummation.Size = new System.Drawing.Size(102, 28);
            this.rbSummation.TabIndex = 0;
            this.rbSummation.TabStop = true;
            this.rbSummation.Text = "Toplama";
            this.rbSummation.UseVisualStyleBackColor = true;
            this.rbSummation.CheckedChanged += new System.EventHandler(this.rbSummation_CheckedChanged);
            // 
            // rbDifference
            // 
            this.rbDifference.AutoSize = true;
            this.rbDifference.Location = new System.Drawing.Point(131, 3);
            this.rbDifference.Name = "rbDifference";
            this.rbDifference.Size = new System.Drawing.Size(99, 28);
            this.rbDifference.TabIndex = 1;
            this.rbDifference.TabStop = true;
            this.rbDifference.Text = "Çıkarma";
            this.rbDifference.UseVisualStyleBackColor = true;
            this.rbDifference.CheckedChanged += new System.EventHandler(this.rbDifference_CheckedChanged);
            // 
            // rbMultiplication
            // 
            this.rbMultiplication.AutoSize = true;
            this.rbMultiplication.Location = new System.Drawing.Point(12, 37);
            this.rbMultiplication.Name = "rbMultiplication";
            this.rbMultiplication.Size = new System.Drawing.Size(96, 28);
            this.rbMultiplication.TabIndex = 3;
            this.rbMultiplication.TabStop = true;
            this.rbMultiplication.Text = "Çarpma";
            this.rbMultiplication.UseVisualStyleBackColor = true;
            this.rbMultiplication.CheckedChanged += new System.EventHandler(this.rbMultiplication_CheckedChanged);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(131, 37);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(84, 28);
            this.rbDivision.TabIndex = 4;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "Bölme";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.rbDivision_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbExponentiation);
            this.panel1.Controls.Add(this.rbSummation);
            this.panel1.Controls.Add(this.rbDifference);
            this.panel1.Controls.Add(this.rbDivision);
            this.panel1.Controls.Add(this.rbMultiplication);
            this.panel1.Controls.Add(this.lblCalc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(88, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 66);
            this.panel1.TabIndex = 10;
            // 
            // rbExponentiation
            // 
            this.rbExponentiation.AutoSize = true;
            this.rbExponentiation.Location = new System.Drawing.Point(239, 3);
            this.rbExponentiation.Name = "rbExponentiation";
            this.rbExponentiation.Size = new System.Drawing.Size(72, 28);
            this.rbExponentiation.TabIndex = 2;
            this.rbExponentiation.TabStop = true;
            this.rbExponentiation.Text = "Üs al";
            this.rbExponentiation.UseVisualStyleBackColor = true;
            this.rbExponentiation.CheckedChanged += new System.EventHandler(this.rbExponentiation_CheckedChanged_1);
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalc.Location = new System.Drawing.Point(261, 39);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(0, 24);
            this.lblCalc.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel1.Controls.Add(this.btnCalculation, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbAnswer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNumber2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNumber1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.10585F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.56267F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.9415F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 321);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnCalculation
            // 
            this.btnCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculation.Location = new System.Drawing.Point(88, 258);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(338, 60);
            this.btnCalculation.TabIndex = 2;
            this.btnCalculation.Text = "Hesapla";
            this.btnCalculation.UseVisualStyleBackColor = false;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // TryExceptForm
            // 
            this.AcceptButton = this.btnCalculation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TryExceptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSummation;
        private System.Windows.Forms.RadioButton rbDifference;
        private System.Windows.Forms.RadioButton rbMultiplication;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.RadioButton rbExponentiation;
    }
}

