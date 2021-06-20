
namespace TEST6_Last
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colum_isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_bclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_restnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_content = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_类别 = new System.Windows.Forms.ComboBox();
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.comboBox_条件 = new System.Windows.Forms.ComboBox();
            this.button_borrow = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label_content);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_类别);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_event);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_条件);
            this.splitContainer1.Panel2.Controls.Add(this.button_borrow);
            this.splitContainer1.Panel2.Controls.Add(this.button_search);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 611);
            this.splitContainer1.SplitterDistance = 798;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_isbn,
            this.colum_bname,
            this.colum_author,
            this.colum_bclass,
            this.colum_publish,
            this.colum_restnum});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(798, 611);
            this.dataGridView1.TabIndex = 0;
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
            // colum_author
            // 
            this.colum_author.DataPropertyName = "author";
            this.colum_author.HeaderText = "作者";
            this.colum_author.MinimumWidth = 6;
            this.colum_author.Name = "colum_author";
            this.colum_author.ReadOnly = true;
            // 
            // colum_bclass
            // 
            this.colum_bclass.DataPropertyName = "bclass";
            this.colum_bclass.HeaderText = "类别";
            this.colum_bclass.MinimumWidth = 6;
            this.colum_bclass.Name = "colum_bclass";
            this.colum_bclass.ReadOnly = true;
            // 
            // colum_publish
            // 
            this.colum_publish.DataPropertyName = "publish";
            this.colum_publish.HeaderText = "出版社";
            this.colum_publish.MinimumWidth = 6;
            this.colum_publish.Name = "colum_publish";
            this.colum_publish.ReadOnly = true;
            // 
            // colum_restnum
            // 
            this.colum_restnum.DataPropertyName = "rest_num";
            this.colum_restnum.HeaderText = "余量";
            this.colum_restnum.MinimumWidth = 6;
            this.colum_restnum.Name = "colum_restnum";
            this.colum_restnum.ReadOnly = true;
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_content.Location = new System.Drawing.Point(8, 9);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(294, 30);
            this.label_content.TabIndex = 6;
            this.label_content.Text = "xxx，你还可借x本书";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(191, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 157);
            this.button1.TabIndex = 5;
            this.button1.Text = "退出借阅系统";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_类别
            // 
            this.comboBox_类别.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_类别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_类别.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_类别.FormattingEnabled = true;
            this.comboBox_类别.Items.AddRange(new object[] {
            "全部",
            "马克思主义、列宁主义、毛泽东思想、邓小平理论",
            "哲学、宗教",
            "社会科学总论",
            "政治、法律",
            "军事",
            "经济",
            "文化、科学、教育、体育",
            "语言、文字",
            "文学",
            "艺术",
            "历史、地理",
            "自然科学总论",
            "数理科学和化学",
            "天文学、地理科学",
            "生物科学",
            "医药、卫生",
            "农业科学",
            "工业技术",
            "一般工业技术",
            "矿业工程",
            "石油、天然气工业",
            "冶金工业",
            "金属学与金属工艺",
            "机械、仪表工业",
            "武器工业",
            "能源与动力工程",
            "原子能技术",
            "电工技术",
            "无线电电子学、电信技术",
            "自动化技术、计算机技术",
            "化学工业",
            "轻工业、手工业",
            "建筑科学",
            "水利工程",
            "交通运输",
            "航空、航天",
            "环境科学、安全科学",
            "综合性图书"});
            this.comboBox_类别.Location = new System.Drawing.Point(12, 60);
            this.comboBox_类别.Name = "comboBox_类别";
            this.comboBox_类别.Size = new System.Drawing.Size(258, 38);
            this.comboBox_类别.TabIndex = 4;
            this.comboBox_类别.SelectedIndexChanged += new System.EventHandler(this.comboBox_类别_SelectedIndexChanged);
            // 
            // textBox_event
            // 
            this.textBox_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_event.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_event.Location = new System.Drawing.Point(155, 123);
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.Size = new System.Drawing.Size(115, 42);
            this.textBox_event.TabIndex = 3;
            this.textBox_event.TextChanged += new System.EventHandler(this.textBox_event_TextChanged);
            this.textBox_event.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_event_KeyPress);
            // 
            // comboBox_条件
            // 
            this.comboBox_条件.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_条件.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_条件.FormattingEnabled = true;
            this.comboBox_条件.Items.AddRange(new object[] {
            "ISBN",
            "书名",
            "作者",
            "出版社"});
            this.comboBox_条件.Location = new System.Drawing.Point(12, 123);
            this.comboBox_条件.Name = "comboBox_条件";
            this.comboBox_条件.Size = new System.Drawing.Size(137, 38);
            this.comboBox_条件.TabIndex = 2;
            // 
            // button_borrow
            // 
            this.button_borrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_borrow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_borrow.Font = new System.Drawing.Font("华文仿宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_borrow.Location = new System.Drawing.Point(12, 451);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(173, 157);
            this.button_borrow.TabIndex = 1;
            this.button_borrow.Text = "借阅选中图书";
            this.button_borrow.UseVisualStyleBackColor = false;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.SystemColors.Info;
            this.button_search.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_search.Location = new System.Drawing.Point(12, 201);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(258, 55);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_event;
        private System.Windows.Forms.ComboBox comboBox_条件;
        private System.Windows.Forms.Button button_borrow;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_bclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_restnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_content;
    }
}