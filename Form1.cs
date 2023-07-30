using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountingApp
{
    public partial class Form1 : Form
    {
        SortedList<string, string> userlist = new SortedList<string, string>(); //所有用戶帳密，利用key的性質成對
        string[] input = new string[2]; //儲存從文件讀取的帳密
        int login = 0; //登入狀態
        string login_user = ""; //當前使用者

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string get; //從user暫時讀取到的內容

            //若無，建立一個User.txt (txt檔用於儲存 所有帳密的純文字內容)
            if (!File.Exists("User.txt"))
            {
                StreamWriter sw = new StreamWriter("User.txt");
                sw.Close();
            }

            //若txt有讀取到內容，將帳密存到sortedlist
            StreamReader sr = new StreamReader("User.txt");
            while ((get = sr.ReadLine()) != null)
            {
                input = get.Split(' ');
                userlist.Add(input[0], input[1]);
            }
            sr.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {           
            //預設帳密未輸入，用於檢查是否確實輸入帳密
            bool input_exist = false;
            string password = "";

            if (textBox_account.Text != "" && textBox_password.Text != "")
            {
                //TryGetValue 從 userlist 獲取指定帳號，若有對應帳號，將對應的密碼存儲到 string password 
                input_exist = userlist.TryGetValue(textBox_account.Text, out password);
                if (!input_exist)
                {
                    //沒找到，註冊新用戶
                    DialogResult register = MessageBox.Show("是否註冊帳號?", "未找到使用者", MessageBoxButtons.YesNo);
                    if (register == DialogResult.Yes)
                    {
                        StreamWriter sw = new StreamWriter("User.txt", true); //若存在 不覆蓋內容
                        userlist.Add(textBox_account.Text, textBox_password.Text);
                        sw.WriteLine(textBox_account.Text + " " + textBox_password.Text);
                        sw.Close();
                        input_exist = true;
                        login = 1;                        
                        login_user = textBox_account.Text;
                    }
                    else
                    {
                        login = 0;
                    }
                }
                else
                {
                    if (password == textBox_password.Text) //密碼正確
                    {
                        login_user = textBox_account.Text;
                        login = 1;
                    }
                    else //密碼錯誤
                    {
                        login = -1;
                        MessageBox.Show("密碼錯誤!");
                    }
                }
            }
            else //登入錯誤的情況
            {
                login = 0;
                if (textBox_account.Text == "" && textBox_password.Text == "") MessageBox.Show("請輸入帳號與密碼", "輸入錯誤");
                else if (textBox_account.Text == "") MessageBox.Show("請輸入帳號", "輸入錯誤");
                else MessageBox.Show("請輸入密碼", "輸入錯誤");
            }

            Form2 F2 = new Form2(login_user);
            //產生Form2的物件，才可以使用它所提供的Method，並將 login_user 作為參數傳遞給 Form2 的函數
            //這樣Form2 窗體就知道當前登錄的用戶名是誰，以便顯示對應用戶的消費記錄。
           
            if (login == 1)
            {
                F2.ShowDialog(this); //設定Form2為Form1的上層，並開啟Form2視窗。                
            }
            textBox_account.Text = "";
            textBox_password.Text = "";            
        } 
    }
}
