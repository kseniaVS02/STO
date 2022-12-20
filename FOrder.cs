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

    public partial class FOrder : Form
    {
        public int IdClient // ид клиента возьмём сразу из сомбобокса
        {
            get
            {
                return ((NV)cbClient.SelectedItem).Value;
            }

        }

        public DateTime DateTimeOrder
        {
            get
            {
                // в DataTimePiker нельзя время выбирать, потому просто добавим в него выбранные значения
                int hour = ((NV)cbHour.SelectedItem).Value;
                int minutes = ((NV)cbMinutes.SelectedItem).Value;
                //сформируем объект дататайма
                DateTime dt = new DateTime(dtpOrder.Value.Year, dtpOrder.Value.Month, dtpOrder.Value.Day, hour, minutes, 0);
                return dt;
            }
        }

        public IdPrice[] arrayWorksId
        {
            get
            {
                //массив работ соберём из листбокса
                IdPrice[] arr = new IdPrice[lbToWork.Items.Count];
                for (int x = 0; x < lbToWork.Items.Count; x++)
                    arr[x] = new IdPrice(((NV)lbToWork.Items[x]).Value, ((NV)lbToWork.Items[x]).Value2);
                return arr;
            }
        }

        public FOrder()
        {
            InitializeComponent();
            LoadDataControls();

        }

        private void LoadDataControls() //функция для заполнения данными контролов
        {
            cbClient.Items.Clear(); // отчистить сомбобокс
            DataTable dt = QueryDB.SelectDb("select IdClient, Fio, Number, Phone, TypeAuto from tClients");
            foreach (DataRow dr in dt.Rows)
                cbClient.Items.Add(new NV(dr["Fio"].ToString() + " [" + dr["TypeAuto"].ToString() + "]" + " [" + dr["Number"].ToString() + "]", Convert.ToInt32(dr["IdClient"])));

            //если есть итемы в комбобоксе, то выберем первый
            if (cbClient.Items.Count != 0)
                cbClient.SelectedIndex = 0;

            cbHour.Items.Clear();
            for (int x = 0; x < 24; x++)
                cbHour.Items.Add(new NV(x.ToString(), x));
            cbHour.SelectedIndex = 0;

            cbMinutes.Items.Clear();
            for (int x = 0; x < 60; x++)
                cbMinutes.Items.Add(new NV(x.ToString(), x));
            cbMinutes.SelectedIndex = 0;

            lbFromWork.Items.Clear();
            DataTable dtRef = QueryDB.SelectDb("select IdWork, NameWork, Price from tWorks");
            foreach (DataRow dr in dtRef.Rows)
                lbFromWork.Items.Add(new NV(dr["NameWork"].ToString() + " [" + dr["Price"].ToString() + "]", Convert.ToInt32(dr["IdWork"]), Convert.ToInt32(dr["Price"])));
        }

        public void LoadDataByIdOrder(int id)//функция для режима просмотра, загрузить данными из формы 
        {
            //заблокируем все контролы
            cbClient.Enabled = false;
            dtpOrder.Enabled = false;
            cbHour.Enabled = false;
            cbMinutes.Enabled = false;
            lbFromWork.Enabled = false;
            lbToWork.Enabled = false;
            btAddWork.Enabled = false;
            btDelWork.Enabled = false;
            btApply.Enabled = false;

            //загрузим данные из таблицы
            DataTable dt = QueryDB.SelectDb("select IdClient, DateOrder, IdClient as Price, IdOrder from tOrders where IdOrder = " + id);
            if (dt != null && dt.Rows.Count != 0)
            {
                for (int x = 0; x < cbClient.Items.Count; x++)
                {
                    //крутим все элементы сомбобокса, ищем нужный
                    if (((NV)cbClient.Items[x]).Value == Convert.ToInt32(dt.Rows[0]["IdClient"]))
                        cbClient.SelectedIndex = x; // и его устанавливаем выбранным
                }
            }

            DateTime dtOrder = DateTime.Parse(dt.Rows[0]["DateOrder"].ToString());
            dtpOrder.Value = dtOrder;

            for(int x = 0; x < cbHour.Items.Count; x++)
            {
                if (((NV)cbHour.Items[x]).Value == dtOrder.Hour)
                    cbHour.SelectedIndex = x;
            }

            for (int x = 0; x < cbMinutes.Items.Count; x++)
            {
                if (((NV)cbMinutes.Items[x]).Value == dtOrder.Minute)
                    cbMinutes.SelectedIndex = x;
            }

            //при помощи left join связываем две таблицы и получаем данны, и заполним листбокс
            lbFromWork.Items.Clear();
            DataTable dtRef = QueryDB.SelectDb("select tRefOrderWork.IdWork, NameWork, tWorks.Price from tRefOrderWork " +
                " left join tWorks" +
                " on tRefOrderWork.IdWork = tWorks.IdWork " +
                "where tRefOrderWork.IdOrder = "  + id);
            foreach (DataRow dr in dtRef.Rows)
                lbToWork.Items.Add(new NV(dr["NameWork"].ToString() + " [" + dr["Price"].ToString() + "]", Convert.ToInt32(dr["IdWork"]), Convert.ToInt32(dr["Price"])));

        }

        private void btAddWork_Click(object sender, EventArgs e)
        {
            if (lbFromWork.SelectedItems.Count != 0)
            {
                var item = lbFromWork.SelectedItem;
                lbToWork.Items.Add(item);
                lbFromWork.Items.Remove(item);
            }
        }

        private void btDelWork_Click(object sender, EventArgs e)
        {
            if (lbToWork.SelectedItems.Count != 0)
            {
                var item = lbToWork.SelectedItem;
                lbFromWork.Items.Add(item);
                lbToWork.Items.Remove(item);
            }
        }
    }
}
