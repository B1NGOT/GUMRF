using System.Windows.Forms;

namespace Program.Forms
{
    public partial class DishForm : BaseForm
    {
        // поля таблицы
        string _name = "";
        int _price = -1;
        int _weight = -1;

        public DishForm(MysqlDB db)
        {
            InitializeComponent();

            tableName = "Блюда";
            mainField = "Название as Блюдо";
            errorMessage = "Выберете блюдо";
            title.Text = tableName;
            Text = tableName;
            dataBase = db;

            UpdateForm();
        }

        // работа с формой
        protected override bool GetFormData()
        {
            _name = name.Text;
            _price = (int)price.Value;
            _weight = (int)weight.Value;
            return IsValid();   // проверка на корректность ввода
        }

        protected override bool IsValid()
        {
            string mess = "";

            if (_name == "")
                mess = "Введите название";
            else if (_price == -1)
                mess = "Введите стоимость";
            else if (_weight == -1)
                mess = "Введите вес";

            if (mess == "")
                return true;

            MessageBox.Show(mess, "Ошибка");
            return false;
        }

        protected override void SetFields()
        {
            if (GetId())
            {
                name.Text = Get("Название");
                price.Value = int.Parse(Get("Стоимость"));
                weight.Value = int.Parse(Get("Вес"));
            }
        }

        // запросы
        protected override string Select()
        {
            return 
                $"SELECT " +
                $"{tableName}.Код, " +
                $"Название, " +
                $"Стоимость, " +
                $"Вес " +
                $"FROM {tableName} " +
                $"order by {tableName}.Код";
        }

        protected override string Insert()
        {
            return
                $"Insert into {tableName} " +
                $"(Название, Стоимость, Вес) VALUES (" +
                $"'{_name}', {_price}, {_weight}" +
                $");";
        }

        protected override string Update()
        {
            return
                $"Update {tableName} SET " +
                $"Название='{_name}', " +
                $"Стоимость={_price}, " +
                $"Вес={_weight} " +
                $"WHERE Код={idNote};";
        }
    }
}
