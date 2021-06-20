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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void SetProgressValue(int value)
        {

        }
        private string[] uclass = {"admin","public" };
        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = "查询用户的"+pubform.request;
            comboBox1.SelectedIndex = 1;
            if (pubform.request == "uid")
            {
                label1.Text = "";
                search_uid();
                
            }
            else
            {
                label1.Text = "用户类型";
                search_passwd();
            }
        }

        private void search_uid()
        {
            string str = string.Format("select uid from user_{0} where uname='{1}'",uclass[comboBox1.SelectedIndex],textBox1.Text);
            string uid = DBHelper.Selectthings(str, "uid");
            textBox3.Text = uid;
            textBox3.SelectAll();
            textBox3.Focus();
        }

        private void search_passwd()
        {
            label1.Text = "操作员ID";
            string str = string.Format("select uid from user_{0} where uid='{1}'", uclass[comboBox1.SelectedIndex], textBox1.Text);
            string uid = DBHelper.Selectthings(str, "uid");
            textBox3.Text = uid;
            textBox3.SelectAll();
            textBox3.Focus();
        }
    }
}
