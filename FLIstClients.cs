using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STO
{
    public partial class FLIstClients : Form
    {
        public FLIstClients()
        {
            InitializeComponent();
            DrawLb();
        }

        private void btAddClient_Click(object sender, EventArgs e)
        {
            //запустим форму клиента
            FClient fClient = new FClient();
            if (fClient.ShowDialog() == DialogResult.OK)
            {
                //проверим все данные, вернувшиеся из формы
                if (fClient.Fio.Trim().Length == 0)
                {
                    MessageBox.Show("Вы не ввели ФИО клиента");
                    return;
                }
                if (fClient.Number.Trim().Length == 0)
                {
                    MessageBox.Show("Вы не ввели номер машины");
                    return;
                }
                if (fClient.Phone.Trim().Length == 0)
                {
                    MessageBox.Show("Вы не ввели телефон клиента");
                    return;
                }
                if (fClient.TypeAuto.Trim().Length == 0)
                {
                    MessageBox.Show("Вы не ввели марку авто");
                    return;
                }
                //добавим запись в базу
                bool res = QueryDB.NonQueryDb("insert into tClients(Fio, Number, Phone, TypeAuto) values ('" + fClient.Fio + "', '" + fClient.Number + "', '" + fClient.Phone + "', '" + fClient.TypeAuto + "')");
                if (res)
                    DrawLb();
                else
                    MessageBox.Show("Клиент не был добавлен");

            }
        }

        private void btDelClient_Click(object sender, EventArgs e)
        {
            //если ни кто не выбран, то сообщение
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали клиента");
                return;
            }
            //запрос на удаление записи из базы
            bool res = QueryDB.NonQueryDb("delete from tClients where IdClient = " + dgvClients.SelectedRows[0].Cells["IdClient"].Value);
            if (res)
                DrawLb();
            else
                MessageBox.Show("Клиент не был удалён");
        }

        private void DrawLb()
        {
            //запрос в базу, и привязка к таблице, отображение всех клиентов
            DataTable dt = QueryDB.SelectDb("select Fio, Number, Phone, IdClient from tClients");
            dgvClients.DataSource = dt;
            dgvClients.Update();
            dgvClients.Columns["IdClient"].Width = 0;
        }
    }
}
