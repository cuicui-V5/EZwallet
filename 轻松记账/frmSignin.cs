using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 轻松记账
{
    public partial class frmSignin : FrmWithTitle
    {
        public frmSignin()
        {
            InitializeComponent();
        }

        private void frmSignin_Load(object sender, EventArgs e)
        {

        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
    
            if (textBoxEx2.Text == textBoxEx3.Text)
            {
                string user_name = textBoxEx1.Text, pswd = textBoxEx2.Text;
                string sqlcmd = $"INSERT INTO User_table(user_name,pswd) VALUES('{user_name}', '{pswd}')";
               
                if (accessDB.Sql_cmd(sqlcmd))
                {
                    FrmTips.ShowTipsSuccess(this, "注册成功");
                    timer1.Start();
                
                }
                else
                {
                    FrmTips.ShowTipsError(this, "注册失败");

                }
            }
            else
            {
                FrmTips.ShowTipsError(this, "两次输入不符");
                label1.Visible = true;
            }

   

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
