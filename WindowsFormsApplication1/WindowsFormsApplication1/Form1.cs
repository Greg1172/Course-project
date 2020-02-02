using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Kurs : Form
    {
        public Kurs()
        {
            InitializeComponent();
            button1.Enabled = false;
            domainUpDown1.Enabled = false;
            domainUpDown2.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
        }

        static int a;
        static int b;
        static int c;
        static int d;
        private int[,] matrix;
        private int[,] matrix2;
        private int[,] matrixItog;
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        string name, filePath;
        private void domainUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void domainUpDown2_KeyPress(object sender, KeyPressEventArgs e) // с помощью этого метода делаю так, что могут вводиться только цифры и backspace 
        {
            char c = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            Int32.TryParse(domainUpDown1.Text,out a);
            if (domainUpDown1.Text.Trim() != "")
            {
                int number = Convert.ToInt32(System.Text.RegularExpressions.Regex.Match(domainUpDown1.Text, @"\d+").Value);//получение значений из textBox

                if (number >= 100 || number <= 0)
                {
                    MessageBox.Show("Число должно быть от 1 до 100!");
                    domainUpDown1.Text = Convert.ToString(12);
                }
            }
            matrix = new int[a, b];
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    matrix[i, j] = 0;
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
            matrix2 = new int[b, a];
            dataGridView2.RowCount = b;
            dataGridView2.ColumnCount = a;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    matrix2[i, j] = 0;
                    dataGridView2.Rows[i].Cells[j].Value = matrix2[i, j].ToString();
                }
            }
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            Int32.TryParse(domainUpDown2.Text,out b);
            if (domainUpDown2.Text.Trim() != "")
            {
                int number = Convert.ToInt32(System.Text.RegularExpressions.Regex.Match(domainUpDown2.Text, @"\d+").Value);//получение значений из textBox

                if (number >= 100 || number <= 0)
                {
                    MessageBox.Show("Число должно быть от 1 до 100!");
                    domainUpDown2.Text = Convert.ToString(12);
                }
            }
            matrix = new int[a, b];
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    matrix[i, j] = 0;
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            matrix2 = new int[b, a];
            dataGridView2.RowCount = b;
            dataGridView2.ColumnCount = a;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    matrix2[i, j] = 0;
                    dataGridView2.Rows[i].Cells[j].Value = matrix2[i, j].ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button10.Enabled = true;
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                dataGridView2.RowCount = b;
                dataGridView2.ColumnCount = a;
                int[,] mat = new int[b, a];
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        matrix2[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }

            matrixItog = WindowsFormsApplication1.Class2.Calc(matrix, matrix2, a, b);

            dataGridView3.RowCount = a;
            dataGridView3.ColumnCount = a;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                 for (int j = 0; j < dataGridView3.ColumnCount; j++)
                 {
                     dataGridView3.Rows[i].Cells[j].Value = (matrixItog[i, j]).ToString();
                 }               
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button1.Enabled = true;
                domainUpDown1.Enabled = true;
                domainUpDown2.Enabled = true;
                button10.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                domainUpDown1.Enabled = false;
                domainUpDown2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button9.Enabled = true;
            }
            else
            {
                button9.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            button1.Enabled = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                string[] mass = File.ReadAllLines(filePath);
                a = Convert.ToInt32(mass[0]);
                b = Convert.ToInt32(mass[1]);
                dataGridView1.RowCount = a;
                dataGridView1.ColumnCount = b;
                matrix = new int[a, b];

                for (int p = 0; p < a; p++)
                {
                    int[] m = mass[p + 2].Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                    for (int i = 0; i < m.Length; i++)
                    {
                        matrix[p, i] = m[i];
                        dataGridView1.Rows[p].Cells[i].Value = (matrix[p, i]).ToString();

                    }
                }
                int g = a + 2;
                c = Convert.ToInt32(mass[g]);
                d = Convert.ToInt32(mass[g + 1]);
                dataGridView2.RowCount = c;
                dataGridView2.ColumnCount = d;
                matrix2 = new int[c, d];

                for (int o = 0; o < c; o++)
                {
                    int[] mat = mass[(g + 2) + o].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                    for (int h = 0; h < mat.Length; h++)
                    {
                        matrix2[o, h] = mat[h];
                        dataGridView2.Rows[o].Cells[h].Value = (matrix2[o, h]).ToString();
                    }
                }

                button9.Text = "Начать заполнение заново";
                button9.BackColor = Color.Red;
                if(a != d || b != c)
                {
                    MessageBox.Show("В текстовом документе совершена ошибка:" +
                        "кол-во строк должно быть равно количесвтву столцов!");
                    button1.Enabled = false;
                    button13.Enabled = false;
                }                
            } 
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string s = WindowsFormsApplication1.Class2.Print(matrixItog, a);
            e.Graphics.DrawString(s, new Font("Arial", 14), Brushes.Black, 50, 50); //рисовка массива с выбором шрифта и цвета
        }

        private void button10_Click(object sender, EventArgs e) //вывод на принтер
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)                        //при нажатии "ок" печатает
            {
                printDialog.Document.Print();                                       //вызов функции печати
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int val = 0;

            try
            {
                val = Convert.ToInt32(dataGridView1[e.ColumnIndex, e.RowIndex].Value);

                if ((val >= 100) || (val <= -100))                                              //если не входит в диапазон вызвать исключение
                    throw new InvalidOperationException
                       ("В данном столбце число должно принадлежать диапазону [-100,100]");

                dataGridView1[e.ColumnIndex, e.RowIndex].Value = val;
            }
            catch (InvalidOperationException x)
            {
                MessageBox.Show(x.Message);
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = 0;
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int val = 0;
            try
            {
                val = Convert.ToInt32(dataGridView2[e.ColumnIndex, e.RowIndex].Value);

                if ((val >= 100) || (val <= -100))                                              //если не входит в диапазон вызвать исключение
                    throw new InvalidOperationException
                       ("В данном столбце число должно принадлежать диапазону [-100,100]");

                dataGridView2[e.ColumnIndex, e.RowIndex].Value = val;
            }
            catch (InvalidOperationException x)
            {
                MessageBox.Show(x.Message);
                dataGridView2[e.ColumnIndex, e.RowIndex].Value = 0;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Cell_KeyPress);          //вызов проверки ввода
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Cell_KeyPress);          //вызов проверки ввода
        }


        private void Cell_KeyPress(object Sender, KeyPressEventArgs e)               //запрет ввода кроме цифр и клавиш удаления и знака '-'
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
                e.KeyChar = Convert.ToChar("\0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[,] arr1 = new string[a, a];
            string[] mas1 = new string[a + 2];
            dataGridView3.RowCount = a;
            dataGridView3.ColumnCount = a;
            mas1[0] = Convert.ToString(a);
            mas1[1] = Convert.ToString(a);
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                {
                    arr1[i, j] = Convert.ToString(dataGridView3.Rows[i].Cells[j].Value);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    mas1[i + 2] += arr1[i, j] + " ";   //сохранение из dataGridView в массив
                }
            }
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(name, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < a + 2; i++)
                    {
                        sw.WriteLine(mas1[i]);
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[,] arr1 = new string[a, b];
            string[] mas1 = new string[a + 2];
            string[,] arr2 = new string[b, a];
            string[] mas2 = new string[b + 2];
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            dataGridView2.RowCount = b;
            dataGridView2.ColumnCount = a;
            mas1[0] = Convert.ToString(a);
            mas1[1] = Convert.ToString(b);
            mas2[0] = Convert.ToString(b);
            mas2[1] = Convert.ToString(a);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    arr1[i, j] = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToInt32(arr1[i, j]);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mas1[i + 2] += arr1[i, j] + " ";   //сохранение из dataGridView в массив
                }
            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    arr2[i, j] = Convert.ToString(dataGridView2.Rows[i].Cells[j].Value);
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToInt32(arr2[i, j]);
                }
            }
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    mas2[i + 2] += arr2[i, j] + " ";   //сохранение из dataGridView в массив
                }
            }
            name = filePath;
                using (StreamWriter sw = new StreamWriter(name, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < a + 2; i++)
                    {
                        sw.WriteLine(mas1[i]);
                    }
                }
                using (StreamWriter sw = new StreamWriter(name, true, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < b + 2; i++)
                    {
                        sw.WriteLine(mas2[i]);
                    }
                }
            matrix = new int[a, b];
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToInt32(arr1[i, j]);
                    matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }
            matrix2 = new int[b, a];
            dataGridView2.RowCount = b;
            dataGridView2.ColumnCount = a;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToInt32(arr2[i, j]);
                    matrix2[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
        }
    }
}
