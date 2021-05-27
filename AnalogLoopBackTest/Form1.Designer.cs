namespace AnalogLoopBackTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.inDataTextBox = new System.Windows.Forms.TextBox();
            this.outDatatextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReadAnalogDataButton_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(125, 27);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(186, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Analog Loop back";
            // 
            // textBox1
            // 
            this.inDataTextBox.Location = new System.Drawing.Point(100, 117);
            this.inDataTextBox.Name = "textBox1";
            this.inDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.inDataTextBox.TabIndex = 4;
            this.inDataTextBox.Text = "0";
            // 
            // textBox2
            // 
            this.outDatatextBox.Location = new System.Drawing.Point(100, 158);
            this.outDatatextBox.Name = "textBox2";
            this.outDatatextBox.Size = new System.Drawing.Size(100, 20);
            this.outDatatextBox.TabIndex = 5;
            this.outDatatextBox.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Write Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.WriteAnalogDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outDatatextBox);
            this.Controls.Add(this.inDataTextBox);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox inDataTextBox;
        private System.Windows.Forms.TextBox outDatatextBox;
        private System.Windows.Forms.Button button2;
    }
}

