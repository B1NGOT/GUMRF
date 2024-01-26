using System.Windows.Forms;

namespace Program.Forms
{
    public partial class Orders : BaseForm
    {
        // поля таблицы
        string _dateNote = "";
        int _clientId = -1;
        int _tableId = -1;

        public Orders(MysqlDB db)
        {
            InitializeComponent();

            tableName = "Заказы";
            mainField = "Код as Номер_заказа";
            errorMessage = "Выберете заказ";
            title.Text = tableName;
            Text = tableName;
            dataBase = db;

            UpdateForm();
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            UpdateComboBox(clientId, "CONCAT(Фамилия, ' ', Имя)", "Клиенты");
            UpdateComboBox(tableId, "Название", "Столы");
        }


        // работа с формой
        protected override bool GetFormData()
        {
            _dateNote = dateNote.Text;
            _clientId = GetId(clientId);
            _tableId = GetId(tableId);
            return IsValid();   // проверка на корректность ввода
        }

        protected override bool IsValid()
        {
            string mess = "";

            if (_dateNote == "")
                mess = "Введите дату заказа";
            else if (_tableId == -1)
                mess = "Выберете стол";
            else if (_clientId == -1)
                mess = "Выберете клиента";
            if (mess == "")
                return true;

            MessageBox.Show(mess, "Ошибка");
            return false;
        }

        protected override void SetFields()
        {
            if (!GetId())
                return;
            dateNote.Text = Get("Дата_заказа");

            SetField("Код_клиента", "CONCAT(Фамилия, ' ', Имя)", "Клиенты", ref clientId);
            SetField("Код_стола", "Название", "Столы", ref tableId);
        }

        // запросы
        protected override string Select()
        {
            return 
                "SELECT " +
                "Заказы.Код, " +
                "CONCAT(Фамилия, ' ', Имя) as Клиент, " +
                "Название as Стол, " +
                "Дата_заказа, " +
                "(SELECT sum(Количество*Блюда.Стоимость) FROM Список_заказа " +
                "JOIN Блюда ON Блюда.Код=Список_заказа.Код_блюда " +
                "WHERE Код_заказа=Заказы.Код) AS Цена_заказа " +
                "FROM Заказы " +
                "JOIN Клиенты ON Клиенты.Код=Заказы.Код_клиента " +
                "JOIN Столы ON Столы.Код=Заказы.Код_стола " +
                "order by Заказы.Код;";
        }

        protected override string Insert()
        {
            return
                $"Insert into {tableName} " +
                $"(Дата_заказа, Код_стола, Код_клиента) VALUES (" +
                $"'{_dateNote}', {_tableId}, {_clientId}" +
                $");";
        }

        protected override string Update()
        {
            return
                $"Update {tableName} SET " +
                $"Дата_заказа='{_dateNote}', " +
                $"Код_стола={_tableId}, " +
                $"Код_клиента={_clientId} " +
                $"WHERE Код={idNote};";
        }
    }
}
