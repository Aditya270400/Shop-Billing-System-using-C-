namespace ShopBilling
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.removeItem = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.paidBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.netBalance = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remainBalance = new System.Windows.Forms.TextBox();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_View = new System.Windows.Forms.ListView();
            this.add_Item = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.cb = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // removeItem
            // 
            this.removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItem.Location = new System.Drawing.Point(718, 284);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(84, 23);
            this.removeItem.TabIndex = 37;
            this.removeItem.Text = "Remove Item";
            this.removeItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(634, 591);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(46, 13);
            this.Label9.TabIndex = 31;
            this.Label9.Text = "Balance";
            // 
            // paidBox
            // 
            this.paidBox.Location = new System.Drawing.Point(693, 546);
            this.paidBox.Name = "paidBox";
            this.paidBox.Size = new System.Drawing.Size(100, 20);
            this.paidBox.TabIndex = 36;
            this.paidBox.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(634, 549);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(28, 13);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "Paid";
            // 
            // netBalance
            // 
            this.netBalance.Enabled = false;
            this.netBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netBalance.Location = new System.Drawing.Point(693, 506);
            this.netBalance.Name = "netBalance";
            this.netBalance.Size = new System.Drawing.Size(100, 20);
            this.netBalance.TabIndex = 35;
            this.netBalance.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(634, 509);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(24, 13);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Net";
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(432, 506);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(100, 20);
            this.discountBox.TabIndex = 34;
            this.discountBox.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(370, 509);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(49, 13);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "Discount";
            // 
            // subTotal
            // 
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(253, 506);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(100, 20);
            this.subTotal.TabIndex = 33;
            this.subTotal.Text = "0";
            this.subTotal.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(194, 509);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 13);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Sub Total";
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Total";
            this.ColumnHeader4.Width = 122;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Quantity";
            this.ColumnHeader3.Width = 105;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Price";
            this.ColumnHeader2.Width = 111;
            // 
            // remainBalance
            // 
            this.remainBalance.Enabled = false;
            this.remainBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainBalance.Location = new System.Drawing.Point(693, 588);
            this.remainBalance.Name = "remainBalance";
            this.remainBalance.Size = new System.Drawing.Size(100, 20);
            this.remainBalance.TabIndex = 32;
            this.remainBalance.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Item Name";
            this.ColumnHeader1.Width = 272;
            // 
            // list_View
            // 
            this.list_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.list_View.FullRowSelect = true;
            this.list_View.HideSelection = false;
            this.list_View.Location = new System.Drawing.Point(197, 313);
            this.list_View.Name = "list_View";
            this.list_View.Size = new System.Drawing.Size(616, 174);
            this.list_View.TabIndex = 26;
            this.list_View.UseCompatibleStateImageBehavior = false;
            this.list_View.View = System.Windows.Forms.View.Details;
            this.list_View.SelectedIndexChanged += new System.EventHandler(this.List_View_SelectedIndexChanged);
            // 
            // add_Item
            // 
            this.add_Item.Location = new System.Drawing.Point(718, 249);
            this.add_Item.Name = "add_Item";
            this.add_Item.Size = new System.Drawing.Size(84, 23);
            this.add_Item.TabIndex = 25;
            this.add_Item.Text = "Add Item";
            this.add_Item.UseVisualStyleBackColor = true;
            this.add_Item.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(548, 226);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(31, 13);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Total";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(370, 226);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(46, 13);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Quantity";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(194, 226);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 13);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Price";
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(551, 252);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 21;
            this.totalBox.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(370, 252);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 20);
            this.quantityBox.TabIndex = 20;
            this.quantityBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // pricebox
            // 
            this.pricebox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pricebox.Enabled = false;
            this.pricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.Location = new System.Drawing.Point(197, 252);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(100, 20);
            this.pricebox.TabIndex = 19;
            this.pricebox.TextChanged += new System.EventHandler(this.Item_price_TextChanged);
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(561, 112);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(136, 17);
            this.RadioButton3.TabIndex = 18;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Snacks and Beverages";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(380, 112);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(62, 17);
            this.RadioButton2.TabIndex = 17;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Utensils";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AccessibleName = "radioB1";
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(207, 112);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(62, 17);
            this.RadioButton1.TabIndex = 16;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Grocery";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // cb
            // 
            this.cb.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(197, 161);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(536, 21);
            this.cb.TabIndex = 15;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(74, 161);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Select Item";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(0, -2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(983, 108);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 626);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.paidBox);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.netBalance);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.remainBalance);
            this.Controls.Add(this.list_View);
            this.Controls.Add(this.add_Item);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.RadioButton3);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button removeItem;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox paidBox;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox netBalance;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox discountBox;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox subTotal;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.TextBox remainBalance;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ListView list_View;
        internal System.Windows.Forms.Button add_Item;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox totalBox;
        internal System.Windows.Forms.TextBox quantityBox;
        internal System.Windows.Forms.TextBox pricebox;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.ComboBox cb;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

