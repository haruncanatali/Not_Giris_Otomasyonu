using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class Request
    {
        public int Id { get; set; }
        public string Tckn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
