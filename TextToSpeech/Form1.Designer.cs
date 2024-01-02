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
            this.txtText = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtRecognizedSpeech = new System.Windows.Forms.TextBox();
            this.btnStartRecognition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(328, 48);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(656, 26);
            this.txtText.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SeaGreen;
            this.btn1.Location = new System.Drawing.Point(594, 118);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(102, 50);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Run";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtRecognizedSpeech
            // 
            this.txtRecognizedSpeech.Location = new System.Drawing.Point(404, 252);
            this.txtRecognizedSpeech.Name = "txtRecognizedSpeech";
            this.txtRecognizedSpeech.Size = new System.Drawing.Size(499, 26);
            this.txtRecognizedSpeech.TabIndex = 2;
            // 
            // btnStartRecognition
            // 
            this.btnStartRecognition.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStartRecognition.Location = new System.Drawing.Point(583, 305);
            this.btnStartRecognition.Name = "btnStartRecognition";
            this.btnStartRecognition.Size = new System.Drawing.Size(123, 87);
            this.btnStartRecognition.TabIndex = 3;
            this.btnStartRecognition.Text = "Start Recognition";
            this.btnStartRecognition.UseVisualStyleBackColor = false;
            this.btnStartRecognition.Click += new System.EventHandler(this.btnStartRecognition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1297, 543);
            this.Controls.Add(this.btnStartRecognition);
            this.Controls.Add(this.txtRecognizedSpeech);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtRecognizedSpeech;
        private System.Windows.Forms.Button btnStartRecognition;
    }
}

