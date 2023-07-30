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
    public partial class Form3 : Form
    {
        Categories categories_instance = new Categories();
        Records records_instance = new Records();
        Records old_records = new Records();       
        string user = ""; //用於儲存當前用戶

        public Form3(string user, ref Records records_instance)
        {
            InitializeComponent();
            text_radiobutton_list = new List<string>();   //將所有button文字加入到此字串
            this.user = user;
            old_records = records_instance;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //設定日期combobox，並預設日期設為現在            
            combox_year.Text = (DateTime.Now.Year).ToString();
            combox_month.Text = DateTime.Now.Month.ToString();
            combox_day.Text = DateTime.Now.Day.ToString();

            //設定combobox年分範圍，10年前至今年
            for (int i = DateTime.Now.Year - 10; i <= DateTime.Now.Year; i++) { combox_year.Items.Add(i.ToString()); }

            //設定combobox月份範圍，1月至12月         
            for (int i = 1; i <= 12; i++) { combox_month.Items.Add(i.ToString()); }

            //設定combobox日期範圍，根據月份判斷最多至30或31
            if (combox_month.Text == "1" || combox_month.Text == "3" || combox_month.Text == "5" || combox_month.Text == "7" || 
                combox_month.Text == "8" || combox_month.Text == "10" || combox_month.Text == "12")
            {
                for (int i = 1; i <= 31; i++) { combox_day.Items.Add(i.ToString()); }               
            }
            if (combox_month.Text == "4" || combox_month.Text == "6" || combox_month.Text == "9" || combox_month.Text == "11")
            {
                for (int i = 1; i <= 30; i++) { combox_day.Items.Add(i.ToString()); }               
            }
            if (combox_month.Text == "2" && (int.Parse(combox_year.Text) % 400 == 0 || (int.Parse(combox_year.Text) % 4 == 0 && int.Parse(combox_year.Text) % 100 != 0)))
            {
                for (int i = 1; i <= 29; i++) { combox_day.Items.Add(i.ToString()); }               
            }
            if (combox_month.Text == "2" && int.Parse(combox_year.Text) % 4 !=0)
            {
                for (int i = 1; i <= 28; i++) { combox_day.Items.Add(i.ToString()); }
            }
        }

        private void combox_month_SelectedIndexChanged(object sender, EventArgs e) //選擇不同月份時，重新檢查對應的日期選項
        {
            if (combox_month.Text == "1" || combox_month.Text == "3" || combox_month.Text == "5" || combox_month.Text == "7" ||
                combox_month.Text == "8" || combox_month.Text == "10" || combox_month.Text == "12")
            {
                combox_day.Items.Clear();
                for (int i = 1; i <= 31; i++) { combox_day.Items.Add(i.ToString()); }              
            }
            if (combox_month.Text == "4" || combox_month.Text == "6" || combox_month.Text == "9" || combox_month.Text == "11")
            {
                combox_day.Items.Clear();
                for (int i = 1; i <= 30; i++) { combox_day.Items.Add(i.ToString()); }
            }
            if (combox_month.Text == "2" && (int.Parse(combox_year.Text) % 400 == 0 || (int.Parse(combox_year.Text) % 4 == 0 && int.Parse(combox_year.Text) % 100 != 0)))
            {
                combox_day.Items.Clear();
                for (int i = 1; i <= 29; i++) { combox_day.Items.Add(i.ToString()); }
            }
            if (combox_month.Text == "2" && int.Parse(combox_year.Text) % 4 != 0)
            {
                combox_day.Items.Clear();
                for (int i = 1; i <= 28; i++) { combox_day.Items.Add(i.ToString()); }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string radio_selected = ""; //用於存儲選擇的小品項
            string category_selected = ""; //用於存儲選擇品項的類別
            int error = 0; //金額是否輸入錯誤

            try //檢測金額輸入正確才能正常新增內容，否則跳出金額錯誤
            {
                if (int.Parse(textbox_money.Text).GetType() != typeof(int)) //確認金額是否為數字
                {
                    MessageBox.Show("金額輸入格式錯誤 ! (e.g. -1000)");
                }
                else
                {
                    string message_added = "您新增了一筆";                   
                    string time_added = combox_year.Text + "/" + combox_month.Text + "/" + combox_day.Text;
                    //根據所選的radiobutton,儲存對應的資訊
                    if (radioButton1.Checked) { radio_selected = radioButton1.Text; category_selected = label_food.Text; }                                       
                    else if (radioButton2.Checked) { radio_selected = radioButton2.Text; category_selected = label_food.Text; }                    
                    else if (radioButton3.Checked) { radio_selected = radioButton3.Text; category_selected = label_food.Text; }                   
                    else if (radioButton4.Checked) { radio_selected = radioButton4.Text; category_selected = label_food.Text; }                    
                    else if (radioButton5.Checked) { radio_selected = radioButton5.Text; category_selected = label_food.Text; }                   
                    else if (radioButton6.Checked) { radio_selected = radioButton6.Text; category_selected = label_food.Text; }
                    else if (radioButton7.Checked) { radio_selected = radioButton7.Text; category_selected = label_traffic.Text; }                    
                    else if (radioButton8.Checked) { radio_selected = radioButton8.Text; category_selected = label_traffic.Text; }
                    else if (radioButton9.Checked) { radio_selected = radioButton9.Text; category_selected = label_traffic.Text; }
                    else if (radioButton10.Checked) { radio_selected = radioButton10.Text; category_selected = label_traffic.Text; }
                    else if (radioButton11.Checked) { radio_selected = radioButton11.Text; category_selected = label_traffic.Text; }
                    else if (radioButton12.Checked) { radio_selected = radioButton12.Text; category_selected = label_entertainment.Text; }
                    else if (radioButton13.Checked) { radio_selected = radioButton13.Text; category_selected = label_entertainment.Text; }
                    else if (radioButton14.Checked) { radio_selected = radioButton14.Text; category_selected = label_entertainment.Text; }
                    else if (radioButton15.Checked) { radio_selected = radioButton15.Text; category_selected = label_entertainment.Text; }
                    else if (radioButton16.Checked) { radio_selected = radioButton16.Text; category_selected = label_living.Text; }
                    else if (radioButton17.Checked) { radio_selected = radioButton17.Text; category_selected = label_living.Text; }
                    else if (radioButton18.Checked) { radio_selected = radioButton18.Text; category_selected = label_living.Text; }
                    else if (radioButton19.Checked) { radio_selected = radioButton19.Text; category_selected = label_living.Text; }
                    else if (radioButton20.Checked) { radio_selected = radioButton20.Text; category_selected = label_income.Text; }
                    else if (radioButton21.Checked) { radio_selected = radioButton21.Text; category_selected = label_income.Text; }

                    //確認金額的正負號
                    if (!(radioButton20.Checked || radioButton21.Checked)) //若選擇屬於支出，金額前未輸入"-"，自動補上
                    {
                        if (textbox_money.Text.Substring(0, 1) != "-") { textbox_money.Text = "-" + textbox_money.Text; }
                    }
                    else //若選擇屬於收入，金額前輸入了"-"，顯示錯誤
                    {
                        if (textbox_money.Text.Substring(0, 1) == "-") { MessageBox.Show("金額輸入有誤 !"); error = 1; }
                    }

                    message_added += "\n日期 : " + time_added + "\n類別 : " + category_selected + "\n分項 : " + radio_selected + 
                                     "\n金額 : " + textbox_money.Text + "\n備註 : " + textbox_description.Text;

                    if (error == 0) //確認金額格式完全正確，才會更新_save_records
                    {                        
                        records_instance._save_records.Add(new Record(radio_selected, textbox_description.Text, int.Parse(textbox_money.Text), time_added));
                        old_records._save_records.Add(new Record(radio_selected, textbox_description.Text, int.Parse(textbox_money.Text), time_added));
                        MessageBox.Show(message_added); //檢視單筆新增
                        MessageBox.Show(records_instance.View());//檢視本次新增，共新增哪些
                    }
                }
            }
            catch { MessageBox.Show("金額輸入格式錯誤 ! (e.g. -1000)"); }
        }

        //將選取的radiobutton文字暫存至text_button，再全部加進text_radiobutton_list當中，到258行皆為同一動
        private List<string> text_radiobutton_list; // 儲存按鈕的文字

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string text_button = clickedButton.Text;
            this.text_radiobutton_list.Add(text_button);
        }      
    }
}
