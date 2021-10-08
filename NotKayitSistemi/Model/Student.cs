using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Tckn { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Exam_1 { get; set; }
        public short Exam_2 { get; set; }
        public short Exam_3 { get; set; }
        public decimal Average { get; set; }
        public bool State { get; set; }
        public string PrivateQuestion { get; set; }
        public string PrivateKey { get; set; }
    }
}
