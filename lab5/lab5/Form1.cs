using System;
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

namespace lab5
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
                if (tempList.Count == 0)
                {
                    MessageBox.Show("Искомое слово не найдено!");
                }
                t.Stop();
                this.text_box4.Text = t.Elapsed.ToString();
                list_box1.SelectedIndex = list_box1.FindStringExact(text_box1.Text);
                Lev_distanse(text_box1.Text);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

        public static int Distance(string str1Param, string str2Param)
        {
            if ((str1Param == null) || (str2Param == null)) return -1;
            int str1Len = str1Param.Length;
            int str2Len = str2Param.Length;
            if ((str1Len == 0) && (str2Len == 0)) return 0;            //Если хотя бы одна строка пустая, возвращается длина другой строки
            if (str1Len == 0) return str2Len;
            if (str2Len == 0) return str1Len;
            string str1 = str1Param.ToUpper();     //Приведение строк к верхнему регистру
            string str2 = str2Param.ToUpper();
            int[,] matrix = new int[str1Len + 1, str2Len + 1];      //Объявление матрицы
            for (int i = 0; i <= str1Len; i++) matrix[i, 0] = i;    //Инициализация нулевой строки и нулевого столбца матрицы
            for (int j = 0; j <= str2Len; j++) matrix[0, j] = j;
            for (int i = 1; i <= str1Len; i++)            //Вычисление расстояния Дамерау-Левенштейна
            {
                for (int j = 1; j <= str2Len; j++)
                {
                    int symbEqual = ((str1.Substring(i - 1, 1) == str2.Substring(j - 1, 1)) ? 0 : 1); //Эквивалентность символов, переменная symbEqual соответствует m(s1[i],s2[j])
                    int ins = matrix[i, j - 1] + 1;     //Добавление
                    int del = matrix[i - 1, j] + 1;     //Удаление
                    int subst = matrix[i - 1, j - 1] + symbEqual;   //Замена
                    matrix[i, j] = Math.Min(Math.Min(ins, del), subst);       //Элемент матрицы вычисляется как минимальный из трех случаев
                    if ((i > 1) && (j > 1) && (str1.Substring(i - 1, 1) == str2.Substring(j - 2, 1)) && (str1.Substring(i - 2, 1) == str2.Substring(j - 1, 1)))             //Дополнение Дамерау по перестановке соседних символов
                    {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + symbEqual);
                    }
                }
            }
            return matrix[str1Len, str2Len]; //Возвращается нижний правый элемент матрицы
        }
        void add_to_list_box(List<string> arr)
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

        int Lev_distanse(string word) {
            list_box2.Items.Clear();
            int a = 0;
            bool f = int.TryParse(text_box5.Text, out a);
            if (!f || a < 0 || a % 1 != 0)
            {
                MessageBox.Show("Параметр введен неверно!"); 
                list_box2.Items.Clear();
                return 0;
            }
            list_box2.BeginUpdate();
            foreach (string s in list_box1.Items)
            {
                if (Distance(word, s) <= a)
                    list_box2.Items.Add(s);
            }
            list_box2.EndUpdate();
            return 0;
        }
    }
}
