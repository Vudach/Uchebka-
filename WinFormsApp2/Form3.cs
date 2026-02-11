using System;
using System.Drawing;
using System.Windows.Forms;

namespace PC_Rental_App
{
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "PC Rental - Аренда";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(43, 45, 66);

            Label title = new Label();
            title.Text = "🛒 ОФОРМЛЕНИЕ АРЕНДЫ";
            title.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.AutoSize = true;
            title.Location = new Point(20, 20);
            this.Controls.Add(title);

            // Поля ввода
            int y = 80;
            string[] labels = { "Выберите ПК:", "Количество часов:", "Ваше имя:", "Телефон:" };

            // Комбобокс для выбора ПК
            Label lblPC = new Label();
            lblPC.Text = labels[0];
            lblPC.Font = new Font("Segoe UI", 12);
            lblPC.ForeColor = Color.White;
            lblPC.AutoSize = true;
            lblPC.Location = new Point(50, y);
            this.Controls.Add(lblPC);

            ComboBox comboPC = new ComboBox();
            comboPC.Items.AddRange(new string[] { "Gaming PC RTX 4080", "Office PC i5", "Workstation Xeon", "Streaming PC Ryzen 9" });
            comboPC.Size = new Size(300, 30);
            comboPC.Location = new Point(250, y - 5);
            comboPC.Font = new Font("Segoe UI", 11);
            this.Controls.Add(comboPC);
            y += 60;

            // Поле для часов
            Label lblHours = new Label();
            lblHours.Text = labels[1];
            lblHours.Font = new Font("Segoe UI", 12);
            lblHours.ForeColor = Color.White;
            lblHours.AutoSize = true;
            lblHours.Location = new Point(50, y);
            this.Controls.Add(lblHours);

            TextBox txtHours = new TextBox();
            txtHours.Size = new Size(300, 30);
            txtHours.Location = new Point(250, y - 5);
            txtHours.Font = new Font("Segoe UI", 11);
            this.Controls.Add(txtHours);
            y += 60;

            // Поле для имени
            Label lblName = new Label();
            lblName.Text = labels[2];
            lblName.Font = new Font("Segoe UI", 12);
            lblName.ForeColor = Color.White;
            lblName.AutoSize = true;
            lblName.Location = new Point(50, y);
            this.Controls.Add(lblName);

            TextBox txtName = new TextBox();
            txtName.Size = new Size(300, 30);
            txtName.Location = new Point(250, y - 5);
            txtName.Font = new Font("Segoe UI", 11);
            this.Controls.Add(txtName);
            y += 60;

            // Поле для телефона
            Label lblPhone = new Label();
            lblPhone.Text = labels[3];
            lblPhone.Font = new Font("Segoe UI", 12);
            lblPhone.ForeColor = Color.White;
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(50, y);
            this.Controls.Add(lblPhone);

            TextBox txtPhone = new TextBox();
            txtPhone.Size = new Size(300, 30);
            txtPhone.Location = new Point(250, y - 5);
            txtPhone.Font = new Font("Segoe UI", 11);
            this.Controls.Add(txtPhone);

            // Кнопка аренды
            RoundedButton rentBtn = new RoundedButton();
            rentBtn.Text = "✅ Подтвердить аренду";
            rentBtn.Size = new Size(250, 50);
            rentBtn.Location = new Point(300, 350);
            rentBtn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            rentBtn.BackColor = Color.FromArgb(239, 35, 60);
            rentBtn.ForeColor = Color.White;
            rentBtn.FlatStyle = FlatStyle.Flat;
            rentBtn.FlatAppearance.BorderSize = 0;
            rentBtn.Click += (s, e) =>
            {
                MessageBox.Show("Аренда оформлена успешно!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            this.Controls.Add(rentBtn);

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