
namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.C_Input = new System.Windows.Forms.NumericUpDown();
            this.K_Input = new System.Windows.Forms.NumericUpDown();
            this.Y_Input = new System.Windows.Forms.NumericUpDown();
            this.M_Input = new System.Windows.Forms.NumericUpDown();
            this.B_Input = new System.Windows.Forms.NumericUpDown();
            this.A_Input = new System.Windows.Forms.NumericUpDown();
            this.L_Input = new System.Windows.Forms.NumericUpDown();
            this.V_Input = new System.Windows.Forms.NumericUpDown();
            this.S_Input = new System.Windows.Forms.NumericUpDown();
            this.H_Input = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.C_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // C_Input
            // 
            this.C_Input.Location = new System.Drawing.Point(73, 147);
            this.C_Input.Name = "C_Input";
            this.C_Input.Size = new System.Drawing.Size(150, 27);
            this.C_Input.TabIndex = 0;
            this.C_Input.ValueChanged += new System.EventHandler(this.CMYK_ValueChanged);
            // 
            // K_Input
            // 
            this.K_Input.Location = new System.Drawing.Point(73, 246);
            this.K_Input.Name = "K_Input";
            this.K_Input.Size = new System.Drawing.Size(150, 27);
            this.K_Input.TabIndex = 1;
            this.K_Input.ValueChanged += new System.EventHandler(this.CMYK_ValueChanged);
            // 
            // Y_Input
            // 
            this.Y_Input.Location = new System.Drawing.Point(73, 213);
            this.Y_Input.Name = "Y_Input";
            this.Y_Input.Size = new System.Drawing.Size(150, 27);
            this.Y_Input.TabIndex = 2;
            this.Y_Input.ValueChanged += new System.EventHandler(this.CMYK_ValueChanged);
            // 
            // M_Input
            // 
            this.M_Input.Location = new System.Drawing.Point(73, 180);
            this.M_Input.Name = "M_Input";
            this.M_Input.Size = new System.Drawing.Size(150, 27);
            this.M_Input.TabIndex = 3;
            this.M_Input.ValueChanged += new System.EventHandler(this.CMYK_ValueChanged);
            // 
            // B_Input
            // 
            this.B_Input.Location = new System.Drawing.Point(337, 213);
            this.B_Input.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.B_Input.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.B_Input.Name = "B_Input";
            this.B_Input.Size = new System.Drawing.Size(150, 27);
            this.B_Input.TabIndex = 4;
            this.B_Input.ValueChanged += new System.EventHandler(this.LAB_ValueChanged);
            // 
            // A_Input
            // 
            this.A_Input.Location = new System.Drawing.Point(337, 180);
            this.A_Input.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.A_Input.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.A_Input.Name = "A_Input";
            this.A_Input.Size = new System.Drawing.Size(150, 27);
            this.A_Input.TabIndex = 5;
            this.A_Input.ValueChanged += new System.EventHandler(this.LAB_ValueChanged);
            // 
            // L_Input
            // 
            this.L_Input.Location = new System.Drawing.Point(337, 147);
            this.L_Input.Name = "L_Input";
            this.L_Input.Size = new System.Drawing.Size(150, 27);
            this.L_Input.TabIndex = 6;
            this.L_Input.ValueChanged += new System.EventHandler(this.LAB_ValueChanged);
            // 
            // V_Input
            // 
            this.V_Input.Location = new System.Drawing.Point(591, 213);
            this.V_Input.Name = "V_Input";
            this.V_Input.Size = new System.Drawing.Size(150, 27);
            this.V_Input.TabIndex = 7;
            this.V_Input.ValueChanged += new System.EventHandler(this.HSV_ValueChanged);
            // 
            // S_Input
            // 
            this.S_Input.Location = new System.Drawing.Point(591, 180);
            this.S_Input.Name = "S_Input";
            this.S_Input.Size = new System.Drawing.Size(150, 27);
            this.S_Input.TabIndex = 8;
            this.S_Input.ValueChanged += new System.EventHandler(this.HSV_ValueChanged);
            // 
            // H_Input
            // 
            this.H_Input.Location = new System.Drawing.Point(591, 147);
            this.H_Input.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.H_Input.Name = "H_Input";
            this.H_Input.Size = new System.Drawing.Size(150, 27);
            this.H_Input.TabIndex = 9;
            this.H_Input.ValueChanged += new System.EventHandler(this.HSV_ValueChanged);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(620, 343);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(121, 29);
            this.btnChoose.TabIndex = 10;
            this.btnChoose.Text = "Choose color";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "K";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "L";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "H";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "S";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(553, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "V";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.H_Input);
            this.Controls.Add(this.S_Input);
            this.Controls.Add(this.V_Input);
            this.Controls.Add(this.L_Input);
            this.Controls.Add(this.A_Input);
            this.Controls.Add(this.B_Input);
            this.Controls.Add(this.M_Input);
            this.Controls.Add(this.Y_Input);
            this.Controls.Add(this.K_Input);
            this.Controls.Add(this.C_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.C_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown C_Input;
        private System.Windows.Forms.NumericUpDown K_Input;
        private System.Windows.Forms.NumericUpDown Y_Input;
        private System.Windows.Forms.NumericUpDown M_Input;
        private System.Windows.Forms.NumericUpDown B_Input;
        private System.Windows.Forms.NumericUpDown A_Input;
        private System.Windows.Forms.NumericUpDown L_Input;
        private System.Windows.Forms.NumericUpDown V_Input;
        private System.Windows.Forms.NumericUpDown S_Input;
        private System.Windows.Forms.NumericUpDown H_Input;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

