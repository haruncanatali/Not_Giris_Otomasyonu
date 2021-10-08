using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class StudentDto
    {
        public string Tckn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Exam_1 { get; set; }
        public int Exam_2 { get; set; }
        public int Exam_3 { get; set; }
        public decimal Average { get; set; }
        public bool State { get; set; }
    }
}
