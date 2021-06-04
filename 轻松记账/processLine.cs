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
    public partial class processLine : FrmWithTitle
    {
        public processLine()
        {
            InitializeComponent();
        }

        private void processLine_Load(object sender, EventArgs e)
        {
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        } //网上找的玄学代码


        private void processLine_Shown(object sender, EventArgs e)
        {
     
            for (int i = 0; i <= 100; )
            {
                ucProcessLine1.Value = i;
                Thread.Sleep(5);
                if (i<35)
                {
                    i+=3;
                }
                else
                {
                    i += 8;
                }
            }
            this.Close();
            this.Dispose();
        }
    }
}
