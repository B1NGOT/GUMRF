using System.Collections.Generic;using System.Data;using System.Windows.Forms;
using MySql.Data.MySqlClient;namespace Program{    public class MysqlDB    {        MySqlConnection conn;        string db = "";        string server = "";        string login = "";        string password = "";        public MysqlDB(string db, string server, string login, string password)        {            this.db = db;            this.server = server;            this.login = login;            this.password = password;        }        public bool Connect(string fileInit)        {            if (!Open())                return false;            if (!InitDB(fileInit))                return false;            return true;        }        public bool Open()        {
            string connectionString = $"SERVER={server };DATABASE={db};UID={login};PASSWORD={password};";            try            {                conn = new MySqlConnection(connectionString);                conn.Open();                return true;            }            catch (MySqlException ex)            {
                MessageBox.Show(ex.Message, "Ошибка");                return false;            }        }        public bool Close()        {            try            {                conn.Close();                conn.Dispose();                return true;            }            catch            {                return false; // соединение не было открыто, поэтому его не удалось закрыть            }        }        public bool InitDB(string file)        {            try            {                new MySqlScript(conn, System.IO.File.ReadAllText(file)).Execute();                return true;            }            catch (MySqlException ex)            {
                MessageBox.Show(ex.Message, "Ошибка");                return false;            }        }        public bool ShowTable(string sql, string tableName, ref DataGridView table)        {            try            {                DataSet ds = new DataSet();                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);                da.Fill(ds, $"[{tableName}]");                table.DataSource = ds.Tables[0].DefaultView;                return true;            }            catch (MySqlException ex)            {
                MessageBox.Show(ex.Message, "Ошибка");                return false;            }        }        public bool SqlQuery(string sql)        {            try            {                new MySqlCommand(sql, conn).ExecuteNonQuery();                return true;            }            catch (MySqlException ex)            {
                MessageBox.Show(ex.Message, "Ошибка");                return false;            }        }        public List<string[]> GetRowData(string query)  // функция вычитывает все, что получила из запроса и сохраняет в список строк
        {
            List<string[]> list = new List<string[]>();
            try            {                using (MySqlDataReader reader = new MySqlCommand(query, conn).ExecuteReader())                {                    while (reader.Read())                    {
                        string[] data = new string[2];
                        data[0] = reader[0].ToString();
                        data[1] = reader[1].ToString();
                        list.Add(data);                    }                }            }            catch (MySqlException ex)            {                MessageBox.Show(ex.Message, "Ошибка");                return null;            }
            return list;
        }        public string GetFieldData(int id, string field, string tableName)        {            string data = "";            string sql = $"SELECT {field} FROM {tableName} WHERE Код={id}";            try            {                using (MySqlDataReader reader = new MySqlCommand(sql, conn).ExecuteReader())                {                    if (reader.Read())                        data = reader[0].ToString();                }            }            catch (MySqlException ex)            {                MessageBox.Show(ex.Message, "Ошибка");                return "";            }            return data;        }        public bool InsertTestDataSet(string file)        {            try            {                new MySqlScript(conn, System.IO.File.ReadAllText(file)).Execute();                return true;            }            catch (MySqlException ex)            {                if (ex.ToString().Contains("Duplicate entry"))
                {
                    MessageBox.Show("Кажется Вы эти данные уже добавляли. Обнаружены дублирующие записи, которые уже есть в таблице. Добавление остановлено", "Ошибка");
                    return true;
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }            }        }

        public DataTable GetData(string query)
        {
            DataTable dt = null;
            try
            {
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }    }}