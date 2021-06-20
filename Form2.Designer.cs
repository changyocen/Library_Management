
namespace TEST6_Last
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_telnum = new System.Windows.Forms.TextBox();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_borrownum = new System.Windows.Forms.Label();
            this.label_uid = new System.Windows.Forms.Label();
            this.label_department = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_目录 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_borrowtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_backtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_目录)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_refresh);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_目录);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1073, 725);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.linkLabel2);
            this.splitContainer2.Panel2.Controls.Add(this.button_update);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_telnum);
            this.splitContainer2.Panel2.Controls.Add(this.label_tel);
            this.splitContainer2.Panel2.Controls.Add(this.label_borrownum);
            this.splitContainer2.Panel2.Controls.Add(this.label_uid);
            this.splitContainer2.Panel2.Controls.Add(this.label_department);
            this.splitContainer2.Panel2.Controls.Add(this.label_name);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(374, 725);
            this.splitContainer2.SplitterDistance = 406;
            this.splitContainer2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(247, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.Location = new System.Drawing.Point(12, 16);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(89, 19);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "编辑资料";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_update.Enabled = false;
            this.button_update.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_update.Location = new System.Drawing.Point(81, 243);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(128, 46);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "保存";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_telnum
            // 
            this.textBox_telnum.Enabled = false;
            this.textBox_telnum.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_telnum.Location = new System.Drawing.Point(152, 153);
            this.textBox_telnum.Name = "textBox_telnum";
            this.textBox_telnum.Size = new System.Drawing.Size(207, 30);
            this.textBox_telnum.TabIndex = 11;
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.label_tel.Location = new System.Drawing.Point(74, 163);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(72, 20);
            this.label_tel.TabIndex = 9;
            this.label_tel.Text = "电话：";
            // 
            // label_borrownum
            // 
            this.label_borrownum.AutoSize = true;
            this.label_borrownum.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.label_borrownum.Location = new System.Drawing.Point(35, 204);
            this.label_borrownum.Name = "label_borrownum";
            this.label_borrownum.Size = new System.Drawing.Size(114, 20);
            this.label_borrownum.TabIndex = 8;
            this.label_borrownum.Text = "可借数目：";
            // 
            // label_uid
            // 
            this.label_uid.AutoSize = true;
            this.label_uid.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.label_uid.Location = new System.Drawing.Point(77, 52);
            this.label_uid.Name = "label_uid";
            this.label_uid.Size = new System.Drawing.Size(63, 20);
            this.label_uid.TabIndex = 7;
            this.label_uid.Text = "uid：";
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_department.Location = new System.Drawing.Point(77, 127);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(72, 20);
            this.label_department.TabIndex = 5;
            this.label_department.Text = "部门：";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(74, 89);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(72, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "姓名：";
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.BackColor = System.Drawing.Color.LimeGreen;
            this.button_refresh.Location = new System.Drawing.Point(456, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(104, 48);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "归还图书";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(566, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "转到借阅系统";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_目录
            // 
            this.dataGridView_目录.AllowUserToAddRows = false;
            this.dataGridView_目录.AllowUserToDeleteRows = false;
            this.dataGridView_目录.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_目录.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_目录.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_目录.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_目录.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_目录.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_目录.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colum_isbn,
            this.colum_bname,
            this.colum_state,
            this.colum_borrowtime,
            this.colum_backtime});
            this.dataGridView_目录.Location = new System.Drawing.Point(3, 66);
            this.dataGridView_目录.Name = "dataGridView_目录";
            this.dataGridView_目录.ReadOnly = true;
            this.dataGridView_目录.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView_目录.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_目录.RowTemplate.Height = 30;
            this.dataGridView_目录.Size = new System.Drawing.Size(689, 656);
            this.dataGridView_目录.TabIndex = 2;
            this.dataGridView_目录.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_目录_RowStateChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "borrowid";
            this.Column1.HeaderText = "编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colum_isbn
            // 
            this.colum_isbn.DataPropertyName = "isbn";
            this.colum_isbn.HeaderText = "ISBN";
            this.colum_isbn.MinimumWidth = 6;
            this.colum_isbn.Name = "colum_isbn";
            this.colum_isbn.ReadOnly = true;
            // 
            // colum_bname
            // 
            this.colum_bname.DataPropertyName = "bname";
            this.colum_bname.HeaderText = "书名";
            this.colum_bname.MinimumWidth = 6;
            this.colum_bname.Name = "colum_bname";
            this.colum_bname.ReadOnly = true;
            // 
            // colum_state
            // 
            this.colum_state.DataPropertyName = "status";
            this.colum_state.HeaderText = "状态";
            this.colum_state.MinimumWidth = 6;
            this.colum_state.Name = "colum_state";
            this.colum_state.ReadOnly = true;
            // 
            // colum_borrowtime
            // 
            this.colum_borrowtime.DataPropertyName = "borrowtime";
            this.colum_borrowtime.HeaderText = "借阅时间";
            this.colum_borrowtime.MinimumWidth = 6;
            this.colum_borrowtime.Name = "colum_borrowtime";
            this.colum_borrowtime.ReadOnly = true;
            // 
            // colum_backtime
            // 
            this.colum_backtime.DataPropertyName = "backtime";
            this.colum_backtime.HeaderText = "归还时间";
            this.colum_backtime.MinimumWidth = 6;
            this.colum_backtime.Name = "colum_backtime";
            this.colum_backtime.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "已归还",
            "未归还"});
            this.comboBox1.Location = new System.Drawing.Point(2, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 725);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "你好，xxx！欢迎使用图书馆管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_目录)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView_目录;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_uid;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_borrownum;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_borrowtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_backtime;
        private System.Windows.Forms.TextBox textBox_telnum;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button3;
    }
}