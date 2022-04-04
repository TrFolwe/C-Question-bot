namespace MGame
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionButton1 = new System.Windows.Forms.Button();
            this.QuestionButton2 = new System.Windows.Forms.Button();
            this.QuestionButton3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.correctCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wrongCount = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Enabled = false;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox.Location = new System.Drawing.Point(121, 46);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(262, 138);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru:";
            // 
            // questionCount
            // 
            this.questionCount.AutoSize = true;
            this.questionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.questionCount.Location = new System.Drawing.Point(86, 54);
            this.questionCount.Name = "questionCount";
            this.questionCount.Size = new System.Drawing.Size(19, 20);
            this.questionCount.TabIndex = 2;
            this.questionCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(126, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "BİLGİ YARIŞMASI";
            // 
            // QuestionButton1
            // 
            this.QuestionButton1.BackColor = System.Drawing.Color.LemonChiffon;
            this.QuestionButton1.Enabled = false;
            this.QuestionButton1.Location = new System.Drawing.Point(131, 205);
            this.QuestionButton1.Name = "QuestionButton1";
            this.QuestionButton1.Size = new System.Drawing.Size(96, 45);
            this.QuestionButton1.TabIndex = 4;
            this.QuestionButton1.Text = "Soru 1";
            this.QuestionButton1.UseVisualStyleBackColor = false;
            this.QuestionButton1.Click += new System.EventHandler(this.Question1_Click);
            // 
            // QuestionButton2
            // 
            this.QuestionButton2.BackColor = System.Drawing.Color.LemonChiffon;
            this.QuestionButton2.Enabled = false;
            this.QuestionButton2.Location = new System.Drawing.Point(261, 205);
            this.QuestionButton2.Name = "QuestionButton2";
            this.QuestionButton2.Size = new System.Drawing.Size(96, 45);
            this.QuestionButton2.TabIndex = 5;
            this.QuestionButton2.Text = "Soru 2";
            this.QuestionButton2.UseVisualStyleBackColor = false;
            this.QuestionButton2.Click += new System.EventHandler(this.QuestionButton2_Click);
            // 
            // QuestionButton3
            // 
            this.QuestionButton3.BackColor = System.Drawing.Color.LemonChiffon;
            this.QuestionButton3.Enabled = false;
            this.QuestionButton3.Location = new System.Drawing.Point(131, 268);
            this.QuestionButton3.Name = "QuestionButton3";
            this.QuestionButton3.Size = new System.Drawing.Size(96, 45);
            this.QuestionButton3.TabIndex = 6;
            this.QuestionButton3.Text = "Soru 3";
            this.QuestionButton3.UseVisualStyleBackColor = false;
            this.QuestionButton3.Click += new System.EventHandler(this.QuestionButton3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(458, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalan süre:";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeText.Location = new System.Drawing.Point(552, 54);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(34, 20);
            this.timeText.TabIndex = 9;
            this.timeText.Text = "0:0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(458, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Doğru Sayısı:";
            // 
            // correctCount
            // 
            this.correctCount.AutoSize = true;
            this.correctCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.correctCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correctCount.Location = new System.Drawing.Point(567, 98);
            this.correctCount.Name = "correctCount";
            this.correctCount.Size = new System.Drawing.Size(19, 20);
            this.correctCount.TabIndex = 11;
            this.correctCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(458, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Yanlış Sayısı:";
            // 
            // wrongCount
            // 
            this.wrongCount.AutoSize = true;
            this.wrongCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wrongCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wrongCount.Location = new System.Drawing.Point(567, 142);
            this.wrongCount.Name = "wrongCount";
            this.wrongCount.Size = new System.Drawing.Size(19, 20);
            this.wrongCount.TabIndex = 13;
            this.wrongCount.Text = "0";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(432, 195);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(179, 89);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "BAŞLAT";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pasButton
            // 
            this.pasButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.pasButton.Enabled = false;
            this.pasButton.Location = new System.Drawing.Point(261, 268);
            this.pasButton.Name = "pasButton";
            this.pasButton.Size = new System.Drawing.Size(96, 45);
            this.pasButton.TabIndex = 15;
            this.pasButton.Text = "PAS";
            this.pasButton.UseVisualStyleBackColor = false;
            this.pasButton.Click += new System.EventHandler(this.pasButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(680, 342);
            this.Controls.Add(this.pasButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wrongCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.correctCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuestionButton3);
            this.Controls.Add(this.QuestionButton2);
            this.Controls.Add(this.QuestionButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questionCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button QuestionButton1;
        private System.Windows.Forms.Button QuestionButton2;
        private System.Windows.Forms.Button QuestionButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label correctCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label wrongCount;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pasButton;
    }
}
#endregion