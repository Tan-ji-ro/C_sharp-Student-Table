using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Main_form : Form
    {
        // Tạo một class để dựng danh sách điểm học tập. 
        // Giống với lớp Student nhưng thêm STT và điểm trung bình.
        public class Table_display
        {
            private static int count = 1;
            public int Count { get; private set; }
            public string Name { get; set; }
            public double Point_math { get; set; }
            public double Point_literature { get; set; }
            public double Point_average { get; set; }

            // Tự động đánh số TT theo từng đối tượng
            public Table_display()
            {
                Count = count++;
            }
        }

        // Thiết lập danh sách dựa vào class trên để hiển thị vào Grid View
        public BindingList<Table_display> Table = new BindingList<Table_display>();

        public Main_form()
        {
            InitializeComponent();
            Data_table.DataSource = Table; // Gán danh sách vào Grid View
        }

        // Thêm dữ liệu học sinh vào danh sách
        private void Add_button_Click(object sender, EventArgs e)
        {
            // Khai báo biến để xử lý
            string name_st = Name_box.Text;
            double point_math, point_litt = 0;

            // Kiểm tra các gía trị nhập. 
            if (name_st == "")
            {
                L_Warning.Text = "Lưu ý: Bạn cần phải nhập tên"; // Kiểm tra xem có nhập tên học sinh hay không
            }

            if (!double.TryParse(Math_box.Text, out point_math) || !double.TryParse(Lit_box.Text, out point_litt)) // Kiểm tra xem có chữ trong phần nhập điểm hay không
            {
                L_Warning.Text = "Lưu ý: Bạn cần phải nhập kiểu số trong 2 vùng nhập điểm";
            }

            if (point_math < 0 || point_math > 10 || point_litt < 0 || point_litt > 10) // Kiểm tra xem điểm đã nhập trong phạm vi 0-10 hay không.
            {
                L_Warning.Text = "Lưu ý: Vượt quá tầm kiểm tra";
            }

            // Thêm thông tin vào class Student, sau đó dùng phương thức từ class để tính điểm trung bình
            Student st = new Student(name_st, point_math, point_litt);
            double avg = st.Average();

            // Chèn dữ liệu đã xử lý vào danh sách đã gắn vào Grid View.
            Table.Add(new Table_display { Name = st.ST_name, Point_math = st.ST_math, Point_literature = st.ST_litt, Point_average = avg });
        }

        // Lưu danh sách vào file txt
        private void Save_bt_Click(object sender, EventArgs e)
        {
            // Thiết lập Save File Dialog để lưu danh sách, định dạng file txt và tên file xuất
            SaveFileDialog save_dialog = new SaveFileDialog();

            save_dialog.Filter = "Text Files (*.txt)|*.txt"; // Bộ lọc Save File Dialog
            save_dialog.DefaultExt = "txt"; // Đuôi ngầm định 
            save_dialog.FileName = "Export.txt"; // Tên file xuất

            // Lưu danh sách vào bất kỳ thư mục
            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextWriter wrt = new StreamWriter(save_dialog.FileName); // Mở Stream Writer để bắt đầu viết danh sách 

                    // Xử lý từng ô trong Grid View để viết vào file txt
                    for (int i = 0; i < Data_table.Rows.Count - 1; i++) // Quét hàng
                    {
                        for (int j = 0; j < Data_table.Columns.Count; j++) // Quét cột
                        {
                            wrt.Write(Data_table.Rows[i].Cells[j].Value.ToString() + ","); // Quét và ghi các giá trị trong hàng theo từng ô
                        }
                        wrt.WriteLine(""); // Xuống dòng
                    }
                    wrt.Close(); // Đóng Stream Writer
                    L_Warning.Text = "Đã lưu kết quả";
                }
                catch (Exception ex)
                {
                    L_Warning.Text = "Có vấn đề khi lưu: " + ex;
                }
            }
        }

        // Tải danh sách từ file txt vào ứng dụng
        private void Load_bt_Click(object sender, EventArgs e)
        {
            // Thiết lập Open File Dialog để mở file txt chứa danh sách
            OpenFileDialog open_dialog = new OpenFileDialog();

            open_dialog.Filter = "Text Files (*.txt)|*.txt"; // Bộ lọc Open File Dialog
            open_dialog.FilterIndex = 1; // Vị trí bộ lọc

            // Mở danh sách từ bất kỳ thư mục
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                // Thiết lập biến để lưu tên file
                string f_path = open_dialog.FileName;

                // Kiểm tra xem nội dung file có phù hợp với GridView hay không, sau đó nhập vào GridView.
                if (File.Exists(f_path))
                {
                    // Thiết lập danh sách kiểm tra chuỗi ban đầu
                    string[] lines = File.ReadAllLines(f_path);
                    double check;

                    if (lines.Length > 1)
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {
                            string[] values = lines[i].Split(','); // Thiết lập danh sách kiểm tra chuỗi để gắn vào danh sách
                            if (values.Length < 6) // Kiểm tra độ dài tối thiểu của chuỗi
                            {
                                L_Warning.Text = "Định dạng quá ngắn";
                            }
                            else if (!double.TryParse(values[2], out check) || !double.TryParse(values[3], out check) || !double.TryParse(values[4], out check)) // Kiểm tra xem điểm số trong danh sách có định dạng là số hay không 
                            {
                                L_Warning.Text = "Phát hiện định dạng không phải là số trong các cột số";
                            }
                            else {
                                Table.Add(new Table_display
                                {
                                    Name = values[1],
                                    Point_math = double.Parse(values[2]),
                                    Point_literature = double.Parse(values[3]),
                                    Point_average = double.Parse(values[4])
                                }); // Thêm vào danh sách trong Grid View
                            }
                        }
                    }
                    else
                    {
                        L_Warning.Text = "Định dạng quá ngắn";
                    }
                }
                else
                {
                    L_Warning.Text = "Không có file ở: " + f_path; // Thông báo ko có file
                }
            }
        }

        // Xóa thông tin theo hàng
        private void Del_bt_Click(object sender, EventArgs e)
        {
            if (Data_table.SelectedRows.Count > 0) // Xác định hàng để xóa
            {
                int Selection = Data_table.SelectedRows[0].Index;

                Table_display Selected = (Table_display)Data_table.Rows[Selection].DataBoundItem; // Gán dữ liệu cần xóa vào biến riêng
                Table.Remove(Selected); // Xóa dữ liệu theo hàng 
            }
            else {
                L_Warning.Text = "Bạn cần chọn 1 hàng để xóa";
            }
        }

        // Tìm dữ liệu
        private void Search_TextChanged(object sender, EventArgs e)
        {
            String result = Search.Text;

            if (string.IsNullOrWhiteSpace(result))
            {
                Data_table.DataSource = Table; // Khoảng không = toàn bộ bảng
            }
            else
            {
                List<Table_display> Filter_table = Table.Where(i => i.Name.Contains(result)).ToList(); // Lọc dữ liệu và gán vào một danh sách mới do BindingList ko hỗ trợ lọc trực tiếp
                Data_table.DataSource = Filter_table;
            }
        }

        // Sửa thông tin theo hàng 
        private void Mod_button_Click(object sender, EventArgs e)
        {
            // Thiết lập biến để sửa
            string name_st = Name_box.Text;
            double point_math, point_litt = 0;

            if (Data_table.SelectedRows.Count > 0) // Xác định hàng để xóa
            {
                int Selection = Data_table.SelectedRows[0].Index;

                Table_display modified_item = (Table_display)Data_table.Rows[Selection].DataBoundItem; // Gán dữ liệu cần sửa vào biến riêng

                    if (name_st == "")
                    {
                        L_Warning.Text = "Lưu ý: Bạn cần phải nhập tên"; // Kiểm tra xem có nhập tên học sinh hay không
                    }

                    if (!double.TryParse(Math_box.Text, out point_math) || !double.TryParse(Lit_box.Text, out point_litt)) // Kiểm tra xem có chữ trong phần nhập điểm hay không
                    {
                        L_Warning.Text = "Lưu ý: Bạn cần phải nhập kiểu số trong 2 vùng nhập điểm";
                    }

                    if (point_math < 0 || point_math > 10 || point_litt < 0 || point_litt > 10) // Kiểm tra xem điểm đã nhập trong phạm vi 0-10 hay không.
                    {
                        L_Warning.Text = "Lưu ý: Vượt quá tầm kiểm tra";
                    }

                    // Ghi thông tin đã sửa vào dữ liệu
                    modified_item.Name = name_st;
                    modified_item.Point_math = point_math;
                    modified_item.Point_literature = point_litt;
                    modified_item.Point_average = (point_math + point_litt) / 2;

                    // Thiết lập lại dữ liệu
                    Table.ResetItem(Selection);
            }
            else
            {
                L_Warning.Text = "Bạn cần chọn 1 hàng để chỉnh sửa";
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_form lgf = new Login_form();
            lgf.Show();
        }
    }
}
