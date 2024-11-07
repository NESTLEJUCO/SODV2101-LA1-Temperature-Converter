namespace WindowsFormsApp1
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
            this.Temperature = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Backspace = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn_PlusMinus = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn_Decimal = new System.Windows.Forms.Button();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_Output2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature.Location = new System.Drawing.Point(203, 9);
            this.Temperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(369, 39);
            this.Temperature.TabIndex = 0;
            this.Temperature.Text = "Temperature Converter";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(580, 54);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 86);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "CE";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.AutoSizeChanged += new System.EventHandler(this.btn_Clear_Click);
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Backspace
            // 
            this.btn_Backspace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backspace.Location = new System.Drawing.Point(681, 54);
            this.btn_Backspace.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Backspace.Name = "btn_Backspace";
            this.btn_Backspace.Size = new System.Drawing.Size(93, 86);
            this.btn_Backspace.TabIndex = 2;
            this.btn_Backspace.Text = "⌫";
            this.btn_Backspace.UseVisualStyleBackColor = false;
            this.btn_Backspace.AutoSizeChanged += new System.EventHandler(this.btn_Backspace_Click);
            this.btn_Backspace.Click += new System.EventHandler(this.btn_Backspace_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(479, 148);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 86);
            this.button3.TabIndex = 3;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button3.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(580, 148);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 86);
            this.button4.TabIndex = 4;
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button4.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(681, 148);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 86);
            this.button5.TabIndex = 5;
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button5.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(479, 242);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 86);
            this.button6.TabIndex = 6;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button6.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(580, 242);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 86);
            this.button7.TabIndex = 7;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button7.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(681, 242);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 86);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button8.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(479, 336);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 86);
            this.button9.TabIndex = 9;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button9.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(580, 336);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 86);
            this.button10.TabIndex = 10;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button10.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(681, 336);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 86);
            this.button11.TabIndex = 11;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button11.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // btn_PlusMinus
            // 
            this.btn_PlusMinus.BackColor = System.Drawing.SystemColors.Info;
            this.btn_PlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlusMinus.Location = new System.Drawing.Point(479, 430);
            this.btn_PlusMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PlusMinus.Name = "btn_PlusMinus";
            this.btn_PlusMinus.Size = new System.Drawing.Size(93, 86);
            this.btn_PlusMinus.TabIndex = 12;
            this.btn_PlusMinus.Text = "±";
            this.btn_PlusMinus.UseVisualStyleBackColor = false;
            this.btn_PlusMinus.AutoSizeChanged += new System.EventHandler(this.btn_PlusMinus_Click);
            this.btn_PlusMinus.Click += new System.EventHandler(this.btn_PlusMinus_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(580, 430);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(93, 86);
            this.button13.TabIndex = 13;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.button13.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // btn_Decimal
            // 
            this.btn_Decimal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decimal.Location = new System.Drawing.Point(681, 430);
            this.btn_Decimal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Decimal.Name = "btn_Decimal";
            this.btn_Decimal.Size = new System.Drawing.Size(93, 86);
            this.btn_Decimal.TabIndex = 14;
            this.btn_Decimal.Text = ".";
            this.btn_Decimal.UseVisualStyleBackColor = false;
            this.btn_Decimal.AutoSizeChanged += new System.EventHandler(this.btn_Numbers);
            this.btn_Decimal.Click += new System.EventHandler(this.btn_Numbers);
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input.Location = new System.Drawing.Point(12, 91);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(87, 95);
            this.lbl_Input.TabIndex = 15;
            this.lbl_Input.Text = "0";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(15, 275);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(69, 76);
            this.lbl_Output.TabIndex = 16;
            this.lbl_Output.Text = "0";
            this.lbl_Output.Click += new System.EventHandler(this.lbl_Output_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "About equal to";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 33);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_Output2
            // 
            this.lbl_Output2.AutoSize = true;
            this.lbl_Output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output2.Location = new System.Drawing.Point(21, 423);
            this.lbl_Output2.Name = "lbl_Output2";
            this.lbl_Output2.Size = new System.Drawing.Size(36, 39);
            this.lbl_Output2.TabIndex = 19;
            this.lbl_Output2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 554);
            this.Controls.Add(this.lbl_Output2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.btn_Decimal);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btn_PlusMinus);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Backspace);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Temperature);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Backspace;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn_PlusMinus;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn_Decimal;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Output2;
    }
}

