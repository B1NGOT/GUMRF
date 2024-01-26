using System.Windows.Forms;

namespace Program.Forms
{
    public partial class DeskForm : BaseForm
    {
        // поля таблицы
        string _name = "";

        public DeskForm(MysqlDB db)
        {
            InitializeComponent();

            tableName = "Столы";
            mainField = "Название as Стол";
            errorMessage = "Выберете Стол";
            title.Text = tableName;
            Text = tableName;
            dataBase = db;

            UpdateForm();
        }

        // работа с формой
        protected override bool GetFormData()
        {
            _name = name.Text;
            return IsValid();   // проверка на корректность ввода
        }

        protected override bool IsValid()
        {
            string mess = "";

            if (_name == "")
                mess = "Введите стол";
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
            }
        }

        // запросы
        protected override string Select()
        {
            return $"SELECT " +
                $"{tableName}.Код, " +
                $"Название " +
                $"FROM {tableName} " +
                $"order by {tableName}.Код";
        }

        protected override string Insert()
        {
            return
                $"Insert into {tableName} " +
                $"(Название) VALUES (" +
                $"'{_name}'" +
                $");";
        }

        protected override string Update()
        {
            return
                $"Update {tableName} SET " +
                $"Название='{_name}' " +
                $"WHERE Код={idNote};";
        }
    }
}
