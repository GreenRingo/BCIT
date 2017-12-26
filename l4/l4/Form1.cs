﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace l4
{
     public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();       // Список слов
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();
                string text = File.ReadAllText(fd.FileName);         //Чтение файла в виде строки
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n', '—', ')', '(' };           //Разделительные символы для чтения из файла
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();                   //Удаление пробелов в начале и конце строки
                    if (!list.Contains(str) && str.Length != 0) //Добавление строки в список, если строка не содержится в списке
                        list.Add(str);        
                }
                t.Stop();
                this.text_box2.Text = t.Elapsed.ToString();
                add_to_list_box(list);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string word = this.text_box1.Text.Trim();        //Слово для поиска
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)     //Если слово для поиска не пусто
            {
                string wordUpper = word.ToUpper();   //Слово для поиска в верхнем регистре
                List<string> tempList = new List<string>();      //Временные результаты поиска
                Stopwatch t = new Stopwatch();
                t.Start();
                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                if (tempList.Count == 0) {
                    MessageBox.Show("Искомое слово не найдено!");
                }
                t.Stop();
                this.text_box4.Text = t.Elapsed.ToString();
                list_box1.SelectedIndex = list_box1.FindStringExact(text_box1.Text);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void list_box1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        void add_to_list_box(List <string> arr) 
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            list_box1.Items.Clear();
            list_box1.BeginUpdate();
            foreach (string l in arr)
            {
                list_box1.Items.Add(l);
            }
            list_box1.EndUpdate();
            t.Stop();
            this.text_box3.Text = t.Elapsed.ToString();
        }
    }
}
