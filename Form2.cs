using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace TEST6_Last
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string str = "select borrowid,isbn,bname,status,borrowtime,backtime from log_borrow where uid='"+pubform.uid+"'";
        string nstr = "";
        MySqlDataAdapter myda ;
        DataSet ds;

        public void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = string.Format("你好,{0}!登录成功！{1}",pubform.uname,System.DateTime.Now.ToShortDateString());
            //this.WindowState = FormWindowState.Maximized;
            comboBox1.SelectedIndex = 0;
            label_department.Text = "部门：" + pubform.department;
            label_name.Text = "姓名：" + pubform.uname;
            label_uid.Text = "UID：" + pubform.uid;

            string telnumber = DBHelper.Selectthings(string.Format("select telnumber from user_public where uid='{0}'",pubform.uid),"telnumber");
            textBox_telnum.Text = telnumber;

            string rest_num = DBHelper.Selectthings("select rest_num from user_public where uid='" + pubform.uid + "'", "rest_num");
            label_borrownum.Text = string.Format("可借数量：{0}本", rest_num);
            pubform.rest_num = int.Parse(rest_num);
            pictureBox1.LoadAsync ("https://ipv4.ftp.uuoc.me:21443/books/images/"+pubform.uid+".png");
            DBHelper.mycon.Open();
            myda = new MySqlDataAdapter(str,DBHelper.mycon);
            DBHelper.mycon.Close();
            ds = new DataSet();
            myda.Fill(ds,"log_borrow");
            dataGridView_目录.DataSource = ds;
            dataGridView_目录.DataMember = "log_borrow";
        }

        public  void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatedata();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            pubform.fom1.Show();
            pubform.fom1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("数据加载中...");
            try
            {
                pubform.fom3.Close();
            }
            catch (Exception)
            {
            }
            pubform.fom3 = new Form3();
            pubform.fom3.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView_目录.Rows.Count<=0)
            {
                return;
            }
            int index = dataGridView_目录.CurrentRow.Index;
            if (dataGridView_目录.Rows[index].Cells[3].Value.ToString() == "已归还")
            {
                MessageBox.Show("这本书已经归还，无需任何操作","⚠提示");
                return;
            }
            string backtime = System.DateTime.Now.ToShortDateString();
            string ustr = string.Format( "update log_borrow set backtime='{0}',status='{1}' where borrowid='{2}'",backtime,"已归还", dataGridView_目录.Rows[index].Cells[0].Value.ToString());
            //MessageBox.Show(ustr);
            //MessageBox.Show(ustr);
            DBHelper.mycon.Open();
            MySqlCommand cmd = new MySqlCommand(ustr, DBHelper.mycon);
            cmd.ExecuteNonQuery();
            //更新用户已借，可借数量
            ustr = string.Format("update user_public set had_num=had_num-1,rest_num=rest_num+1 where uid='{0}'", pubform.uid);
            cmd = new MySqlCommand(ustr, DBHelper.mycon);
            cmd.ExecuteNonQuery();
            pubform.rest_num++;
            label_borrownum.Text = string.Format("可借数量：{0}本", pubform.rest_num);
            //更新书本的数量
            ustr = string.Format("update books_data set rest_num=rest_num+1 where isbn='{0}'", dataGridView_目录.Rows[index].Cells[1].Value.ToString());
            cmd = new MySqlCommand(ustr, DBHelper.mycon);
            cmd.ExecuteNonQuery();
            DBHelper.mycon.Close();
            updatedata();
        }

        public void updatedata()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    nstr = str + ";";
                    break;
                case 1:
                    nstr = str + " and status='已归还';";
                    break;
                case 2:
                    nstr = str + " and status='未归还';";
                    break;
                case 3:
                    nstr = str + " and status='未归还';";
                    break;
            }

            DBHelper.mycon.Open();
            myda = new MySqlDataAdapter(nstr, DBHelper.mycon);
            DBHelper.mycon.Close();
            ds = new DataSet();
            myda.Fill(ds, "log_borrow");
            dataGridView_目录.DataSource = ds;
            dataGridView_目录.DataMember = "log_borrow";
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            Form2_Load(sender,e);
            comboBox1.SelectedIndex = i;
            updatedata();
        }

        private void dataGridView_目录_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string pattern = @"^[A-Za-z0-9]+$";
            Regex regex = new Regex(pattern);
            if (textBox_telnum.Text=="" || !regex.IsMatch(textBox_telnum.Text) || (textBox_telnum.Text.Length != 11 && textBox_telnum.Text.Length!=7))
            {
                MessageBox.Show("电话格式输入错误，请重新输入", "⚠提示");
                return;
            }
            string ustr = string.Format("update user_public set telnumber='{0}' where uid='{1}'", textBox_telnum.Text, pubform.uid);
            DBHelper.mycon.Open();
            MySqlCommand cmd = new MySqlCommand(ustr,DBHelper.mycon);
            cmd.ExecuteNonQuery();
            DBHelper.mycon.Close();
            MessageBox.Show("更新成功","⚠提示");
            button_update.Enabled = false;
            textBox_telnum.Enabled = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_telnum.Enabled = true;
            button_update.Enabled = true;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pubform.fom1.Show();
            this.Close();
        }
    }
}
