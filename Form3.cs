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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string rstr = "select isbn,bname,author,publish,bclass,rest_num from books_data";
        string nstr;
        string[] bclass = {"全部", "马克思主义、列宁主义、毛泽东思想、邓小平理论", "哲学、宗教", "社会科学总论", "政治、法律", "军事", "经济", "文化、科学、教育、体育", "语言、文字", "文学", "艺术", "历史、地理", "自然科学总论", "数理科学和化学", "天文学、地理科学", "生物科学", "医药、卫生", "农业科学", "工业技术", "一般工业技术", "矿业工程", "石油、天然气工业", "冶金工业", "金属学与金属工艺", "机械、仪表工业", "武器工业", "能源与动力工程", "原子能技术", "电工技术", "无线电电子学、电信技术", "自动化技术、计算机技术", "化学工业", "轻工业、手工业", "建筑科学", "水利工程", "交通运输", "航空、航天", "环境科学、安全科学", "综合性图书"};
        string[] condition = {"isbn","bname","author","publish" };
        MySqlDataAdapter myda;
        DataSet ds;

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox_类别.SelectedIndex = 0;
            comboBox_条件.SelectedIndex = 0;
            label_content.Text = string.Format("{0}，你还能借{1}本书",pubform.uname.Replace(" ",""),pubform.rest_num);
            this.WindowState = FormWindowState.Maximized;
            DBHelper.mycon.Open();
            myda = new MySqlDataAdapter(rstr, DBHelper.mycon);
            DBHelper.mycon.Close();
            ds = new DataSet();
            myda.Fill(ds, "books_data");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "books_data";
            if (pubform.rest_num <= 0)
            {
                button_borrow.Enabled = false;
                MessageBox.Show(string.Format("{0},你好。你的可借书本为{1}本！不能借阅图书，只能查询图书信息",pubform.uname.Replace(" ",""),pubform.rest_num),"⚠提示");
            }
        }

        private void comboBox_类别_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_search_Click(sender, e);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            nstr = rstr;
            bool flag = false;
            if (textBox_event.Text == "")
            {
                nstr = rstr;
            }
            else
            {
                nstr = rstr + string.Format(" where {0} like '%{1}%'",condition[comboBox_条件.SelectedIndex],textBox_event.Text);
                flag = true;
            }
            if (comboBox_类别.SelectedIndex != 0)
            {
                if (flag)
                {
                    nstr = nstr + string.Format(" and bclass = '{0}'",bclass[comboBox_类别.SelectedIndex]);
                    flag = false;
                }
                else
                {
                    nstr = nstr + string.Format(" where bclass = '{0}'", bclass[comboBox_类别.SelectedIndex]);
                }
                
            }
            DBHelper.mycon.Open();
            myda = new MySqlDataAdapter(nstr, DBHelper.mycon);
            DBHelper.mycon.Close();
            ds = new DataSet();
            myda.Fill(ds, "books_data");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "books_data";
        }

        private void button_borrow_Click(object sender, EventArgs e)
        {
            if (pubform.rest_num == 0)
            {
                MessageBox.Show("你的待还书本数量已经达到上限","⚠提示");
                return;
            }
            int index = dataGridView1.CurrentRow.Index;
            //if (index == 0)
            //{
              //  MessageBox.Show("未选中任何书目！","⚠提示");
                //return;
            //}
            string bnum = DBHelper.Selectthings(string.Format("select rest_num from books_data where isbn='{0}'", dataGridView1.Rows[index].Cells[0].Value.ToString()),"rest_num");

            if (int.Parse(bnum) == 0)
            {
                MessageBox.Show("该本图书余量不足，可以借阅别的图书或刷新后再试！","⚠提示");
                return;
            }

            //MessageBox.Show(index.ToString());
            string isbn = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string bname = dataGridView1.Rows[index].Cells[1].Value.ToString();
            //MessageBox.Show(isbn + "\n" + bname);
            string uid = pubform.uid;
            string uname =pubform.uname;
            int borrowid = DBHelper.Get_rows_count("log_borrow")+1;
            string wstr = string.Format("insert into log_borrow (borrowid,isbn,bname,uid,uname,status,borrowtime,backtime) values ('{0}','{1}','{2}','{3}','{4}','未归还','{5}','')",borrowid,isbn,bname,uid,uname,System.DateTime.Now.ToShortDateString());
            pubform.rest_num--;
            string ustr = string.Format("update books_data set rest_num=rest_num-1 where isbn='{0}'",isbn);
            DBHelper.mycon.Open();
            MySqlCommand cmd = new MySqlCommand(wstr, DBHelper.mycon);
            cmd.ExecuteNonQuery();
            //更新原本书本数量
            cmd = new MySqlCommand(ustr, DBHelper.mycon);
            cmd.ExecuteNonQuery();
            //更新用户已借，可借数目
            ustr = string.Format("update user_public set had_num=had_num+1,rest_num=rest_num-1 where uid='{0}'",uid);
            cmd = new MySqlCommand(ustr, DBHelper.mycon);
            cmd.ExecuteNonQuery();
            DBHelper.mycon.Close();
            label_content.Text = string.Format("{0}，你还可借{1}本书", pubform.uname.Replace(" ", ""), pubform.rest_num.ToString());
            button_search_Click(sender, e);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            pubform.fom2.Show();
            pubform.fom2.Form2_Load(sender, e);
            pubform.fom2.comboBox1_SelectedIndexChanged(sender,e);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_event_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                button_search_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_event_TextChanged(object sender, EventArgs e)
        {
            button_search_Click(sender,e);
        }
    }
}
