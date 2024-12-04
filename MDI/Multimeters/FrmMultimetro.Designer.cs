namespace Instrumentation
{
    partial class FormMultimetro
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.btnVoltDC = new System.Windows.Forms.Button();
            this.btnVoltAC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.LbMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblDisplay
            // 
            this.LblDisplay.BackColor = System.Drawing.Color.Black;
            this.LblDisplay.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblDisplay.Location = new System.Drawing.Point(-14, 0);
            this.LblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(1317, 220);
            this.LblDisplay.TabIndex = 0;
            this.LblDisplay.Text = "- - - - - - - - - - - ";
            this.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltDC
            // 
            this.btnVoltDC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVoltDC.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltDC.Location = new System.Drawing.Point(246, 272);
            this.btnVoltDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltDC.Name = "btnVoltDC";
            this.btnVoltDC.Size = new System.Drawing.Size(130, 85);
            this.btnVoltDC.TabIndex = 1;
            this.btnVoltDC.Tag = "DC V";
            this.btnVoltDC.Text = "DC V";
            this.btnVoltDC.UseVisualStyleBackColor = false;
            this.btnVoltDC.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVoltAC
            // 
            this.btnVoltAC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVoltAC.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltAC.Location = new System.Drawing.Point(424, 272);
            this.btnVoltAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltAC.Name = "btnVoltAC";
            this.btnVoltAC.Size = new System.Drawing.Size(130, 85);
            this.btnVoltAC.TabIndex = 2;
            this.btnVoltAC.Tag = "AC V";
            this.btnVoltAC.Text = "AC V";
            this.btnVoltAC.UseVisualStyleBackColor = false;
            this.btnVoltAC.Click += new System.EventHandler(this.btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(597, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 85);
            this.button1.TabIndex = 3;
            this.button1.Tag = "Resistor";
            this.button1.Text = "Ω";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(778, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 85);
            this.button2.TabIndex = 4;
            this.button2.Tag = "Freq";
            this.button2.Text = "Freq";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(597, 358);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 85);
            this.button3.TabIndex = 5;
            this.button3.Tag = "Cont";
            this.button3.Text = "Cont \r\n>>>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(424, 358);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 85);
            this.button4.TabIndex = 6;
            this.button4.Tag = "AC I";
            this.button4.Text = "AC I";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(246, 358);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 85);
            this.button5.TabIndex = 7;
            this.button5.Tag = "DC I";
            this.button5.Text = "DC I";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button10.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(778, 272);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 85);
            this.button10.TabIndex = 11;
            this.button10.Tag = "Diode";
            this.button10.Text = "Diode";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btn_Click);
            // 
            // LbMode
            // 
            this.LbMode.AutoSize = true;
            this.LbMode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbMode.ForeColor = System.Drawing.Color.Lime;
            this.LbMode.Location = new System.Drawing.Point(951, 180);
            this.LbMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbMode.Name = "LbMode";
            this.LbMode.Size = new System.Drawing.Size(57, 20);
            this.LbMode.TabIndex = 12;
            this.LbMode.Text = "MODE";
            this.LbMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMultimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 522);
            this.Controls.Add(this.LbMode);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoltAC);
            this.Controls.Add(this.btnVoltDC);
            this.Controls.Add(this.LblDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMultimetro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label LblDisplay;
        private System.Windows.Forms.Button btnVoltDC;
        private System.Windows.Forms.Button btnVoltAC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label LbMode;
    }
}

