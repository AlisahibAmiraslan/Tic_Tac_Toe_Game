namespace TicTacToe
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            button11 = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(97, 14);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(335, 14);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "Bilgisayar: ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(97, 54);
            button1.Name = "button1";
            button1.Size = new Size(111, 100);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(216, 54);
            button2.Name = "button2";
            button2.Size = new Size(111, 100);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(335, 54);
            button3.Name = "button3";
            button3.Size = new Size(111, 100);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(97, 160);
            button4.Name = "button4";
            button4.Size = new Size(111, 100);
            button4.TabIndex = 7;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(216, 160);
            button5.Name = "button5";
            button5.Size = new Size(111, 100);
            button5.TabIndex = 6;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(335, 159);
            button6.Name = "button6";
            button6.Size = new Size(111, 100);
            button6.TabIndex = 5;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(97, 265);
            button7.Name = "button7";
            button7.Size = new Size(111, 100);
            button7.TabIndex = 10;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(216, 265);
            button8.Name = "button8";
            button8.Size = new Size(111, 100);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(335, 265);
            button9.Name = "button9";
            button9.Size = new Size(111, 100);
            button9.TabIndex = 8;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(64, 0, 0);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(216, 388);
            button10.Name = "button10";
            button10.Size = new Size(121, 51);
            button10.TabIndex = 11;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RestartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 12;
            // 
            // button11
            // 
            button11.BackColor = Color.Black;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.Window;
            button11.Location = new Point(362, 12);
            button11.Name = "button11";
            button11.Size = new Size(94, 40);
            button11.TabIndex = 13;
            button11.Text = "Ekle";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 14;
            label3.Text = "Adınızı Giriniz:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button11);
            groupBox1.Location = new Point(123, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 61);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(59, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(547, 446);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Tic Tac Toe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
        private TextBox textBox1;
        private Button button11;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}