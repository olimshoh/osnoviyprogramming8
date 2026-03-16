namespace Laba
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            // numericUpDown1
            this.numericUpDown1.Location = new System.Drawing.Point(100, 20);
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown1.Maximum = 10;
            this.numericUpDown1.Value = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.Columns[0].Name = "Фамилия";
            this.dataGridView1.Columns[1].Name = "Имя";
            this.dataGridView1.Columns[2].Name = "Группа";
            this.dataGridView1.Columns[3].Name = "Оценка";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.RowHeadersVisible = false;

            // dataGridView2
            this.dataGridView2.Location = new System.Drawing.Point(20, 270);
            this.dataGridView2.Size = new System.Drawing.Size(500, 150);
            this.dataGridView2.ColumnCount = 4;
            this.dataGridView2.Columns[0].Name = "Фамилия";
            this.dataGridView2.Columns[1].Name = "Имя";
            this.dataGridView2.Columns[2].Name = "Группа";
            this.dataGridView2.Columns[3].Name = "Оценка";
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ReadOnly = true;

            // button1
            this.button1.Text = "Сохранить";
            this.button1.Location = new System.Drawing.Point(20, 220);
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Click += new System.EventHandler(this.button1_Click);


            // button3
            this.button3.Text = "Поиск";
            this.button3.Location = new System.Drawing.Point(420, 430);
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(70, 435);
            this.textBox1.Size = new System.Drawing.Size(100, 20);

            // textBox2
            this.textBox2.Location = new System.Drawing.Point(240, 435);
            this.textBox2.Size = new System.Drawing.Size(100, 20);

            // label1
            this.label1.Text = "Кол-во:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Size = new System.Drawing.Size(50, 20);

            // label2
            this.label2.Text = "Группа:";
            this.label2.Location = new System.Drawing.Point(20, 435);
            this.label2.Size = new System.Drawing.Size(50, 20);

            // label3
            this.label3.Text = "Оценка:";
            this.label3.Location = new System.Drawing.Point(190, 435);
            this.label3.Size = new System.Drawing.Size(50, 20);

            // label4
            this.label4.Text = "";
            this.label4.Location = new System.Drawing.Point(20, 480);
            this.label4.Size = new System.Drawing.Size(300, 20);
            this.label4.ForeColor = System.Drawing.Color.Red;

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 520);
            this.Text = "Лаба";
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
        }
    }
}