using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lớp học sinh, gồm có các thuộc tính: Tên học sinh, Điểm toán, Điểm Văn.
// Phương thức: Tính điểm trung bình.
namespace Bai5_2
{
    class Student
    {
        // Các thuộc tính
        public string ST_name;
        public double ST_math;
        public double ST_litt;

        // Khai báo ko tham số
        public Student()
        {
            ST_name = "Lê Tuấn";
            ST_math = 1;
            ST_litt = 1;
        }

        // Khai báo có tham số
        public Student(string name, double math, double literature)
        {
            ST_name = name;
            ST_math = math;
            ST_litt = literature;
        }

        // Phương thức tính trung bình, không input nhưng có output
        public double Average()
        {
            return (ST_math + ST_litt) / 2;
        }
    }
}
