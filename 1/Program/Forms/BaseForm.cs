using Program.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Program.Forms
{
    public partial class BaseForm : Form
    {
        protected MysqlDB dataBase;

        protected int idNote = 0;
        protected string tableName = "";
        protected string mainField = "";
        protected string errorMessage = "";
        protected string idName = "Код";

        public BaseForm()
        {
            InitializeComponent();
        }

        protected void insertNote_Click(object sender, EventArgs e)
        {
            if (GetFormData() && dataBase.SqlQuery(Insert()))
            {
                UpdateForm();
                MessageBox.Show("Запись добавлена", "Сообщение");
            }
            else
                MessageBox.Show("Запись не удалось добавить", "Ошибка");
       
        }

        protected void deleteNote_Click(object sender, EventArgs e)
        {
            if (GetId() && dataBase.SqlQuery(Delete()))
            {
                UpdateForm();
                MessageBox.Show("Запись удалена", "Сообщение");
            }
            else
                MessageBox.Show("Запись не удалось удалить", "Ошибка");
            UpdateForm();
        }

        protected void updateNote_Click(object sender, EventArgs e)
        {
            if (GetFormData() && GetId() && dataBase.SqlQuery(Update()))
            {
                UpdateForm();
                MessageBox.Show("Запись обновлена", "Сообщение");
            }
            else
                MessageBox.Show("Запись не удалось обновить", "Ошибка");
            UpdateForm();
        }

        protected void field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { e.Handled = false; return; }
            if (((TextBox)sender).Text.Length >= 10)    { e.Handled = true; return; }
            if (char.IsDigit(e.KeyChar))                { e.Handled = false; return; }
            e.Handled = true;
        }

        protected void selecter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFields();
        }

        protected bool SelectTable()
        {
            return dataBase.ShowTable(Select(), tableName, ref dataGridView);
        }

        protected string Get(string field)
        { 
            return dataBase.GetFieldData(idNote, field, tableName);
        }

        protected bool GetId()
        {
            int.TryParse(notes.Text.Split('.')[0], out idNote);
            if (idNote != 0)
                return true;

            MessageBox.Show(errorMessage, "Сообщение");
            idNote = -1;
            return false;
        }

        protected void SetField(string fieldId, string fieldName, string tableName, ref ComboBox cb)
        {
            try
            {
                int id = int.Parse(dataBase.GetFieldData(idNote, fieldId, this.tableName));
                string name = dataBase.GetFieldData(id, fieldName, tableName);
                cb.Text = $"{id}.{name}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
        }

        protected int GetId(ComboBox field)
        {
            int id = 0;
            int.TryParse(field.Text.Split('.')[0], out id);
            if (id != 0)
                return id;
            return -1;
        }

        // виртуальные функции
        protected virtual bool GetFormData() { return false; }

        protected virtual bool IsValid() { return false; }

        protected virtual void SetFields() { }

        protected virtual void UpdateForm()
        {
            notes.Items.Clear();

            string sql = $"SELECT {idName}, {mainField} FROM {tableName} order by {idName};";
            List<string[]> list = dataBase.GetRowData(sql);
            if (list != null)
                foreach (var row in list)
                    notes.Items.Add($"{int.Parse(row[0])}.{row[1]}");

            SelectTable();
        }

        protected void UpdateComboBox(ComboBox cb, string field = "", string table = "", string nameId = "")
        {
            cb.Items.Clear();
            if (field == "")
                field = mainField;
            if (table == "")
                table = tableName;
            string sql = $"SELECT Код, {field} FROM {table} order by Код;";
            List<string[]> list = dataBase.GetRowData(sql);
            if (list != null)
                foreach (var row in list)
                    cb.Items.Add($"{int.Parse(row[0])}.{row[1]}");
        }

        protected new virtual string Select() { return ""; }

        protected virtual string Insert() { return ""; }

        protected virtual string Delete() 
        {
            return $"Delete from {tableName} where {idName}={idNote}";
        }

        protected new virtual string Update() { return ""; }

        private void export_Click(object sender, EventArgs e)
        {
            var data = dataBase.GetData(Select());
            new ExcelConnector().Export(data, tableName + $"_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}.xlsx");
        }
    }
}
