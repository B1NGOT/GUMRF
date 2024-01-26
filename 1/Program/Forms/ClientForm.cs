using System.Windows.Forms;

namespace Program.Forms
{
    public partial class ClientForm : BaseForm
    {
        // поля таблицы
        string _family = "";
        string _name = "";
        string _phone = "";

        public ClientForm(MysqlDB db)
        {
            InitializeComponent();

            tableName = "Клиенты";
            mainField = "Фамилия as Клиент";
            errorMessage = "Выберете клиента";
            title.Text = tableName;
            Text = tableName;
            dataBase = db;

            phone.KeyPress += new KeyPressEventHandler(this.field_KeyPress);
            UpdateForm();
        }

        // работа с формой
        protected override bool GetFormData()
        {
            _family = family.Text;
            _name = name.Text;
            _phone = phone.Text;

            return IsValid();   // проверка на корректность ввода
        }

        protected override bool IsValid()
        {
            string mess = "";

            if (_family == "")
                mess = "Введите фамилию";
            else if (_name == "")
                mess = "Введите имя";
            else if (_phone == "")
                mess = "Введите телефон";

            if (mess == "")
                return true;

            MessageBox.Show(mess, "Ошибка");
            return false;
        }

        protected override void SetFields()
        {
            if (GetId())
            {
                family.Text = Get("Фамилия");
                name.Text = Get("Имя");
                phone.Text = Get("Телефон");
            }
        }

        // запросы
        protected override string Select()
        {
            return $"SELECT Код, Фамилия, Имя, Телефон FROM {tableName} order by Код";
        }

        protected override string Insert()
        {
            return
                $"Insert into {tableName} " +
                $"(Фамилия, Имя, Телефон) VALUES (" +
                $"'{_family}', '{_name}',  '{_phone}'" +
                $");";
        }

        protected override string Update()
        {
            return
                $"Update {tableName} SET " +
                $"Фамилия='{_family}', " +
                $"Имя='{_name}'," +
                $"Телефон='{_phone}' " +
                $"WHERE Код={idNote};";
        }
    }
}
