using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 轻松记账
{
    public partial class frmModify : FrmWithTitle
    {
        //传入b_id，读取数据并进行修改操作
        string bill_id, amount_so, note_so, time_so, type_so;

        public frmModify(string b_id, string amount, string note, string time, string type)
        {
            InitializeComponent();
            bill_id = b_id;
            amount_so = amount;
            note_so = note;
            time_so = time;
            type_so = type;


        }

        private void frmModify_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();
            lstCom.Add(new KeyValuePair<string, string>("1", "美食"));
            lstCom.Add(new KeyValuePair<string, string>("2", "购物"));
            lstCom.Add(new KeyValuePair<string, string>("3", "缴费"));
            lstCom.Add(new KeyValuePair<string, string>("4", "转账"));
            lstCom.Add(new KeyValuePair<string, string>("5", "其他"));
            this.ucCombox1.Source = lstCom;


            ucCombox1.SelectedIndex = 0;

      
            ucNumTextBox1.Num = Convert.ToDecimal(amount_so);
            switch (type_so)
            {
                case "美食": ucCombox1.SelectedIndex = 0; break;
                case "购物": ucCombox1.SelectedIndex = 1; break;
                case "缴费": ucCombox1.SelectedIndex = 2; break;
                case "转账": ucCombox1.SelectedIndex = 3; break;
                case "其他": ucCombox1.SelectedIndex = 4; break;
                default:
                    break;
            }
            textBoxEx3.Text = time_so;
            textBoxEx1.Text = note_so;



        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            string amount = ucNumTextBox1.Num.ToString(), note = textBoxEx1.Text, time = textBoxEx3.Text, type = ucCombox1.TextValue;

            string sqlcmd = $"UPDATE bill SET amount={amount},note='{note}',time='{time}',type='{type}' WHERE b_id={bill_id};";

            if (accessDB.Sql_cmd(sqlcmd))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }


        }

        private void textBoxEx3_MouseClick(object sender, MouseEventArgs e)
        {
            if (ucDateTimeSelectPan21.Visible == false)
            {
                ucDateTimeSelectPan21.Visible = true;
            }
            else
            {
                ucDateTimeSelectPan21.Visible = false;

            }
        }



        private void ucDateTimeSelectPan21_SelectedTimeEvent(object sender, EventArgs e)
        {
            textBoxEx3.Text = ucDateTimeSelectPan21.CurrentTime.ToString("yyyy-MM-dd HH:mm:ss:fff");
            ucDateTimeSelectPan21.Visible = false;
        }


        private void ucDateTimeSelectPan21_CancelTimeEvent(object sender, EventArgs e)
        {
            ucDateTimeSelectPan21.Visible = false;
        }

    }
}
