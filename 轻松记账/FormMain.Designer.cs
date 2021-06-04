
namespace 轻松记账
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.verificationComponent1 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.ucCombox1 = new HZH_Controls.Controls.UCCombox();
            this.textBoxEx1 = new HZH_Controls.Controls.TextBoxEx();
            this.textBoxEx2 = new HZH_Controls.Controls.TextBoxEx();
            this.textBoxEx3 = new HZH_Controls.Controls.TextBoxEx();
            this.tabControlExt1 = new HZH_Controls.Controls.TabControlExt();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucDateTimeSelectPan21 = new HZH_Controls.Controls.UCDateTimeSelectPan2();
            this.ucSplitLabel4 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucKeyBorderAll1 = new HZH_Controls.Controls.UCKeyBorderAll();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.ucSplitLabel3 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucNumTextBox1 = new HZH_Controls.Controls.UCNumTextBox();
            this.ucSplitLabel2 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel1 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucledTime1 = new HZH_Controls.Controls.UCLEDTime();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucBtnExt5 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt4 = new HZH_Controls.Controls.UCBtnExt();
            this.ucDataGridView1 = new HZH_Controls.Controls.UCDataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlExt1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // verificationComponent1
            // 
            this.verificationComponent1.AutoCloseErrorTipsTime = 3000;
            this.verificationComponent1.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verificationComponent1.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // ucCombox1
            // 
            this.ucCombox1.BackColor = System.Drawing.Color.Transparent;
            this.ucCombox1.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucCombox1.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucCombox1.ConerRadius = 5;
            this.ucCombox1.DropPanelHeight = -1;
            this.ucCombox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucCombox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucCombox1.IsRadius = true;
            this.ucCombox1.IsShowRect = true;
            this.ucCombox1.ItemWidth = 70;
            this.ucCombox1.Location = new System.Drawing.Point(97, 69);
            this.ucCombox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCombox1.Name = "ucCombox1";
            this.ucCombox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucCombox1.RectWidth = 1;
            this.ucCombox1.SelectedIndex = -1;
            this.ucCombox1.SelectedValue = "";
            this.ucCombox1.Size = new System.Drawing.Size(172, 33);
            this.ucCombox1.Source = null;
            this.ucCombox1.TabIndex = 9;
            this.ucCombox1.TextValue = null;
            this.ucCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.verificationComponent1.SetVerificationCustomRegex(this.ucCombox1, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.ucCombox1, "");
            this.verificationComponent1.SetVerificationModel(this.ucCombox1, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.ucCombox1, false);
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DecLength = 2;
            this.textBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx1.Location = new System.Drawing.Point(97, 165);
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
            this.textBoxEx1.Multiline = true;
            this.textBoxEx1.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.OldText = null;
            this.textBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx1.PromptText = "";
            this.textBoxEx1.RegexPattern = "";
            this.textBoxEx1.Size = new System.Drawing.Size(172, 33);
            this.textBoxEx1.TabIndex = 14;
            this.verificationComponent1.SetVerificationCustomRegex(this.textBoxEx1, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBoxEx1, "");
            this.verificationComponent1.SetVerificationModel(this.textBoxEx1, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBoxEx1, false);
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.DecLength = 2;
            this.textBoxEx2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEx2.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx2.Location = new System.Drawing.Point(0, 6);
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
            this.textBoxEx2.Multiline = true;
            this.textBoxEx2.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.OldText = null;
            this.textBoxEx2.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx2.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx2.PromptText = "";
            this.textBoxEx2.RegexPattern = "";
            this.textBoxEx2.Size = new System.Drawing.Size(790, 298);
            this.textBoxEx2.TabIndex = 0;
            this.textBoxEx2.Text = "                                                 powered by cuicui\r\n";
            this.verificationComponent1.SetVerificationCustomRegex(this.textBoxEx2, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBoxEx2, "");
            this.verificationComponent1.SetVerificationModel(this.textBoxEx2, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBoxEx2, false);
            // 
            // textBoxEx3
            // 
            this.textBoxEx3.DecLength = 2;
            this.textBoxEx3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEx3.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx3.Location = new System.Drawing.Point(97, 118);
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
            this.textBoxEx3.Multiline = true;
            this.textBoxEx3.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx3.Name = "textBoxEx3";
            this.textBoxEx3.OldText = null;
            this.textBoxEx3.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx3.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx3.PromptText = "";
            this.textBoxEx3.RegexPattern = "";
            this.textBoxEx3.Size = new System.Drawing.Size(172, 33);
            this.textBoxEx3.TabIndex = 18;
            this.verificationComponent1.SetVerificationCustomRegex(this.textBoxEx3, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBoxEx3, "");
            this.verificationComponent1.SetVerificationModel(this.textBoxEx3, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBoxEx3, false);
            this.textBoxEx3.Click += new System.EventHandler(this.textBoxEx3_Click);
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlExt1.CloseBtnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.tabControlExt1.Controls.Add(this.tabPage1);
            this.tabControlExt1.Controls.Add(this.tabPage2);
            this.tabControlExt1.Controls.Add(this.tabPage3);
            this.tabControlExt1.Controls.Add(this.tabPage4);
            this.tabControlExt1.Controls.Add(this.tabPage5);
            this.tabControlExt1.IsShowCloseBtn = false;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(0, 50);
            this.tabControlExt1.Location = new System.Drawing.Point(6, 66);
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(794, 394);
            this.tabControlExt1.TabIndex = 7;
            this.tabControlExt1.UncloseTabIndexs = null;
            this.tabControlExt1.SelectedIndexChanged += new System.EventHandler(this.tabControlExt1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxEx3);
            this.tabPage1.Controls.Add(this.ucDateTimeSelectPan21);
            this.tabPage1.Controls.Add(this.ucSplitLabel4);
            this.tabPage1.Controls.Add(this.ucKeyBorderAll1);
            this.tabPage1.Controls.Add(this.ucBtnExt2);
            this.tabPage1.Controls.Add(this.textBoxEx1);
            this.tabPage1.Controls.Add(this.ucSplitLabel3);
            this.tabPage1.Controls.Add(this.ucNumTextBox1);
            this.tabPage1.Controls.Add(this.ucCombox1);
            this.tabPage1.Controls.Add(this.ucSplitLabel2);
            this.tabPage1.Controls.Add(this.ucSplitLabel1);
            this.tabPage1.Controls.Add(this.ucBtnExt1);
            this.tabPage1.Controls.Add(this.ucledTime1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "记账";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucDateTimeSelectPan21
            // 
            this.ucDateTimeSelectPan21.BackColor = System.Drawing.Color.White;
            this.ucDateTimeSelectPan21.CurrentTime = new System.DateTime(2021, 5, 31, 18, 19, 15, 0);
            this.ucDateTimeSelectPan21.Location = new System.Drawing.Point(280, 19);
            this.ucDateTimeSelectPan21.Name = "ucDateTimeSelectPan21";
            this.ucDateTimeSelectPan21.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucDateTimeSelectPan21.Size = new System.Drawing.Size(240, 220);
            this.ucDateTimeSelectPan21.TabIndex = 17;
            this.ucDateTimeSelectPan21.TimeType = HZH_Controls.Controls.DateTimePickerType.DateTime;
            this.ucDateTimeSelectPan21.Visible = false;
            // 
            // ucSplitLabel4
            // 
            this.ucSplitLabel4.AutoSize = true;
            this.ucSplitLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSplitLabel4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel4.Location = new System.Drawing.Point(18, 123);
            this.ucSplitLabel4.MaximumSize = new System.Drawing.Size(0, 23);
            this.ucSplitLabel4.MinimumSize = new System.Drawing.Size(150, 23);
            this.ucSplitLabel4.Name = "ucSplitLabel4";
            this.ucSplitLabel4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel4.Size = new System.Drawing.Size(150, 23);
            this.ucSplitLabel4.TabIndex = 16;
            this.ucSplitLabel4.Text = "时间";
            // 
            // ucKeyBorderAll1
            // 
            this.ucKeyBorderAll1.BackColor = System.Drawing.Color.White;
            this.ucKeyBorderAll1.CharType = HZH_Controls.Controls.KeyBorderCharType.CHAR;
            this.ucKeyBorderAll1.Location = new System.Drawing.Point(273, 3);
            this.ucKeyBorderAll1.Margin = new System.Windows.Forms.Padding(0);
            this.ucKeyBorderAll1.Name = "ucKeyBorderAll1";
            this.ucKeyBorderAll1.Size = new System.Drawing.Size(510, 236);
            this.ucKeyBorderAll1.TabIndex = 2;
            this.ucKeyBorderAll1.RetractClike += new System.EventHandler(this.ucKeyBorderAll1_RetractClike);
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "记账";
            this.ucBtnExt2.ConerRadius = 5;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(97, 238);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(123, 42);
            this.ucBtnExt2.TabIndex = 15;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            this.ucBtnExt2.BtnClick += new System.EventHandler(this.ucBtnExt2_BtnClick);
            // 
            // ucSplitLabel3
            // 
            this.ucSplitLabel3.AutoSize = true;
            this.ucSplitLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSplitLabel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel3.Location = new System.Drawing.Point(18, 170);
            this.ucSplitLabel3.MaximumSize = new System.Drawing.Size(0, 23);
            this.ucSplitLabel3.MinimumSize = new System.Drawing.Size(150, 23);
            this.ucSplitLabel3.Name = "ucSplitLabel3";
            this.ucSplitLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel3.Size = new System.Drawing.Size(150, 23);
            this.ucSplitLabel3.TabIndex = 13;
            this.ucSplitLabel3.Text = "备注";
            // 
            // ucNumTextBox1
            // 
            this.ucNumTextBox1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ucNumTextBox1.InputType = HZH_Controls.TextInputType.Number;
            this.ucNumTextBox1.IsNumCanInput = false;
            this.ucNumTextBox1.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox1.Location = new System.Drawing.Point(97, 28);
            this.ucNumTextBox1.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ucNumTextBox1.MinValue = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.ucNumTextBox1.Name = "ucNumTextBox1";
            this.ucNumTextBox1.Num = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ucNumTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.ucNumTextBox1.Size = new System.Drawing.Size(173, 33);
            this.ucNumTextBox1.TabIndex = 10;
            // 
            // ucSplitLabel2
            // 
            this.ucSplitLabel2.AutoSize = true;
            this.ucSplitLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSplitLabel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel2.Location = new System.Drawing.Point(18, 74);
            this.ucSplitLabel2.MaximumSize = new System.Drawing.Size(0, 23);
            this.ucSplitLabel2.MinimumSize = new System.Drawing.Size(150, 23);
            this.ucSplitLabel2.Name = "ucSplitLabel2";
            this.ucSplitLabel2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel2.Size = new System.Drawing.Size(150, 23);
            this.ucSplitLabel2.TabIndex = 8;
            this.ucSplitLabel2.Text = "分类";
            // 
            // ucSplitLabel1
            // 
            this.ucSplitLabel1.AutoSize = true;
            this.ucSplitLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSplitLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel1.Location = new System.Drawing.Point(18, 34);
            this.ucSplitLabel1.MaximumSize = new System.Drawing.Size(0, 23);
            this.ucSplitLabel1.MinimumSize = new System.Drawing.Size(150, 23);
            this.ucSplitLabel1.Name = "ucSplitLabel1";
            this.ucSplitLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel1.Size = new System.Drawing.Size(150, 23);
            this.ucSplitLabel1.TabIndex = 6;
            this.ucSplitLabel1.Text = "金额";
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "显示键盘";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(523, 189);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(141, 38);
            this.ucBtnExt1.TabIndex = 11;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick_1);
            // 
            // ucledTime1
            // 
            this.ucledTime1.LineWidth = 8;
            this.ucledTime1.Location = new System.Drawing.Point(399, 83);
            this.ucledTime1.Name = "ucledTime1";
            this.ucledTime1.Size = new System.Drawing.Size(290, 58);
            this.ucledTime1.TabIndex = 12;
            this.ucledTime1.Value = new System.DateTime(2021, 5, 16, 20, 47, 14, 130);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(333, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "欢迎！";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.ucBtnExt5);
            this.tabPage2.Controls.Add(this.ucBtnExt4);
            this.tabPage2.Controls.Add(this.ucDataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "账单";
            // 
            // ucBtnExt5
            // 
            this.ucBtnExt5.BackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnFont = new System.Drawing.Font("微软雅黑", 10F);
            this.ucBtnExt5.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnText = "删除";
            this.ucBtnExt5.ConerRadius = 5;
            this.ucBtnExt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt5.EnabledMouseEffect = false;
            this.ucBtnExt5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt5.IsRadius = true;
            this.ucBtnExt5.IsShowRect = true;
            this.ucBtnExt5.IsShowTips = false;
            this.ucBtnExt5.Location = new System.Drawing.Point(713, 293);
            this.ucBtnExt5.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt5.Name = "ucBtnExt5";
            this.ucBtnExt5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt5.RectWidth = 1;
            this.ucBtnExt5.Size = new System.Drawing.Size(68, 30);
            this.ucBtnExt5.TabIndex = 2;
            this.ucBtnExt5.TabStop = false;
            this.ucBtnExt5.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt5.TipsText = "";
            this.ucBtnExt5.BtnClick += new System.EventHandler(this.ucBtnExt5_BtnClick);
            // 
            // ucBtnExt4
            // 
            this.ucBtnExt4.BackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnFont = new System.Drawing.Font("微软雅黑", 10F);
            this.ucBtnExt4.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnText = "修改";
            this.ucBtnExt4.ConerRadius = 5;
            this.ucBtnExt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt4.EnabledMouseEffect = false;
            this.ucBtnExt4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt4.IsRadius = true;
            this.ucBtnExt4.IsShowRect = true;
            this.ucBtnExt4.IsShowTips = false;
            this.ucBtnExt4.Location = new System.Drawing.Point(632, 293);
            this.ucBtnExt4.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt4.Name = "ucBtnExt4";
            this.ucBtnExt4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt4.RectWidth = 1;
            this.ucBtnExt4.Size = new System.Drawing.Size(68, 30);
            this.ucBtnExt4.TabIndex = 1;
            this.ucBtnExt4.TabStop = false;
            this.ucBtnExt4.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt4.TipsText = "";
            this.ucBtnExt4.BtnClick += new System.EventHandler(this.ucBtnExt4_BtnClick);
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1.BackColor = System.Drawing.Color.White;
            this.ucDataGridView1.Columns = null;
            this.ucDataGridView1.DataSource = null;
            this.ucDataGridView1.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucDataGridView1.HeadHeight = 40;
            this.ucDataGridView1.HeadPadingLeft = 0;
            this.ucDataGridView1.HeadTextColor = System.Drawing.Color.Black;
            this.ucDataGridView1.IsShowCheckBox = false;
            this.ucDataGridView1.IsShowHead = true;
            this.ucDataGridView1.Location = new System.Drawing.Point(0, 3);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ucDataGridView1.RowHeight = 40;
            this.ucDataGridView1.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.ucDataGridView1.Size = new System.Drawing.Size(786, 287);
            this.ucDataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "统计";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(786, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBoxEx2);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(786, 336);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "关于";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.tabControlExt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "FormMain";
            this.ShowInTaskbar = true;
            this.Text = "Form1";
            this.Title = "轻松记账";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Controls.SetChildIndex(this.tabControlExt1, 0);
            this.tabControlExt1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.VerificationComponent verificationComponent1;
        private HZH_Controls.Controls.TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private HZH_Controls.Controls.UCKeyBorderAll ucKeyBorderAll1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel1;
        private HZH_Controls.Controls.UCCombox ucCombox1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel2;
        private HZH_Controls.Controls.UCNumTextBox ucNumTextBox1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCLEDTime ucledTime1;
        private System.Windows.Forms.Timer timer1;
        private HZH_Controls.Controls.TextBoxEx textBoxEx1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.UCDataGridView ucDataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private HZH_Controls.Controls.TextBoxEx textBoxEx2;
        private HZH_Controls.Controls.UCDateTimeSelectPan2 ucDateTimeSelectPan21;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel4;
        private HZH_Controls.Controls.TextBoxEx textBoxEx3;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt5;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt4;
    }
}

