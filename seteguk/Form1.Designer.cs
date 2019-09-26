namespace seteguk
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.text_no = new System.Windows.Forms.TextBox();
            this.text_pembeli = new System.Windows.Forms.TextBox();
            this.text_menu = new System.Windows.Forms.TextBox();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_harga = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_checkout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(212, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 359);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Menu";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jumlah";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Harga";
            this.columnHeader3.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Pemesanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(20, 226);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // text_no
            // 
            this.text_no.Location = new System.Drawing.Point(93, 29);
            this.text_no.Name = "text_no";
            this.text_no.ReadOnly = true;
            this.text_no.Size = new System.Drawing.Size(100, 20);
            this.text_no.TabIndex = 6;
            // 
            // text_pembeli
            // 
            this.text_pembeli.Location = new System.Drawing.Point(73, 68);
            this.text_pembeli.Name = "text_pembeli";
            this.text_pembeli.ReadOnly = true;
            this.text_pembeli.Size = new System.Drawing.Size(100, 20);
            this.text_pembeli.TabIndex = 7;
            // 
            // text_menu
            // 
            this.text_menu.Location = new System.Drawing.Point(73, 108);
            this.text_menu.Name = "text_menu";
            this.text_menu.ReadOnly = true;
            this.text_menu.Size = new System.Drawing.Size(100, 20);
            this.text_menu.TabIndex = 8;
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(73, 147);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(100, 20);
            this.text_jumlah.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Harga";
            // 
            // text_harga
            // 
            this.text_harga.Location = new System.Drawing.Point(73, 182);
            this.text_harga.Name = "text_harga";
            this.text_harga.ReadOnly = true;
            this.text_harga.Size = new System.Drawing.Size(100, 20);
            this.text_harga.TabIndex = 11;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(101, 226);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 12;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_checkout
            // 
            this.button_checkout.Location = new System.Drawing.Point(20, 324);
            this.button_checkout.Name = "button_checkout";
            this.button_checkout.Size = new System.Drawing.Size(156, 23);
            this.button_checkout.TabIndex = 13;
            this.button_checkout.Text = "Checkout";
            this.button_checkout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(194, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 63);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Harga";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(59, 255);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 359);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_checkout);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.text_harga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.text_menu);
            this.Controls.Add(this.text_pembeli);
            this.Controls.Add(this.text_no);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox text_no;
        private System.Windows.Forms.TextBox text_pembeli;
        private System.Windows.Forms.TextBox text_menu;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_harga;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_checkout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_delete;
    }
}

