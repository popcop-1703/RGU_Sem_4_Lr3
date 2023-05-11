namespace Laboratorka_3
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
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.HighlightText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(968, 140);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(243, 69);
            button1.TabIndex = 0;
            button1.Text = "Внести данные ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkSlateGray;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(31, 290);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 254);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 2;
            label1.Text = "Название библиотеки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(200, 28);
            label2.TabIndex = 3;
            label2.Text = "Открыть/Закрыть";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 117);
            label3.Name = "label3";
            label3.Size = new Size(275, 28);
            label3.TabIndex = 4;
            label3.Text = "Вместимость хранилища";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 181);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 5;
            label4.Text = "Добавить книгу";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 12);
            textBox1.MaximumSize = new Size(500, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(500, 56);
            textBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(780, 109);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 45);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(780, 165);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 44);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 239);
            label6.Name = "label6";
            label6.Size = new Size(192, 28);
            label6.TabIndex = 12;
            label6.Text = "книгохранилище";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1082, 558);
            label7.Name = "label7";
            label7.Size = new Size(129, 28);
            label7.TabIndex = 13;
            label7.Text = "Вариант 10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 112);
            label8.Name = "label8";
            label8.Size = new Size(200, 28);
            label8.TabIndex = 14;
            label8.Text = "Открыть/Закрыть";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 153);
            label9.Name = "label9";
            label9.Size = new Size(135, 28);
            label9.TabIndex = 15;
            label9.Text = "библиотеку";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(499, 221);
            label10.Name = "label10";
            label10.Size = new Size(162, 28);
            label10.TabIndex = 18;
            label10.Text = "Забрать книгу";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(780, 221);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 44);
            textBox6.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(256, 111);
            button2.Name = "button2";
            button2.Size = new Size(51, 43);
            button2.TabIndex = 20;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(257, 211);
            button3.Name = "button3";
            button3.Size = new Size(50, 38);
            button3.TabIndex = 21;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1209, 605);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Лаба3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
    }
}