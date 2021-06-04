
namespace 轻松记账
{
    partial class frmSignin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ucSplitLabel1 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel2 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel3 = new HZH_Controls.Controls.UCSplitLabel();
            this.textBoxEx1 = new HZH_Controls.Controls.TextBoxEx();
            this.textBoxEx2 = new HZH_Controls.Controls.TextBoxEx();
            this.textBoxEx3 = new HZH_Controls.Controls.TextBoxEx();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.verificationComponent1 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ucSplitLabel1
            // 
            this.ucSplitLabel1.AutoSize = true;
            this.ucSplitLabel1.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.ucSplitLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel1.Location = new System.Drawing.Point(127, 109);
            this.ucSplitLabel1.MaximumSize = new System.Drawing.Size(0, 15);
            this.ucSplitLabel1.MinimumSize = new System.Drawing.Size(150, 15);
            this.ucSplitLabel1.Name = "ucSplitLabel1";
            this.ucSplitLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel1.Size = new System.Drawing.Size(150, 15);
            this.ucSplitLabel1.TabIndex = 7;
            this.ucSplitLabel1.Text = "用户名";
            // 
            // ucSplitLabel2
            // 
            this.ucSplitLabel2.AutoSize = true;
            this.ucSplitLabel2.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.ucSplitLabel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel2.Location = new System.Drawing.Point(127, 155);
            this.ucSplitLabel2.MaximumSize = new System.Drawing.Size(0, 15);
            this.ucSplitLabel2.MinimumSize = new System.Drawing.Size(150, 15);
            this.ucSplitLabel2.Name = "ucSplitLabel2";
            this.ucSplitLabel2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel2.Size = new System.Drawing.Size(150, 15);
            this.ucSplitLabel2.TabIndex = 8;
            this.ucSplitLabel2.Text = "密码";
            this.ucSplitLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucSplitLabel3
            // 
            this.ucSplitLabel3.AutoSize = true;
            this.ucSplitLabel3.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.ucSplitLabel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel3.Location = new System.Drawing.Point(127, 204);
            this.ucSplitLabel3.MaximumSize = new System.Drawing.Size(0, 15);
            this.ucSplitLabel3.MinimumSize = new System.Drawing.Size(150, 15);
            this.ucSplitLabel3.Name = "ucSplitLabel3";
            this.ucSplitLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel3.Size = new System.Drawing.Size(150, 15);
            this.ucSplitLabel3.TabIndex = 9;
            this.ucSplitLabel3.Text = "确认密码";
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DecLength = 2;
            this.textBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx1.Location = new System.Drawing.Point(233, 105);
            this.textBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxEx1.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.OldText = null;
            this.textBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx1.PromptText = "";
            this.textBoxEx1.RegexPattern = "";
            this.textBoxEx1.Size = new System.Drawing.Size(135, 23);
            this.textBoxEx1.TabIndex = 10;
            this.verificationComponent1.SetVerificationCustomRegex(this.textBoxEx1, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBoxEx1, "");
            this.verificationComponent1.SetVerificationModel(this.textBoxEx1, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBoxEx1, false);
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.DecLength = 2;
            this.textBoxEx2.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx2.Location = new System.Drawing.Point(233, 151);
            this.textBoxEx2.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxEx2.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxEx2.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.OldText = null;
            this.textBoxEx2.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx2.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx2.PromptText = "";
            this.textBoxEx2.RegexPattern = "";
            this.textBoxEx2.Size = new System.Drawing.Size(135, 23);
            this.textBoxEx2.TabIndex = 11;
            this.verificationComponent1.SetVerificationCustomRegex(this.textBoxEx2, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBoxEx2, "");
            this.verificationComponent1.SetVerificationModel(this.textBoxEx2, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBoxEx2, false);
            // 
            // textBoxEx3
            // 
            this.textBoxEx3.DecLength = 2;
            this.textBoxEx3.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx3.Location = new System.Drawing.Point(233, 200);
            this.textBoxEx3.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxEx3.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxEx3.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx3.Name = "textBoxEx3";
            this.textBoxEx3.OldText = null;
            this.textBoxEx3.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx3.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx3.PromptText = "";
            this.textBoxEx3.RegexPattern = "";
            this.textBoxEx3.Size = new System.Drawing.Size(135, 23);
            this.textBoxEx3.TabIndex = 12;
            this.verificationComponent1.SetVerificationCustomRegex(this.textBoxEx3, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBoxEx3, "");
            this.verificationComponent1.SetVerificationModel(this.textBoxEx3, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBoxEx3, false);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "注册";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(198, 252);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(131, 42);
            this.ucBtnExt1.TabIndex = 13;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // verificationComponent1
            // 
            this.verificationComponent1.AutoCloseErrorTipsTime = 3000;
            this.verificationComponent1.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verificationComponent1.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(374, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "两次输入不符";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(493, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.textBoxEx3);
            this.Controls.Add(this.textBoxEx2);
            this.Controls.Add(this.textBoxEx1);
            this.Controls.Add(this.ucSplitLabel3);
            this.Controls.Add(this.ucSplitLabel2);
            this.Controls.Add(this.ucSplitLabel1);
            this.IsShowCloseBtn = true;
            this.Name = "frmSignin";
            this.Text = "frmSignin";
            this.Title = "注册账号";
            this.Load += new System.EventHandler(this.frmSignin_Load);
            this.Controls.SetChildIndex(this.ucSplitLabel1, 0);
            this.Controls.SetChildIndex(this.ucSplitLabel2, 0);
            this.Controls.SetChildIndex(this.ucSplitLabel3, 0);
            this.Controls.SetChildIndex(this.textBoxEx1, 0);
            this.Controls.SetChildIndex(this.textBoxEx2, 0);
            this.Controls.SetChildIndex(this.textBoxEx3, 0);
            this.Controls.SetChildIndex(this.ucBtnExt1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel2;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel3;
        private HZH_Controls.Controls.TextBoxEx textBoxEx1;
        private HZH_Controls.Controls.TextBoxEx textBoxEx2;
        private HZH_Controls.Controls.TextBoxEx textBoxEx3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.VerificationComponent verificationComponent1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}