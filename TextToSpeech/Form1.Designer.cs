namespace TextToSpeech
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
            this.txtTextToSay = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextToSay
            // 
            this.txtTextToSay.Location = new System.Drawing.Point(24, 31);
            this.txtTextToSay.Multiline = true;
            this.txtTextToSay.Name = "txtTextToSay";
            this.txtTextToSay.Size = new System.Drawing.Size(393, 178);
            this.txtTextToSay.TabIndex = 0;
            this.txtTextToSay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(541, 186);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Speak";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 260);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTextToSay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextToSay;
        private System.Windows.Forms.Button btnStart;
    }
}

