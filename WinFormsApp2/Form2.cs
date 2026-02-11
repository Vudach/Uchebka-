using System;
using System.Drawing;
using System.Windows.Forms;

namespace PC_Rental_App
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "PC Rental - Каталог";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(43, 45, 66);

            // Заголовок
            Label title = new Label();
            title.Text = "📋 КАТАЛОГ КОМПЬЮТЕРОВ";
            title.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.AutoSize = true;
            title.Location = new Point(20, 20);
            this.Controls.Add(title);

            // Панель с карточками
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Size = new Size(860, 400);
            flowPanel.Location = new Point(20, 80);
            flowPanel.AutoScroll = true;

            // Карточки ПК
            string[] pcs = {
                "Gaming PC RTX 4080\nЦена: 500₽/час",
                "Office PC i5\nЦена: 150₽/час",
                "Workstation Xeon\nЦена: 300₽/час",
                "Streaming PC Ryzen 9\nЦена: 450₽/час"
            };

            foreach (string pc in pcs)
            {
                Panel card = CreatePCCard(pc);
                flowPanel.Controls.Add(card);
            }

            this.Controls.Add(flowPanel);

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
            backBtn.Click += (s, e) => {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            };
            this.Controls.Add(backBtn);
        }

        private Panel CreatePCCard(string info)
        {
            Panel card = new Panel();
            card.Size = new Size(200, 180);
            card.BackColor = Color.FromArgb(64, 66, 88);
            card.Margin = new Padding(10);

            // Иконка
            Label icon = new Label();
            icon.Text = "🖥️";
            icon.Font = new Font("Segoe UI", 40);
            icon.AutoSize = true;
            icon.Location = new Point(70, 20);
            card.Controls.Add(icon);

            // Описание
            Label desc = new Label();
            desc.Text = info;
            desc.Font = new Font("Segoe UI", 11);
            desc.ForeColor = Color.White;
            desc.TextAlign = ContentAlignment.MiddleCenter;
            desc.Size = new Size(180, 80);
            desc.Location = new Point(10, 90);
            card.Controls.Add(desc);

            return card;
        }
    }
}