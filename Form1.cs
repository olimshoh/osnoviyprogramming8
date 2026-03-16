using System;
using System.IO;
using System.Windows.Forms;

namespace Laba
{
    public partial class Form1 : Form
    {
        string[] f = new string[10];
        string[] i = new string[10];
        string[] g = new string[10];
        int[] o = new int[10];
        int kol = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            dataGridView1.Rows.Clear();
            for (int j = 0; j < n; j++)
                dataGridView1.Rows.Add("", "", "", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kol = dataGridView1.Rows.Count;

            for (int j = 0; j < kol; j++)
            {
                if (dataGridView1.Rows[j].Cells[0].Value == null ||
                    dataGridView1.Rows[j].Cells[1].Value == null ||
                    dataGridView1.Rows[j].Cells[2].Value == null ||
                    dataGridView1.Rows[j].Cells[3].Value == null)
                {
                    MessageBox.Show("Заполни строку " + (j + 1));
                    return;
                }

                f[j] = dataGridView1.Rows[j].Cells[0].Value.ToString();
                i[j] = dataGridView1.Rows[j].Cells[1].Value.ToString();
                g[j] = dataGridView1.Rows[j].Cells[2].Value.ToString();

                if (!int.TryParse(dataGridView1.Rows[j].Cells[3].Value.ToString(), out o[j]))
                {
                    MessageBox.Show("Оценка должна быть числом");
                    return;
                }
            }
                        try
            {
                StreamWriter sw = new StreamWriter("data.txt");
                sw.WriteLine(kol);
                for (int j = 0; j < kol; j++)
                {
                    sw.WriteLine(f[j]);
                    sw.WriteLine(i[j]);
                    sw.WriteLine(g[j]);
                    sw.WriteLine(o[j]);
                }
                sw.Close();
                MessageBox.Show("Сохранено");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            if (kol == 0)
            {
                label4.Text = "Сначала загрузи";
                return;
            }

            string gr = textBox1.Text;
            string oc = textBox2.Text;

            if (gr == "" || oc == "")
            {
                label4.Text = "Введи группу и оценку";
                return;
            }

            int ocenka;
            if (!int.TryParse(oc, out ocenka))
            {
                label4.Text = "Оценка должна быть числом";
                return;
            }

            int count = 0;
            for (int j = 0; j < kol; j++)
            {
                if (g[j] == gr && o[j] == ocenka)
                {
                    dataGridView2.Rows.Add(f[j], i[j], g[j], o[j]);
                    count++;
                }
            }

            if (count == 0)
                label4.Text = "Ответ не найден";
            else
                label4.Text = "Найдено: " + count;
        }
    }
}