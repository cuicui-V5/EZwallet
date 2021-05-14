using HZH_Controls.Controls;
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
    public partial class FormMain : FrmWithTitle
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            for (; ; )
            {
                FrmInputs frm = new FrmInputs("请输入密码",
                                       new string[] { "密码" });
                DialogResult rst = frm.ShowDialog(this);

                Console.WriteLine(frm.Values[0]);
                //frm.ShowDialog(this);
                if (frm.Values[0] == "123")
                {
                    FrmTips.ShowTipsSuccess(this, "密码正确");
                    break;
                }
                else
                {
                    if (rst==DialogResult.Cancel)
                    {
                        this.Close();
                        this.Dispose();
                        break;
                    }

                    FrmTips.ShowTipsWarning(this, "密码错误");
                    
              
                }
            



            }

        }
    }
}
