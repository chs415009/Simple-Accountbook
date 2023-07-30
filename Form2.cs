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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountingApp
{   
    public partial class Form2 : Form
    {
        

        //呼叫自己的函數(_init_)以建立物件
        Records records_instance = new Records();

        string user = ""; //存取當前用戶名
        string input = ""; //存取讀取文件時的內容

        public Form2(string user) //整個form2的初始化，包含接收user字串
        {
            InitializeComponent();
            this.user = user + ".txt"; //將當前user的用戶名和 ".txt" 拼接在一起，並指派回user
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //將按鈕定錨，縮放視窗大小相對位置不變
            label1.Anchor = AnchorStyles.Left;
            label2.Anchor = AnchorStyles.Bottom;            
            label3.Anchor = AnchorStyles.Right;            
            button_add.Anchor = AnchorStyles.Bottom;

            if (!File.Exists(user)) //user已於前面更改為"當前使用者.txt"          
            {
                File.Create(user).Close();
            }

            //讀取到input中，再分割資訊(類別、敘述、金額、日期)存到_save_records
            StreamReader sr = new StreamReader(user);
            while ((input = sr.ReadLine()) != null)
            {
                records_instance._save_records.Add(new Record(input.Split(' ')[0], input.Split(' ')[1], int.Parse(input.Split(' ')[2]), input.Split(' ')[3]));
            }
            sr.Close();           
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(user,ref records_instance);  //產生Form3的物件，才可以使用它所提供的Method，並繼承user、rec
            F3.ShowDialog(this); //設定Form3為Form2的上層，並開啟Form3視窗。
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //按下離開鈕後會結束Form2，並儲存所有變更
            DialogResult choose;
            string mes = "儲存變更離開嗎";
            choose = MessageBox.Show(mes, "離開", MessageBoxButtons.OKCancel);
           
            if (choose == DialogResult.Cancel) //若在離開時選擇取消，會顯示當前變更的紀錄
            {
                MessageBox.Show(records_instance.View()); 
            }
            else //確認離開後存取紀錄
            {
                StreamWriter sw = new StreamWriter(user);
                foreach(Record r in records_instance._save_records)
                {
                    sw.WriteLine(r.r_category+" "+r.r_description+" "+r.r_amount+" " + r.r_time);
                }
                sw.Close();
                this.Close(); //關閉視窗
            }
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4(user,ref records_instance); //產生Form4的物件，才可以使用它所提供的Method
            F4.ShowDialog(this); //設定Form4為Form3的上層，並開啟Form4視窗。
        }
    }

    //以下為各種class物件
    

    public class Record /////////////////////////////////////////////////////////////////////////////////////////////
    {
        public string r_category { get; }
        public string r_description { get; }
        public int r_amount { get; }
        public string r_time { get; }
        public Record(string category, string description, int amount,string time) //用於儲存單項紀錄，包括(類別、敘述、金額、時間)
        {
            r_category = category;
            r_description = description;
            r_amount = amount;
            r_time = time;
        }
    }

    public class Records /////////////////////////////////////////////////////////////////////////////////////////////
    {       
        public List<Record> _save_records; //儲存所有的Record在 _save_records 的list中
        public Records() //類_init_，
        {          
            List<Record> save_records = new List<Record>();           
            _save_records = save_records;
        }
        //以下為一些編輯_save_records的功能函數

        public string View() //用於新增或離開時，messagebox的檢視頁面
        {
            string result = "";
            result+="類別\t敘述\t\t金額\n";
            result+="================================ \n";
            int total_money = 0;
            foreach (Record rec in _save_records) //把所有_save_records裡的Record存到result字串以便顯示，同時加總金額
            {
                total_money += rec.r_amount;
                result+=$"{rec.r_category,-8}\t{rec.r_description,-20}\t{rec.r_amount}\n";
            }
            result +="================================ \n";
            result += $"！本次新增共累積 {total_money} 元\n";
            return result;
        }

        public string ViewInTextbox() //功能大致與View相同，多了時間的顯示
        {
            string result = "";
            result += "序     類別\t備註\t\t金額\t        日期 "+Environment.NewLine;
            result += "======================================================="+Environment.NewLine;
            int total_money = 0;
            int index = 1;
            foreach (Record rec in _save_records)
            {
                total_money += rec.r_amount;
                result += $"{index,-8}{rec.r_category,-4}\t{rec.r_description,-16}\t{rec.r_amount}\t        {rec.r_time}" + Environment.NewLine;
                index++;
            }
            result += "=======================================================" + Environment.NewLine;
            result += $"~ 您的戶頭餘額為 {total_money} 元 ~" + Environment.NewLine;
            return result;
        }

        public void Delete(int delete_record) //用於Form4的選取刪除功能
        {            
            _save_records.RemoveAt(delete_record);
        }
        
        public List<string> FindInListBox(string target_category, Categories categories_instance) //用於篩選想要看到那些Record
        {
            while (target_category.Substring(0,1) == "-") //把篩選列表的"-"清除，再讀取所選類別
            {
                target_category =  target_category.TrimStart('-');
            }

            List<string> find = new List<string>(); //若想篩選的是以下大分類，利用FindSubcategories的功能，把將尋找的子類別暫存到find
            if (target_category == "支出" || target_category == "食物"|| target_category == "交通" || target_category == "娛樂" || 
                target_category == "生活" || target_category == "收入" )
            {
               find = categories_instance.FindSubcategories(target_category);
            }

            List <string> filter_result = new List<string>(); //根據find，從整個_save_records挑出目標存入filter_result及加總total_filter_amount
            int total_filter_amount = 0;
            int index = 1;
            foreach (Record rec in _save_records)
            {
                if(target_category == "全") //選 全 的情況
                {
                    total_filter_amount += rec.r_amount;
                    filter_result.Add($"{index,-7}{rec.r_category}\t{rec.r_description,-16}\t{rec.r_amount}");
                }
                else if (rec.r_category == target_category) //選 子類別(任一r_category) 的情況，直接核對
                {
                    total_filter_amount += rec.r_amount;
                    filter_result.Add($"{index,-7}{rec.r_category}\t{rec.r_description,-16}\t{rec.r_amount}");
                }
                else //選 大類別 的情況，從find去找對應的r_category
                {
                    if(find.Contains(rec.r_category))
                    {
                        total_filter_amount += rec.r_amount;
                        filter_result.Add($"{index,-7}{rec.r_category}\t{rec.r_description,-16}\t{rec.r_amount}");
                    }
                }
                index++;
            }
            return filter_result;
        }        
    }

    public class Categories /////////////////////////////////////////////////////////////////////////////////////////////
    {
        private List<string> _categories_list;

        public Categories()
        {
            _categories_list = new List<string>
        {
            "支出" //0
            ,"食物","早餐", "午餐", "晚餐", "點心", "飲料","其他(食" //1~7
            ,"交通","汽油","公車","捷運","火車","其他(交" //8~13
            ,"娛樂","電影","衣著","旅遊","其他(娛" //14~18
            ,"生活", "房租", "電信", "水電", "其他(生" //19~23
            ,"收入" //24
            ," ","薪資", "其他(收" //25~27
        };
        }

        public List<string> FindSubcategories(string target_category) //篩選為大分類時，利用FindSubcategories將尋找的子類別暫存到find
        {
            List<string> found_categories = new List<string>();
            //FindSubcategories函數將根據target_category的字串去搜尋 _categories中符合條件的元素，再將其匯整到found_categories中

            if (target_category == "支出")
            {
                for (int i = 1; i < 24; i++) { found_categories.Add(_categories_list[i]); }                
            }
            if (target_category == "食物")
            {
                for (int i = 2; i < 8; i++) { found_categories.Add(_categories_list[i]); }                
            }
            if (target_category == "交通")
            {
                for (int i = 9; i < 14; i++) { found_categories.Add(_categories_list[i]); }                
            }
            if (target_category == "娛樂")
            {
                for (int i = 15; i < 19; i++) { found_categories.Add(_categories_list[i]); }
            }
            if (target_category == "生活")
            {
                for (int i = 20; i < 24; i++) { found_categories.Add(_categories_list[i]); }             
            }
            if (target_category == "收入")
            {
                for (int i = 26; i < 28; i++) { found_categories.Add(_categories_list[i]); }               
            }
            return found_categories;
        }       
    }    
}
