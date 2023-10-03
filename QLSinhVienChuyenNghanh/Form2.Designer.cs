
namespace QLSinhVienChuyenNghanh
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.comboBoxCN = new System.Windows.Forms.ComboBox();
            this.CHON = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyên ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(285, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐĂNG KÝ CHUYÊN NGÀNH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHON,
            this.MSSV,
            this.HOTEN,
            this.KHOA,
            this.DTB});
            this.dataGridView1.Location = new System.Drawing.Point(34, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 294);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(234, 84);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(260, 21);
            this.comboBoxKhoa.TabIndex = 3;
            this.comboBoxKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKhoa_SelectedIndexChanged);
            // 
            // comboBoxCN
            // 
            this.comboBoxCN.FormattingEnabled = true;
            this.comboBoxCN.Location = new System.Drawing.Point(234, 135);
            this.comboBoxCN.Name = "comboBoxCN";
            this.comboBoxCN.Size = new System.Drawing.Size(260, 21);
            this.comboBoxCN.TabIndex = 3;
            // 
            // CHON
            // 
            this.CHON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CHON.FillWeight = 253.8071F;
            this.CHON.Frozen = true;
            this.CHON.HeaderText = "Chọn";
            this.CHON.Name = "CHON";
            this.CHON.ReadOnly = true;
            this.CHON.Width = 50;
            // 
            // MSSV
            // 
            this.MSSV.FillWeight = 61.54822F;
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.FillWeight = 61.54822F;
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // KHOA
            // 
            this.KHOA.FillWeight = 61.54822F;
            this.KHOA.HeaderText = "Khoa";
            this.KHOA.Name = "KHOA";
            this.KHOA.ReadOnly = true;
            // 
            // DTB
            // 
            this.DTB.FillWeight = 61.54822F;
            this.DTB.HeaderText = "ĐTB";
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.comboBoxCN);
            this.Controls.Add(this.comboBoxKhoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.ComboBox comboBoxCN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
    }
}