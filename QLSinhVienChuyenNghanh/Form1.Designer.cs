
namespace QLSinhVienChuyenNghanh
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
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddUpdate = new System.Windows.Forms.Button();
            this.checkBoxChuyenNganh = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.pictureBoxanhdaidien = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUYENNGANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đăngKýChuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxanhdaidien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.AllowUserToAddRows = false;
            this.dataGridViewSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HOTEN,
            this.Khoa,
            this.DTB,
            this.CHUYENNGANH});
            this.dataGridViewSV.Location = new System.Drawing.Point(313, 130);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.ReadOnly = true;
            this.dataGridViewSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSV.Size = new System.Drawing.Size(631, 356);
            this.dataGridViewSV.TabIndex = 0;
            this.dataGridViewSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pictureBoxanhdaidien);
            this.groupBox1.Controls.Add(this.cbbkhoa);
            this.groupBox1.Controls.Add(this.txtdtb);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmssv);
            this.groupBox1.Controls.Add(this.buttonAddUpdate);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(336, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ảnh đại diện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Điểm trung bình";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(198, 314);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddUpdate
            // 
            this.buttonAddUpdate.Location = new System.Drawing.Point(82, 314);
            this.buttonAddUpdate.Name = "buttonAddUpdate";
            this.buttonAddUpdate.Size = new System.Drawing.Size(85, 23);
            this.buttonAddUpdate.TabIndex = 3;
            this.buttonAddUpdate.Text = "Add / Update";
            this.buttonAddUpdate.UseVisualStyleBackColor = true;
            this.buttonAddUpdate.Click += new System.EventHandler(this.buttonAddUpdate_Click);
            // 
            // checkBoxChuyenNganh
            // 
            this.checkBoxChuyenNganh.AutoSize = true;
            this.checkBoxChuyenNganh.Location = new System.Drawing.Point(708, 78);
            this.checkBoxChuyenNganh.Name = "checkBoxChuyenNganh";
            this.checkBoxChuyenNganh.Size = new System.Drawing.Size(140, 17);
            this.checkBoxChuyenNganh.TabIndex = 3;
            this.checkBoxChuyenNganh.Text = "Chưa ĐK chuyên ngành";
            this.checkBoxChuyenNganh.UseVisualStyleBackColor = true;
            this.checkBoxChuyenNganh.CheckedChanged += new System.EventHandler(this.checkBoxChuyenNganh_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(115, 47);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(158, 20);
            this.txtmssv.TabIndex = 4;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(115, 82);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(158, 20);
            this.txthoten.TabIndex = 4;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(115, 164);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(158, 20);
            this.txtdtb.TabIndex = 4;
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Location = new System.Drawing.Point(115, 122);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(158, 21);
            this.cbbkhoa.TabIndex = 5;
            // 
            // pictureBoxanhdaidien
            // 
            this.pictureBoxanhdaidien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxanhdaidien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxanhdaidien.Location = new System.Drawing.Point(115, 204);
            this.pictureBoxanhdaidien.Name = "pictureBoxanhdaidien";
            this.pictureBoxanhdaidien.Size = new System.Drawing.Size(135, 87);
            this.pictureBoxanhdaidien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxanhdaidien.TabIndex = 6;
            this.pictureBoxanhdaidien.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(256, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýChuyênNgànhToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // DTB
            // 
            this.DTB.HeaderText = "DTB";
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            // 
            // CHUYENNGANH
            // 
            this.CHUYENNGANH.HeaderText = "Chuyên ngành";
            this.CHUYENNGANH.Name = "CHUYENNGANH";
            this.CHUYENNGANH.ReadOnly = true;
            // 
            // đăngKýChuyênNgànhToolStripMenuItem
            // 
            this.đăngKýChuyênNgànhToolStripMenuItem.Name = "đăngKýChuyênNgànhToolStripMenuItem";
            this.đăngKýChuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.đăngKýChuyênNgànhToolStripMenuItem.Text = "Đăng ký chuyên ngành";
            this.đăngKýChuyênNgànhToolStripMenuItem.Click += new System.EventHandler(this.đăngKýChuyênNgànhToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 511);
            this.Controls.Add(this.checkBoxChuyenNganh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxanhdaidien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxanhdaidien;
        private System.Windows.Forms.ComboBox cbbkhoa;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.Button buttonAddUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxChuyenNganh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUYENNGANH;
        private System.Windows.Forms.ToolStripMenuItem đăngKýChuyênNgànhToolStripMenuItem;
    }
}

