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
    public partial class Form2 : Form
    {
        ModelStudent modelStudent = new ModelStudent();
 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Faculty> listFaculty = modelStudent.Faculties.ToList();
            comboBoxKhoa.DataSource = listFaculty;
            comboBoxKhoa.DisplayMember = "FacultyName";
            comboBoxKhoa.ValueMember = "FacultyID";
        }
        public static List<Major> GetMajorsByFacultyID(int facultyID)
        {
            // Truy vấn CSDL hoặc sử dụng Entity Framework để lấy danh sách chuyên ngành dựa trên facultyID
            using (var context = new ModelStudent()) // Thay YourDbContext bằng tên DbContext của bạn
            {
                List<Major> majors = context.Majors
                    .Where(major => major.FacultyID == facultyID)
                    .ToList();

                return majors;
            }
        }
        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKhoa.SelectedItem != null)
            {
                // Lấy facultyID của khoa được chọn
                int selectedFacultyID = ((Faculty)comboBoxKhoa.SelectedItem).FacultyID;

                // Giả sử bạn có danh sách chuyên ngành dựa trên facultyID
                //List<Major> listMajor = modelStudent.s(selectedFacultyID);

                //comboBoxCN.DataSource = listMajor;
                //comboBoxCN.DisplayMember = "Name";
                //comboBoxCN.ValueMember = "MajorID";
            }
        }

    }
}
