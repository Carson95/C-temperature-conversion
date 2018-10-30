namespace Temperature_Conversion
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
            this.convertBtn = new System.Windows.Forms.Button();
            this.fChoice = new System.Windows.Forms.RadioButton();
            this.cChoice = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.temp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(100, 27);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(175, 22);
            this.convertBtn.TabIndex = 0;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // fChoice
            // 
            this.fChoice.AutoSize = true;
            this.fChoice.CausesValidation = false;
            this.fChoice.Location = new System.Drawing.Point(3, 3);
            this.fChoice.Name = "fChoice";
            this.fChoice.Size = new System.Drawing.Size(91, 17);
            this.fChoice.TabIndex = 1;
            this.fChoice.Text = "To Fahrenheit";
            this.fChoice.UseVisualStyleBackColor = true;
            // 
            // cChoice
            // 
            this.cChoice.AutoSize = true;
            this.cChoice.Checked = true;
            this.cChoice.Location = new System.Drawing.Point(281, 4);
            this.cChoice.Name = "cChoice";
            this.cChoice.Size = new System.Drawing.Size(75, 17);
            this.cChoice.TabIndex = 2;
            this.cChoice.TabStop = true;
            this.cChoice.Text = "To Celcius";
            this.cChoice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.temp);
            this.panel1.Controls.Add(this.fChoice);
            this.panel1.Controls.Add(this.convertBtn);
            this.panel1.Controls.Add(this.cChoice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 54);
            this.panel1.TabIndex = 4;
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(100, 1);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(175, 20);
            this.temp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 79);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Temperature Conversion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.RadioButton fChoice;
        private System.Windows.Forms.RadioButton cChoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox temp;
    }
}

