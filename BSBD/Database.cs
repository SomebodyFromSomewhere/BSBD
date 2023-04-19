using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace workshop
{
    internal class DataBase
    {
        public enum Status
        {
            DB_OK,
            DB_ERR_CONN,
            DB_ERR_SQL
        };


        private int port;
        private string address;
        private string user;
        private string password;
        private string database;
        public string message = string.Empty;
        private MySqlConnection conn;
        public Status status = Status.DB_ERR_CONN;

        public DataBase(string address = "localhost", string user = "root", string password = "", int port = 3306, string database = "")
        {
            if (database == "")
            {
                this.message = "Не выбрана база данных.";
                this.status = Status.DB_ERR_CONN;
                return;
            }

            this.address = address;
            this.user = user;
            this.password = password;
            this.port = port;
            this.database = database;
            this.conn = new MySqlConnection($"server={this.address};port={this.port};userid={this.user};password={this.password};database={this.database};");
            
            try
            {
                this.conn.Open();
                this.status = Status.DB_OK;
            }
            catch (Exception e)
            {
                this.message = "Не удалось подключиться к серверу баз данных, повторите попытку позже." + e.Message;
                this.status = Status.DB_ERR_CONN;
                return;
            }
        }

        public DataTable ExecuteSql(string sql)
        {
            MySqlCommand sqlCom = new MySqlCommand(sql, this.conn);

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dataTable = new DataTable();
            myAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable GetRecords(string table, string field = "", string value = "", string select_fields = "*", string sortColumn = "", string direction = "DESC")
        {
            string selectStatement = $"SELECT {select_fields} FROM {table}";
            if (field.Length > 0 && value.Length > 0)
                selectStatement += $" WHERE `{field}`= '{value}'";
            if (sortColumn.Length > 0)
                selectStatement += $" ORDER BY {sortColumn} {direction}";

            selectStatement += ";";
            return this.ExecuteSql(selectStatement);
        }

        public DataTable GetRecords<T>(string table, string field, List<T> value, string select_fields = "*", string sortColumn = "", string direction = "DESC")
        {
            string selectStatement = $"SELECT {select_fields} FROM {table}";
            if (field.Length > 0 && value.Count > 0)
            {
                selectStatement += $" WHERE `{field}` IN (";

                foreach (var val in value) { selectStatement += "'" + val.ToString() + "', "; }
                selectStatement = selectStatement.Remove(selectStatement.Length - 2, 2);
                selectStatement += $")";
            }
            if (sortColumn.Length > 0)
                selectStatement += $" ORDER BY {sortColumn} {direction}";

            selectStatement += ";";
            return this.ExecuteSql(selectStatement);
        }

        public DataRow GetRecord(string table, string field, string value, string select_fields = "*", int offset = 0, string sortColumn = "", string direction = "DESC")
        {
            string selectStatement = $"SELECT {select_fields} FROM {table} WHERE `{field}`='{value}' LIMIT 1 OFFSET {offset}";
            if (sortColumn.Length > 0)
                selectStatement += $" ORDER BY {sortColumn} {direction}";

            selectStatement += ";";
            DataTable dataTable = this.ExecuteSql(selectStatement);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }

            return null;
        }

        public bool UpdateRecord(string table, List<Tuple<string, string>> updateValues, List<Tuple<string, string>> whereValues = null, string whereOperation = "AND")
        {
            string updateStatement = $"UPDATE {table} SET ";

            foreach (var value in updateValues)
                updateStatement += $"`{value.Item1}` = '{value.Item2}', ";

            if (whereValues != null)
            {
                updateStatement = updateStatement.Remove(updateStatement.Length - 2, 2);
                updateStatement += " WHERE ";
                foreach (var value in whereValues)
                    updateStatement += $"`{value.Item1}` = '{value.Item2}' {whereOperation} ";
                updateStatement = updateStatement.Remove(updateStatement.Length - 4, 4);
            }

            updateStatement += ";";
            this.ExecuteSql(updateStatement);

            return true;
        }

        public int InsertRecord(string table, List<Tuple<string, string>> values)
        {
            string insertStatement = $"INSERT INTO {table} (";
            foreach (var val in values)
            {
                insertStatement += val.Item1 + ", ";
            }
            insertStatement = insertStatement.Remove(insertStatement.Length - 2, 2) + ") VALUES (";
            foreach (var val in values)
            {
                int value;
                if (int.TryParse(val.Item2, out value))
                {
                    insertStatement += val.Item2 + ", ";
                } else if (val.Item2.Contains("("))
                {
                    insertStatement += "" + val.Item2 + ", ";
                } else
                {
                    insertStatement += "'" + val.Item2 + "', ";
                }
            }
            insertStatement = insertStatement.Remove(insertStatement.Length - 2, 2) + ");";
            this.ExecuteSql(insertStatement);

            return 0;
        }

        public bool DeleteRecord(string table, List<Tuple<string, string>> whereValues, string whereOperation = "AND")
        {
            string deleteStatement = $"DELETE FROM {table}";

            if (whereValues == null)
                throw new Exception("");

            deleteStatement += " WHERE ";
            foreach (var value in whereValues)
                deleteStatement += $"`{value.Item1}` = '{value.Item2}' {whereOperation} ";
            deleteStatement = deleteStatement.Remove(deleteStatement.Length - 4, 4);

            deleteStatement += ";";
            this.ExecuteSql(deleteStatement);

            return true;
        }

        ~DataBase()
        {
            this.conn.Close();
        }
    }
}