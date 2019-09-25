namespace seteguk
{
    partial class FormSatuan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_satuan = new System.Windows.Forms.TextBox();
            this.text_satuan_detail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.list_satuan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satuan Bahan Baku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satuan";
            // 
            // text_satuan
            // 
            this.text_satuan.Location = new System.Drawing.Point(92, 114);
            this.text_satuan.Name = "text_satuan";
            this.text_satuan.Size = new System.Drawing.Size(183, 20);
            this.text_satuan.TabIndex = 2;
            // 
            // text_satuan_detail
            // 
            this.text_satuan_detail.Location = new System.Drawing.Point(91, 166);
            this.text_satuan_detail.Name = "text_satuan_detail";
            this.text_satuan_detail.Size = new System.Drawing.Size(183, 20);
            this.text_satuan_detail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satuan Detail";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(92, 88);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(183, 20);
            this.text_id.TabIndex = 6;
            this.text_id.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tambah";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // list_satuan
            // 
            this.list_satuan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.list_satuan.HideSelection = false;
            this.list_satuan.Location = new System.Drawing.Point(299, 88);
            this.list_satuan.Name = "list_satuan";
            this.list_satuan.Size = new System.Drawing.Size(480, 265);
            this.list_satuan.TabIndex = 9;
            this.list_satuan.UseCompatibleStateImageBehavior = false;
            this.list_satuan.View = System.Windows.Forms.View.Details;
            this.list_satuan.SelectedIndexChanged += new System.EventHandler(this.List_satuan_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Satuan";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Satuan Detail";
            this.columnHeader3.Width = 123;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jumlah";
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(91, 140);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(183, 20);
            this.text_jumlah.TabIndex = 12;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jumlah";
            this.columnHeader4.Width = 135;
            // 
            // FormSatuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 369);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.list_satuan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_satuan_detail);
            this.Controls.Add(this.text_satuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSatuan";
            this.Text = "FormSatuan";
            this.Load += new System.EventHandler(this.FormSatuan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_satuan;
        private System.Windows.Forms.TextBox text_satuan_detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView list_satuan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_jumlah;
    }
}