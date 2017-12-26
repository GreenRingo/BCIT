namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.list_box1 = new System.Windows.Forms.ListBox();
            this.text_box1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_box2 = new System.Windows.Forms.TextBox();
            this.text_box3 = new System.Windows.Forms.TextBox();
            this.text_box4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.list_box2 = new System.Windows.Forms.ListBox();
            this.text_box5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(523, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_box1
            // 
            this.list_box1.FormattingEnabled = true;
            this.list_box1.ItemHeight = 20;
            this.list_box1.Location = new System.Drawing.Point(93, 133);
            this.list_box1.Name = "list_box1";
            this.list_box1.Size = new System.Drawing.Size(237, 364);
            this.list_box1.TabIndex = 1;
            // 
            // text_box1
            // 
            this.text_box1.BackColor = System.Drawing.Color.GhostWhite;
            this.text_box1.Location = new System.Drawing.Point(93, 54);
            this.text_box1.Name = "text_box1";
            this.text_box1.Size = new System.Drawing.Size(242, 26);
            this.text_box1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(401, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Найти слово";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Время загрузки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время сохранения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска";
            // 
            // text_box2
            // 
            this.text_box2.BackColor = System.Drawing.SystemColors.Menu;
            this.text_box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_box2.Location = new System.Drawing.Point(260, 558);
            this.text_box2.Name = "text_box2";
            this.text_box2.Size = new System.Drawing.Size(187, 26);
            this.text_box2.TabIndex = 7;
            // 
            // text_box3
            // 
            this.text_box3.BackColor = System.Drawing.SystemColors.Menu;
            this.text_box3.Location = new System.Drawing.Point(260, 592);
            this.text_box3.Name = "text_box3";
            this.text_box3.Size = new System.Drawing.Size(187, 26);
            this.text_box3.TabIndex = 8;
            // 
            // text_box4
            // 
            this.text_box4.BackColor = System.Drawing.SystemColors.Menu;
            this.text_box4.Location = new System.Drawing.Point(260, 625);
            this.text_box4.Name = "text_box4";
            this.text_box4.Size = new System.Drawing.Size(187, 26);
            this.text_box4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Расстояние Левенштейна";
            // 
            // list_box2
            // 
            this.list_box2.FormattingEnabled = true;
            this.list_box2.ItemHeight = 20;
            this.list_box2.Location = new System.Drawing.Point(401, 253);
            this.list_box2.Name = "list_box2";
            this.list_box2.Size = new System.Drawing.Size(270, 244);
            this.list_box2.TabIndex = 11;
            // 
            // text_box5
            // 
            this.text_box5.Location = new System.Drawing.Point(401, 171);
            this.text_box5.Name = "text_box5";
            this.text_box5.Size = new System.Drawing.Size(283, 26);
            this.text_box5.TabIndex = 12;
            this.text_box5.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Введите максимальное расстояние";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 712);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_box5);
            this.Controls.Add(this.list_box2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_box4);
            this.Controls.Add(this.text_box3);
            this.Controls.Add(this.text_box2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_box1);
            this.Controls.Add(this.list_box1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Работа с файлами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_box1;
        private System.Windows.Forms.TextBox text_box1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_box2;
        private System.Windows.Forms.TextBox text_box3;
        private System.Windows.Forms.TextBox text_box4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_box2;
        private System.Windows.Forms.TextBox text_box5;
        private System.Windows.Forms.Label label5;
    }
}

