using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;


namespace TEST6_Last
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            pubform.fom1 = this;

            Form3 fom3 = new Form3();
            pubform.fom3 = fom3;
            try
            {
                if (!DBHelper.Checknet())
                {
                    MessageBox.Show("应用联网后才能使用","⚠提示");
                    return;
                }
                DBHelper.Sqlconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR：云数据库连接出错","⚠警告");
                throw;
            }
            if (DBHelper.Sqlconnect())
            {
                comboBox_idclass.Enabled = true;
                textBox_uid.Enabled = true;
                button_exit.Enabled = true;
                comboBox_idclass.SelectedIndex = 1;
                timer1.Start();
                timer1.Interval = 100;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dt = System.DateTime.Now;
            label_time.Text = dt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string uid =textBox_uid.Text;
            string passwd = textBox_passwd.Text;
            string table;
            if(comboBox_idclass.SelectedIndex == 1)
            {
                table = "public";
            }
            else
            {
                table = "admin";
            }
            try
            {
                string uvalue = "'"+uid+"',";
                if (DBHelper.Checkuser(table, uid))
                {
                    string str=DBHelper.Selectpasswd(table,uid);
                    string uname = str.Split('&')[0];
                    string cpasswd = str.Split('&')[1];
                    string mode = str.Split('&')[2];
                    string department = str.Split('&')[3];
                    uvalue = "'" + uid + "','" + uname +"','"+department+ "','" +System.DateTime.Now.ToString()+"','"+ mode + "',";
                    if(mode != "permiss")
                    {
                        uvalue += "'FAIL'";
                        MessageBox.Show("无登录权限！", "⚠提示");
                        return;
                    }
                    if(passwd == cpasswd)
                    {
                        this.BackColor = Color.LimeGreen;
                        pubform.uid = uid;
                        pubform.uname = uname;
                        pubform.department = department;
                        uvalue += "'SUCCESSFUL'";
                        if (comboBox_idclass.SelectedIndex == 1)
                        {
                            Form2 fom2 = new Form2();
                            pubform.fom2 = fom2;
                            fom2.Show();
                        }
                        else
                        {
                            Form4 fom4 = new Form4();
                            pubform.fom4 = fom4;
                            fom4.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        uvalue += "'FAIL'";
                        this.BackColor = Color.Red;
                        MessageBox.Show("密码错误", "登录失败");
                    }
                }
                else
                {
                    uvalue += (string.Format("'未知','未知','{0}','未知','FAIL'",System.DateTime.Now.ToString()));   
                    //MessageBox.Show("未查询到该操作员ID,","⚠提示");
                }
                DBHelper.Insertlogin(uvalue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "⚠提示");
            } 
        }

        private void textBox_passwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                button_login_Click(sender, e);
            }
        }

        private void textBox_uid_TextChanged(object sender, EventArgs e)
        {
            textBox_passwd.Enabled = true;
        }

        private void textBox_passwd_TextChanged(object sender, EventArgs e)
        {
            button_login.Enabled = true;
            button_login.BackColor = Color.LimeGreen;
        }

        private void 查询操作员IDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pubform.request = "UID";
            Form6 fom6 = new Form6();
            this.Hide();
            fom6.Show();
        }

        private void 查询密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pubform.request = "密码";
            Form6 fom6 = new Form6();
            this.Hide();
            fom6.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1_Load(sender,e);
        }
    }
}
