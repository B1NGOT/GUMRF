using System.Windows.Forms;

namespace Program.Forms
{
    public partial class OrderListForm : BaseForm
    {
        // поля таблицы
        int _count = -1;
        int _orderId = -1;
        int _dishId = -1;

        public OrderListForm(MysqlDB db)
        {
            InitializeComponent();

            tableName = "Список_заказа";
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
            UpdateComboBox(orderId, "CONCAT(Код, ' ', Дата_заказа)", "Заказы");
            UpdateComboBox(dishId, "Название", "Блюда");
        }
        // работа с формой
        protected override bool GetFormData()
        {
            _count = (int)count.Value;
            _orderId = GetId(orderId);
            _dishId = GetId(dishId);
            return IsValid();   // проверка на корректность ввода
        }

        protected override bool IsValid()
        {
            string mess = "";

            if (_orderId == -1)
                mess = "Выберете заказ";
            else if (_dishId == -1)
                mess = "Выберете блюдо";
            else if (_count == -1)
                mess = "Введите число порций";
            if (mess == "")
                return true;

            MessageBox.Show(mess, "Ошибка");
            return false;
        }

        protected override void SetFields()
        {
            if (!GetId())
                return;
            count.Value = int.Parse(Get("Количество"));
            SetField("Код_заказа", "CONCAT(Код, ' ', Дата_заказа)", "Заказы", ref orderId);
            SetField("Код_блюда", "Название", "Блюда", ref dishId);
        }

        // запросы
        protected override string Select()
        {
            return $"SELECT " +
                $"{tableName}.Код, " +
                $"Код_заказа as Заказ, " +
                $"Название as Блюдо, " +
                $"Количество, " +
                $"Количество * Стоимость as Цена " +
                $"FROM {tableName} " +
                $"JOIN Блюда ON Блюда.Код={tableName}.Код_блюда " +
                $"order by {tableName}.Код_заказа";
        }

        protected override string Insert()
        {
            return
                $"Insert into {tableName} " +
                $"(Код_заказа, Код_блюда, Количество) VALUES (" +
                $"{_orderId}, {_dishId}, {_count}" +
                $");";
        }

        protected override string Update()
        {
            return
                $"Update {tableName} SET " +
                $"Количество={_count}, " +
                $"Код_заказа={_orderId}, " +
                $"Код_блюда={_dishId} " +
                $"WHERE Код={idNote};";
        }
    }
}
