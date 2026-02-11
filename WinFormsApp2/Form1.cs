using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PC_Rental_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Настройка формы
            this.Text = "PC Rental - Главная";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(43, 45, 66);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Панель заголовка
            Panel headerPanel = new Panel();
            headerPanel.Size = new Size(900, 80);
            headerPanel.BackColor = Color.FromArgb(64, 66, 88);
            headerPanel.Dock = DockStyle.Top;

            Label titleLabel = new Label();
            titleLabel.Text = "🖥️ АРЕНДА ПК";
            titleLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(20, 20);

            headerPanel.Controls.Add(titleLabel);
            this.Controls.Add(headerPanel);

            // Панель с кнопками
            Panel buttonPanel = new Panel();
            buttonPanel.Size = new Size(300, 400);
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Location = new Point(300, 150);

            // Кнопки
            RoundedButton btnCatalog = new RoundedButton();
            btnCatalog.Text = "📋 Каталог ПК";
            btnCatalog.Size = new Size(280, 60);
            btnCatalog.Location = new Point(10, 10);
            btnCatalog.Font = new Font("Segoe UI", 14);
            btnCatalog.ForeColor = Color.White;
            btnCatalog.BackColor = Color.FromArgb(64, 66, 88);
            btnCatalog.FlatStyle = FlatStyle.Flat;
            btnCatalog.FlatAppearance.BorderSize = 0;
            btnCatalog.Cursor = Cursors.Hand;
            btnCatalog.Click += btnCatalog_Click;
            buttonPanel.Controls.Add(btnCatalog);

            RoundedButton btnRent = new RoundedButton();
            btnRent.Text = "🛒 Арендовать";
            btnRent.Size = new Size(280, 60);
            btnRent.Location = new Point(10, 90);
            btnRent.Font = new Font("Segoe UI", 14);
            btnRent.ForeColor = Color.White;
            btnRent.BackColor = Color.FromArgb(64, 66, 88);
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.FlatAppearance.BorderSize = 0;
            btnRent.Cursor = Cursors.Hand;
            btnRent.Click += btnRent_Click;
            buttonPanel.Controls.Add(btnRent);

            RoundedButton btnHistory = new RoundedButton();
            btnHistory.Text = "📊 История";
            btnHistory.Size = new Size(280, 60);
            btnHistory.Location = new Point(10, 170);
            btnHistory.Font = new Font("Segoe UI", 14);
            btnHistory.ForeColor = Color.White;
            btnHistory.BackColor = Color.FromArgb(64, 66, 88);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.Click += btnHistory_Click;
            buttonPanel.Controls.Add(btnHistory);

            RoundedButton btnExit = new RoundedButton();
            btnExit.Text = "❌ Выход";
            btnExit.Size = new Size(280, 60);
            btnExit.Location = new Point(10, 250);
            btnExit.Font = new Font("Segoe UI", 14);
            btnExit.ForeColor = Color.White;
            btnExit.BackColor = Color.FromArgb(239, 35, 60);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Click += btnExit_Click;
            buttonPanel.Controls.Add(btnExit);

            this.Controls.Add(buttonPanel);

            // Статус бар
            StatusStrip statusStrip = new StatusStrip();
            statusStrip.BackColor = Color.FromArgb(64, 66, 88);
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel();
            statusLabel.Text = "Готово к работе";
            statusLabel.ForeColor = Color.White;
            statusStrip.Items.Add(statusLabel);
            statusStrip.Dock = DockStyle.Bottom;
            this.Controls.Add(statusStrip);
        }

        // Обработчики событий
        private void btnCatalog_Click(object sender, EventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentForm rentForm = new RentForm();
            rentForm.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // Класс для скругленных кнопок (должен быть в том же файле!)
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(this.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(this.Width - 20, this.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, this.Height - 20, 20, 20, 90, 90);
            this.Region = new Region(path);
        }
    }
}