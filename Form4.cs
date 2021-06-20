using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TEST6_Last
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        int flag = 0;//-2代表查询登录记录，-1代表需查询借阅记录，0代表图书信息,1代表普通用户信息，2代表管理员用户信息

        string[] bclass = { "全部", "马克思主义、列宁主义、毛泽东思想、邓小平理论", "哲学、宗教", "社会科学总论", "政治、法律", "军事", "经济", "文化、科学、教育、体育", "语言、文字", "文学", "艺术", "历史、地理", "自然科学总论", "数理科学和化学", "天文学、地理科学", "生物科学", "医药、卫生", "农业科学", "工业技术", "一般工业技术", "矿业工程", "石油、天然气工业", "冶金工业", "金属学与金属工艺", "机械、仪表工业", "武器工业", "能源与动力工程", "原子能技术", "电工技术", "无线电电子学、电信技术", "自动化技术、计算机技术", "化学工业", "轻工业、手工业", "建筑科学", "水利工程", "交通运输", "航空、航天", "环境科学、安全科学", "综合性图书" };
        string[] bclass2 = {"ISBN","书名","作者","出版社" };
        string[] bclass2_all = {"isbn","bname","author","publish"};

        string[] bclass_all = {"ISBN","书名","作者","出版社","出版时间","种类","余量" };
        string[] bclass_all_ds = { "isbn", "bname", "author", "publish", "pub_date", "bclass", "rest_num" };

        string[] uclass = { "普通用户", "管理员用户" };
        string[] uclass2 = { "uid", "用户名","密码", "部门" ,"权限"};
        string[] uclass2_all = { "uid", "uname","passwd" ,"department","mode" };

        string[] uclass_all = { "uid", "用户名","密码", "部门", "性别","电话","身份","权限","已借数目","可借数目","身份证号码" };
        string[] uclass_all_ds = { "uid", "uname", "passwd", "department", "gender", "telnumber", "identity", "mode", "had_num", "rest_num" ,"id"};


        string[] uclass3 = { "uid", "用户名", "部门", "操作时间", "权限", "登录状态" };
        string[] uclass3_all = { "uid", "uname", "department", "time", "mode", "status" };

        string[] uclass4 = {"编号", "uid", "姓名", "ISBN", "书名", "状态", "借阅时间", "归还时间" };
        string[] uclass4_all = { "borrowid","uid", "uname", "isbn", "bname", "status", "borrowtime","backtime"};

        string[] sclass = { "uid", "用户名", "部门" ,"权限", "登陆状态" };
        string[] sclass_all = { "uid", "uname", "department" ,"mode", "status" };

        string[] sclass2 = { "uid", "用户名", "ISBN", "书名","状态" };
        string[] sclass2_all = { "uid", "uname", "isbn", "bname" , "status" };



        MySqlDataAdapter myda;
        DataSet ds;

        string tables="";

        private void 图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Start_Click(sender, e);
            MessageBox.Show("数据载入中，请稍后...", "⚠提示");
            dataGridView1.ReadOnly = false;
            flag = 0;
            comboBox1.Items.Clear();
            for (int i = 0; i < bclass.Length; i++)
            {
                comboBox1.Items.Add(bclass[i]);
            }
            comboBox2.Items.Clear();
            for (int i = 0; i < bclass2.Length; i++)
            {
                comboBox2.Items.Add(bclass2[i]);
            }
            comboBox1.Enabled = true;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            book_columns();
            string rstr = "select * from books_data";
            DataSet ds = new DataSet();
            myda = DBHelper.Selectall(rstr);
            myda.Fill(ds, "books_data");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "books_data";
        }


        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            flag = 1;
            comboBox1.Items.Clear();
            for (int i = 0; i < uclass.Length; i++)
            {
                comboBox1.Items.Add(uclass[i]);
            }
            comboBox2.Items.Clear();
            for (int i = 0; i < uclass2.Length; i++)
            {
                comboBox2.Items.Add(uclass2[i]);
            }

            if (pubform.uid != "root")
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            user_columns();
            string rstr = "select * from user_public";
            ds = new DataSet();
            myda = DBHelper.Selectall(rstr);
            myda.Fill(ds, "user_public");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "user_public";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag>=0)//查询信息
            {
                if (flag == 0)
                {
                    search_book();
                }
                else
                {
                    search_user();
                }
            }
            else//查询记录
            {
                if (flag == -1)//借阅记录
                {
                    search_log_borrow();
                }
                else
                {
                    search_log_login();
                }
            }
        }

        private void search_book()
        {
            string rstr = "select * from books_data";
            string nstr;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    nstr = rstr;
                    break;
                default:
                    nstr = rstr + string.Format(" where bclass='{0}'",bclass[comboBox1.SelectedIndex]);
                    break;
            }
            if (textBox1.Text != "")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    nstr += " where ";
                }
                else
                {
                    nstr += " and ";
                }
                  nstr = nstr + string.Format(" {0} like '%{1}%'",bclass2_all[comboBox2.SelectedIndex],textBox1.Text);
            }
            book_columns();
            ds = new DataSet();
            //  MessageBox.Show(nstr);
            myda = DBHelper.Selectall(nstr);
            myda.Fill(ds, "books_data");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "books_data";
        }

        private void search_user()
        {
            string rstr = "select * from ";
            string nstr="";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    nstr = rstr + " user_public";
                    flag = 1;
                    user_columns();
                    break;
                case 1:
                    nstr = rstr + " user_admin";
                    flag = 2;
                    break;
            }
            if (textBox1.Text != "")
            {
                nstr = nstr + string.Format(" where {0} like '%{1}%'", uclass2_all[comboBox2.SelectedIndex], textBox1.Text);
            }
            user_columns();
            ds = new DataSet();
            myda = DBHelper.Selectall(nstr);
            myda.Fill(ds, "users");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "users";
        }

        private void book_columns()
        {
            dataGridView1.Columns.Clear();
            for (int i = 0; i < bclass_all.Length; i++)
            {
                DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
                colum.Name = string.Format("column{0}", i);
                colum.DataPropertyName = bclass_all_ds[i];
                colum.HeaderText = bclass_all[i];
                dataGridView1.Columns.Add(colum);
            }
        }

        private void user_columns()
        {
            dataGridView1.Columns.Clear();
            if (flag == 1)
            {
                for (int i = 0; i < uclass_all.Length; i++)
                {
                    DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
                    colum.Name = string.Format("column{0}", i);
                    colum.DataPropertyName = uclass_all_ds[i];
                    colum.HeaderText = uclass_all[i];
                    dataGridView1.Columns.Add(colum);
                }
            }
            if (flag == 2)
            {
                for (int i = 0; i < uclass2.Length; i++)
                {
                    DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
                    colum.Name = string.Format("column{0}", i);
                    colum.DataPropertyName = uclass2_all[i];
                    colum.HeaderText = uclass2[i];
                    dataGridView1.Columns.Add(colum);
                }
            }
        }

        private void button_flush_Click(object sender, EventArgs e)
        {
            if (flag < 0)
            {
                MessageBox.Show("只读信息，不允许修改！","⚠提示");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = tables;
                return;
            }
            MySqlCommandBuilder mycb = new MySqlCommandBuilder(myda);
            myda.Update(ds,dataGridView1.DataMember);
            MessageBox.Show("数据更新成功！","⚠提示");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            pubform.fom1.Show();
        }

        private void 借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Enabled = false;
            dataGridView1.ReadOnly = true;
            flag = -1;
            log_borrowcolumns();
            comboBox2.SelectedIndex = 0;

            ds = new DataSet();
            myda = DBHelper.Selectall("select * from log_borrow");
            myda.Fill(ds, "log_borrow");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "log_borrow";
            tables = "log_borrow";
        }

        private void log_borrowcolumns()
        {
            dataGridView1.Columns.Clear();
            for (int i = 0; i < uclass4_all.Length; i++)
            {
                DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
                colum.Name = string.Format("column{0}", i);
                colum.DataPropertyName = uclass4_all[i];
                colum.HeaderText = uclass4[i];
                dataGridView1.Columns.Add(colum);
            }
            comboBox2.Items.Clear();
            for (int i = 0; i < sclass2.Length; i++)
            {
                comboBox2.Items.Add(sclass2[i]);
            }
        }
        private void log_logincolumns()
        {

            comboBox2.Items.Clear();
            for (int i = 0; i < sclass2.Length; i++)
            {
                comboBox2.Items.Add(sclass[i]);
            }
            dataGridView1.Columns.Clear();
            for (int i = 0; i < uclass3.Length; i++)
            {
                DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
                colum.Name = string.Format("column{0}", i);
                colum.DataPropertyName = uclass3_all[i];
                colum.HeaderText = uclass3[i];
                dataGridView1.Columns.Add(colum);
            }

        }


        private void 登录记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            comboBox1.Items.Clear();
            comboBox1.Enabled = false;
            flag = -2;
            log_logincolumns();
            comboBox2.SelectedIndex = 0;
            ds = new DataSet();
            myda = DBHelper.Selectall("select * from log_login");
            myda.Fill(ds,"log_login");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "log_login";
            tables = "log_login";
        }
        private void search_log_login()
        {
            if (textBox1.Text != "")
            {
                string str = string.Format("select * from log_login where {0} like '%{1}%'",  sclass_all[comboBox2.SelectedIndex],textBox1.Text);
                ds = new DataSet();
                myda = DBHelper.Selectall(str);
                myda.Fill(ds, "log_login");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "log_login";
            }
        }
        private void search_log_borrow()
        {
            if (textBox1.Text != "")
            {
                string str = string.Format("select * from log_borrow where {0} like '%{1}%'", sclass2_all[comboBox2.SelectedIndex],textBox1.Text);
                ds = new DataSet();
                myda = DBHelper.Selectall(str);
                myda.Fill(ds, "log_borrow");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "log_borrow";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(flag== 0 && comboBox1.SelectedIndex == 0)
            {
                return;
            }
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pubform.fom1.Show();
            this.Close();
        }
    }
}
