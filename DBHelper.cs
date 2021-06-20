using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net;

namespace TEST6_Last
{
    public class DBHelper
    {
        private static string constr = "server=yocen.top;port=3306;user=iauser;password=iauser2020;database=library;";
        public static MySqlConnection mycon = new MySqlConnection(constr);
        public static bool Checknet()
        {
            try
            {
                Dns.GetHostEntry("yocen.top");
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }
        public static bool Sqlconnect()//数据库的连接
        {
            try
            {
                if (Checknet())
                {
                    mycon.Open();
                    mycon.Close();
                    return true;
                }
            }
            catch
            {
                mycon.Close();
                return false;
            }
            return false;
        }

        public static bool Checkuser(string uclass, string uid)//查询数据库中是否存在uid
        {
            string str = string.Format("select * from user_{0} where uid='{1}'", uclass, uid);
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand(str, mycon);
            if (cmd.ExecuteReader().HasRows)
            {
                mycon.Close();
                return true;
            }
            else
            {
                mycon.Close();
                return false;
            }

        }

        public static bool Checkid(string uclass, string id)//查询数据库中是否存在uid
        {
            string str = string.Format("select * from user_{0} where id='{1}'", uclass, id);
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand(str, mycon);
            if (cmd.ExecuteReader().HasRows)
            {
                mycon.Close();
                return true;
            }
            else
            {
                mycon.Close();
                return false;
            }

        }

        public static bool Checkuname(string uclass, string uname)//查询数据库中是否存在uid
        {
            string str = string.Format("select * from user_{0} where uname='{1}'", uclass, uname);
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand(str, mycon);
            if (cmd.ExecuteReader().HasRows)
            {
                mycon.Close();
                return true;
            }
            else
            {
                mycon.Close();
                return false;
            }

        }

        public static string Selectpasswd(string uclass, string uid)//查询uname,密码，登陆权限
        {
            string str = string.Format("select passwd,uname,mode,department from user_{0} where uid='{1}'",uclass,uid );
            
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand(str, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string ans = reader.GetString("uname") + '&' + reader.GetString("passwd") + '&' + reader.GetString("mode") + '&' + reader.GetString("department");
            mycon.Close();
            return ans;
        }

        public static void Insertlogin(string uvalue)//写入登录记录
        {
            string str = string.Format("insert into log_login ({0},{1},{2},{3},{4},{5}) values ({6})","uid","uname","department","time","mode","status",uvalue);
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand(str, mycon);
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static string Selectthings(string str,string get)
        {
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand(str, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string ans = reader.GetString(get);
            mycon.Close();
            if (ans == "")
                ans = "NULL";
            return ans;
        }

        public static MySqlDataAdapter Selectall(string str)
        {
            mycon.Open();
            MySqlDataAdapter myda = new MySqlDataAdapter(str, mycon);
            mycon.Close();
            return myda;
        }

        public static int Get_rows_count(string table)
        {
            int ans;
            string str = "select count(*) from "+table;
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand(str,mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ans = reader.GetInt32("count(*)");
            mycon.Close();
            return ans;
        }
	}
}
