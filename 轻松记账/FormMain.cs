using HZH_Controls.Controls;
using HZH_Controls.Forms;
using System;
using System.Collections;
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
    public partial class FormMain : FrmWithTitle
    {
        int log_user_id;

        DataTable table;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            timer1.Start();

            frmLogin frmlog = new frmLogin();
            frmlog.ShowDialog();//登录界面
            Console.WriteLine(frmlog.loginuser_id);
            log_user_id = frmlog.loginuser_id;


            FrmTips.ShowTipsSuccess(this, "登录成功");

            processLine pl = new processLine();
            pl.ShowDialog(); //进度条


            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();
            lstCom.Add(new KeyValuePair<string, string>("1", "美食"));
            lstCom.Add(new KeyValuePair<string, string>("2", "购物"));
            lstCom.Add(new KeyValuePair<string, string>("3", "缴费"));
            lstCom.Add(new KeyValuePair<string, string>("4", "转账"));
            lstCom.Add(new KeyValuePair<string, string>("5", "其他"));
            this.ucCombox1.Source = lstCom;
            //combox数据绑定

            ucNumTextBox1.Num = -10;


            ucKeyBorderAll1.Visible = false;


            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "b_id", HeadText = "序号", Width = 10, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "type", HeadText = "类型", Width = 15, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "amount", HeadText = "金额", Width = 20, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "time", HeadText = "时间", Width = 25, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "note", HeadText = "备注", Width = 25, WidthType = SizeType.Percent });

            this.ucDataGridView1.Columns = lstCulumns;

            ucDataGridView1.IsShowCheckBox = true;


            ucCombox1.SelectedIndex = 0;

            //初始化欢迎语句
            string user_Id = log_user_id.ToString();
            string sqlcmd = $"SELECT * FROM User_table WHERE user_Id = {user_Id}";
            DataTable dt = accessDB.Sql_Inquire(sqlcmd);
            if (dt.Rows.Count != 0)
            {
                label1.Text += dt.Rows[0][1].ToString();
            }
            else
            {
                label1.Text += "未知用户";
            }


            textBoxEx3.Text = ucDateTimeSelectPan21.CurrentTime.ToString("yyyy-MM-dd HH:mm:ss:fff");


        }


        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {

        }

        private void ucKeyBorderAll1_RetractClike(object sender, EventArgs e)
        {
            ucKeyBorderAll1.Visible = false;
        }

        private void ucBtnExt1_BtnClick_1(object sender, EventArgs e)
        {
            ucKeyBorderAll1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ucledTime1.Value = DateTime.Now;

            Application.DoEvents();
        }

        private void tabControlExt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            processLine pl = new processLine();
            pl.ShowDialog(); //进度条
            switch (tabControlExt1.SelectedIndex)
            {
                case 0: this.Title = "轻松记账"; break;
                case 1:
                    {
                        this.Title = "账单";
                        string sqlcmd = $"select * from bill where user_id = {log_user_id}";
                        table = accessDB.Sql_Inquire(sqlcmd);
                        this.ucDataGridView1.DataSource = table;

                    }
                    break;
                case 2: this.Title = "统计"; break;
                case 3: this.Title = "设置"; break;
                default:
                    break;
            }
        }



        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            string user_Id = log_user_id.ToString(), amount = ucNumTextBox1.Num.ToString(), note = textBoxEx1.Text, time = ucDateTimeSelectPan21.CurrentTime.ToString("yyyy-MM-dd HH:mm:ss:fff"), type = ucCombox1.TextValue;
            string sqlcmd = $"INSERT INTO bill(user_Id,amount,note,[time],type) VALUES({user_Id}, {amount},'{note}','{time}','{type}')";


            if (accessDB.Sql_cmd(sqlcmd))
            {
                FrmTips.ShowTipsSuccess(this, "记账成功");
            }
            else
            {
                FrmTips.ShowTipsWarning(this, "出了点错误");
            }
        }

        private void textBoxEx3_Click(object sender, EventArgs e)
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

        private void ucBtnExt4_BtnClick(object sender, EventArgs e)
        {



            foreach (IDataGridViewRow row in ucDataGridView1.Rows)
            {
                if (row.IsChecked)
                {

                    Console.WriteLine("修改。。。");
                    string b_id = table.Rows[row.RowIndex][5].ToString();
                    string amount = table.Rows[row.RowIndex][1].ToString();
                    string note = table.Rows[row.RowIndex][2].ToString();
                    string time = table.Rows[row.RowIndex][3].ToString();
                    string type = table.Rows[row.RowIndex][4].ToString();
                    frmModify frmmod = new frmModify(b_id, amount, note, time,type);
                    frmmod.ShowDialog();
                    if (frmmod.DialogResult == DialogResult.OK)
                    {
                        FrmTips.ShowTipsSuccess(this, "删除成功");
                        break;
                    }

                    else
                    {
                        FrmTips.ShowTipsWarning(this, "出了点错误");
                    }

                }

            }
            string sqlcmd1 = $"select * from bill where user_id = {log_user_id}";
            table = accessDB.Sql_Inquire(sqlcmd1);
            this.ucDataGridView1.DataSource = table;
            ucDataGridView1.ReloadSource();


        }

        private void ucBtnExt5_BtnClick(object sender, EventArgs e)
        {
            foreach (IDataGridViewRow row in ucDataGridView1.Rows)
            {
                if (row.IsChecked)
                {
                    string str = "确认删除编号 : " + table.Rows[row.RowIndex][5].ToString();
                    if (FrmDialog.ShowDialog(this, str, "删除记录", true) == DialogResult.OK)
                    {
                        Console.WriteLine("删除。。。");
                        string b_id = table.Rows[row.RowIndex][5].ToString();
                        string sqlcmd = $"DELETE FROM bill WHERE b_id={b_id};";
                        if (accessDB.Sql_cmd(sqlcmd))
                        {
                            FrmTips.ShowTipsSuccess(this, "删除成功");
                            break;
                        }

                        else
                        {
                            FrmTips.ShowTipsWarning(this, "出了点错误");
                        }



                    }



                }

            }
            string sqlcmd1 = $"select * from bill where user_id = {log_user_id}";
            table = accessDB.Sql_Inquire(sqlcmd1);
            this.ucDataGridView1.DataSource = table;
            ucDataGridView1.ReloadSource();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xrswyea/EZwallet");
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

