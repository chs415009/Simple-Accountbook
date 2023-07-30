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
    public partial class Form4 : Form
    {
        Categories categories_instance = new Categories(); 
        Records records_instance = new Records();
        string user = ""; //用於儲存繼承user        

        public Form4(string user,ref Records _save_records)
        {
            InitializeComponent();
            //植入所有類別供選擇
            combox_find.Items.Add("全");
            combox_find.Items.Add("--------支出");
            combox_find.Items.Add("----食物");
            combox_find.Items.Add("早餐");
            combox_find.Items.Add("午餐");
            combox_find.Items.Add("晚餐");
            combox_find.Items.Add("點心");
            combox_find.Items.Add("飲料");
            combox_find.Items.Add("其他(食");
            combox_find.Items.Add("----交通");
            combox_find.Items.Add("汽油");
            combox_find.Items.Add("公車");
            combox_find.Items.Add("捷運");
            combox_find.Items.Add("火車");
            combox_find.Items.Add("其他(交");
            combox_find.Items.Add("----娛樂");
            combox_find.Items.Add("電影");
            combox_find.Items.Add("衣著");
            combox_find.Items.Add("旅遊");
            combox_find.Items.Add("其他(娛");
            combox_find.Items.Add("----生活");
            combox_find.Items.Add("房租");
            combox_find.Items.Add("電信費");
            combox_find.Items.Add("水電費");
            combox_find.Items.Add("其他(生");
            combox_find.Items.Add("--------收入");
            combox_find.Items.Add("薪資");
            combox_find.Items.Add("其他(收");
            
            this.records_instance = _save_records; //繼承_save_records
            this.user = user; //繼承user
        }

        private void Form4_Load(object sender, EventArgs e) //在左右兩側顯示預設的記帳資料
        {
            textBox_view.Text = records_instance.ViewInTextbox(); //顯示_save_records所有資訊
            listBox_find.Items.Clear(); //預設查詢沒選擇，空的
        }

        private void combox_find_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Console.WriteLine(combox_find.SelectedItem.ToString());
            listBox_find.Items.Clear(); //先清空listbox，再根據combox所選的顯示查詢結果
            listBox_find.Items.AddRange(records_instance.FindInListBox(combox_find.SelectedItem.ToString(), categories_instance).ToArray());           
        }

        private void listBox_find_SelectedIndexChanged(object sender, EventArgs e) 
        {
            button_delete.Enabled = true;//選取listbox內容後，刪除按鈕才生效
        }

        private void button_delete_Click(object sender, EventArgs e)
        {                       
            if (listBox_find.SelectedIndex != -1) //檢查是否有選取ListBox項目
            {
                records_instance.Delete(listBox_find.SelectedIndex); //根據序號，從_save_records中移除所選取的ListBox項目
                listBox_find.Items.RemoveAt(listBox_find.SelectedIndex); //更新右側的listbox顯示
                textBox_view.Text = records_instance.ViewInTextbox(); //更新左側的textbox顯示
            }
            else { MessageBox.Show("請先選取欲刪除項目!"); }

            button_delete.Enabled = false;//執行完使按鈕失效
        }

        private void button_main_Click(object sender, EventArgs e) { this.Close(); }  //回到Form3的首頁     
    }
}
