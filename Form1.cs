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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillCbFilterClients();
            DrawLb();
            
        }

        private void btAddOrder_Click(object sender, EventArgs e)
        {
            // создадим форму
            FOrder fOrder = new FOrder();
            if (fOrder.ShowDialog() == DialogResult.OK)
            {
                //если нажали Применить
                bool res = true;
                //вставляем данные в базу
                res = QueryDB.NonQueryDb("insert into tOrders(IdClient, DateOrder, DateOrderCreate, IsSuccess) values ("+fOrder.IdClient+", '"+fOrder.DateTimeOrder+"', '"+DateTime.Now+"', 0)");
                //получам максимальный идентификатор записи
                int idOrder = QueryDB.SelectDbScalar("select Max(IdOrder) from tOrders");

                //добавляем все работы для этого ордера
                foreach (IdPrice work in fOrder.arrayWorksId)
                {
                    bool res1 = QueryDB.NonQueryDb("insert into tRefOrderWork(IdOrder, IdWork, Price) values (" + idOrder + ", " + work.Id + ", "+work.Price+")");
                    if (res)
                        res1 = res;
                }
                if (res) // если успешно, отрисовываем
                    DrawLb();
                else
                    MessageBox.Show("Заявка не была добавлена");
            }
        }

        private void btDelOrder_Click(object sender, EventArgs e)
        {
            if (dgvListOrders.SelectedRows.Count == 0) //если не выбрано ни одной строчки в таблице
            {
                MessageBox.Show("Вы не выбрали ордер для удаления");
                return;//выходим
            }
            //меняем статус заявки на выполнено
            bool res = QueryDB.NonQueryDb("update tOrders set IsSuccess = 1 where IdOrder = " + dgvListOrders.SelectedRows[0].Cells["IdOrder"].Value);
            if (res)
                DrawLb();
            else
                MessageBox.Show("Статус заявки не был изменён");

            //if (dgvListOrders.SelectedRows.Count == 0) //если не выбрано ни одной строчки в таблице
            //{
            //    MessageBox.Show("Вы не выбрали ордер для удаления");
            //    return;//выходим
            //}
            ////удаляем запись из базы
            //bool res = QueryDB.NonQueryDb("delete from tOrders where IdOrder = " + dgvListOrders.SelectedRows[0].Cells["IdOrder"].Value);
            //if (res)
            //    DrawLb();
            //else
            //    MessageBox.Show("Заявка не была удалена");
        }

        private void btAddClient_Click(object sender, EventArgs e)
        {
            FLIstClients fclients = new FLIstClients();
            fclients.ShowDialog();
        }

        private void btWorks_Click(object sender, EventArgs e)
        {
            FWorks fWork = new FWorks();
            fWork.ShowDialog();
        }

        public void DrawLb()
        {
            int idClient = ((NV)cbFilterClients.Items[cbFilterClients.SelectedIndex]).Value;

            //запрашиваем в базе все ордера и передаём в таблицу. Колонка Price нужна, что бы потом туда вставить цены
            string query = "select Fio, DateOrder, tOrders.IdClient as Price, IsSuccess, 'Success' as Success, IdOrder" +
                " from tOrders" +
                " left join tClients on tOrders.IdClient = tClients.IdClient";
            if (idClient > -1) //если значение в комбобоксе  не -1, то добавим к запросу уточнение
                query += " where tClients.IdClient = " + idClient;
            DataTable dt = QueryDB.SelectDb(query);
            dgvListOrders.DataSource = dt;
            dgvListOrders.Update();
            dgvListOrders.Columns["IdOrder"].Visible = false;
            dgvListOrders.Columns["IsSuccess"].Visible = false;

            //пересчитываем колонку прайс, вставляем туда суммы работ
            for (int x = 0; x < dgvListOrders.Rows.Count; x++)
            {

                int isSuccess = Convert.ToInt32(dgvListOrders.Rows[x].Cells["IsSuccess"].Value);
                if (isSuccess == 0)
                    dgvListOrders.Rows[x].Cells["Success"].Value = "Не выполнено";
                else
                    dgvListOrders.Rows[x].Cells["Success"].Value = "Выполнено";

                int summ = QueryDB.SelectDbScalar("select Sum(Price) from tRefOrderWork where IdOrder = " + dgvListOrders.Rows[x].Cells["IdOrder"].Value);
                dgvListOrders.Rows[x].Cells["Price"].Value = summ;
            }

            

        }

        public void FillCbFilterClients()
        {
            //заполним сомбобокс клиентами из базы и в начале добавим пункт ВСЕ со значением -1
            cbFilterClients.Items.Clear();
            cbFilterClients.Items.Add(new NV("Все", -1));

            DataTable dt = QueryDB.SelectDb("select IdClient, Fio from tClients");
            foreach (DataRow dr in dt.Rows)
            {
                NV nv = new NV(dr["Fio"].ToString(), Convert.ToInt32(dr["IdClient"].ToString()));
                cbFilterClients.Items.Add(nv);
            }
            cbFilterClients.SelectedIndex = 0;  
        }

        private void dgvListOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //двойной клик по ордеру, закрузим форму ордера для просмотра
            int idOrder = Convert.ToInt32(dgvListOrders.SelectedRows[0].Cells["IdOrder"].Value);
            FOrder fOrder = new FOrder();
            fOrder.LoadDataByIdOrder(idOrder);
            fOrder.ShowDialog();

        }

        private void cbFilterClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawLb();
        }
    }
}
