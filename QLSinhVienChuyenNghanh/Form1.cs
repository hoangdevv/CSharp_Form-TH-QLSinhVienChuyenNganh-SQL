using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSinhVienChuyenNghanh.Model;

namespace QLSinhVienChuyenNghanh
{
    public partial class Form1 : Form
    {
        ModelStudent modelStudent = new ModelStudent();
        int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        void LoadDGV()
        {
            List<Student> listStudent = modelStudent.Students.ToList();
            dataGridViewSV.Rows.Clear();
            foreach(var item in listStudent)
            {
                string majorName = item.Major != null ? item.Major.Name : ""; 
                dataGridViewSV.Rows.Add(item.StudentID, item.FullName, item.Faculty.FacultyName, item.AverageScore, majorName);
            }
        }
        int KT_MSSV()
        {
            var Trungmssv = modelStudent.Students.FirstOrDefault(p => p.StudentID == txtmssv.Text);
            if(Trungmssv != null) 
                return -1; //trung
            return 0; // khong trung
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Faculty> listFaculty = modelStudent.Faculties.ToList();
            cbbkhoa.DataSource = listFaculty;
            cbbkhoa.DisplayMember = "FacultyName";
            cbbkhoa.ValueMember = "FacultyID";

            LoadDGV();
        }

        private void buttonAddUpdate_Click(object sender, EventArgs e)
        {
            var context = new ModelStudent();
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    string mssv = txtmssv.Text;
                    string hoten = txthoten.Text;
                    int khoaID = Convert.ToInt32(cbbkhoa.SelectedValue);
                    double dtb = double.Parse(txtdtb.Text);
                    if (KT_MSSV() == 0)
                    {
                        Student newStudent = new Student()
                        {
                            StudentID = mssv,
                            FullName = hoten,
                            FacultyID = khoaID,
                            AverageScore = dtb
                        };
                        modelStudent.Students.Add(newStudent);
                        modelStudent.SaveChanges();
                        LoadDGV();
                        transaction.Commit();
                        MessageBox.Show("ADD thành công");
                    }
                    else if(KT_MSSV() == -1)
                    {
                        Student exictingStudent = modelStudent.Students.FirstOrDefault(p => p.StudentID == txtmssv.Text);
                        if(exictingStudent != null)
                        {
                            exictingStudent.FullName = hoten;
                            exictingStudent.FacultyID = khoaID;
                            exictingStudent.AverageScore = dtb;
                            modelStudent.SaveChanges();
                            LoadDGV();
                            transaction.Commit();
                            MessageBox.Show("Update thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mssv");
                    }

                }
                catch (Exception ex) 
                {
                    transaction.Rollback();
                    MessageBox.Show("rollback: "+ex.Message);
                }
            }
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(index <0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi");
                return;
            }
            var studentToRemove = modelStudent.Students.FirstOrDefault(s => s.StudentID == txtmssv.Text);
            modelStudent.Students.Remove(studentToRemove);
            modelStudent.SaveChanges();
            LoadDGV();
        }
        private void dataGridViewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if(index < 0)
            {
                return;
            }

            txtmssv.Text = dataGridViewSV.Rows[index].Cells[0].Value.ToString();
            txthoten.Text = dataGridViewSV.Rows[index].Cells[1].Value.ToString();
            cbbkhoa.Text = dataGridViewSV.Rows[index].Cells[2].Value.ToString();
            txtdtb.Text = dataGridViewSV.Rows[index].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|Tất cả các tệp (*.*)|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxanhdaidien.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Tệp không tồn tại hoặc không phải là hình ảnh hợp lệ.");
            }

        }

        private void checkBoxChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxChuyenNganh.Checked == true)
            {
                List<Student> listStudent = modelStudent.Students.ToList();
                dataGridViewSV.Rows.Clear();
                foreach (var item in listStudent)
                {
                   if(item.Major == null)
                    {
                        string majornull = "";
                        dataGridViewSV.Rows.Add(item.StudentID, item.FullName, item.Faculty.FacultyName, item.AverageScore, majornull);

                    }
                }
            }
            else
            {
                LoadDGV();
            }
            
        }

        private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
