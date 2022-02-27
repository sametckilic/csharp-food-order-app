
namespace Yemekcim
{
    partial class FormRsnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRsnt));
            this.lblRsnt = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lBoxFood = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubBalance = new System.Windows.Forms.Label();
            this.lnkLblMainMenu = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lBoxOrderList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRsnt
            // 
            this.lblRsnt.AutoSize = true;
            this.lblRsnt.Font = new System.Drawing.Font("DM Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRsnt.Location = new System.Drawing.Point(31, 101);
            this.lblRsnt.Name = "lblRsnt";
            this.lblRsnt.Size = new System.Drawing.Size(145, 48);
            this.lblRsnt.TabIndex = 0;
            this.lblRsnt.Text = "lblRsnt";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("DM Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFoodName.Location = new System.Drawing.Point(543, 100);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(211, 35);
            this.txtFoodName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("DM Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Location = new System.Drawing.Point(543, 154);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 35);
            this.txtPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(538, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yemek Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(300, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yemek Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(357, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyatı:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAdd.Location = new System.Drawing.Point(574, 215);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lBoxFood
            // 
            this.lBoxFood.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lBoxFood.FormattingEnabled = true;
            this.lBoxFood.ItemHeight = 31;
            this.lBoxFood.Location = new System.Drawing.Point(781, 85);
            this.lBoxFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lBoxFood.Name = "lBoxFood";
            this.lBoxFood.Size = new System.Drawing.Size(386, 252);
            this.lBoxFood.TabIndex = 7;
            this.lBoxFood.DoubleClick += new System.EventHandler(this.btnAddVisibleFalse);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(775, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yemek Listesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(724, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 124);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uyarı!\r\nYemekler %25 komisyon ile \r\nsatılmaktadır lütfen fiyatlandırmanızı\r\nbu ko" +
    "misyona göre ayarlayınız.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(906, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Toplam Ciro :";
            // 
            // lblSubBalance
            // 
            this.lblSubBalance.AutoSize = true;
            this.lblSubBalance.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSubBalance.Location = new System.Drawing.Point(1069, 555);
            this.lblSubBalance.Name = "lblSubBalance";
            this.lblSubBalance.Size = new System.Drawing.Size(56, 31);
            this.lblSubBalance.TabIndex = 11;
            this.lblSubBalance.Text = "null";
            // 
            // lnkLblMainMenu
            // 
            this.lnkLblMainMenu.AutoSize = true;
            this.lnkLblMainMenu.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lnkLblMainMenu.Location = new System.Drawing.Point(11, 9);
            this.lnkLblMainMenu.Name = "lnkLblMainMenu";
            this.lnkLblMainMenu.Size = new System.Drawing.Size(231, 31);
            this.lnkLblMainMenu.TabIndex = 16;
            this.lnkLblMainMenu.TabStop = true;
            this.lnkLblMainMenu.Text = "<- Ana Ekrana Dön";
            this.lnkLblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblMainMenu_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUpdate.Location = new System.Drawing.Point(574, 215);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 45);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lBoxOrderList
            // 
            this.lBoxOrderList.Font = new System.Drawing.Font("DM Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBoxOrderList.FormattingEnabled = true;
            this.lBoxOrderList.ItemHeight = 28;
            this.lBoxOrderList.Location = new System.Drawing.Point(17, 274);
            this.lBoxOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lBoxOrderList.Name = "lBoxOrderList";
            this.lBoxOrderList.Size = new System.Drawing.Size(542, 312);
            this.lBoxOrderList.TabIndex = 18;
            this.lBoxOrderList.Click += new System.EventHandler(this.lBoxOrderList_Click);
            this.lBoxOrderList.DoubleClick += new System.EventHandler(this.lBoxOrderList_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DM Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 48);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sipariş Listesi";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRefresh.Location = new System.Drawing.Point(17, 599);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(213, 41);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormRsnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(229)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1195, 644);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lBoxOrderList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lnkLblMainMenu);
            this.Controls.Add(this.lblSubBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lBoxFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblRsnt);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormRsnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restorant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRsnt_FormClosing);
            this.Load += new System.EventHandler(this.FormRsnt_Load);
            this.Click += new System.EventHandler(this.btnAddVisibleTrue);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRsnt;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lBoxFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubBalance;
        private System.Windows.Forms.LinkLabel lnkLblMainMenu;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lBoxOrderList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
    }
}