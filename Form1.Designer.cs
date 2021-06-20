
namespace TEST6_Last
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_idclass = new System.Windows.Forms.ComboBox();
            this.textBox_uid = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.label_uid = new System.Windows.Forms.Label();
            this.label_passwd = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_login = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询操作员IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_idclass
            // 
            this.comboBox_idclass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_idclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_idclass.Enabled = false;
            this.comboBox_idclass.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_idclass.FormattingEnabled = true;
            this.comboBox_idclass.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.comboBox_idclass.Location = new System.Drawing.Point(338, 105);
            this.comboBox_idclass.Name = "comboBox_idclass";
            this.comboBox_idclass.Size = new System.Drawing.Size(272, 33);
            this.comboBox_idclass.TabIndex = 0;
            // 
            // textBox_uid
            // 
            this.textBox_uid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_uid.Enabled = false;
            this.textBox_uid.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_uid.Location = new System.Drawing.Point(338, 163);
            this.textBox_uid.Name = "textBox_uid";
            this.textBox_uid.Size = new System.Drawing.Size(272, 36);
            this.textBox_uid.TabIndex = 1;
            this.textBox_uid.TextChanged += new System.EventHandler(this.textBox_uid_TextChanged);
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_passwd.Enabled = false;
            this.textBox_passwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_passwd.Location = new System.Drawing.Point(338, 227);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.PasswordChar = '*';
            this.textBox_passwd.Size = new System.Drawing.Size(272, 36);
            this.textBox_passwd.TabIndex = 2;
            this.textBox_passwd.TextChanged += new System.EventHandler(this.textBox_passwd_TextChanged);
            this.textBox_passwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_passwd_KeyPress);
            // 
            // label_uid
            // 
            this.label_uid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_uid.AutoSize = true;
            this.label_uid.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uid.Location = new System.Drawing.Point(201, 174);
            this.label_uid.Name = "label_uid";
            this.label_uid.Size = new System.Drawing.Size(118, 25);
            this.label_uid.TabIndex = 3;
            this.label_uid.Text = "操作员ID";
            // 
            // label_passwd
            // 
            this.label_passwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_passwd.AutoSize = true;
            this.label_passwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label_passwd.Location = new System.Drawing.Point(201, 238);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(116, 25);
            this.label_passwd.TabIndex = 4;
            this.label_passwd.Text = "操作密码";
            // 
            // label_class
            // 
            this.label_class.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_class.AutoSize = true;
            this.label_class.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label_class.Location = new System.Drawing.Point(203, 113);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(116, 25);
            this.label_class.TabIndex = 5;
            this.label_class.Text = "用户类型";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("华文彩云", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.Color.Black;
            this.label_time.Location = new System.Drawing.Point(437, 31);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(304, 31);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "2020/12/13/12:27:45";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_login
            // 
            this.button_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_login.Enabled = false;
            this.button_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.Location = new System.Drawing.Point(338, 328);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(110, 55);
            this.button_login.TabIndex = 8;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.LightCoral;
            this.button_exit.Enabled = false;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.button_exit.Location = new System.Drawing.Point(500, 328);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(110, 55);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询操作员IDToolStripMenuItem,
            this.查询密码ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 查询操作员IDToolStripMenuItem
            // 
            this.查询操作员IDToolStripMenuItem.Name = "查询操作员IDToolStripMenuItem";
            this.查询操作员IDToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.查询操作员IDToolStripMenuItem.Text = "查询操作员ID";
            this.查询操作员IDToolStripMenuItem.Click += new System.EventHandler(this.查询操作员IDToolStripMenuItem_Click);
            // 
            // 查询密码ToolStripMenuItem
            // 
            this.查询密码ToolStripMenuItem.Name = "查询密码ToolStripMenuItem";
            this.查询密码ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.查询密码ToolStripMenuItem.Text = "查询密码";
            this.查询密码ToolStripMenuItem.Click += new System.EventHandler(this.查询密码ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用文档ToolStripMenuItem,
            this.联系作者ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 使用文档ToolStripMenuItem
            // 
            this.使用文档ToolStripMenuItem.Name = "使用文档ToolStripMenuItem";
            this.使用文档ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.使用文档ToolStripMenuItem.Text = "使用文档";
            // 
            // 联系作者ToolStripMenuItem
            // 
            this.联系作者ToolStripMenuItem.Name = "联系作者ToolStripMenuItem";
            this.联系作者ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.联系作者ToolStripMenuItem.Text = "联系作者";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(24, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_passwd);
            this.Controls.Add(this.label_uid);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.textBox_uid);
            this.Controls.Add(this.comboBox_idclass);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书馆系统登陆";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_idclass;
        private System.Windows.Forms.TextBox textBox_uid;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.Label label_uid;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询操作员IDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系作者ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

