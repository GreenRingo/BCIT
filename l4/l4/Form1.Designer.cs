﻿namespace l4
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
            this.list_box1.Size = new System.Drawing.Size(551, 364);
            this.list_box1.TabIndex = 1;
            //this.list_box1.SelectedIndexChanged += new System.EventHandler(this.list_box1_SelectedIndexChanged);
            // 
            // text_box1
            // 
            this.text_box1.BackColor = System.Drawing.Color.GhostWhite;
            this.text_box1.Location = new System.Drawing.Point(118, 60);
            this.text_box1.Name = "text_box1";
            this.text_box1.Size = new System.Drawing.Size(242, 26);
            this.text_box1.TabIndex = 2;
            //this.text_box1.TextChanged += new System.EventHandler(this.text_box1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(405, 54);
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
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время сохранения";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_box2
            // 
            this.text_box2.BackColor = System.Drawing.SystemColors.Menu;
            this.text_box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_box2.Location = new System.Drawing.Point(260, 558);
            this.text_box2.Name = "text_box2";
            this.text_box2.Size = new System.Drawing.Size(187, 26);
            this.text_box2.TabIndex = 7;
            //this.text_box2.TextChanged += new System.EventHandler(this.text_box2_TextChanged);
            // 
            // text_box3
            // 
            this.text_box3.BackColor = System.Drawing.SystemColors.Menu;
            this.text_box3.Location = new System.Drawing.Point(260, 590);
            this.text_box3.Name = "text_box3";
            this.text_box3.Size = new System.Drawing.Size(187, 26);
            this.text_box3.TabIndex = 8;
            //this.text_box3.TextChanged += new System.EventHandler(this.text_box3_TextChanged);
            // 
            // text_box4
            // 
            this.text_box4.BackColor = System.Drawing.SystemColors.Menu;
            this.text_box4.Location = new System.Drawing.Point(260, 625);
            this.text_box4.Name = "text_box4";
            this.text_box4.Size = new System.Drawing.Size(187, 26);
            this.text_box4.TabIndex = 9;
            //this.text_box4.TextChanged += new System.EventHandler(this.text_box4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 712);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

