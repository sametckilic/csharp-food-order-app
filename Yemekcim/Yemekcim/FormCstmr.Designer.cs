
namespace Yemekcim
{
    partial class FormCstmr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCstmr));
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lBoxCart = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubAmount = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxFoodAndPrice = new System.Windows.Forms.ListBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lnkLblMainMenu = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lBoxRsntList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lBoxOrders = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("DM Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUsername.Location = new System.Drawing.Point(750, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(199, 48);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(107, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cüzdan:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBalance.Location = new System.Drawing.Point(212, 142);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(31, 31);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(33, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bakiye Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBoxCart
            // 
            this.lBoxCart.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lBoxCart.FormattingEnabled = true;
            this.lBoxCart.ItemHeight = 31;
            this.lBoxCart.Location = new System.Drawing.Point(33, 382);
            this.lBoxCart.Name = "lBoxCart";
            this.lBoxCart.Size = new System.Drawing.Size(320, 159);
            this.lBoxCart.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(84, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam tutar :";
            // 
            // lblSubAmount
            // 
            this.lblSubAmount.AutoSize = true;
            this.lblSubAmount.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSubAmount.Location = new System.Drawing.Point(255, 560);
            this.lblSubAmount.Name = "lblSubAmount";
            this.lblSubAmount.Size = new System.Drawing.Size(31, 31);
            this.lblSubAmount.TabIndex = 8;
            this.lblSubAmount.Text = "0";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOrder.Location = new System.Drawing.Point(90, 619);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(191, 48);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Sipariş Ver";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(403, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Restorant Lisetesi";
            // 
            // lBoxFoodAndPrice
            // 
            this.lBoxFoodAndPrice.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lBoxFoodAndPrice.FormattingEnabled = true;
            this.lBoxFoodAndPrice.ItemHeight = 31;
            this.lBoxFoodAndPrice.Location = new System.Drawing.Point(760, 188);
            this.lBoxFoodAndPrice.Name = "lBoxFoodAndPrice";
            this.lBoxFoodAndPrice.Size = new System.Drawing.Size(449, 407);
            this.lBoxFoodAndPrice.TabIndex = 10;
            this.lBoxFoodAndPrice.DoubleClick += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAddCart.Location = new System.Drawing.Point(910, 619);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(209, 63);
            this.btnAddCart.TabIndex = 13;
            this.btnAddCart.Text = "Sepete Ekle";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lnkLblMainMenu
            // 
            this.lnkLblMainMenu.AutoSize = true;
            this.lnkLblMainMenu.Font = new System.Drawing.Font("DM Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLblMainMenu.Location = new System.Drawing.Point(10, 9);
            this.lnkLblMainMenu.Name = "lnkLblMainMenu";
            this.lnkLblMainMenu.Size = new System.Drawing.Size(151, 21);
            this.lnkLblMainMenu.TabIndex = 16;
            this.lnkLblMainMenu.TabStop = true;
            this.lnkLblMainMenu.Text = "<- Ana Ekrana Dön";
            this.lnkLblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblMainMenu_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("DM Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(340, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 48);
            this.label5.TabIndex = 17;
            this.label5.Text = "yemekçim\'e";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("DM Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(563, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 48);
            this.label6.TabIndex = 18;
            this.label6.Text = "hoşgeldin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(117, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sepet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(754, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yemek Lisetesi";
            // 
            // lBoxRsntList
            // 
            this.lBoxRsntList.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lBoxRsntList.FormattingEnabled = true;
            this.lBoxRsntList.ItemHeight = 31;
            this.lBoxRsntList.Location = new System.Drawing.Point(409, 188);
            this.lBoxRsntList.Name = "lBoxRsntList";
            this.lBoxRsntList.Size = new System.Drawing.Size(325, 407);
            this.lBoxRsntList.TabIndex = 23;
            this.lBoxRsntList.SelectedIndexChanged += new System.EventHandler(this.lBoxRstnList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(309, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "TL";
            // 
            // lBoxOrders
            // 
            this.lBoxOrders.Font = new System.Drawing.Font("DM Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lBoxOrders.FormattingEnabled = true;
            this.lBoxOrders.ItemHeight = 31;
            this.lBoxOrders.Location = new System.Drawing.Point(409, 619);
            this.lBoxOrders.Name = "lBoxOrders";
            this.lBoxOrders.Size = new System.Drawing.Size(426, 66);
            this.lBoxOrders.TabIndex = 25;
            this.lBoxOrders.Click += new System.EventHandler(this.lBoxOrders_Click);
            this.lBoxOrders.DoubleClick += new System.EventHandler(this.lBoxOrders_DoubleClick);
            // 
            // FormCstmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(229)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1220, 712);
            this.Controls.Add(this.lBoxOrders);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lBoxRsntList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubAmount);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnkLblMainMenu);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.lBoxFoodAndPrice);
            this.Controls.Add(this.lBoxCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormCstmr";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.FormCstmr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lBoxCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubAmount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxFoodAndPrice;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.LinkLabel lnkLblMainMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lBoxRsntList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lBoxOrders;
    }
}