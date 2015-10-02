namespace Report_Test
{
    partial class Export_Opts
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
            this.grpPageRange = new System.Windows.Forms.GroupBox();
            this.btnOK = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblFromRange = new System.Windows.Forms.Label();
            this.lblToRange = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpPageRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPageRange
            // 
            this.grpPageRange.Controls.Add(this.textBox2);
            this.grpPageRange.Controls.Add(this.textBox1);
            this.grpPageRange.Controls.Add(this.lblToRange);
            this.grpPageRange.Controls.Add(this.lblFromRange);
            this.grpPageRange.Controls.Add(this.radioButton2);
            this.grpPageRange.Controls.Add(this.radioButton1);
            this.grpPageRange.Location = new System.Drawing.Point(8, 8);
            this.grpPageRange.Name = "grpPageRange";
            this.grpPageRange.Size = new System.Drawing.Size(296, 120);
            this.grpPageRange.TabIndex = 0;
            this.grpPageRange.TabStop = false;
            this.grpPageRange.Text = "Page Range";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(64, 136);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Page Range";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblFromRange
            // 
            this.lblFromRange.AutoSize = true;
            this.lblFromRange.Location = new System.Drawing.Point(16, 84);
            this.lblFromRange.Name = "lblFromRange";
            this.lblFromRange.Size = new System.Drawing.Size(36, 13);
            this.lblFromRange.TabIndex = 2;
            this.lblFromRange.Text = "From :";
            // 
            // lblToRange
            // 
            this.lblToRange.AutoSize = true;
            this.lblToRange.Location = new System.Drawing.Point(176, 84);
            this.lblToRange.Name = "lblToRange";
            this.lblToRange.Size = new System.Drawing.Size(26, 13);
            this.lblToRange.TabIndex = 3;
            this.lblToRange.Text = "To :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 5;
            // 
            // ExportOpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 173);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpPageRange);
            this.Name = "ExportOpts";
            this.Text = "ExportOpts";
            this.grpPageRange.ResumeLayout(false);
            this.grpPageRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPageRange;
        private C1.Win.C1Input.C1Button btnOK;
        private C1.Win.C1Input.C1Button btnCancel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblToRange;
        private System.Windows.Forms.Label lblFromRange;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}