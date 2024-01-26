using System;
using System.Windows.Forms;

namespace Program
{
    public partial class Connect : Form
    {
        public MysqlDB db = null;
        public Connect(MysqlDB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            db = new MysqlDB(shema.Text, server.Text, login.Text, password.Text);
            if (db.Connect("../../SQL/create_tables.sql"))
                MessageBox.Show("Программа успешно подключилась к базе данных");
            else
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                db = null;
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (db != null)
            {
                if (db.InsertTestDataSet("../../SQL/test_data.sql"))
                    MessageBox.Show("Данные успешно добавлены");
                else
                    MessageBox.Show("Тестовые данные не удалось добавить");
            }
            else
            {
                MessageBox.Show("Выполните подключение к базе данных");
            }
        }
    }
}
