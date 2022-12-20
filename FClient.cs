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
    public partial class FClient : Form
    {
        //свойство фио
        public string Fio
        {
            get { return tbFio.Text; }
            set { tbFio.Text = value; }
        }
        //свойство номер машины
        public string Number
        {
            get { return tbNumber.Text; }
            set { tbNumber.Text = value; }
        }
        //свойство телефон
        public string Phone
        {
            get { return tbPhone.Text; }
            set { tbPhone.Text = value; }
        }
        //свойство марка авто
        public string TypeAuto
        {
            get { return tbTypeAuto.Text; }
            set { tbTypeAuto.Text = value; }
        }

        public FClient()
        {
            InitializeComponent();
        }

        private void FClient_Load(object sender, EventArgs e)
        {

        }
    }
}
