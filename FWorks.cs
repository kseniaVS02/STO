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
    public partial class FWorks : Form
    {
        public FWorks()
        {
            InitializeComponent();
            DrawLB();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            panelAddItem.Visible = true;
            tbName.Text = "";
            tbPrice.Text = "";
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не заполнили вид работ");
                return;
            }
            if (tbPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не заполнили цену работы");
                return;
            }
            int price = 0;
            if(!Int32.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Вы не верно заполнили цену работы");
                return;
            }

            if (QueryDB.NonQueryDb("insert into tWorks(NameWork, Price) values ('" + tbName.Text + "', "+price+")"))
            {
                panelAddItem.Visible = false;
                DrawLB();
            }
            else
                MessageBox.Show("Не удалось добавить вид работ");
        }

        private void btAddCancel_Click(object sender, EventArgs e)
        {
            panelAddItem.Visible = false;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (lbWorks.SelectedItems.Count != 0)
            {
                int idWork = ((NV)lbWorks.Items[lbWorks.SelectedIndex]).Value;
                if (QueryDB.NonQueryDb("delete from tWorks where IdWork = " + idWork))
                {
                    panelAddItem.Visible = false;
                    DrawLB();
                }
                else
                    MessageBox.Show("Не удалось удалить вид работ");
            }
            else
                MessageBox.Show("Необходимо выбрать вид работ для удаления");
        }

        private void DrawLB()
        {
            DataTable dt = QueryDB.SelectDb("select IdWork, NameWork, Price from tWorks");
            lbWorks.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                lbWorks.Items.Add(new NV(dr["NameWork"].ToString() + " [" + dr["Price"].ToString() + "]", Convert.ToInt32(dr["IdWork"])));
        }

       
    }
}
