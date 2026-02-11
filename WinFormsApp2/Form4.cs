using System;
using System.Drawing;
using System.Windows.Forms;

namespace PC_Rental_App
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "PC Rental - История";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(43, 45, 66);

            Label title = new Label();
            title.Text = "📊 ИСТОРИЯ АРЕНД";
            title.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.AutoSize = true;
            title.Location = new Point(20, 20);
            this.Controls.Add(title);

            // Таблица
            DataGridView grid = new DataGridView();
            grid.Size = new Size(840, 400);
            grid.Location = new Point(30, 80);
            grid.BackgroundColor = Color.FromArgb(64, 66, 88);
            grid.ForeColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 45, 66);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.EnableHeadersVisualStyles = false;

            // Колонки
            grid.Columns.Add("Date", "Дата");
            grid.Columns.Add("PC", "Компьютер");
            grid.Columns.Add("Hours", "Часы");
            grid.Columns.Add("Price", "Стоимость");

            // Пример данных
            grid.Rows.Add("01.01.2024", "Gaming PC RTX 4080", "3", "1500₽");
            grid.Rows.Add("02.01.2024", "Office PC i5", "5", "750₽");

            this.Controls.Add(grid);

            // Кнопка назад
            RoundedButton backBtn = new RoundedButton();
            backBtn.Text = "← Назад";
            backBtn.Size = new Size(120, 40);
            backBtn.Location = new Point(20, 500);
            backBtn.Font = new Font("Segoe UI", 12);
            backBtn.BackColor = Color.FromArgb(64, 66, 88);
            backBtn.ForeColor = Color.White;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Click += (s, e) =>
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            };
            this.Controls.Add(backBtn);
        }
    }
}