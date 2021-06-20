using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST6_Last
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private string[] uclass = { "admin", "public" };
        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "查询用户的" + pubform.request;
            comboBox1.SelectedIndex = 1;
            if (pubform.request == "密码")
            {
                label2.Text = "操作员ID：";
            }
        }

        private void search_uid()
        {
            if (DBHelper.Checkuname(uclass[comboBox1.SelectedIndex], textBox1.Text) && DBHelper.Checkid(uclass[comboBox1.SelectedIndex], textBox2.Text))
            {
                string str = string.Format("select uid from user_{0} where uname='{1}' and id='{2}'", uclass[comboBox1.SelectedIndex], textBox1.Text, textBox2.Text);
                string uid = DBHelper.Selectthings(str, "uid");
                textBox3.Text = uid;
                textBox3.Enabled = true;
                textBox3.SelectAll();
                textBox3.Focus();
            }
            else
            {
                MessageBox.Show("未查询到任何信息，请重试或联系管理员", "⚠提示");
            }
        }

        private void search_passwd()
        {
            if(DBHelper.Checkuser(uclass[comboBox1.SelectedIndex], textBox1.Text)  && DBHelper.Checkid(uclass[comboBox1.SelectedIndex], textBox2.Text))
            {
                string str = string.Format("select passwd from user_{0} where uid='{1}' and id='{2}'", uclass[comboBox1.SelectedIndex], textBox1.Text, textBox2.Text);
                string uid = DBHelper.Selectthings(str, "passwd");
                textBox3.Text = uid;
                textBox3.Enabled = true;
                textBox3.SelectAll();
                textBox3.Focus();
            }
            else
            {
                MessageBox.Show("未查询到任何信息，请重试或联系管理员","⚠提示");
            }
        }

        private void button_request_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text=="")
            {
                MessageBox.Show("输入信息不全或有误，请检查后重试","⚠提示");
                return;
            }
            if (pubform.request == "UID")
            {
                search_uid();
            }
            else
            {
                search_passwd();
            }
            if (textBox3.Text != "")
            {
                Clipboard.SetDataObject(textBox3.Text);
                MessageBox.Show(pubform.request + "是：" + textBox3.Text + "\n已复制剪切板", "⚠提示");
            }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            pubform.fom1.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                button_request_Click(sender,e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pubform.fom1.Show();
            this.Close();
        }
    }
}
