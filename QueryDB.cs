using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace STO
{
    static class QueryDB
    {
        static SQLiteConnection Connection = null; //коннект к базе


        public static bool CreateConnection()
        {
            Connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\db.db;Version=3;"); // создадим соединение с базой
            Connection.Open(); // откроем соединение
            if (Connection.State == System.Data.ConnectionState.Open) // если соединение открыто
                return true;
            else
                return false;
        }

        public static DataTable SelectDb(string query)
        {
            DataTable dt = new DataTable();
            //если коннекта нет или закрыт, то пересоздадим его
            if (Connection == null || Connection.State != System.Data.ConnectionState.Open) //если соединение не открыто, то создадим его
                CreateConnection();

            //адаптер на выполнение запроса
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, Connection); //создаём адаптер
            adapter.Fill(dt);// загрузка в таблицу
            return dt;
        }

        public static int SelectDbScalar(string query)
        {
            if (Connection == null || Connection.State != System.Data.ConnectionState.Open) //если соединение не открыто, то создадим его
                CreateConnection();

            SQLiteCommand command = new SQLiteCommand(query, Connection);//создаём комманду
            return Convert.ToInt32(command.ExecuteScalar());// выполняем комманду
        }

        public static bool NonQueryDb(string query)
        {
            try
            {
                if (Connection == null || Connection.State != System.Data.ConnectionState.Open) //если соединение не открыто, то создадим его
                    CreateConnection();

                SQLiteCommand command = new SQLiteCommand(query, Connection);//создаём комманду
                command.ExecuteNonQuery();// выполняем комманду
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



    }

    class NV //класс для хранения обектов (nameб id)
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }

        public NV(string _name, int _value)
        {
            Name = _name;
            Value = _value;
        }

        public NV(string _name, int _value, int _value2)
        {
            Name = _name;
            Value = _value;
            Value2 = _value2;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class IdPrice //класс для работ, для возврата из функции объекта с ид и ценой
    {
        public int Id { get; set; }
        public int Price { get; set; }

        public IdPrice(int _id, int _price)
        {
            Id = _id;
            Price = _price;
        }


    }
}
