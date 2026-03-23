using System.Windows.Forms;

namespace DiplomaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private NumericUpDown numericRecordCount;
        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewResults;
        private Button btnSaveToFile;
        private Button btnLoadAndSearch;
        private TextBox txtGroup;
        private ComboBox cmbGrade;
        private Label lblGroup;
        private Label lblGrade;
        private Label lblRecordCount;
        private Label lblInputData;
        private Label lblResults;
        private Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numericRecordCount = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.ResultLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnLoadAndSearch = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblInputData = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericRecordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // numericRecordCount
            // 
            this.numericRecordCount.Location = new System.Drawing.Point(374, 14);
            this.numericRecordCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericRecordCount.Name = "numericRecordCount";
            this.numericRecordCount.Size = new System.Drawing.Size(60, 20);
            this.numericRecordCount.TabIndex = 0;
            this.numericRecordCount.ValueChanged += new System.EventHandler(this.numericRecordCount_ValueChanged);
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Group,
            this.Grade});
            this.dataGridViewInput.Location = new System.Drawing.Point(9, 65);
            this.dataGridViewInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowHeadersWidth = 51;
            this.dataGridViewInput.Size = new System.Drawing.Size(425, 244);
            this.dataGridViewInput.TabIndex = 2;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.Width = 80;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Оценка";
            this.Grade.Name = "Grade";
            this.Grade.Width = 60;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultLastName,
            this.ResultFirstName,
            this.ResultGroup,
            this.ResultGrade});
            this.dataGridViewResults.Location = new System.Drawing.Point(9, 341);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.Size = new System.Drawing.Size(425, 162);
            this.dataGridViewResults.TabIndex = 4;
            // 
            // ResultLastName
            // 
            this.ResultLastName.HeaderText = "Фамилия";
            this.ResultLastName.Name = "ResultLastName";
            // 
            // ResultFirstName
            // 
            this.ResultFirstName.HeaderText = "Имя";
            this.ResultFirstName.Name = "ResultFirstName";
            // 
            // ResultGroup
            // 
            this.ResultGroup.HeaderText = "Группа";
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Width = 80;
            // 
            // ResultGrade
            // 
            this.ResultGrade.HeaderText = "Оценка";
            this.ResultGrade.Name = "ResultGrade";
            this.ResultGrade.Width = 60;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(679, 157);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(112, 28);
            this.btnSaveToFile.TabIndex = 10;
            this.btnSaveToFile.Text = "Сохранить в файл";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnLoadAndSearch
            // 
            this.btnLoadAndSearch.Location = new System.Drawing.Point(679, 198);
            this.btnLoadAndSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadAndSearch.Name = "btnLoadAndSearch";
            this.btnLoadAndSearch.Size = new System.Drawing.Size(112, 28);
            this.btnLoadAndSearch.TabIndex = 11;
            this.btnLoadAndSearch.Text = "Найти";
            this.btnLoadAndSearch.UseVisualStyleBackColor = true;
            this.btnLoadAndSearch.Click += new System.EventHandler(this.btnLoadAndSearch_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(679, 75);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(114, 20);
            this.txtGroup.TabIndex = 6;
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmbGrade.Location = new System.Drawing.Point(679, 117);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(114, 21);
            this.cmbGrade.TabIndex = 8;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(679, 60);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(45, 13);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Группа:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(679, 101);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 13);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "Оценка:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(256, 16);
            this.lblRecordCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(114, 13);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "Количество записей:";
            // 
            // lblInputData
            // 
            this.lblInputData.AutoSize = true;
            this.lblInputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInputData.Location = new System.Drawing.Point(9, 49);
            this.lblInputData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputData.Name = "lblInputData";
            this.lblInputData.Size = new System.Drawing.Size(182, 17);
            this.lblInputData.TabIndex = 3;
            this.lblInputData.Text = "Ввод исходных данных:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblResults.Location = new System.Drawing.Point(9, 325);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(197, 17);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Результаты выполнения:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(679, 239);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 615);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadAndSearch);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.lblInputData);
            this.Controls.Add(this.dataGridViewInput);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.numericRecordCount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Учет защиты дипломных работ";
            ((System.ComponentModel.ISupportInitialize)(this.numericRecordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn ResultLastName;
        private DataGridViewTextBoxColumn ResultFirstName;
        private DataGridViewTextBoxColumn ResultGroup;
        private DataGridViewTextBoxColumn ResultGrade;
    }
}
