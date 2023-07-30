namespace AccountingApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combox_find = new System.Windows.Forms.ComboBox();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_view = new System.Windows.Forms.TextBox();
            this.listBox_find = new System.Windows.Forms.ListBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combox_find
            // 
            this.combox_find.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combox_find.ForeColor = System.Drawing.Color.SeaGreen;
            this.combox_find.FormattingEnabled = true;
            this.combox_find.Location = new System.Drawing.Point(603, 33);
            this.combox_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_find.Name = "combox_find";
            this.combox_find.Size = new System.Drawing.Size(201, 39);
            this.combox_find.TabIndex = 0;
            this.combox_find.SelectedIndexChanged += new System.EventHandler(this.combox_find_SelectedIndexChanged);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label_search.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_search.Location = new System.Drawing.Point(523, 36);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(74, 31);
            this.label_search.TabIndex = 1;
            this.label_search.Text = "查詢 :";
            // 
            // textBox_view
            // 
            this.textBox_view.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox_view.Location = new System.Drawing.Point(12, 33);
            this.textBox_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_view.MaximumSize = new System.Drawing.Size(562, 359);
            this.textBox_view.Multiline = true;
            this.textBox_view.Name = "textBox_view";
            this.textBox_view.Size = new System.Drawing.Size(504, 359);
            this.textBox_view.TabIndex = 4;
            // 
            // listBox_find
            // 
            this.listBox_find.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBox_find.FormattingEnabled = true;
            this.listBox_find.ItemHeight = 18;
            this.listBox_find.Location = new System.Drawing.Point(530, 82);
            this.listBox_find.Margin = new System.Windows.Forms.Padding(0);
            this.listBox_find.Name = "listBox_find";
            this.listBox_find.Size = new System.Drawing.Size(387, 310);
            this.listBox_find.TabIndex = 5;
            this.listBox_find.SelectedIndexChanged += new System.EventHandler(this.listBox_find_SelectedIndexChanged);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button_delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_delete.Location = new System.Drawing.Point(820, 33);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(96, 39);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_main
            // 
            this.button_main.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.button_main.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_main.Location = new System.Drawing.Point(339, 418);
            this.button_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(259, 61);
            this.button_main.TabIndex = 7;
            this.button_main.Text = "回首頁";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button_main_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.listBox_find);
            this.Controls.Add(this.textBox_view);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.combox_find);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_find;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_view;
        private System.Windows.Forms.ListBox listBox_find;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_main;
    }
}