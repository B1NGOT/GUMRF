using System.Collections.Generic;
using MySql.Data.MySqlClient;
            string connectionString = $"SERVER={server };DATABASE={db};UID={login};PASSWORD={password};";
                MessageBox.Show(ex.Message, "Ошибка");
                MessageBox.Show(ex.Message, "Ошибка");
                MessageBox.Show(ex.Message, "Ошибка");
                MessageBox.Show(ex.Message, "Ошибка");
        {
            List<string[]> list = new List<string[]>();
            try
                        string[] data = new string[2];
                        data[0] = reader[0].ToString();
                        data[1] = reader[1].ToString();
                        list.Add(data);
            return list;
        }
                {
                    MessageBox.Show("Кажется Вы эти данные уже добавляли. Обнаружены дублирующие записи, которые уже есть в таблице. Добавление остановлено", "Ошибка");
                    return true;
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }

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
        }