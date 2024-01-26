using System.Windows.Forms;

namespace Program.Forms
{
    public partial class CatDishForm : BaseForm
    {
        // поля таблицы
        int _orderId = -1;
        int _dishId = -1;

        public CatDishForm(MysqlDB db)
        {
            InitializeComponent();

            tableName = "Категории_блюд";
            mainField = "Код as Запись";
            errorMessage = "Выберете запись";
            title.Text = tableName;
            Text = tableName;
            dataBase = db;
            UpdateForm();
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            UpdateComboBox(catId, "Название", "Категории");
            UpdateComboBox(dishId, "Название", "Блюда");
        }
        // работа с формой
        protected override bool GetFormData()
        {
            _orderId = GetId(catId);
            _dishId = GetId(dishId);
            return IsValid();   // проверка на корректность ввода
        }

        protected override bool IsValid()
        {
            string mess = "";

            if (_orderId == -1)
                mess = "Выберете категорию";
            else if (_dishId == -1)
                mess = "Выберете блюдо";
            if (mess == "")
                return true;

            MessageBox.Show(mess, "Ошибка");
            return false;
        }

        protected override void SetFields()
        {
            if (!GetId())
                return;
            SetField("Код_категории", "Название", "Категории", ref catId);
            SetField("Код_блюда", "Название", "Блюда", ref dishId);
        }

        // запросы
        protected override string Select()
        {
            return $"SELECT " +
                $"{tableName}.Код, " +
                $"Категории.Название as Категория, " +
                $"Блюда.Название as Блюдо " +
                $"FROM {tableName} " +
                $"JOIN Блюда ON Блюда.Код={tableName}.Код_блюда " +
                $"JOIN Категории ON Категории.Код={tableName}.Код_категории " +
                $"order by {tableName}.Код_категории";
        }

        protected override string Insert()
        {
            return
                $"Insert into {tableName} " +
                $"(Код_категории, Код_блюда) VALUES (" +
                $"{_orderId}, {_dishId}" +
                $");";
        }

        protected override string Update()
        {
            return
                $"Update {tableName} SET " +
                $"Код_заказа={_orderId}, " +
                $"Код_блюда={_dishId} " +
                $"WHERE Код={idNote};";
        }

        private void catId_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void CatDishForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
