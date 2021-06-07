using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 轻松记账
{
    public partial class frmLogin : FrmWithTitle
    {

        //查询用户名密码是否存在，返回一个用户id
        public int loginuser_id;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

           


        }

        public void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            string user_name = textBoxEx1.Text, pswd = textBoxEx2.Text;
            string sqlcmd = $"SELECT * FROM User_table WHERE user_name='{user_name}' AND pswd ='{pswd}'";
            DataTable dt = accessDB.Sql_Inquire(sqlcmd);
            Boolean sign;
            if (dt!=null&&dt.Rows.Count != 0) //看有没有查到数据
            {
                sign = true;
                loginuser_id = Convert.ToInt32(dt.Rows[0][0]);
                FrmTips.ShowTipsSuccess(this, "登录成功");
            }
            else
            {
                sign = false;
                FrmTips.ShowTipsError(this, "登录失败");

            }
            if (sign == true)


            {
                //处理记住密码部分
                if (ucCheckBox1.Checked)
                {
                    string sqlcmd1 = "UPDATE User_table SET default_user=0 WHERE default_user=1;";
                    accessDB.Sql_cmd(sqlcmd1);

                    string sqlcmd2 = $"UPDATE User_table SET default_user=1 WHERE user_Id={loginuser_id};";
                    accessDB.Sql_cmd(sqlcmd2);


                }
                else
                {
                    string sqlcmd3 = "UPDATE User_table SET default_user=0 WHERE default_user=1;";
                    accessDB.Sql_cmd(sqlcmd3);
                }

  

                this.Close();
                this.Dispose();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignin frmsign = new frmSignin();
            frmsign.ShowDialog();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ucBtnExt1_BtnClick( sender,  e);
            }


        }

        private void ucCheckBox2_CheckedChangeEvent(object sender, EventArgs e)
        {

            if (ucCheckBox2.Checked)
            {
                string file = System.Windows.Forms.Application.ExecutablePath;
                Configuration config = ConfigurationManager.OpenExeConfiguration(file);
                config.AppSettings.Settings["database"].Value = "mysql";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                string file = System.Windows.Forms.Application.ExecutablePath;
                Configuration config = ConfigurationManager.OpenExeConfiguration(file);
                config.AppSettings.Settings["database"].Value = "sql server";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            //处理记住密码部分
            string sqlcmd = "SELECT * FROM User_table WHERE default_user= 1";

            DataTable dt = accessDB.Sql_Inquire(sqlcmd);



            if (dt != null && dt.Rows.Count != 0)
            {
                textBoxEx1.Text = dt.Rows[0][1].ToString();
                textBoxEx2.Text = dt.Rows[0][2].ToString();
                ucCheckBox1.Checked = true;


            }

        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            //处理记住密码部分
            string sqlcmd = "SELECT * FROM User_table WHERE default_user= 1";

            DataTable dt = accessDB.Sql_Inquire(sqlcmd);

    

            if (dt != null && dt.Rows.Count != 0)
            {
                textBoxEx1.Text = dt.Rows[0][1].ToString();
                textBoxEx2.Text = dt.Rows[0][2].ToString();
                ucCheckBox1.Checked = true;


            }
            if (ConfigurationManager.AppSettings["database"].ToString() == "mysql")
            {
                ucCheckBox2.Checked = true;
            }
            else
            {
                ucCheckBox2.Checked = false;
            }
        }
    }
}
