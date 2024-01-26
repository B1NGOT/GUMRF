using System;
using System.Windows.Forms;
using Program.Forms;

namespace Program
{
    public partial class Menu : Form
    {
        MysqlDB db = null;
        public Menu()
        {
            InitializeComponent();
        }
        private void TableClick(object sender, EventArgs e)
        {
            if (!CheckConnect())
                return;

            var title = ((Button)sender).Text;
            
            BaseForm table = null;
            if (title == bClients.Text)
                table = new ClientForm(db);
            else if(title == bOrders.Text)
                table = new Orders(db);
            else if (title == bDishes.Text)
                table = new DishForm(db);
            else if (title == bCatDishes.Text)
                table = new CatDishForm(db);
            else if (title == bDesks.Text)
                table = new DeskForm(db);
            else if (title == bCat.Text)
                table = new CatForm(db);
            else if (title == bOrderList.Text)
                table = new OrderListForm(db);


            if (table != null)
                table.ShowDialog();
        }

        private void connectDataBase_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect(db);
            conn.ShowDialog();
            db = conn.db;
            //stateConnect.Checked = db != null;
            if (db != null)
                MessageBox.Show("База данных успешно подключена");
            else
                MessageBox.Show("Не удалось выполнить подключение к базе данных");
        }

        private bool CheckConnect()
        {
            if (db == null)
            {
                MessageBox.Show("Выполните подкючение к базе данных");
                return false;
            }
            return true;
        }
    }
}
